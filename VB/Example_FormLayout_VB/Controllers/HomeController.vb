Imports System.Web.Mvc

Public Class HomeController
    Inherits Controller

    Function Index() As ActionResult
        Dim model = New Category() With {.ID = 1, .Name = "TestName", .Products = New List(Of String)()}
        Session("CategoryData") = model
        Return View(model)
    End Function

    Function CategoryFormLayoutPartial(command As String) As ActionResult
        Dim p As Category = TryCast(Session("CategoryData"), Category)
        Dim results As String() = command.Split(";"c)
        If results(0) = "add" Then
            p.Products.Add([String].Empty)
        Else
            p.Products.RemoveAt(Convert.ToInt32(results(1)))
        End If
        Return PartialView(p)
    End Function


End Class


