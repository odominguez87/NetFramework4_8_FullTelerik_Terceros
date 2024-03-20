<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Terceros.aspx.vb" Inherits="PruebaTercerosV2.Terceros" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
                </asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function rowDblClick(sender, eventArgs) {
                            sender.get_masterTableView().editItem(eventArgs.get_itemIndexHierarchical());
                        }
                    </script>
                </telerik:RadCodeBlock>
                <telerik:RadGrid runat="server" ID="RadGrid1" AutoGenerateColumns="False" AllowPaging="True" OnItemCreated="RadGrid1_ItemCreated" OnInsertCommand="RadGrid1_InsertCommand" OnNeedDataSource="RadGrid1_NeedDataSource" OnUpdateCommand="RadGrid1_UpdateCommand" OnDeleteCommand="RadGrid1_DeleteCommand" Culture="es-ES">
                    <MasterTableView DataKeyNames="IdTercero" CommandItemDisplay="Top" InsertItemPageIndexAction="ShowItemOnCurrentPage" EditMode="InPlace">
                        <Columns>
                            <telerik:GridEditCommandColumn HeaderText="Edit" ButtonType="FontIconButton" />
                            <telerik:GridButtonColumn HeaderText="Delete" ConfirmText="Delete this Person?" ConfirmDialogType="Classic" ConfirmTitle="Delete" ButtonType="FontIconButton" CommandName="Delete" />
                            <telerik:GridBoundColumn DataField="IdTercero" DataType="System.Int32" FilterControlAltText="Filter IdTercero column" HeaderText="IdTercero" ReadOnly="True" ForceExtractValue="Always" Display="false" ShowNoSortIcon="False" SortExpression="IdTercero" UniqueName="IdTercero"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="TipoTercero" FilterControlAltText="Filter TipoTercero column" HeaderText="TipoTercero" ShowNoSortIcon="False" SortExpression="TipoTercero" UniqueName="TipoTercero"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="TipoDocumento" FilterControlAltText="Filter TipoDocumento column" HeaderText="TipoDocumento" ShowNoSortIcon="False" SortExpression="TipoDocumento" UniqueName="TipoDocumento"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NrIdntfcion" DataType="System.Decimal" FilterControlAltText="Filter NrIdntfcion column" HeaderText="NrIdntfcion" ShowNoSortIcon="False" SortExpression="NrIdntfcion" UniqueName="NrIdntfcion"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Ps" DataType="System.Int32" FilterControlAltText="Filter Ps column" HeaderText="Ps" ShowNoSortIcon="False" SortExpression="Ps" UniqueName="Ps"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Pais" FilterControlAltText="Filter Pais column" HeaderText="Pais" ReadOnly="true" ShowNoSortIcon="False" SortExpression="Pais" UniqueName="Pais"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Dpto" DataType="System.Int32" FilterControlAltText="Filter Dpto column" HeaderText="Dpto" ShowNoSortIcon="False" SortExpression="Dpto" UniqueName="Dpto"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Departamento" FilterControlAltText="Filter Departamento column" HeaderText="Departamento" ReadOnly="true" ShowNoSortIcon="False" SortExpression="Departamento" UniqueName="Departamento"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Mncpo" DataType="System.Int32" FilterControlAltText="Filter Mncpo column" HeaderText="Mncpo" ShowNoSortIcon="False" SortExpression="Mncpo" UniqueName="Mncpo"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Municipio" FilterControlAltText="Filter Municipio column" HeaderText="Municipio" ReadOnly="true" ShowNoSortIcon="False" SortExpression="Municipio" UniqueName="Municipio"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NmbrsCmpltos" FilterControlAltText="Filter NmbrsCmpltos column" HeaderText="NmbrsCmpltos" ShowNoSortIcon="False" SortExpression="NmbrsCmpltos" UniqueName="NmbrsCmpltos"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="ApllsCmpltos" FilterControlAltText="Filter ApllsCmpltos column" HeaderText="ApllsCmpltos" ShowNoSortIcon="False" SortExpression="ApllsCmpltos" UniqueName="ApllsCmpltos"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="RznScial" FilterControlAltText="Filter RznScial column" HeaderText="RznScial" ShowNoSortIcon="False" SortExpression="RznScial" UniqueName="RznScial"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NmbrCmrcial" FilterControlAltText="Filter NmbrCmrcial column" HeaderText="NmbrCmrcial" ShowNoSortIcon="False" SortExpression="NmbrCmrcial" UniqueName="NmbrCmrcial"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Sgla" FilterControlAltText="Filter Sgla column" HeaderText="Sgla" ShowNoSortIcon="False" SortExpression="Sgla" UniqueName="Sgla"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Email" FilterControlAltText="Filter Email column" HeaderText="Email" ShowNoSortIcon="False" SortExpression="Email" UniqueName="Email"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdAp" DataType="System.Int32" FilterControlAltText="Filter IdAp column" HeaderText="IdAp" ShowNoSortIcon="False" SortExpression="IdAp" UniqueName="IdAp"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdRf" DataType="System.Int32" FilterControlAltText="Filter IdRf column" HeaderText="IdRf" ShowNoSortIcon="False" SortExpression="IdRf" UniqueName="IdRf"></telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                    <PagerStyle Mode="NextPrevAndNumeric" />
                    <ClientSettings>
                        <ClientEvents OnRowDblClick="rowDblClick" />
                    </ClientSettings>
                </telerik:RadGrid>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
