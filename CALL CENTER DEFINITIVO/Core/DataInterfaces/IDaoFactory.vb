Imports Core.Domain.Seguridad

Namespace Core.DataInterfaces
    Public Interface IDaoFactory
        Function GetUsuarioDao() As IUsuarioDao
        Function GetAgenteDao() As IAgenteDao
        Function GetGestoresDao() As IGestoresDao
        Function GetCallcenteradmDao() As ICallcenteradmDao
        Function GetEmpleadoDao() As IEmpleadoDao
        Function Getgestor_usuarioDao() As Igestor_usuarioDao
        Function GetEstado_CuentaDao() As IEstado_Cuenta
        Function GetUsu_LLamadasDao() As IUsu_LLamadasDao
        Function GetVenta_CursoDao() As IVenta_CursoDao
        Function GetQJM_cua_sDao() As IQJM_cua_sDao
        Function GetFacperiodoDao() As IFacperiodoDao
        Function GetSoli_ajusteDao() As ISoli_asjuteDao
        Function GetPromesa_PagDao() As IPromesa_PagDao
        Function GetBloquearDao() As IBloquearDao
        Function GetSol_noblo_tiposDao() As ISol_noblo_tiposDao
        Function GetSol_nobloDao() As ISol_nobloDao
        Function GetSol_noblo_aprobDao() As ISol_noblo_aprobDao
        Function GetSol_noblo_selectDao() As ISol_noblo_selectDao
        Function Get_tp_llamada_Dao() As I_tp_llamada_Dao
        Function Get_motivo_cct_Dao() As I_motivo_cct_Dao
        Function Get_tp_llamada_motivo_cct_Dao() As I_tp_llamada_motivo_Dao
        Function Get_incidencia_cct_Dao() As I_incidencia_cct_Dao
        Function Get_mot_inc_cct_Dao() As I_mot_inc_Dao
        Function Get_con_cct_Dao() As I_con_cct_Dao
        Function Get_inc_con_Dao() As I_inc_con_Dao
        Function Get_prospDao() As I_prosp_dao
        Function Getcct_reg_llamadaDao() As I_cct_reg_llamada
        Function Getcct_llamadaDao() As I_cct_llamadas
        Function Get_emplDao() As I_empl_Dao
        Function Get_age_svDao() As I_age_sv_Dao
        Function Getcct_componentesDao() As I_cct_componentes_Dao
        Function Getcct_reg_compDao() As I_cct_reg_comp
        Function Getcct_comp_ageDao() As I_cct_comp_age
        Function Getcct_comp_cara_ageDao() As I_cct_comp_cara_age
        Function Getcct_matDao() As I_cct_materiales
        Function Getcct_reg_matDao() As I_cct_reg_mat 'inserta en el historial de materiales
        Function Getcct_reg_cara_ageDao() As I_cct_reg_cara_age
        Function Getcct_mat_histDao() As I_cct_mat_hist
        Function Getcct_capDao() As I_cct_capacitaciones
        Function Getcct_reg_capDao() As I_cct_reg_cap 'inserta en el historial de capacitaciones
        Function Getcct_cap_histDao() As I_cct_cap_hist
        Function Getcct_reg_tkDao() As I_cct_reg_tk
        Function Getcct_h_ll_ageDao() As I_cct_h_ll_age
        Function Getcct_h_llDao() As I_cct_h_ll
        Function Getcct_h_tksDao() As I_cct_h_tks
        Function Getcct_tksDao() As I_cct_tks
        Function Getcct_reg_notaDao() As I_cct_reg_nota
        Function Getcct_notasDao() As I_cct_notas
        Function Getcct_generic_updateDao() As I_cct_generic_update
    End Interface
