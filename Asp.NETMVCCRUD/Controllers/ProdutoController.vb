Imports System.Web.Mvc

Namespace Controllers
    Public Class ProdutoController
        Inherits Controller

        ' GET: Produto
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace