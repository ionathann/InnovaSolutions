<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="inovaWEBdap3._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
    <link href="Scripts/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-3.1.1.js" type="text/javascript"></script>
</head>
<body background="Content/pink.jpg">
    <form id="form1" runat="server">
    <div>
     <div  style="margin-left:50px;"> 
         
         
        <table style="width:100%; ">
            <tr>
                <td class="style1">
                    <h4>
                     <strong>LISTADO<br /> </h4>
                    <asp:TextBox ID="txtBuscar" runat="server" Width="200px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" CssClass="bg-success" 
                        onclick="Button1_Click" Text="Buscar" />
                    <br />
                    <br />
                    </strong>
                    </td>
            </tr>

           
           
            <tr>
                
                
                <td style="margin-left: 100px;text-align:center;">
                    <asp:DataList ID="DataList1" runat="server" 
                        onitemcommand="DataList1_ItemCommand" RepeatColumns="5">
                        <ItemTemplate>
                            <asp:Image ID="Image1" Cssclass="thumbnail" runat="server" 
                                        ImageUrl='<%# Eval("sFotografia") %>' Height="220px" 
                                        Width="200px" />
                            <div class="text-left">
                                <br />
                                Nombre :
                                <asp:Label ID="lblnombre" runat="server" Text='<%# Eval("sNombreCompleto") %>' 
                                    Width="198px"></asp:Label>
                                <asp:Label ID="lblid" runat="server" Text='<%# Eval("pkCandidata") %>' 
                                    Visible="False"></asp:Label>
                                <br />
                                Edad:
                                <asp:Label ID="lbledad" runat="server" Text='<%# Eval("edad") %>'></asp:Label>
                                <br />
                                Nivel de estudios:
                                <asp:Label ID="lblestudios" runat="server" Text='<%# Eval("sNivelEstudios") %>'></asp:Label>
                                <br />
                                Votos:<asp:Label ID="lblvoto" runat="server" Text='<%# Eval("Totalvotos") %>'></asp:Label>
                                <br />
                                Descripción<br />:<asp:TextBox ID="TextBox1" runat="server" Height="70px" 
                                    ReadOnly="True" Text='<%# Eval("sDescrip") %>' TextMode="MultiLine" 
                                    Width="192px"></asp:TextBox>
                                <br />
                                <asp:Button ID="btnLike" runat="server" CssClass="btn btn-primary" 
                                    onclick="btnLike_Click" Text="Votar" />
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
               
            </tr>
        </table>
         </div>
    
    </div>
    </form>
</body>
</html>
