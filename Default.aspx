<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemplosOracle._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-4">
            <h2>Ejemplos de conexión a oracle desde .net framework</h2>
            <ul>
                <li>
                    <h4>Procedimientos</h4>
                    <ul>
                        <li>Parametros de entrada
                            <ul>
                                <li><a href="ProcedimientoEntradaPrimitiva.aspx">Datos primitivos</a></li>
                            </ul>
                        </li>
                        <li>Parametros de salida
                            <ul>
                                <li><a href="ProcedimientoSalidaPrimitivo.aspx">Datos primitivos</a></li>
                                <li><a href="ProcedumientoSalidaCursor.aspx">Cursores</a></li>
                            </ul>
                        </li>
                    </ul>
                    <h4>Funciones</h4>
                    <ul>
                        <li>Tipos de datos de salida
                            <ul>
                                <li><a href="FuncionPrimitivos.aspx">Datos primitivos</a></li>
                                <li><a href="FuncionCursor.aspx">Cursores</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li><a></a></li>
            </ul>
        </div>
    </div>

</asp:Content>

