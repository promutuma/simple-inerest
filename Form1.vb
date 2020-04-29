Public Class frmSimpleinterest

    Dim amount As Double
    Dim simple As Double
    Dim rate As Double
    Dim principal As Double
    Dim time As Double




    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click


        principal = Val(txtPrincipal.Text)
        rate = Val(txtRate.Text)
        time = Val(txtPeriod.Text)

        simple = principal * rate * time / 100

        txtSimple.Text = Format(simple, "0.00")
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        principal = Val(txtPrincipal.Text)
        rate = Val(txtRate.Text)
        time = Val(txtPeriod.Text)

        simple = principal * rate * time / 100

        txtSimple.Text = Format(simple, "0.00")

        amount = principal + simple
        txtTotal.Text = Format(amount, "0.00")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Text = 0
        txtSimple.Text = 0
        txtRate.Text = 0
        txtPrincipal.Text = 0
        txtPeriod.Text = 0


    End Sub
End Class
