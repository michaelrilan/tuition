Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name_val As String
        Dim tuition_val As Integer
        Dim inflation_val As Double
        Dim resultss As Integer
        Dim year_val As Integer
        Dim n As Integer = 1
        name_val = namee.Text
        tuition_val = tuitionn.Text
        inflation_val = inflationn.Text / 100
        year_val = yearr.Text

        While year_val >= n
            tuition_val = tuition_val + (tuition_val * inflation_val)
            n = n + 1
        End While
        Dim str_result As String = tuition_val
        Dim str_year As String = year_val


        result.Text = "Output(in $): " & name_val & "'s tuition in " & str_year & "years is expected to be $" & str_result






    End Sub


End Class
