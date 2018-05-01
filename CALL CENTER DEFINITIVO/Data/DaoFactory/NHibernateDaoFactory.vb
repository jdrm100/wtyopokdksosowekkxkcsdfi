Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Imports NHibernate
Imports NHibernate.Expression

Namespace Data

    Public Class NHibernateDaoFactory
        Implements IDaoFactory
#Region "Seguridad"
        Public Class UsuarioDao
            Inherits GenericNHibernateDao(Of Usuario, String)
            Implements IUsuarioDao

            Public Function GetLikeIdUserNombre(ByVal IdUser As String, ByVal Nombre As String) As System.Collections.Generic.List(Of Core.Domain.Seguridad.Usuario) Implements Core.DataInterfaces.IUsuarioDao.GetLikeIdUserNombre
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Like("ID_USER", "%" & IdUser & "%"))
                criteria.Add(Expression.Like("NOMBRE", "%" & Nombre & "%"))
                Return ConvertToGenericList(criteria.List())
            End Function

            Public Function GetByIdUser(ByVal idUser As String) As System.Collections.Generic.List(Of Core.Domain.Seguridad.Usuario) Implements Core.DataInterfaces.IUsuarioDao.GetByIdUser
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("ID_USER", idUser))
                Return ConvertToGenericList(criteria.List())
            End Function

            Public Function GetByusupass(codusu As String, pass As String) As List(Of Usuario) Implements IUsuarioDao.GetByusupass
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("login", codusu))
                criteria.Add(Expression.Eq("clave", pass))
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class
        Public Class age_svDao
            Inherits GenericNHibernateDao(Of age_sin_venta, String)
            Implements I_age_sv_Dao
            Public Function GetByAge(agente As String, dias As Integer, fec_v As String, fec_ticket As String, codusu As Integer) As List(Of age_sin_venta) Implements I_age_sv_Dao.GetByAge
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Eq("ID", agente))
                    If dias <> 0 Then
                        criteria.Add(Expression.Eq("retirada", dias))
                    End If
                    If fec_v <> "" Then
                        criteria.Add(Expression.Gt("ultima_venta", fec_v))
                    End If
                    If fec_ticket <> "" Then
                        criteria.Add(Expression.Gt("ticket_tec", fec_ticket))
                    End If
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agente sin venta - FACTORY", ex)
                End Try
            End Function
        End Class
        Public Class AgenteDao
            Inherits GenericNHibernateDao(Of agente, String)
            Implements IAgenteDao

            Public Function GetByCodgtech(codgtech As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente) Implements IAgenteDao.GetByCodgtech
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("ID", "%" & codgtech & "%"))
                    If gestor <> "" Then
                        criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM grupogesdet where codgru in (select codgru from grupogesh where codges in (" & gestor & ")))"))
                        'If (gestor <> "12" And gestor <> "22" And gestor <> "24" And gestor <> "25" And gestor <> "26" And gestor <> "27" And gestor <> "39") Then
                        '    criteria.Add(Expression.Eq("retirada", "0"))
                        'End If
                    End If
                    If bloq = "1" Then
                        criteria.Add(Expression.Like("bloqueada", "%" & bloq & "%"))
                        criteria.Add(Expression.Eq("retirada", "0"))
                    End If
                    If bala = "p" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Gt("baldia", val))
                    ElseIf bala = "n" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Le("baldia", val))
                    End If
                    If fec_prom <> "" Then
                        Dim s As String = ""
                        criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM PROMESA_PAG where codges ='" & gestor & "' and fecha = '" & fec_prom & "')"))
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agentes", ex)
                End Try
            End Function

            Public Function GetLikeCodgtech(codgtech As String, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente) Implements IAgenteDao.GetLikeCodgtech
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("nombre", "%" & nombre & "%"))
                    criteria.Add(Expression.Like("ID", "8%"))
                    If gestor <> "" Then
                        criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM grupogesdet where codgru in (select codgru from grupogesh where codges in (" & gestor & ")))"))
                        'If (gestor <> "12" And gestor <> "22" And gestor <> "24" And gestor <> "25" And gestor <> "26" And gestor <> "27" And gestor <> "39") Then
                        '    criteria.Add(Expression.Eq("retirada", "0"))
                        'End If
                    End If
                    If bloq = "1" Then
                        criteria.Add(Expression.Like("bloqueada", "%" & bloq & "%"))
                        criteria.Add(Expression.Eq("retirada", "0"))
                    End If
                    If bala = "p" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Gt("baldia", val))
                    ElseIf bala = "n" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Le("baldia", val))
                    End If
                    If fec_prom <> "" Then
                        Dim s As String = ""
                        criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM PROMESA_PAG where codges ='" & gestor & "' and fecha = '" & fec_prom & "')"))
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agentes", ex)
                End Try
            End Function

            Public Function GetByllamadahoy(usuario As String) As List(Of agente) Implements IAgenteDao.GetByllamadahoy
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM callcenteradm2 where codusu = '" & usuario & "' and DAY(fecrec) = DAY(getdate()) and MONTH(fecrec)= MONTH(getdate()) and YEAR(fecrec)= YEAR(getdate()) )"))
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agentes por llamadas de hoy", ex)
                End Try

            End Function

            Public Function GetByBal(gestor As String, p_n_b As String) As List(Of agente) Implements IAgenteDao.GetByBal
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("ID", "8%"))
                    If gestor <> "" Then
                        criteria.Add(Expression.Sql("codgtech IN (SELECT codage  FROM grupogesdet where codgru in (select codgru from grupogesh where codges in (" & gestor & ")))"))
                        'If (gestor <> "12" And gestor <> "22" And gestor <> "24" And gestor <> "25" And gestor <> "26" And gestor <> "27" And gestor <> "39") Then
                        '    criteria.Add(Expression.Eq("retirada", "0"))
                        'End If
                    End If
                    If p_n_b = "p" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Gt("baldia", val))
                    ElseIf p_n_b = "n" Then
                        Dim val As Decimal = 0.0
                        criteria.Add(Expression.Le("baldia", val))
                    ElseIf p_n_b = "b" Then
                        criteria.Add(Expression.Eq("bloqueada", "1"))
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agentes por balance", ex)
                End Try
            End Function

            Public Function GetProspByNom(codgtech As String, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente) Implements IAgenteDao.GetProspByNom
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("nombre", "%" & nombre & "%"))
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de agentes", ex)
                End Try
            End Function

            Public Function GetBySinVenta(agente As String, usuario As Integer) As List(Of agente) Implements IAgenteDao.GetBySinVenta
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Sql("codgtech IN (SELECT agente  FROM AGENTE_SIN_VENTA where CODUSU = '" & usuario & "' )"))
                    If agente <> "" Then
                        If IsNumeric(agente) Then
                            criteria.Add(Expression.Like("ID", "%" & agente & "%"))
                        Else
                            criteria.Add(Expression.Like("nombre", "%" & agente & "%"))
                        End If
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de agentes sin venta", ex)
                End Try
            End Function

            Public Function GetByTkAbiertos(agente As String, usuario As Integer) As List(Of agente) Implements IAgenteDao.GetByTkAbiertos
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Sql("codgtech IN (SELECT AGENTE FROM TICKETS_ABIERTOS_CCT )"))
                    If agente <> "" Then
                        If IsNumeric(agente) Then
                            criteria.Add(Expression.Like("ID", "%" & agente & "%"))
                        Else
                            criteria.Add(Expression.Like("nombre", "%" & agente & "%"))
                        End If
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de agentes con tickets abiertos", ex)
                End Try
            End Function

            Public Function GetByTkVerif(agente As String, verif As String, usuario As String) As List(Of agente) Implements IAgenteDao.GetByTkVerif
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Sql("codgtech IN (SELECT AGENTE FROM TICKETS_CERRADOS_CCT WHERE VERIFICACION='" & verif & "' AND GESTOR= '" & usuario & "' )"))
                    If agente <> "" Then
                        If IsNumeric(agente) Then
                            criteria.Add(Expression.Like("ID", "%" & agente & "%"))
                        Else
                            criteria.Add(Expression.Like("nombre", "%" & agente & "%"))
                        End If
                    End If
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de agentes con tickets por vefificar", ex)
                End Try
            End Function

        End Class
        Public Class ProspDao
            Inherits GenericNHibernateDao(Of prosp, String)
            Implements I_prosp_dao

            Public Function GetByCodigo(codigo As Integer, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of prosp) Implements I_prosp_dao.GetByCodigo
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("codgtech", "%" & codigo & "%"))
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de prospecciones", ex)
                End Try
            End Function
            Public Function GetByNom(codigo As Integer, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of prosp) Implements I_prosp_dao.GetByNom
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("nombre", "%" & nombre & "%"))
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de prospecciones", ex)
                End Try
            End Function
        End Class

        Public Class EmpleadoDao
            Inherits GenericNHibernateDao(Of empleado, String)
            Implements IEmpleadoDao

            Public Function GetByCodemp(codemp As String) As List(Of empleado) Implements IEmpleadoDao.GetByCodemp
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("ID", codemp))
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class
        Public Class gestor_usuarioDao
            Inherits GenericNHibernateDao(Of gestor_usuario, String)
            Implements Igestor_usuarioDao
            Public Function GetByCodusu(codusu As String, codges As String) As List(Of gestor_usuario) Implements Igestor_usuarioDao.GetByCodusu
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("codusu", "%" & codusu & "%"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de gestores usuarios", ex)
                End Try

            End Function
        End Class

        Public Class emplDao
            Inherits GenericNHibernateDao(Of empl, String)
            Implements I_empl_Dao

            Public Function GetByempl(ID As String, nombre As String, tipo As String, activo As String) As List(Of empl) Implements I_empl_Dao.GetByempl
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Like("ID", "%" + ID + "%"))
                    criteria.Add(Expression.Like("NOMBRE", "%" + nombre + "%"))
                    criteria.Add(Expression.Like("ID", tipo + "%"))
                    criteria.Add(Expression.Eq("ACTIVO", activo))
                    criteria.AddOrder(Order.Asc("NOMBRE"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en la consulta de empleados", ex)
                End Try
            End Function
        End Class

        Public Class cct_componentesDao
            Inherits GenericNHibernateDao(Of cct_componentes, String)
            Implements I_cct_componentes_Dao
            Public Function GetByID_Comp(id_comp As String, descripcion As String, obl_sn As Integer, activo As Integer, agente As String) As List(Of cct_componentes) Implements I_cct_componentes_Dao.GetByID_Comp
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Eq("activo", activo))
                    criteria.Add(Expression.Sql("id_comp not IN (select ID_COMP from CCT_COMP_CARA_AGE where activo = 1 and agente = '" & agente & "')"))
                    criteria.AddOrder(Order.Asc("descripcion"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de componentes.", ex)
                End Try
            End Function

            Public Function GetByIDs_Comp(list_id_comp As String) As List(Of cct_componentes) Implements I_cct_componentes_Dao.GetByIDs_Comp
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    If list_id_comp <> "" Then
                        criteria.Add(Expression.Sql("id in (" & list_id_comp & ")"))
                    End If

                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de gestores.", ex)
                End Try

            End Function

        End Class

        Public Class GestoresDao
            Inherits GenericNHibernateDao(Of gestores, String)
            Implements IGestoresDao
            Public Function GetByCodges(codges As String) As List(Of gestores) Implements IGestoresDao.GetByCodges
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    If codges = "" Then
                        criteria.Add(Expression.Sql("codges IN (select codges from grupogesh where codgru in (select codgru from grupogesdet))"))
                    Else
                        'criteria.Add(Expression.Like("ID", "%" & codges & "%"))
                        criteria.Add(Expression.Sql("codges in (" & codges & ")"))
                    End If

                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de gestores.", ex)
                End Try

            End Function

            Public Function GetByCodusu(codusu As String) As List(Of gestores) Implements IGestoresDao.GetByCodusu
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("telges", codusu))
                Return ConvertToGenericList(criteria.List())
            End Function


            Public Function GetByCodage(age As String) As List(Of gestores) Implements IGestoresDao.GetByCodage
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Sql("codges IN (select codges from grupogesh where codgru in (select codgru from grupogesdet where codage = '" & age & "'))"))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de gestores.", ex)
                End Try

            End Function
        End Class

        Public Class CallcenteradmDao
            Inherits GenericNHibernateDao(Of callcenteradm, String)
            Implements ICallcenteradmDao
            Public Function GetByCodage(codage As String, hist As String) As List(Of callcenteradm) Implements ICallcenteradmDao.GetByCodage
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("codage", codage))
                If IsNumeric(hist) Then
                    criteria.Add(Expression.Sql("fecrec > CONVERT(DATE,DATEADD(day,-" & hist & ",GETDATE()))"))
                End If
                criteria.AddOrder(Order.Desc("ID"))
                Return ConvertToGenericList(criteria.List())
            End Function

            Public Function GetLast(codage As String) As List(Of callcenteradm) Implements ICallcenteradmDao.GetLast
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.AddOrder(Order.Desc("ID"))
                criteria.SetMaxResults(1)
                Return ConvertToGenericList(criteria.List())
            End Function

        End Class

        Public Class Estado_CuentaDao
            Inherits GenericNHibernateDao(Of estado_cuenta, String)
            Implements IEstado_Cuenta
            Public Function GetByAgente(agente As String) As List(Of estado_cuenta) Implements IEstado_Cuenta.GetByAgente
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Eq("agente", agente))
                    criteria.AddOrder(Order.Asc("ID"))
                    Return ConvertToGenericList(criteria.List())
                    'estado_cuenta_list = NHibernateSession.GetNamedQuery("SELECT_EST_CUENTA").SetString("agente", agente).List
                    'If estado_cuenta_list.Count > 0 Then
                    '    Return ConvertToGenericList(estado_cuenta_list)
                    'Else
                    '    Return Nothing
                    'End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de estado de cuenta", ex)
                End Try
            End Function
        End Class

        Public Class Usu_LLamadasDao
            Inherits GenericNHibernateDao(Of usu_llamadas, String)
            Implements IUsu_LLamadasDao

            Public Function GetbyCodusu(codusu As String) As List(Of usu_llamadas) Implements IUsu_LLamadasDao.GetbyCodusu
                Dim usu_llamadas_list As IList
                Try
                    usu_llamadas_list = NHibernateSession.GetNamedQuery("SELECT_USU_LLAMADAS").SetString("codusu", codusu).List
                    If usu_llamadas_list.Count > 0 Then
                        Return ConvertToGenericList(usu_llamadas_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta del total de llamadas", ex)
                End Try
            End Function
        End Class

        Public Class BloquearDao
            Inherits GenericNHibernateDao(Of bloquear, String)
            Implements IBloquearDao
            Public Function GetByExcep(excep1 As String, excep2 As String, excep3 As String, excep4 As String, excep5 As String, excep6 As String) As List(Of bloquear) Implements IBloquearDao.GetByExcep
                Dim bloquear_list As IList
                Try
                    bloquear_list = NHibernateSession.GetNamedQuery("SELECT_BLOQ_AGE").SetString("EXCEP1", excep1).SetString("EXCEP2", excep2).SetString("EXCEP3", excep3).SetString("EXCEP4", excep4).SetString("EXCEP5", excep5).SetString("EXCEP6", excep6).List
                    If bloquear_list.Count > 0 Then
                        Return ConvertToGenericList(bloquear_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de agentes a bloquear", ex)
                End Try
            End Function

            Public Function GetExcep(excep1 As String, excep2 As String, excep3 As String, excep4 As String, excep5 As String, excep6 As String) As List(Of bloquear) Implements IBloquearDao.GetExcep
                Dim bloquear_list As IList
                Try
                    bloquear_list = NHibernateSession.GetNamedQuery("SELECT_BLOQ_AGE_EXEP").SetString("EXCEP1", excep1).SetString("EXCEP2", excep2).SetString("EXCEP3", excep3).SetString("EXCEP4", excep4).SetString("EXCEP5", excep5).SetString("EXCEP6", excep6).List
                    If bloquear_list.Count > 0 Then
                        Return ConvertToGenericList(bloquear_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de excepcion de agentes a bloquear", ex)
                End Try
            End Function
        End Class
        Public Class Sol_noblo_tiposDao
            Inherits GenericNHibernateDao(Of sol_noblo_tipos, String)
            Implements ISol_noblo_tiposDao

            Public Function GetByTodos(tipo As String) As List(Of sol_noblo_tipos) Implements ISol_noblo_tiposDao.GetByTodos
                Dim sol_noblo_tipos_list As IList
                Try
                    sol_noblo_tipos_list = NHibernateSession.GetNamedQuery("SELECT_SOL_NOBLO_TIPOS").SetString("TIPO", tipo).List
                    If sol_noblo_tipos_list.Count > 0 Then
                        Return ConvertToGenericList(sol_noblo_tipos_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de tipos de solicitudes de NO BLOQUEO", ex)
                End Try
            End Function
        End Class

        Public Class Sol_nobloDao
            Inherits GenericNHibernateDao(Of sol_noblo, String)
            Implements ISol_nobloDao

            Public Function SetSolnoblo(ByVal id_tipo As Integer, ByVal usuario As Integer, ByVal agente As String, ByVal fecha_fin As String, ByVal comen As String) As List(Of sol_noblo) Implements ISol_nobloDao.SetSolnoblo
                Dim sol_noblo_list As IList
                Try
                    sol_noblo_list = NHibernateSession.GetNamedQuery("ENVIO_SOL_NOBLO").SetInt32("id_tipo", id_tipo).SetInt32("usuario", usuario).SetString("agente", agente).SetString("fecha_fin", fecha_fin).SetString("comen", comen).List
                    If sol_noblo_list.Count > 0 Then
                        Return ConvertToGenericList(sol_noblo_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en el envio de solicitud de NO BLOQUEO", ex)
                End Try
            End Function


            Public Function SetSolnoblo_a_r(id_sol As Integer, usuario As Integer, id_nivel As Integer, comen As String, a_r As Integer) As List(Of sol_noblo) Implements ISol_nobloDao.SetSolnoblo_a_r
                Dim sol_noblo_list As IList
                Try
                    sol_noblo_list = NHibernateSession.GetNamedQuery("ENVIO_APROB_SOL_NOBLO").SetInt32("id_sol", id_sol).SetInt32("usuario", usuario).SetInt32("id_nivel", id_nivel).SetString("comen", comen).SetInt32("a_r", a_r).List
                    If sol_noblo_list.Count > 0 Then
                        Return ConvertToGenericList(sol_noblo_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en el envio de solicitud de NO BLOQUEO", ex)
                End Try
            End Function
        End Class

        Public Class Sol_noblo_selectDao
            Inherits GenericNHibernateDao(Of sol_noblo_select, String)
            Implements ISol_noblo_selectDao
            Public Function SetSolnoblo(id_nivel As Integer, age As String, nombre As String, est As String) As List(Of sol_noblo_select) Implements ISol_noblo_selectDao.SetSolnoblo
                Dim sol_noblo_list As IList
                Try
                    sol_noblo_list = NHibernateSession.GetNamedQuery("SELECT_NO_BLOQ_AGE").SetInt32("id_nivel", id_nivel).SetString("age", age).SetString("nom_age", nombre).SetString("est", est).List
                    If sol_noblo_list.Count > 0 Then
                        Return ConvertToGenericList(sol_noblo_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en la consulta de solicitudes de NO BLOQUEO", ex)
                End Try
            End Function
        End Class

        Public Class sol_noblo_aproDao
            Inherits GenericNHibernateDao(Of sol_noblo_aprob, String)
            Implements ISol_noblo_aprobDao
            Public Function SetSolnoblo(usuario As Integer) As List(Of sol_noblo_aprob) Implements ISol_noblo_aprobDao.SetSolnoblo
                Dim sol_noblo_aproblist As IList
                Try
                    sol_noblo_aproblist = NHibernateSession.GetNamedQuery("SELECT_SOL_NOBLO_APROB").SetInt32("usuario", usuario).List
                    If sol_noblo_aproblist.Count > 0 Then
                        Return ConvertToGenericList(sol_noblo_aproblist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las solicitudes de NO BLOQUEO", ex)
                End Try
            End Function
        End Class
        Public Class tp_llamadaDao
            Inherits GenericNHibernateDao(Of cct_tp_llamda, String)
            Implements I_tp_llamada_Dao
            Public Function GetByEstado(id As Integer, desc As String, activo As Integer) As List(Of cct_tp_llamda) Implements I_tp_llamada_Dao.GetByEstado
                Dim cct_tp_llamadalist As IList
                Try
                    cct_tp_llamadalist = NHibernateSession.GetNamedQuery("SELECT_TP_LLAMADA").SetInt32("id", id).SetString("descripcion", desc).SetInt32("activo", activo).List
                    If cct_tp_llamadalist.Count > 0 Then
                        Return ConvertToGenericList(cct_tp_llamadalist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las solicitudes de tipo de llamada", ex)
                End Try
            End Function
        End Class
        Public Class motivo_cctDao
            Inherits GenericNHibernateDao(Of cct_motivo, String)
            Implements I_motivo_cct_Dao

            Public Function GetByEstado(desc As String, activo As Integer) As List(Of cct_motivo) Implements I_motivo_cct_Dao.GetByEstado
                Dim cct_motivolist As IList
                Try
                    cct_motivolist = NHibernateSession.GetNamedQuery("SELECT_CCT_MOTIVOS").SetString("descripcion", desc).SetInt32("activo", activo).List
                    If cct_motivolist.Count > 0 Then
                        Return ConvertToGenericList(cct_motivolist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar los motivos", ex)
                End Try
            End Function

            Public Function Setmotivos(id_motivo As Integer, desc As String, activo As Integer, codusu As Integer) As List(Of cct_motivo) Implements I_motivo_cct_Dao.Setmotivos
                Dim cct_motivolist As IList
                Try
                    cct_motivolist = NHibernateSession.GetNamedQuery("INSERT_CCT_MOTIVO").SetInt32("id", id_motivo).SetString("descripcion", desc).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_motivolist.Count > 0 Then
                        Return ConvertToGenericList(cct_motivolist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar los motivos", ex)
                End Try
            End Function
        End Class
        Public Class incidencia_cctDao
            Inherits GenericNHibernateDao(Of cct_incidencia, String)
            Implements I_incidencia_cct_Dao
            Public Function GetByEstado(desc As String, activo As Integer) As List(Of cct_incidencia) Implements I_incidencia_cct_Dao.GetByEstado
                Dim cct_incidencialist As IList
                Try
                    cct_incidencialist = NHibernateSession.GetNamedQuery("SELECT_CCT_INCIDENCIAS").SetString("descripcion", desc).SetInt32("activo", activo).List
                    If cct_incidencialist.Count > 0 Then
                        Return ConvertToGenericList(cct_incidencialist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las incidencias", ex)
                End Try
            End Function
            Public Function Setincidencias(id_incidencia As Integer, desc As String, activo As Integer, codusu As Integer) As List(Of cct_incidencia) Implements I_incidencia_cct_Dao.Setincidencias
                Dim cct_incidencialist As IList
                Try
                    cct_incidencialist = NHibernateSession.GetNamedQuery("INSERT_CCT_INCIDENCIA").SetInt32("id", id_incidencia).SetString("descripcion", desc).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_incidencialist.Count > 0 Then
                        Return ConvertToGenericList(cct_incidencialist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar las incidencias", ex)
                End Try
            End Function
        End Class
        Public Class conclusiones_cctDao
            Inherits GenericNHibernateDao(Of cct_con, String)
            Implements I_con_cct_Dao

            Public Function GetByEstado(desc As String, activo As Integer) As List(Of cct_con) Implements I_con_cct_Dao.GetByEstado
                Dim cct_conlist As IList
                Try
                    cct_conlist = NHibernateSession.GetNamedQuery("SELECT_CCT_CON").SetString("descripcion", desc).SetInt32("activo", activo).List
                    If cct_conlist.Count > 0 Then
                        Return ConvertToGenericList(cct_conlist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las conclusiones", ex)
                End Try
            End Function

            Public Function SetConclusion(id_conclusion As Integer, desc As String, activo As Integer, codusu As Integer) As List(Of cct_con) Implements I_con_cct_Dao.SetConclusion
                Dim cct_conlist As IList
                Try
                    cct_conlist = NHibernateSession.GetNamedQuery("INSERT_CCT_CON").SetInt32("id", id_conclusion).SetString("descripcion", desc).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_conlist.Count > 0 Then
                        Return ConvertToGenericList(cct_conlist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar las conclusiones", ex)
                End Try
            End Function

        End Class
        Public Class tp_llamada_motivo_cctDao
            Inherits GenericNHibernateDao(Of cct_tp_llamada_motivo, String)
            Implements I_tp_llamada_motivo_Dao
            Public Function GetByEstado(id_motivo As Integer, id_tp_llamada As Integer, activo As Integer) As List(Of cct_tp_llamada_motivo) Implements I_tp_llamada_motivo_Dao.GetByEstado
                Dim cct_tp_llamada_motivolist As IList
                Try
                    cct_tp_llamada_motivolist = NHibernateSession.GetNamedQuery("SELECT_CCT_TP_LLAMADA_MOTIVO").SetInt32("id_motivo", id_motivo).SetInt32("id_tp_llamada", id_tp_llamada).SetInt32("activo", activo).List
                    If cct_tp_llamada_motivolist.Count > 0 Then
                        Return ConvertToGenericList(cct_tp_llamada_motivolist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar los motivos", ex)
                End Try
            End Function
            Public Function Setmotivos(id_motivo As Integer, id_tp_llamada As Integer, activo As Integer, codusu As Integer) As List(Of cct_tp_llamada_motivo) Implements I_tp_llamada_motivo_Dao.Setmotivos
                Dim cct_tp_llamada_motivolist As IList
                Try
                    cct_tp_llamada_motivolist = NHibernateSession.GetNamedQuery("INSERT_CCT_TP_LLAMADA_MOTIVO").SetInt32("id_motivo", id_motivo).SetInt32("id_tp_llamada", id_tp_llamada).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_tp_llamada_motivolist.Count > 0 Then
                        Return ConvertToGenericList(cct_tp_llamada_motivolist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar los motivos", ex)
                End Try
            End Function
        End Class
        Public Class mot_inc_cctDao
            Inherits GenericNHibernateDao(Of cct_mot_inc, String)
            Implements I_mot_inc_Dao
            Public Function GetByEstado(id_incidencia As Integer, id_motivo As Integer, activo As Integer) As List(Of cct_mot_inc) Implements I_mot_inc_Dao.GetByEstado
                Dim cct_mot_inclist As IList
                Try
                    cct_mot_inclist = NHibernateSession.GetNamedQuery("SELECT_CCT_MOTIVO_INCIDENCIA").SetInt32("id_incidencia", id_incidencia).SetInt32("id_motivo", id_motivo).SetInt32("activo", activo).List
                    If cct_mot_inclist.Count > 0 Then
                        Return ConvertToGenericList(cct_mot_inclist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las incidencias", ex)
                End Try
            End Function

            Public Function Setincidencias(id_incidencia As Integer, id_motivo As Integer, activo As Integer, codusu As Integer) As List(Of cct_mot_inc) Implements I_mot_inc_Dao.Setincidencias
                Dim cct_mot_inclist As IList
                Try
                    cct_mot_inclist = NHibernateSession.GetNamedQuery("INSERT_CCT_MOTIVO_INCIDENCIA").SetInt32("id_incidencia", id_incidencia).SetInt32("id_motivo", id_motivo).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_mot_inclist.Count > 0 Then
                        Return ConvertToGenericList(cct_mot_inclist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar las incidencias", ex)
                End Try
            End Function
        End Class
        Public Class inc_con_cctDao
            Inherits GenericNHibernateDao(Of cct_inc_con, String)
            Implements I_inc_con_Dao
            Public Function GetByEstado(id_conclusion As Integer, id_incidencia As Integer, activo As Integer) As List(Of cct_inc_con) Implements I_inc_con_Dao.GetByEstado
                Dim cct_inc_conlist As IList
                Try
                    cct_inc_conlist = NHibernateSession.GetNamedQuery("SELECT_CCT_INC_CON").SetInt32("id_incidencia", id_incidencia).SetInt32("id_conclusion", id_conclusion).SetInt32("activo", activo).List
                    If cct_inc_conlist.Count > 0 Then
                        Return ConvertToGenericList(cct_inc_conlist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al consultar las conclusiones", ex)
                End Try
            End Function

            Public Function SetConclusiones(id_conclusion As Integer, id_incidencia As Integer, activo As Integer, codusu As Integer) As List(Of cct_inc_con) Implements I_inc_con_Dao.SetConclusiones
                Dim cct_inc_conlist As IList
                Try
                    cct_inc_conlist = NHibernateSession.GetNamedQuery("INSERT_CCT_INC_CON").SetInt32("id_incidencia", id_incidencia).SetInt32("id_conclusion", id_conclusion).SetInt32("activo", activo).SetInt32("usuario", codusu).List
                    If cct_inc_conlist.Count > 0 Then
                        Return ConvertToGenericList(cct_inc_conlist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error al insertar las conclusiones", ex)
                End Try

            End Function

        End Class
        Public Class Venta_CursoDao
            Inherits GenericNHibernateDao(Of venta_curso, String)
            Implements IVenta_CursoDao
            Public Function GetByAgente(agente As String) As List(Of venta_curso) Implements IVenta_CursoDao.GetByAgente
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("agente", agente))
                criteria.AddOrder(Order.Asc("ID"))
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class

        Public Class QJM_cua_sDao
            Inherits GenericNHibernateDao(Of qjm_cua_s, String)
            Implements IQJM_cua_sDao
            Public Function GetByAgente(agente As String) As List(Of qjm_cua_s) Implements IQJM_cua_sDao.GetByAgente
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                criteria.Add(Expression.Eq("agente", agente))
                criteria.AddOrder(Order.Desc("ID"))
                criteria.SetMaxResults(1)
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class

        Public Class FacperiodoDao
            Inherits GenericNHibernateDao(Of facperiodo, String)
            Implements IFacperiodoDao

            Public Function GetByCodage(codage As String) As List(Of facperiodo) Implements IFacperiodoDao.GetByCodage
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Eq("codage", codage))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de factura Loto Real", ex)
                End Try
            End Function

        End Class
        Public Class cct_capacitacionesDao
            Inherits GenericNHibernateDao(Of cct_capacitaciones, String)
            Implements I_cct_capacitaciones
            Public Function GetByCapAct(id_cap As Integer, desc As String, act As Integer) As List(Of cct_capacitaciones) Implements I_cct_capacitaciones.GetByCapAct
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                If id_cap <> 0 Then
                    criteria.Add(Expression.Eq("ID", id_cap))
                End If
                If desc <> "" Then
                    criteria.Add(Expression.Like("DESCRIPCION", "%" & desc & "%"))
                End If
                criteria.Add(Expression.Eq("ACTIVO", act))
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class
        Public Class cct_materialesDao
            Inherits GenericNHibernateDao(Of cct_materiales, String)
            Implements I_cct_materiales
            Public Function GetByMatAct(id_mat As Integer, desc As String, act As Integer) As List(Of cct_materiales) Implements I_cct_materiales.GetByMatAct
                Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                If id_mat <> 0 Then
                    criteria.Add(Expression.Eq("ID", id_mat))
                End If
                If desc <> "" Then
                    criteria.Add(Expression.Like("DESCRIPCION", "%" & desc & "%"))
                End If
                criteria.Add(Expression.Eq("ACTIVO", act))
                Return ConvertToGenericList(criteria.List())
            End Function
        End Class
        Public Class cct_cap_histDao
            Inherits GenericNHibernateDao(Of cct_cap_hist, String)
            Implements I_cct_cap_hist
            Public Function GetByCapAct(_AGE As String, _ACTIVO As Integer) As List(Of cct_cap_hist) Implements I_cct_cap_hist.GetByCapAct
                Dim li As IList
                Try
                    li = NHibernateSession.GetNamedQuery("SELECT_CCT_CAP_HIST").SetString("_AGE", _AGE).SetInt32("_ACTIVO", _ACTIVO).List
                    If li.Count > 0 Then
                        Return ConvertToGenericList(li)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de historial de capacitaciones", ex)
                End Try
            End Function
        End Class
        Public Class cct_notasDao
            Inherits GenericNHibernateDao(Of cct_notas, String)
            Implements I_cct_notas
            Public Function GetNotaByAge(_AGE As String, _FEC As String, _USU As String, _NOTA As String, _FEC_AGE As String) As List(Of cct_notas) Implements I_cct_notas.GetNotaByAge
                Dim li As IList
                Try
                    li = NHibernateSession.GetNamedQuery("SELECT_CCT_NOTAS").SetString("_AGE", _AGE).SetString("_FEC", _FEC).SetString("_USU", _USU).SetString("_NOTA", _NOTA).SetString("_FEC_AGE", _FEC_AGE).List
                    If li.Count > 0 Then
                        Return ConvertToGenericList(li)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error en consulta de notas de Agente", ex)
                End Try
            End Function
        End Class
        Public Class cct_mat_histDao
            Inherits GenericNHibernateDao(Of cct_mat_hist, String)
            Implements I_cct_mat_hist
            Public Function GetByHistAct(_AGE As String, _ACTIVO As Integer) As List(Of cct_mat_hist) Implements I_cct_mat_hist.GetByHistAct
                Dim li As IList
                Try
                    li = NHibernateSession.GetNamedQuery("SELECT_CCT_MAT_HIST").SetString("_AGE", _AGE).SetInt32("_ACTIVO", _ACTIVO).List
                    If li.Count > 0 Then
                        Return ConvertToGenericList(li)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de historial de materiales de Agente", ex)
                End Try
            End Function
        End Class
        Public Class cct_comp_cara_ageDao
            Inherits GenericNHibernateDao(Of cct_comp_cara_age, String)
            Implements I_cct_comp_cara_age
            Public Function GetCaraByAge(_AGENTE As String, _ID_COMP As Integer) As List(Of cct_comp_cara_age) Implements I_cct_comp_cara_age.GetCaraByAge
                Dim li As IList
                Try
                    li = NHibernateSession.GetNamedQuery("SELECT_COMP_CARA_AGE").SetString("_AGENTE", _AGENTE).SetInt32("_ID_COMP", _ID_COMP).List
                    If li.Count > 0 Then
                        Return ConvertToGenericList(li)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de caracteristica de Agente", ex)
                End Try
            End Function

            Public Function GetCaraActByAge(_AGENTE As String, _ID_COMP As Integer, _ACTIVO As Integer) As List(Of cct_comp_cara_age) Implements I_cct_comp_cara_age.GetCaraActByAge
                Dim li As IList
                Try
                    li = NHibernateSession.GetNamedQuery("SELECT_COMP_CARA_AGE_ACT").SetString("_AGENTE", _AGENTE).SetInt32("_ID_COMP", _ID_COMP).SetInt32("_ACTIVO", _ACTIVO).List
                    If li.Count > 0 Then
                        Return ConvertToGenericList(li)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error en consulta de caracteristica de Agente", ex)
                End Try
            End Function

        End Class
        Public Class cct_comp_ageDao
            Inherits GenericNHibernateDao(Of cct_comp_age, String)
            Implements I_cct_comp_age
            Public Function GetCompAge(_AGENTE As String, _ACTIVO As Integer) As List(Of cct_comp_age) Implements I_cct_comp_age.GetCompAge
                Try
                    Dim criteria As ICriteria = NHibernateSession.CreateCriteria(persistentType)
                    criteria.Add(Expression.Eq("AGENTE", _AGENTE))
                    criteria.Add(Expression.Eq("ACTIVO", _ACTIVO))
                    Return ConvertToGenericList(criteria.List())
                Catch ex As Exception
                    Throw New Exception("Error en consulta de componentes de Agente", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_capDao
            Inherits GenericNHibernateDao(Of cct_reg_cap, String)
            Implements I_cct_reg_cap
            Public Function SetRegCap(_id_cap As Integer, _age As String, _rec As String, _ent As String, _id_empl As Integer, _fecha As String, _fec_reg As String, _id_reg As Integer, _codusu As Integer, _activo As Integer, _id_h_cap As Integer) As List(Of cct_reg_cap) Implements I_cct_reg_cap.SetRegCap
                Dim reg_list As IList
                Try
                    reg_list = NHibernateSession.GetNamedQuery("INSERT_CCT_CAP").SetInt32("_id_cap", _id_cap).SetString("_age", _age).SetString("_rec", _rec).SetString("_ent", _ent).SetInt32("_id_empl", _id_empl).SetString("_fecha", _fecha).SetString("_fec_reg", _fec_reg).SetInt32("_id_reg", _id_reg).SetInt32("_codusu", _codusu).SetInt32("_activo", _activo).SetInt32("_id_h_cap", _id_h_cap).List
                    If reg_list.Count > 0 Then
                        Return ConvertToGenericList(reg_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando registro", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_matDao
            Inherits GenericNHibernateDao(Of cct_reg_mat, String)
            Implements I_cct_reg_mat
            Public Function SetRegMat(_id_mat As Integer, _cant As Decimal, _age As String, _rec As String, _ent As String, _id_empl As Integer, _fecha As String, _fec_reg As String, _id_reg As Integer, _codusu As Integer, _activo As Integer, _id_h_mat As Integer) As List(Of cct_reg_mat) Implements I_cct_reg_mat.SetRegMat
                Dim reg_list As IList
                Try
                    reg_list = NHibernateSession.GetNamedQuery("INSERT_CCT_MAT").SetInt32("_id_mat", _id_mat).SetDecimal("_cant", _cant).SetString("_age", _age).SetString("_rec", _rec).SetString("_ent", _ent).SetInt32("_id_empl", _id_empl).SetString("_fecha", _fecha).SetString("_fec_reg", _fec_reg).SetInt32("_id_reg", _id_reg).SetInt32("_codusu", _codusu).SetInt32("_activo", _activo).SetInt32("_id_h_mat", _id_h_mat).List
                    If reg_list.Count > 0 Then
                        Return ConvertToGenericList(reg_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando registro", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_cara_ageDao
            Inherits GenericNHibernateDao(Of cct_reg_cara_age, String)
            Implements I_cct_reg_cara_age
            Public Function SetRegCara(_AGENTE As String, _ID_COMP As Integer, _ID_CARA As Integer, _S1 As String, _S2 As String, _ACTIVO As Integer, _ACTUALIZA As Integer) As List(Of cct_reg_cara_age) Implements I_cct_reg_cara_age.SetRegCara
                Dim reg_list As IList
                Try
                    reg_list = NHibernateSession.GetNamedQuery("INSERT_REG_CARA_AGE").SetString("_AGENTE", _AGENTE).SetInt32("_ID_COMP", _ID_COMP).SetInt32("_ID_CARA", _ID_CARA).SetString("_S1", _S1).SetString("_S2", _S2).SetInt32("_ACTIVO", _ACTIVO).SetInt32("_ACTUALIZA", _ACTUALIZA).List
                    If reg_list.Count > 0 Then
                        Return ConvertToGenericList(reg_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando registro de caracteristica", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_compDao
            Inherits GenericNHibernateDao(Of cct_reg_comp, String)
            Implements I_cct_reg_comp
            Public Function SetRegComp(_AGENTE As String, _ID_COMP As Integer, _ACTIVO As Integer) As List(Of cct_reg_comp) Implements I_cct_reg_comp.SetRegComp
                Dim reg_list As IList
                Try
                    reg_list = NHibernateSession.GetNamedQuery("INSERT_REG_COMP").SetString("_AGENTE", _AGENTE).SetInt32("_ID_COMP", _ID_COMP).SetInt32("_ACTIVO", _ACTIVO).List
                    If reg_list.Count > 0 Then
                        Return ConvertToGenericList(reg_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando registro", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_notaDao
            Inherits GenericNHibernateDao(Of cct_reg_nota, String)
            Implements I_cct_reg_nota
            Public Function SetRegNota(_AGE As String, _CODUSU As Integer, _NOTA As String, _FEC_AGE As String) As List(Of cct_reg_nota) Implements I_cct_reg_nota.SetRegNota
                Dim reg As IList
                Try
                    reg = NHibernateSession.GetNamedQuery("INSERT_CCT_NOTA").SetString("_AGE", _AGE).SetInt32("_CODUSU", _CODUSU).SetString("_NOTA", _NOTA).SetString("_FEC_AGE", _FEC_AGE).List
                    If reg.Count > 0 Then
                        Return ConvertToGenericList(reg)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error guardando registro de nota", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_tkDao
            Inherits GenericNHibernateDao(Of cct_reg_tk, String)
            Implements I_cct_reg_tk
            Public Function SetRegTk(_ID_EST_TK As Integer, _VERIF_SN As Integer, _ID_REG As Integer, _COMEN As String, _ID_INCFRM As Integer, _CODUSU As Integer) As List(Of cct_reg_tk) Implements I_cct_reg_tk.SetRegTk
                Dim reg As IList
                Try
                    reg = NHibernateSession.GetNamedQuery("INSERT_REG_TK").SetInt32("_ID_EST_TK", _ID_EST_TK).SetInt32("_VERIF_SN", _VERIF_SN).SetInt32("_ID_REG", _ID_REG).SetString("_COMEN", _COMEN).SetInt32("_ID_INCFRM", _ID_INCFRM).SetInt32("_CODUSU", _CODUSU).List
                    If reg.Count > 0 Then
                        Return ConvertToGenericList(reg)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error guardando registro de tk", ex)
                End Try
            End Function

            Public Function ActRegTk(_ID_TK As Integer, _ID_EST_TK As Integer, _VERIF As Integer) As List(Of cct_reg_tk) Implements I_cct_reg_tk.ActRegTk
                Dim reg As IList
                Try
                    reg = NHibernateSession.GetNamedQuery("UPDATE_CCT_TKS").SetInt32("_ID_TK", _ID_TK).SetInt32("_ID_EST_TK", _ID_EST_TK).SetInt32("_VERIF", _VERIF).List
                    If reg.Count > 0 Then
                        Return ConvertToGenericList(reg)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error guardando registro de tk", ex)
                End Try
            End Function

            Public Function GetEstTk(_ID_TK As Integer) As List(Of cct_reg_tk) Implements I_cct_reg_tk.GetEstTk
                Dim reg As IList
                Try
                    reg = NHibernateSession.GetNamedQuery("SELECT_ESTADO_CCT_TK").SetInt32("_ID_TK", _ID_TK).List
                    If reg.Count > 0 Then
                        Return ConvertToGenericList(reg)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error al seleccionar registro de tk", ex)
                End Try
            End Function
        End Class
        Public Class cct_reg_llamadaDao
            Inherits GenericNHibernateDao(Of cct_reg_llamada, String)
            Implements I_cct_reg_llamada
            Public Function SetRegLlama(_AGENTE As String, _ID_CONT As Integer, _NOM_CONT As String, _ID_TP_LLAMADA As Integer, _ID_MOTIVO As Integer, _ID_INCIDENCIA As Integer, _ID_CONCLUSION As Integer, _NOTA As String, _FEC_INI As String, _FEC_FIN As String, _H_INI As String, _H_FIN As String, _CODUSU As Integer, _ID_LLAMADA As Integer, _ID_TK_CERRADO As Integer) As List(Of cct_reg_llamada) Implements I_cct_reg_llamada.SetRegLlama
                Dim soli_ajuste_list As IList
                Try
                    soli_ajuste_list = NHibernateSession.GetNamedQuery("INSERT_REG_LLAMADA").SetString("_AGENTE", _AGENTE).SetInt32("_ID_CONT", _ID_CONT).SetString("_NOM_CONT", _NOM_CONT).SetInt32("_ID_TP_LLAMADA", _ID_TP_LLAMADA).SetInt32("_ID_MOTIVO", _ID_MOTIVO).SetInt32("_ID_INCIDENCIA", _ID_INCIDENCIA).SetInt32("_ID_CONCLUSION", _ID_CONCLUSION).SetString("_NOTA", _NOTA).SetString("_FEC_INI", _FEC_INI).SetString("_FEC_FIN", _FEC_FIN).SetString("_H_INI", _H_INI).SetString("_H_FIN", _H_FIN).SetInt32("_CODUSU", _CODUSU).SetInt32("_ID_LLAMADA", _ID_LLAMADA).SetInt32("_ID_TK_CERRADO", _ID_TK_CERRADO).List
                    If soli_ajuste_list.Count > 0 Then
                        Return ConvertToGenericList(soli_ajuste_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error guardando registro", ex)
                End Try
            End Function

            Public Function ActRegLlama(_ID_REG As Integer, _ID_TK As Integer) As List(Of cct_reg_llamada) Implements I_cct_reg_llamada.ActRegLlama
                Dim soli_ajuste_list As IList
                Try
                    soli_ajuste_list = NHibernateSession.GetNamedQuery("UPDATE_REG_LLAMADA").SetInt32("_ID_REG", _ID_REG).SetInt32("_ID_TK", _ID_TK).List
                    If soli_ajuste_list.Count > 0 Then
                        Return ConvertToGenericList(soli_ajuste_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error al actualizar registro", ex)
                End Try
            End Function

        End Class
        Public Class cct_llamadasDao
            Inherits GenericNHibernateDao(Of cct_llamadas, String)
            Implements I_cct_llamadas
            Public Function SetLlamada(_ID_TP_LLAMADA As Integer, _AGENTE As String, _CODUSU As Integer, _ID_TP_CONT As Integer, _NOM_CONT As String, _NUM_MOT As Integer, _NUM_TK_A As Integer, _NUM_TK_C As Integer, _FEC_TK_C As String, _FECHA As String, _H_INI As String, _H_FIN As String, _ACTIVO As Integer) As List(Of cct_llamadas) Implements I_cct_llamadas.SetLlamada
                Dim result_list As IList
                Try
                    result_list = NHibernateSession.GetNamedQuery("INSERT_LLAMADA").SetInt32("_ID_TP_LLAMADA", _ID_TP_LLAMADA).SetString("_AGENTE", _AGENTE).SetInt32("_CODUSU", _CODUSU).SetInt32("_ID_TP_CONT", _ID_TP_CONT).SetString("_NOM_CONT", _NOM_CONT).SetInt32("_NUM_MOT", _NUM_MOT).SetInt32("_NUM_TK_A", _NUM_TK_A).SetInt32("_NUM_TK_C", _NUM_TK_C).SetString("_FEC_TK_C", _FEC_TK_C).SetString("_FECHA", _FECHA).SetString("_H_INI", _H_INI).SetString("_H_FIN", _H_FIN).SetInt32("_ACTIVO", _ACTIVO).List
                    If result_list.Count > 0 Then
                        Return ConvertToGenericList(result_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando registro", ex)
                End Try
            End Function
        End Class
        Public Class cct_tksDao
            Inherits GenericNHibernateDao(Of cct_tks, String)
            Implements I_cct_tks
            Public Function GetByEst(_AGENTE As String, _ID_EST_TK As Integer) As List(Of cct_tks) Implements I_cct_tks.GetByEst
                Dim tks As IList
                Try
                    tks = NHibernateSession.GetNamedQuery("SELECT_CCT_TKS").SetString("_AGENTE", _AGENTE).SetInt32("_ID_EST_TK", _ID_EST_TK).List
                    If tks.Count > 0 Then
                        Return ConvertToGenericList(tks)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error en la consulta de tickets", ex)
                End Try
            End Function
        End Class
        Public Class cct_h_ll_ageDao
            Inherits GenericNHibernateDao(Of cct_h_ll_age, String)
            Implements I_cct_h_ll_age
            Public Function GetByllAge(_AGENTE As String, _NOM_CONT As String, _TOP As Integer) As List(Of cct_h_ll_age) Implements I_cct_h_ll_age.GetByllAge
                Dim hist As IList
                Try
                    hist = NHibernateSession.GetNamedQuery("SELECT_CCT_H_LL_AGE").SetString("_AGENTE", _AGENTE).SetString("_NOM_CONT", _NOM_CONT).SetInt32("_TOP", _TOP).List
                    If hist.Count > 0 Then
                        Return ConvertToGenericList(hist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error en la consulta de llamadas", ex)
                End Try
            End Function
        End Class
        Public Class cct_h_tks_Dao
            Inherits GenericNHibernateDao(Of cct_h_tks, String)
            Implements I_cct_h_tks
            Public Function GetByAge(_AGENTE As String) As List(Of cct_h_tks) Implements I_cct_h_tks.GetByAge
                Dim hist As IList
                Try
                    hist = NHibernateSession.GetNamedQuery("SELECT_CCT_H_TKS").SetString("_AGENTE", _AGENTE).List
                    If hist.Count > 0 Then
                        Return ConvertToGenericList(hist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error en la consulta del historial de tickets", ex)
                End Try
            End Function
        End Class
        Public Class cct_h_ll_Dao
            Inherits GenericNHibernateDao(Of cct_h_ll, String)
            Implements I_cct_h_ll
            Public Function GetByid_lla(_ID_LLAMADA As Integer) As List(Of cct_h_ll) Implements I_cct_h_ll.GetByid_lla
                Dim hist As IList
                Try
                    hist = NHibernateSession.GetNamedQuery("SELECT_CCT_H_LL").SetInt32("_ID_LLAMADA", _ID_LLAMADA).List
                    If hist.Count > 0 Then
                        Return ConvertToGenericList(hist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("NH: Error en la consulta del historial de llamadas", ex)
                End Try
            End Function
        End Class

        Public Class SoliajusteDao
            Inherits GenericNHibernateDao(Of soli_ajuste, String)
            Implements ISoli_asjuteDao
            Public Function SetByAgente(usu As String, agente As String, comen As String) As List(Of soli_ajuste) Implements ISoli_asjuteDao.SetByAgente
                Dim soli_ajuste_list As IList
                Try
                    soli_ajuste_list = NHibernateSession.GetNamedQuery("ENVIO_SOLI_AJUSTE").SetString("usu", usu).SetString("agente", agente).SetString("comen", comen).List
                    If soli_ajuste_list.Count > 0 Then
                        Return ConvertToGenericList(soli_ajuste_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error enviando solicitud de ajuste", ex)
                End Try
            End Function
        End Class

        Public Class PromesaPagDao
            Inherits GenericNHibernateDao(Of promesa_pag, String)
            Implements IPromesa_PagDao
            Public Function SetByAgente(codage As String, fecha As String, hora As String, monto As Decimal) As List(Of promesa_pag) Implements IPromesa_PagDao.SetByAgente
                Dim prom_pag_list As IList
                Try
                    prom_pag_list = NHibernateSession.GetNamedQuery("GUARDA_PROMESA").SetString("codage", codage).SetString("fecha", fecha).SetString("hora", hora).SetDecimal("monto", monto).List
                    If prom_pag_list.Count > 0 Then
                        Return ConvertToGenericList(prom_pag_list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando promesa de pago", ex)
                End Try
            End Function
        End Class

        Public Class cct_Generic_UpdateDao
            Inherits GenericNHibernateDao(Of generic_update, String)
            Implements I_cct_generic_update

            Public Function SetUpdate(id As Integer, desc As String) As List(Of generic_update) Implements I_cct_generic_update.SetUpdate
                Dim list As IList
                Try
                    list = NHibernateSession.GetNamedQuery("UPDATE_COMP").SetInt32("_ID", id).SetString("_DESC", desc).List
                    If list.Count > 0 Then
                        Return ConvertToGenericList(list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando descripcion", ex)
                End Try
            End Function

            Public Function SetUpdate_cara(id_comp As Integer, id As Integer, desc As String) As List(Of generic_update) Implements I_cct_generic_update.SetUpdate_cara
                Dim list As IList
                Try
                    list = NHibernateSession.GetNamedQuery("UPDATE_CARA").SetInt32("_ID_COMP", id_comp).SetInt32("_ID", id).SetString("_DESC", desc).List
                    If list.Count > 0 Then
                        Return ConvertToGenericList(list)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Throw New Exception("Error guardando descripcion", ex)
                End Try
            End Function

        End Class
        Public Function GetUsuarioDao() As Core.DataInterfaces.IUsuarioDao Implements Core.DataInterfaces.IDaoFactory.GetUsuarioDao
            Return New UsuarioDao
        End Function

        Public Function GetAgenteDao() As IAgenteDao Implements IDaoFactory.GetAgenteDao
            Return New AgenteDao
        End Function

        Public Function GetGestoresDao() As IGestoresDao Implements IDaoFactory.GetGestoresDao
            Return New GestoresDao
        End Function

        Public Function GetCallcenteradmDao() As ICallcenteradmDao Implements IDaoFactory.GetCallcenteradmDao
            Return New CallcenteradmDao
        End Function
        Public Function GetEmpleadoDao() As IEmpleadoDao Implements IDaoFactory.GetEmpleadoDao
            Return New EmpleadoDao
        End Function
        Public Function Getgestor_usuarioDao() As Igestor_usuarioDao Implements IDaoFactory.Getgestor_usuarioDao
            Return New gestor_usuarioDao
        End Function
        Public Function GetEstado_CuentaDao() As IEstado_Cuenta Implements IDaoFactory.GetEstado_CuentaDao
            Return New Estado_CuentaDao
        End Function
        Public Function GetUsu_LLamadasDao() As IUsu_LLamadasDao Implements IDaoFactory.GetUsu_LLamadasDao
            Return New Usu_LLamadasDao
        End Function

        Public Function GetVenta_CursoDao() As IVenta_CursoDao Implements IDaoFactory.GetVenta_CursoDao
            Return New Venta_CursoDao
        End Function

        Public Function GetQJM_cua_sDao() As IQJM_cua_sDao Implements IDaoFactory.GetQJM_cua_sDao
            Return New QJM_cua_sDao
        End Function
        Public Function GetFacperiodoDao() As IFacperiodoDao Implements IDaoFactory.GetFacperiodoDao
            Return New FacperiodoDao
        End Function
        Public Function GetSoli_ajusteDao() As ISoli_asjuteDao Implements IDaoFactory.GetSoli_ajusteDao
            Return New SoliajusteDao
        End Function
        Public Function GetPromesa_PagDao() As IPromesa_PagDao Implements IDaoFactory.GetPromesa_PagDao
            Return New PromesaPagDao
        End Function
        Public Function GetBloquearDao() As IBloquearDao Implements IDaoFactory.GetBloquearDao
            Return New BloquearDao
        End Function
        Public Function GetSol_noblo_tiposDao() As ISol_noblo_tiposDao Implements IDaoFactory.GetSol_noblo_tiposDao
            Return New Sol_noblo_tiposDao
        End Function
        Public Function GetSol_nobloDao() As ISol_nobloDao Implements IDaoFactory.GetSol_nobloDao
            Return New Sol_nobloDao
        End Function
        Public Function GetSol_noblo_aprobDao() As ISol_noblo_aprobDao Implements IDaoFactory.GetSol_noblo_aprobDao
            Return New sol_noblo_aproDao
        End Function
        Public Function GetSol_noblo_selectDao() As ISol_noblo_selectDao Implements IDaoFactory.GetSol_noblo_selectDao
            Return New Sol_noblo_selectDao
        End Function
        Public Function Get_tp_llamada_Dao() As I_tp_llamada_Dao Implements IDaoFactory.Get_tp_llamada_Dao
            Return New tp_llamadaDao
        End Function
        Public Function Get_motivo_cct_Dao() As I_motivo_cct_Dao Implements IDaoFactory.Get_motivo_cct_Dao
            Return New motivo_cctDao
        End Function
        Public Function Get_tp_llamada_motivo_cct_Dao() As I_tp_llamada_motivo_Dao Implements IDaoFactory.Get_tp_llamada_motivo_cct_Dao
            Return New tp_llamada_motivo_cctDao
        End Function
        Public Function Get_incidencia_cct_Dao() As I_incidencia_cct_Dao Implements IDaoFactory.Get_incidencia_cct_Dao
            Return New incidencia_cctDao
        End Function
        Public Function Get_mot_inc_cct_Dao() As I_mot_inc_Dao Implements IDaoFactory.Get_mot_inc_cct_Dao
            Return New mot_inc_cctDao
        End Function
        Public Function Get_con_cct_Dao() As I_con_cct_Dao Implements IDaoFactory.Get_con_cct_Dao
            Return New conclusiones_cctDao
        End Function
        Public Function Get_inc_con_Dao() As I_inc_con_Dao Implements IDaoFactory.Get_inc_con_Dao
            Return New inc_con_cctDao
        End Function
        Public Function Get_prospDao() As I_prosp_dao Implements IDaoFactory.Get_prospDao
            Return New ProspDao
        End Function
        Public Function Getcct_reg_llamadaDao() As I_cct_reg_llamada Implements IDaoFactory.Getcct_reg_llamadaDao
            Return New cct_reg_llamadaDao
        End Function
        Public Function Getcct_llamadaDao() As I_cct_llamadas Implements IDaoFactory.Getcct_llamadaDao
            Return New cct_llamadasDao
        End Function
        Public Function Get_emplDao() As I_empl_Dao Implements IDaoFactory.Get_emplDao
            Return New emplDao
        End Function
        Public Function Get_age_svDao() As I_age_sv_Dao Implements IDaoFactory.Get_age_svDao
            Return New age_svDao
        End Function
        Public Function Getcct_componentesDao() As I_cct_componentes_Dao Implements IDaoFactory.Getcct_componentesDao
            Return New cct_componentesDao
        End Function
        Public Function Getcct_reg_compDao() As I_cct_reg_comp Implements IDaoFactory.Getcct_reg_compDao
            Return New cct_reg_compDao
        End Function
        Public Function Getcct_comp_ageDao() As I_cct_comp_age Implements IDaoFactory.Getcct_comp_ageDao
            Return New cct_comp_ageDao
        End Function
        Public Function Getcct_comp_cara_ageDao() As I_cct_comp_cara_age Implements IDaoFactory.Getcct_comp_cara_ageDao
            Return New cct_comp_cara_ageDao
        End Function
        Public Function Getcct_matDao() As I_cct_materiales Implements IDaoFactory.Getcct_matDao
            Return New cct_materialesDao
        End Function
        Public Function Getcct_reg_matDao() As I_cct_reg_mat Implements IDaoFactory.Getcct_reg_matDao
            Return New cct_reg_matDao
        End Function
        Public Function Getcct_reg_cara_ageDao() As I_cct_reg_cara_age Implements IDaoFactory.Getcct_reg_cara_ageDao
            Return New cct_reg_cara_ageDao
        End Function
        Public Function Getcct_mat_histDao() As I_cct_mat_hist Implements IDaoFactory.Getcct_mat_histDao
            Return New cct_mat_histDao
        End Function
        Public Function Getcct_capDao() As I_cct_capacitaciones Implements IDaoFactory.Getcct_capDao
            Return New cct_capacitacionesDao
        End Function
        Public Function Getcct_reg_capDao() As I_cct_reg_cap Implements IDaoFactory.Getcct_reg_capDao
            Return New cct_reg_capDao
        End Function
        Public Function Getcct_cap_histDao() As I_cct_cap_hist Implements IDaoFactory.Getcct_cap_histDao
            Return New cct_cap_histDao
        End Function
        Public Function Getcct_reg_tkDao() As I_cct_reg_tk Implements IDaoFactory.Getcct_reg_tkDao
            Return New cct_reg_tkDao
        End Function
        Public Function Getcct_h_ll_ageDao() As I_cct_h_ll_age Implements IDaoFactory.Getcct_h_ll_ageDao
            Return New cct_h_ll_ageDao
        End Function
        Public Function Getcct_h_llDao() As I_cct_h_ll Implements IDaoFactory.Getcct_h_llDao
            Return New cct_h_ll_Dao
        End Function
        Public Function Getcct_h_tksDao() As I_cct_h_tks Implements IDaoFactory.Getcct_h_tksDao
            Return New cct_h_tks_Dao
        End Function
        Public Function Getcct_tksDao() As I_cct_tks Implements IDaoFactory.Getcct_tksDao
            Return New cct_tksDao
        End Function
        Public Function Getcct_reg_notaDao() As I_cct_reg_nota Implements IDaoFactory.Getcct_reg_notaDao
            Return New cct_reg_notaDao
        End Function
        Public Function Getcct_notasDao() As I_cct_notas Implements IDaoFactory.Getcct_notasDao
            Return New cct_notasDao
        End Function

        Public Function Getcct_generic_updateDao() As I_cct_generic_update Implements IDaoFactory.Getcct_generic_updateDao
            Return New cct_Generic_UpdateDao
        End Function

#End Region

    End Class
End Namespace