#Region "Seguridad"
    Public Interface I_cct_notas
        Inherits IGenericDao(Of cct_notas, String)
        Function GetNotaByAge(ByVal _AGE As String, ByVal _FEC As String, ByVal _USU As String, ByVal _NOTA As String, ByVal _FEC_AGE As String) As List(Of cct_notas)
    End Interface
    Public Interface I_cct_reg_nota
        Inherits IGenericDao(Of cct_reg_nota, String)
        Function SetRegNota(ByVal _AGE As String, ByVal _CODUSU As Integer, ByVal _NOTA As String, ByVal _FEC_AGE As String) As List(Of cct_reg_nota)
    End Interface
    Public Interface I_cct_tks
        Inherits IGenericDao(Of cct_tks, String)
        Function GetByEst(ByVal _AGENTE As String, ByVal _ID_EST_TK As Integer) As List(Of cct_tks)
    End Interface
    Public Interface I_cct_h_tks
        Inherits IGenericDao(Of cct_h_tks, String)
        Function GetByAge(ByVal _AGENTE As String) As List(Of cct_h_tks)
    End Interface
    Public Interface I_cct_h_ll_age
        Inherits IGenericDao(Of cct_h_ll_age, String)
        Function GetByllAge(ByVal _AGENTE As String, ByVal _NOM_CONT As String, ByVal _TOP As Integer) As List(Of cct_h_ll_age)
    End Interface
    Public Interface I_cct_h_ll
        Inherits IGenericDao(Of cct_h_ll, String)
        Function GetByid_lla(ByVal _ID_LLAMADA As Integer) As List(Of cct_h_ll)
    End Interface

    Public Interface I_cct_reg_tk
        Inherits IGenericDao(Of cct_reg_tk, String)
        Function SetRegTk(ByVal _ID_EST_TK As Integer, ByVal _VERIF_SN As Integer, ByVal _ID_REG As Integer, ByVal _COMEN As String, ByVal _ID_INCFRM As Integer, ByVal _CODUSU As Integer) As List(Of cct_reg_tk)
        Function ActRegTk(ByVal _ID_TK As Integer, ByVal _ID_EST_TK As Integer, ByVal VERIF As Integer) As List(Of cct_reg_tk)
        Function GetEstTk(ByVal _ID_TK As Integer) As List(Of cct_reg_tk)
    End Interface
    Public Interface I_cct_cap_hist
        Inherits IGenericDao(Of cct_cap_hist, String)
        Function GetByCapAct(ByVal _AGE As String, ByVal _ACTIVO As Integer) As List(Of cct_cap_hist)
    End Interface
    Public Interface I_cct_reg_cap
        Inherits IGenericDao(Of cct_reg_cap, String)
        Function SetRegCap(ByVal _id_cap As Integer, ByVal _age As String, ByVal _rec As String, ByVal _ent As String, ByVal _id_empl As Integer, ByVal _fecha As String, ByVal _fec_reg As String, ByVal _id_reg As Integer, ByVal _codusu As Integer, ByVal _activo As Integer, ByVal _id_h_cap As Integer) As List(Of cct_reg_cap)
    End Interface
    Public Interface I_cct_capacitaciones
        Inherits IGenericDao(Of cct_capacitaciones, String)
        Function GetByCapAct(ByVal id_cap As Integer, ByVal desc As String, ByVal act As Integer) As List(Of cct_capacitaciones)
    End Interface
    Public Interface I_cct_mat_hist
        Inherits IGenericDao(Of cct_mat_hist, String)
        Function GetByHistAct(ByVal _AGE As String, ByVal _ACTIVO As Integer) As List(Of cct_mat_hist)
    End Interface
    Public Interface I_cct_reg_cara_age
        Inherits IGenericDao(Of cct_reg_cara_age, String)
        Function SetRegCara(ByVal _AGENTE As String, ByVal _ID_COMP As Integer, ByVal _ID_CARA As Integer, ByVal _S1 As String, ByVal _S2 As String, ByVal _ACTIVO As Integer, ByVal _ACTUALIZA As Integer) As List(Of cct_reg_cara_age)
    End Interface
    Public Interface I_cct_reg_mat
        Inherits IGenericDao(Of cct_reg_mat, String)
        Function SetRegMat(ByVal _id_mat As Integer, ByVal _cant As Decimal, ByVal _age As String, ByVal _rec As String, ByVal _ent As String, ByVal _id_empl As Integer, ByVal _fecha As String, ByVal _fec_reg As String, ByVal _id_reg As Integer, ByVal _codusu As Integer, ByVal _activo As Integer, ByVal _id_h_mat As Integer) As List(Of cct_reg_mat)
    End Interface
    Public Interface I_cct_materiales
        Inherits IGenericDao(Of cct_materiales, String)
        Function GetByMatAct(ByVal id_mat As Integer, ByVal desc As String, ByVal act As Integer) As List(Of cct_materiales)
    End Interface
    Public Interface I_cct_comp_cara_age
        Inherits IGenericDao(Of cct_comp_cara_age, String)
        Function GetCaraByAge(ByVal _AGENTE As String, _ID_COMP As Integer) As List(Of cct_comp_cara_age)
        Function GetCaraActByAge(ByVal _AGENTE As String, _ID_COMP As Integer, _ACTIVO As Integer) As List(Of cct_comp_cara_age)
    End Interface

    Public Interface I_cct_comp_age
        Inherits IGenericDao(Of cct_comp_age, String)
        Function GetCompAge(ByVal _AGENTE As String, _ACTIVO As Integer) As List(Of cct_comp_age)
    End Interface
    Public Interface I_cct_reg_comp
        Inherits IGenericDao(Of cct_reg_comp, String)
        Function SetRegComp(ByVal _AGENTE As String, ByVal _ID_COMP As Integer, ByVal _ACTIVO As Integer) As List(Of cct_reg_comp)
    End Interface
    Public Interface I_cct_componentes_Dao
        Inherits IGenericDao(Of cct_componentes, String)
        Function GetByID_Comp(ByVal id_comp As String, ByVal descripcion As String, ByVal obl_sn As Integer, ByVal activo As Integer, ByVal agente As String) As List(Of cct_componentes)
        Function GetByIDs_Comp(ByVal list_id_comp As String) As List(Of cct_componentes)
    End Interface

    Public Interface I_age_sv_Dao
        Inherits IGenericDao(Of age_sin_venta, String)
        Function GetByAge(ByVal agente As String, ByVal dias As Integer, fec_v As String, fec_ticket As String, codusu As Integer) As List(Of age_sin_venta)
    End Interface
    Public Interface I_empl_Dao
        Inherits IGenericDao(Of empl, String)
        Function GetByempl(ByVal ID As String, ByVal nombre As String, tipo As String, activo As String) As List(Of empl)
    End Interface

    Public Interface I_prosp_dao
        Inherits IGenericDao(Of prosp, String)
        Function GetByNom(ByVal codigo As Integer, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of prosp)
        Function GetByCodigo(ByVal codigo As Integer, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of prosp)
    End Interface

    Public Interface I_inc_con_Dao
        Inherits IGenericDao(Of cct_inc_con, String)
        Function GetByEstado(ByVal id_conclusion As Integer, ByVal id_incidencia As Integer, ByVal activo As Integer) As List(Of cct_inc_con)
        Function SetConclusiones(ByVal id_conclusion As Integer, ByVal id_incidencia As Integer, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_inc_con)
    End Interface
    Public Interface I_con_cct_Dao
        Inherits IGenericDao(Of cct_con, String)
        Function GetByEstado(ByVal desc As String, ByVal activo As Integer) As List(Of cct_con)
        Function SetConclusion(ByVal id_conclusion As Integer, ByVal desc As String, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_con)
    End Interface
    Public Interface I_mot_inc_Dao
        Inherits IGenericDao(Of cct_mot_inc, String)
        Function GetByEstado(ByVal id_incidencia As Integer, ByVal id_motivo As Integer, ByVal activo As Integer) As List(Of cct_mot_inc)
        Function Setincidencias(ByVal id_incidencia As Integer, ByVal id_motivo As Integer, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_mot_inc)
    End Interface
    Public Interface I_incidencia_cct_Dao
        Inherits IGenericDao(Of cct_incidencia, String)
        Function GetByEstado(ByVal desc As String, ByVal activo As Integer) As List(Of cct_incidencia)
        Function Setincidencias(ByVal id_incidencia As Integer, ByVal desc As String, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_incidencia)
    End Interface
    Public Interface I_tp_llamada_motivo_Dao
        Inherits IGenericDao(Of cct_tp_llamada_motivo, String)
        Function GetByEstado(ByVal id_motivo As Integer, ByVal id_tp_llamada As Integer, ByVal activo As Integer) As List(Of cct_tp_llamada_motivo)
        Function Setmotivos(ByVal id_motivo As Integer, ByVal id_tp_llamada As Integer, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_tp_llamada_motivo)
    End Interface
    Public Interface I_motivo_cct_Dao
        Inherits IGenericDao(Of cct_motivo, String)
        Function GetByEstado(ByVal desc As String, ByVal activo As Integer) As List(Of cct_motivo)
        Function Setmotivos(ByVal id_motivo As Integer, ByVal desc As String, ByVal activo As Integer, ByVal codusu As Integer) As List(Of cct_motivo)
    End Interface
    Public Interface I_tp_llamada_Dao
        Inherits IGenericDao(Of cct_tp_llamda, String)
        Function GetByEstado(ByVal id As Integer, ByVal desc As String, ByVal activo As Integer) As List(Of cct_tp_llamda)
    End Interface

    Public Interface ISol_noblo_selectDao
        Inherits IGenericDao(Of sol_noblo_select, String)
        Function SetSolnoblo(ByVal id_nivel As Integer, ByVal age As String, ByVal nombre As String, ByVal est As String) As List(Of sol_noblo_select)
    End Interface
    Public Interface ISol_noblo_aprobDao
        Inherits IGenericDao(Of sol_noblo_aprob, String)
        Function SetSolnoblo(ByVal usuario As Integer) As List(Of sol_noblo_aprob)
    End Interface

    Public Interface ISol_nobloDao
        Inherits IGenericDao(Of sol_noblo, String)
        Function SetSolnoblo(ByVal id_tipo As Integer, ByVal usuario As Integer, ByVal agente As String, ByVal fecha_fin As String, ByVal comen As String) As List(Of sol_noblo)
        Function SetSolnoblo_a_r(ByVal id_sol As Integer, ByVal usuario As Integer, ByVal id_nivel As Integer, ByVal comen As String, ByVal a_r As Integer) As List(Of sol_noblo)
    End Interface

    Public Interface ISol_noblo_tiposDao
        Inherits IGenericDao(Of sol_noblo_tipos, String)
        Function GetByTodos(ByVal tipo As String) As List(Of sol_noblo_tipos)
    End Interface

    Public Interface IBloquearDao
        Inherits IGenericDao(Of bloquear, String)
        Function GetByExcep(ByVal excep1 As String, ByVal excep2 As String, ByVal excep3 As String, ByVal excep4 As String, ByVal excep5 As String, ByVal excep6 As String) As List(Of bloquear)
        Function GetExcep(ByVal excep1 As String, ByVal excep2 As String, ByVal excep3 As String, ByVal excep4 As String, ByVal excep5 As String, ByVal excep6 As String) As List(Of bloquear)
    End Interface

    Public Interface IFacperiodoDao
        Inherits IGenericDao(Of facperiodo, String)
        Function GetByCodage(ByVal codage As String) As List(Of facperiodo)
    End Interface

    Public Interface IUsu_LLamadasDao
        Inherits IGenericDao(Of usu_llamadas, String)
        Function GetbyCodusu(ByVal codusu As String) As List(Of usu_llamadas)
    End Interface
    Public Interface IUsuarioDao
        Inherits IGenericDao(Of Usuario, String)
        Function GetLikeIdUserNombre(ByVal IdUser As String, ByVal Nombre As String) As List(Of Usuario)
        Function GetByIdUser(ByVal idUser As String) As List(Of Usuario)
        Function GetByusupass(ByVal codusu As String, ByVal pass As String) As List(Of Usuario)
    End Interface

    Public Interface IAgenteDao
        Inherits IGenericDao(Of agente, String)
        Function GetLikeCodgtech(ByVal codgtech As String, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente)
        Function GetByCodgtech(ByVal codgtech As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente)
        Function GetByllamadahoy(ByVal usuario As String) As List(Of agente)
        Function GetByBal(ByVal gestor As String, p_n_b As String) As List(Of agente)
        Function GetProspByNom(ByVal codgtech As String, nombre As String, bloq As String, gestor As String, fec_prom As String, bala As String) As List(Of agente)
        Function GetBySinVenta(ByVal agente As String, ByVal usuario As Integer) As List(Of agente)
        Function GetByTkAbiertos(ByVal agente As String, ByVal usuario As Integer) As List(Of agente)
        Function GetByTkVerif(ByVal agente As String, ByVal verif As String, usuario As String) As List(Of agente)
    End Interface

    Public Interface IGestoresDao
        Inherits IGenericDao(Of gestores, String)
        Function GetByCodges(ByVal codges As String) As List(Of gestores)
        Function GetByCodusu(ByVal codusu As String) As List(Of gestores)
        Function GetByCodage(ByVal age As String) As List(Of gestores)
    End Interface

    Public Interface ICallcenteradmDao
        Inherits IGenericDao(Of callcenteradm, String)
        Function GetByCodage(ByVal codage As String, ByVal hist As String) As List(Of callcenteradm)
        Function GetLast(ByVal codage As String) As List(Of callcenteradm)

    End Interface

    Public Interface IEmpleadoDao
        Inherits IGenericDao(Of empleado, String)
        Function GetByCodemp(ByVal codemp As String) As List(Of empleado)

    End Interface
    Public Interface Igestor_usuarioDao
        Inherits IGenericDao(Of gestor_usuario, String)
        Function GetByCodusu(ByVal codusu As String, ByVal codges As String) As List(Of gestor_usuario)

    End Interface
    Public Interface IEstado_Cuenta
        Inherits IGenericDao(Of estado_cuenta, String)
        Function GetByAgente(ByVal agente As String) As List(Of estado_cuenta)
    End Interface
    Public Interface IVenta_CursoDao
        Inherits IGenericDao(Of venta_curso, String)
        Function GetByAgente(ByVal agente As String) As List(Of venta_curso)
    End Interface

    Public Interface IQJM_cua_sDao
        Inherits IGenericDao(Of qjm_cua_s, String)
        Function GetByAgente(ByVal agente As String) As List(Of qjm_cua_s)
    End Interface

    Public Interface I_cct_reg_llamada
        Inherits IGenericDao(Of cct_reg_llamada, String)
        Function SetRegLlama(ByVal _AGENTE As String, ByVal _ID_CONT As Integer, ByVal _NOM_CONT As String, _ID_TP_LLAMADA As Integer, _ID_MOTIVO As Integer, _ID_INCIDENCIA As Integer, _ID_CONCLUSION As Integer, _NOTA As String, _FEC_INI As String, _FEC_FIN As String, _H_INI As String, _H_FIN As String, _CODUSU As Integer, _ID_LLAMADA As Integer, _ID_TK_CERRADO As Integer) As List(Of cct_reg_llamada)
        Function ActRegLlama(ByVal _ID_REG As Integer, _ID_TK As Integer) As List(Of cct_reg_llamada)
    End Interface

    Public Interface I_cct_llamadas
        Inherits IGenericDao(Of cct_llamadas, String)
        Function SetLlamada(ByVal _ID_TP_LLAMADA As Integer, ByVal _AGENTE As String, ByVal _CODUSU As Integer, ByVal _ID_TP_CONT As Integer, ByVal _NOM_CONT As String, ByVal _NUM_MOT As Integer, ByVal _NUM_TK_A As Integer, ByVal _NUM_TK_C As Integer, ByVal _FEC_TK_C As String, ByVal _FECHA As String, ByVal _H_INI As String, ByVal _H_FIN As String, ByVal _ACTIVO As Integer) As List(Of cct_llamadas)
    End Interface

    Public Interface ISoli_asjuteDao
        Inherits IGenericDao(Of soli_ajuste, String)
        Function SetByAgente(ByVal usu As String, ByVal agente As String, ByVal comen As String) As List(Of soli_ajuste)
    End Interface

    Public Interface IPromesa_PagDao
        Inherits IGenericDao(Of promesa_pag, String)
        Function SetByAgente(ByVal codage As String, ByVal fecha As String, ByVal hora As String, ByVal monto As Decimal) As List(Of promesa_pag)
    End Interface
    Public Interface I_cct_generic_update
        Inherits IGenericDao(Of generic_update, String)
        Function SetUpdate(ByVal id As Integer, ByVal desc As String) As List(Of generic_update)
        Function SetUpdate_cara(ByVal id_comp As Integer, ByVal id As Integer, ByVal desc As String) As List(Of generic_update)
    End Interface
#End Region

End Namespace
