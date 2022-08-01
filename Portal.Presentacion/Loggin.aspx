<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loggin.aspx.cs" Inherits="PortalProveedores.Loggin.Loggin" %>

<%@ Register assembly="DevExpress.Web.v20.2, Version=20.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>IPSA WEB (Portal Proveedores)</title>
    <style type="text/css">
        .formLayout{
            max-width:1200px;
            margin:auto;
        }
        body {
          background: #76b852; /* fallback for old browsers */
          background: -webkit-linear-gradient(right, #76b852, #8DC26F);
          background: -moz-linear-gradient(right, #76b852, #8DC26F);
          background: -o-linear-gradient(right, #76b852, #8DC26F);
          background: linear-gradient(to left, #76b852, #8DC26F);
          font-family: "Roboto", sans-serif;
          -webkit-font-smoothing: antialiased;
          /*-moz-osx-font-smoothing: grayscale;*/      
        }
        .form {
            position: relative;
            z-index: 1;
            background: #FFFFFF;
            max-width: 450px;
            margin: 0 auto 100px;
            padding: 45px;
            text-align: center;
            box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form">
        <div>
            
            <dx:ASPxPageControl ID="login" runat="server" ActiveTabIndex="0" OnLoad="login_Load" >
            <TabPages>
                <dx:TabPage Text="Iniciar Sesión">
                    <ContentCollection>
                        <dx:ContentControl>
                            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" CssClass="formLayout">
                                <Items>
                                    <dx:LayoutItem Caption="Usuario:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox ID="txtUserName" runat="server">
                                                    <ValidationSettings ValidationGroup="iniciarsesion">
                                                        <RequiredField IsRequired="True" ErrorText="Dato requerido" />
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Contraseña">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxTextBox ID="txtPass" runat="server"  Password="true">
                                                    <ValidationSettings ValidationGroup="iniciarsesion">
                                                        <RequiredField ErrorText="Dato requerido" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxButton ID="btnEnviar" runat="server" Text="Enviar" ValidationGroup="iniciarsesion" OnClick="btnEnviar_Click"></dx:ASPxButton>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer>
                                                    <dx:ASPxPopupControl ID="popupIniciarSesion" runat="server">
                                                        <ContentCollection>
                                                            <dx:PopupControlContentControl runat="server">
                                                            </dx:PopupControlContentControl>
                                                        </ContentCollection>
                                                    </dx:ASPxPopupControl>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>  
                                </Items>
                            </dx:ASPxFormLayout>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
            
        </div>
    </form>
</body>
</html>
