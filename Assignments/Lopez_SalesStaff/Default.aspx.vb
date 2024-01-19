Public Class _Default
    Inherits System.Web.UI.Page

    '************************************************************************************************************
    'Programmer: Erick Lopez
    'Date: February 23rd 2023
    'Title: Assignment 6: Sales Staff
    'Description: Web application to display sales staff information and update as necessary.
    '************************************************************************************************************

    '************************************************************************************************************
    'Page Load
    'This handles the initial page load. The only bit of code in here handles an error that began when the 
    'validation checks were added.
    '************************************************************************************************************
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'This little bit of code was grabbed from stack overflow. Without it the application just crashes. 
        'Application started crashing immediately after adding the validation checks. 
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None
    End Sub

    '************************************************************************************************************
    'Login Button 
    'The code below handles the login button click event. The button just redirects to the update page for sales
    'staff information. The validation checks handles everything and no checks were needed to be written in. 
    '************************************************************************************************************
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Didn't need to add any checks here since the validators do all the work :D
        Response.Redirect("update.aspx")
    End Sub
End Class