Public Class DashBoardForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Student_Loan_module_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DashBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHospital_Click(sender As Object, e As EventArgs) Handles btnHospital.Click
        HospitalBillingForm.Show()
        Me.Hide()
    End Sub
End Class