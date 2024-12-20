Public Class frmcalculatrice
    Dim op As Char
    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        op = "+"
    End Sub

    Private Sub Btn_mult_Click(sender As Object, e As EventArgs) Handles Btn_mult.Click
        op = "*"
    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles Btn_minus.Click
        op = "-"
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        op = "/"
    End Sub

    Private Sub Btn_equal_Click(sender As Object, e As EventArgs) Handles Btn_equal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim res = 0
            Dim test = True
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then
                res = a / b
            Else
                MessageBox.Show("veuille choisir un operateur")
                test = False
            End If
            If test Then
                Lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString
            End If
        Else
            MessageBox.Show("A et B divent etre des entiers")
        End If
    End Sub
End Class
