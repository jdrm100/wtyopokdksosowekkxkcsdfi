Imports System
Imports System.Collections.Generic

Namespace Core.DataInterfaces

    Public Interface IGenericDao(Of T, ID)

        Function GetById(ByVal _id As ID, ByVal shouldLock As Boolean) As T
        Function GetAll() As List(Of T)
        Function GetByExample(ByVal exampleInstance As T, ByVal propertiesToExclude As ArrayList) As List(Of T)
        Function GetUniqueByExample(ByVal exampleInstance As T, ByVal propertiesToExclude As ArrayList) As T
        Function Save(ByVal entity As T) As T
        Function SaveOrUpdate(ByVal entity As T) As T
        Sub Delete(ByVal entity As T)
        Sub CommitChanges()

    End Interface

End Namespace
