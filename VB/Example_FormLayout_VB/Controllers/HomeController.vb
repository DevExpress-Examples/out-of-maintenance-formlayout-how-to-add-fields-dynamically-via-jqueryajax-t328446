Imports System.Web.Mvc

Public Class HomeController
    Inherits Controller

    Function Index() As ActionResult
        Dim model As Category = New Category() With {.ID = 1, .Name = "Fruits", .Products = New List(Of String)()}
        Session("CategoryData") = model
        Return View(model)
    End Function

    Function CategoryFormLayoutPartial(command As String) As ActionResult
        Dim p As Category = TryCast(Session("CategoryData"), Category)
        Dim results As String() = command.Split(";"c)
        Dim action As String = results(0)
        Dim index As Integer = Convert.ToInt32(results(1))
        If action = "add" Then
            p.Products.Add([String].Empty)
        Else
            p.Products.RemoveAt(index)
        End If
        Return PartialView(p)
    End Function


End Class


