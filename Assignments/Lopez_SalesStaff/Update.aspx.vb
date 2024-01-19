Public Class Update
    Inherits System.Web.UI.Page

    '************************************************************************************************************
    'The code below handles the logout button click event. The button just redirects back to the default page.
    'This is to simulate a log out.
    '************************************************************************************************************
    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class