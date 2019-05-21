Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click

        Dim test1, test2, test3, total As Integer
        Dim average As Double

        test1 = Convert.ToInt16(txtTest1.Text)
        test2 = Convert.ToInt16(txtTest2.Text)
        test3 = Convert.ToInt16(txtTest3.Text)

        total = test1 + test2 + test3
        average = total / 3.0

        lblAverage.Text = average.ToString("####0.00")

        If average >= 90 And average <= 100 Then
            lblGrade.Text = "A"
        ElseIf average >= 80 And average < 90 Then
            lblGrade.Text = "B"
        ElseIf average >= 70 And average < 80 Then
            lblGrade.Text = "C"
        ElseIf average >= 60 And average < 70 Then
            lblGrade.Text = "D"
        Else
            lblGrade.Text = "F"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Text = String.Empty
        txtTest3.Text = String.Empty
        txtTest2.Text = String.Empty
        lblGrade.Text = String.Empty
        lblAverage.Text = String.Empty
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblAverage.Click

    End Sub

    Private Sub TxtTest1_TextChanged(sender As Object, e As EventArgs) Handles txtTest1.TextChanged

    End Sub

    Private Sub TxtTest2_TextChanged(sender As Object, e As EventArgs) Handles txtTest2.TextChanged

    End Sub

    Private Sub TxtTest3_TextChanged(sender As Object, e As EventArgs) Handles txtTest3.TextChanged

    End Sub
End Class
