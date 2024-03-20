Imports Telerik.Web.UI
Imports System.Data.SqlClient

Public Class Terceros
    Inherits System.Web.UI.Page

    Public connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("BD_PruebasConnectionString").ConnectionString)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Function DataAccess(ByVal Optional Command As String = "", ByVal Optional Query As String = "Execute spGetAllTerceros",
                                  ByVal Optional TipoProceso As String = "", ByVal Optional TipoTercero As String = "",
                                  ByVal Optional TipoDocumento As String = "", ByVal Optional NrIdntfcion As Decimal = 0,
                                  ByVal Optional Ps As Integer = 0, ByVal Optional Dpto As Integer = 0, ByVal Optional Mncpo As Integer = 0,
                                  ByVal Optional NmbrsCmpltos As String = "", ByVal Optional ApllsCmpltos As String = "",
                                  ByVal Optional RznScial As String = "", ByVal Optional NmbrCmrcial As String = "", ByVal Optional Sgla As String = "",
                                  ByVal Optional Email As String = "", ByVal Optional IdAp As Integer = 0, ByVal Optional IdRf As Integer = 0) As DataTable
        Dim dt As DataTable = New DataTable()
        Select Case Command
            Case RadGrid.PerformInsertCommandName
                Using cmd As SqlCommand = New SqlCommand(Query, connection)
                    cmd.Parameters.Add(New SqlParameter("@TipoProceso", TipoProceso))
                    cmd.Parameters.Add(New SqlParameter("@TipoTercero", TipoTercero))
                    cmd.Parameters.Add(New SqlParameter("@TipoDocumento", TipoDocumento))
                    cmd.Parameters.Add(New SqlParameter("@NrIdntfcion", NrIdntfcion))
                    cmd.Parameters.Add(New SqlParameter("@Ps", Ps))
                    cmd.Parameters.Add(New SqlParameter("@Dpto", Dpto))
                    cmd.Parameters.Add(New SqlParameter("@Mncpo", Mncpo))
                    cmd.Parameters.Add(New SqlParameter("@NmbrsCmpltos", NmbrsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@ApllsCmpltos", ApllsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@RznScial", RznScial))
                    cmd.Parameters.Add(New SqlParameter("@NmbrCmrcial", NmbrCmrcial))
                    cmd.Parameters.Add(New SqlParameter("@Sgla", Sgla))
                    cmd.Parameters.Add(New SqlParameter("@Email", Email))
                    cmd.Parameters.Add(New SqlParameter("@IdAp", IdAp))
                    cmd.Parameters.Add(New SqlParameter("@IdRf", IdRf))

                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
                Return dt
            Case RadGrid.UpdateCommandName
                Using cmd As SqlCommand = New SqlCommand(Query, connection)
                    cmd.Parameters.Add(New SqlParameter("@TipoProceso", TipoProceso))
                    cmd.Parameters.Add(New SqlParameter("@TipoTercero", TipoTercero))
                    cmd.Parameters.Add(New SqlParameter("@TipoDocumento", TipoDocumento))
                    cmd.Parameters.Add(New SqlParameter("@NrIdntfcion", NrIdntfcion))
                    cmd.Parameters.Add(New SqlParameter("@Ps", Ps))
                    cmd.Parameters.Add(New SqlParameter("@Dpto", Dpto))
                    cmd.Parameters.Add(New SqlParameter("@Mncpo", Mncpo))
                    cmd.Parameters.Add(New SqlParameter("@NmbrsCmpltos", NmbrsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@ApllsCmpltos", ApllsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@RznScial", RznScial))
                    cmd.Parameters.Add(New SqlParameter("@NmbrCmrcial", NmbrCmrcial))
                    cmd.Parameters.Add(New SqlParameter("@Sgla", Sgla))
                    cmd.Parameters.Add(New SqlParameter("@Email", Email))
                    cmd.Parameters.Add(New SqlParameter("@IdAp", IdAp))
                    cmd.Parameters.Add(New SqlParameter("@IdRf", IdRf))

                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
                Return dt
            Case RadGrid.DeleteCommandName
                Using cmd As SqlCommand = New SqlCommand(Query, connection)
                    cmd.Parameters.Add(New SqlParameter("@TipoProceso", TipoProceso))
                    cmd.Parameters.Add(New SqlParameter("@TipoTercero", TipoTercero))
                    cmd.Parameters.Add(New SqlParameter("@TipoDocumento", TipoDocumento))
                    cmd.Parameters.Add(New SqlParameter("@NrIdntfcion", NrIdntfcion))
                    cmd.Parameters.Add(New SqlParameter("@Ps", Ps))
                    cmd.Parameters.Add(New SqlParameter("@Dpto", Dpto))
                    cmd.Parameters.Add(New SqlParameter("@Mncpo", Mncpo))
                    cmd.Parameters.Add(New SqlParameter("@NmbrsCmpltos", NmbrsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@ApllsCmpltos", ApllsCmpltos))
                    cmd.Parameters.Add(New SqlParameter("@RznScial", RznScial))
                    cmd.Parameters.Add(New SqlParameter("@NmbrCmrcial", NmbrCmrcial))
                    cmd.Parameters.Add(New SqlParameter("@Sgla", Sgla))
                    cmd.Parameters.Add(New SqlParameter("@Email", Email))
                    cmd.Parameters.Add(New SqlParameter("@IdAp", IdAp))
                    cmd.Parameters.Add(New SqlParameter("@IdRf", IdRf))

                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
                Return dt
            Case Else
                Using data As SqlDataAdapter = New SqlDataAdapter(Query, connection)
                    data.Fill(dt)
                    connection.Close()
                End Using
                Return dt
        End Select
    End Function

    Protected Sub RadGrid1_ItemCreated(sender As Object, e As GridItemEventArgs)
        If TypeOf e.Item Is GridEditableItem AndAlso e.Item.IsInEditMode Then
            If (TypeOf e.Item Is GridDataInsertItem) AndAlso e.Item.IsInEditMode Then
                Debug.WriteLine("Init Insert Operation Triggered")
            ElseIf (TypeOf e.Item Is GridEditableItem) AndAlso e.Item.IsInEditMode Then
                Debug.WriteLine("Edit Operation Triggered")
            End If
        ElseIf TypeOf e.Item Is GridDataItem Then
            Dim dataItem As GridDataItem = TryCast(e.Item, GridDataItem)
            Debug.WriteLine($"The {dataItem} Item Is In Regular Mode")
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(sender As Object, e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim values As Hashtable = New Hashtable()
        editableItem.ExtractValues(values)
        Dim query As String = "Execute spiudTerceros @TipoProceso, @TipoTercero, @TipoDocumento, @NrIdntfcion, @Ps, @Dpto, @Mncpo, @NmbrsCmpltos, @ApllsCmpltos, @RznScial, @NmbrCmrcial, @Sgla, @Email, @IdAp, @IdRf"
        DataAccess(Command:=RadGrid.PerformInsertCommandName, Query:=query, TipoProceso:="INS", TipoTercero:=values("TipoTercero").ToString(),
                   TipoDocumento:=values("TipoDocumento").ToString(), NrIdntfcion:=values("NrIdntfcion").ToString(), Ps:=values("Ps"),
                   Dpto:=values("Dpto"), Mncpo:=values("Mncpo"), NmbrsCmpltos:=values("NmbrsCmpltos").ToString(),
                   ApllsCmpltos:=values("ApllsCmpltos").ToString(), RznScial:=values("RznScial").ToString(),
                   NmbrCmrcial:=values("NmbrCmrcial").ToString(), Sgla:=values("Sgla").ToString(), Email:=values("Email").ToString(),
                   IdAp:=values("IdAp"), IdRf:=values("IdRf"))
    End Sub

    Protected Sub RadGrid1_NeedDataSource(sender As Object, e As GridNeedDataSourceEventArgs)
        RadGrid1.DataSource = DataAccess()
    End Sub

    Protected Sub RadGrid1_UpdateCommand(sender As Object, e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim values As Hashtable = New Hashtable()
        editableItem.ExtractValues(values)
        Dim query As String = "Execute spiudTerceros @TipoProceso, @TipoTercero, @TipoDocumento, @NrIdntfcion, @Ps, @Dpto, @Mncpo, @NmbrsCmpltos, @ApllsCmpltos, @RznScial, @NmbrCmrcial, @Sgla, @Email, @IdAp, @IdRf"
        DataAccess(Command:=RadGrid.UpdateCommandName, Query:=query, TipoProceso:="UPD", TipoTercero:=values("TipoTercero").ToString(),
                   TipoDocumento:=values("TipoDocumento").ToString(), NrIdntfcion:=values("NrIdntfcion").ToString(), Ps:=values("Ps"),
                   Dpto:=values("Dpto"), Mncpo:=values("Mncpo"), NmbrsCmpltos:=values("NmbrsCmpltos").ToString(),
                   ApllsCmpltos:=values("ApllsCmpltos").ToString(), RznScial:=values("RznScial").ToString(),
                   NmbrCmrcial:=values("NmbrCmrcial").ToString(), Sgla:=values("Sgla").ToString(), Email:=values("Email").ToString(),
                   IdAp:=values("IdAp"), IdRf:=values("IdRf"))
    End Sub

    Protected Sub RadGrid1_DeleteCommand(sender As Object, e As GridCommandEventArgs)
        Dim editableItem As GridEditableItem = (CType(e.Item, GridEditableItem))
        Dim values As Hashtable = New Hashtable()
        editableItem.ExtractValues(values)
        Dim query As String = "Execute spiudTerceros @TipoProceso, @TipoTercero, @TipoDocumento, @NrIdntfcion, @Ps, @Dpto, @Mncpo, @NmbrsCmpltos, @ApllsCmpltos, @RznScial, @NmbrCmrcial, @Sgla, @Email, @IdAp, @IdRf"
        DataAccess(Command:=RadGrid.DeleteCommandName, Query:=query, TipoProceso:="DEL", TipoTercero:=values("TipoTercero").ToString(),
                   TipoDocumento:=values("TipoDocumento").ToString(), NrIdntfcion:=values("NrIdntfcion").ToString(), Ps:=values("Ps"),
                   Dpto:=values("Dpto"), Mncpo:=values("Mncpo"), NmbrsCmpltos:=values("NmbrsCmpltos").ToString(),
                   ApllsCmpltos:=values("ApllsCmpltos").ToString(), RznScial:=values("RznScial").ToString(),
                   NmbrCmrcial:=values("NmbrCmrcial").ToString(), Sgla:=values("Sgla").ToString(), Email:=values("Email").ToString(),
                   IdAp:=values("IdAp"), IdRf:=values("IdRf"))
    End Sub
End Class