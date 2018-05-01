Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports NHibernate.Expression
Imports Core.DataInterfaces


Namespace Data

    Public MustInherit Class GenericNHibernateDao(Of T, ID)
        Implements IGenericDao(Of T, ID)


        Public Sub CommitChanges() Implements Core.DataInterfaces.IGenericDao(Of T, ID).CommitChanges

            If NHibernateSessionManager.Instancia.HasOpenTransaction Then
                NHibernateSessionManager.Instancia.CommitTransaction()
            Else
                NHibernateSessionManager.Instancia.GetSession.Flush()
            End If
        End Sub

        Public Sub Delete(ByVal entity As T) Implements Core.DataInterfaces.IGenericDao(Of T, ID).Delete
            NHibernateSession.Delete(entity)
        End Sub

        Public Function GetAll() As System.Collections.Generic.List(Of T) Implements Core.DataInterfaces.IGenericDao(Of T, ID).GetAll

            Return GetByCriteria(Nothing)

        End Function

        Public Function GetByCriteria(ByVal criterion As ArrayList) As List(Of T)
            Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)

            If Not criterion Is Nothing Then
                For Each criterium As ICriterion In criterion
                    criteria.Add(criterium)
                Next
            End If

            Return ConvertToGenericList(criteria.List())
        End Function


        Protected Function ConvertToGenericList(ByVal listObjects As IList) As List(Of T)
            Dim convertedList As New List(Of T)

            For Each listObject As Object In listObjects
                convertedList.Add(CType(listObject, T))
            Next

            Return convertedList

        End Function

        Public Function GetById(ByVal _id As ID, ByVal shouldLock As Boolean) As T Implements Core.DataInterfaces.IGenericDao(Of T, ID).GetById
            Dim entity As T

            If shouldLock Then
                entity = CType(NHibernateSession.Load(persistentType, _id, LockMode.Upgrade), T)
            Else
                entity = CType(NHibernateSession.Load(persistentType, _id), T)
            End If

            Return entity

        End Function

        Public Function GetUniqueByExample(ByVal exampleInstance As T, ByVal propertiesToExclude As ArrayList) As T Implements Core.DataInterfaces.IGenericDao(Of T, ID).GetUniqueByExample
            Dim foundList As List(Of T) = GetByExample(exampleInstance, propertiesToExclude)

            If foundList.Count > 1 Then
                Throw New NonUniqueResultException(foundList.Count)
            End If

            If foundList.Count > 0 Then
                Return foundList(0)
            Else
                Return Nothing
            End If

        End Function

        Public Function Save(ByVal entity As T) As T Implements Core.DataInterfaces.IGenericDao(Of T, ID).Save
            NHibernateSession.Save(entity)
            Return entity
        End Function

        Public Function SaveOrUpdate(ByVal entity As T) As T Implements Core.DataInterfaces.IGenericDao(Of T, ID).SaveOrUpdate
            NHibernateSession.SaveOrUpdate(entity)
            Return entity
        End Function

        Protected ReadOnly Property NHibernateSession() As ISession
            Get
                Return NHibernateSessionManager.Instancia.GetSession
            End Get
        End Property

        Protected persistentType As Type = GetType(T)

        Public Function GetByExample(ByVal exampleInstance As T, ByVal propertiesToExclude As ArrayList) As System.Collections.Generic.List(Of T) Implements Core.DataInterfaces.IGenericDao(Of T, ID).GetByExample
            Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
            Dim ejemplo As Example = Example.Create(exampleInstance)

            For Each propertyTo As String In propertiesToExclude
                ejemplo.ExcludeProperty(propertyTo)
            Next

            criteria.Add(ejemplo)

            Return ConvertToGenericList(criteria.List())
        End Function

    End Class

End Namespace
