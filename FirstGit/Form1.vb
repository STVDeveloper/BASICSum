Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim first As Integer
        Dim second As Integer
        Dim result As Integer
        first = TextBox1.Text
        second = TextBox2.Text
        result = first + second
        MsgBox("The sum is: " + result.ToString())
    End Sub
End Class
