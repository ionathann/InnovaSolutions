<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confiltro.aspx.cs" Inherits="inovaWEBdap3.Confiltro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    

    <link href="Scripts/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-3.1.1.js" type="text/javascript"></script>
</head>
<body background="Content/bg2.jpg">
    <form id="form1" runat="server">
    <div>
     <center>         

        <table align="center">
            <tr>
                
                
                <td>
                    <b><h4 style="font-family: Nightingale; font-size: small"> VOTA POR LA MÁS PERRONA</h4></b><br />
                </td>
            </tr>
            <tr>
               
               
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td>
                    <asp:TextBox ID="TextBox2" placeholder="Busqueda por nombre " runat="server" CssClass="form-control" Width="180px"></asp:TextBox>
                            </td>
                            <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="BUSCAR" 
                                    CssClass="btn-info active" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" 
                                    Width="180px">
                                </asp:DropDownList>
                            </td>
                            <td>
                    <asp:Button ID="btbBuscar2" runat="server" onclick="btbBuscar2_Click" Text="BUSCAR" 
                                    CssClass="btn-info active" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="70%" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        CssClass="table-responsive">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Cssclass="thumbnail" Height="220px" 
                                        ImageUrl='<%# Eval("sFotografia") %>' Width="200px" />
                                    <div class="text-left" 
                                        style="color: #333333; font-style: inherit; font-family: 'Arial Black';">
                                        <br />
                                        Nombre :
                                        <asp:Label ID="lblnombre" runat="server" Text='<%# Eval("sNombreCompleto") %>' 
                                            Width="198px" CssClass="text-info" Font-Bold="False" ForeColor="Red"></asp:Label>
                                        <asp:Label ID="lblid" runat="server" Text='<%# Eval("pkCandidata") %>' 
                                            Visible="False"></asp:Label>
                                        <br />
                                        Edad:
                                        <asp:Label ID="lbledad" runat="server" Text='<%# Eval("edad") %>' 
                                            Font-Bold="False" ForeColor="Blue"></asp:Label>
                                        <br />
                                        Nivel de estudios:
                                        <asp:Label ID="lblestudios" runat="server" Text='<%# Eval("sNivelEstudios") %>' 
                                            Font-Bold="False" ForeColor="Blue"></asp:Label>
                                        <br />
                                        Votos:<asp:Label ID="lblvoto" runat="server" Text='<%# Eval("Totalvotos") %>' 
                                            Font-Bold="False" ForeColor="#009900"></asp:Label>
                                        <br />
                                        Descripción<br />:<asp:TextBox ID="TextBox1" runat="server" Height="70px" 
                                            ReadOnly="True" Text='<%# Eval("sDescrip") %>' TextMode="MultiLine" 
                                            Width="192px"></asp:TextBox>
                                        <br />
                                        <asp:Button ID="btnLike" runat="server" CssClass="btn btn-primary" 
                                            onclick="btnLike_Click" Text="Votar" />
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
     </center>
    </div>
    </form>
</body>
</html>
