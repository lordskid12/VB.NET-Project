Public Class Student_Loan_module_Form
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCheckelegibility_Click(sender As Object, e As EventArgs) Handles btnCheckelegibility.Click
        If txtGPA.Text = "" Or txtFamilyincome.Text = "" Then
            MessageBox.Show("Enter GPA and Income")
            Exit Sub
        End If

        Dim gpa As Double
        Dim income As Double = Val(txtFamilyincome.Text)

        'Validate GPA
        If Not Double.TryParse(txtGPA.Text, gpa) Then
            MessageBox.Show("Enter a valid GPA")
            Exit Sub
        End If

        If gpa < 0.1 Or gpa > 4.0 Then
            MessageBox.Show("GPA must be between 0.1 and 4.0")
            Exit Sub
        End If

        'Eligibility Rules
        If gpa >= 2.5 And income < 40000 Then
            MessageBox.Show("Eligible for Loan")
            btnRepayment.Enabled = True
        ElseIf gpa < 2.5 Then
            MessageBox.Show("Rejected: GPA too low")
            btnRepayment.Enabled = False
        ElseIf income >= 40000 Then
            MessageBox.Show("Rejected: Income too high")
            btnRepayment.Enabled = False
        End If
    End Sub

    Private Sub btnRepayment_Click(sender As Object, e As EventArgs) Handles btnRepayment.Click
        'Check if fields are empty
        If txtStudentname.Text = "" Then
            MessageBox.Show("Please enter Student Name")
            Exit Sub
        End If

        If txtGPA.Text = "" Then
            MessageBox.Show("Please enter student GPA")
            Exit Sub
        End If

        If txtFamilyincome.Text = "" Then
            MessageBox.Show("Please enter Family Amount Income")
            Exit Sub
        End If
        If txtLoanamount.Text = "" Then
            MessageBox.Show("Please enter Loan Amount")
            Exit Sub
        End If

        Dim P As Double = Val(txtLoanamount.Text)
        Dim r As Double = 0.08 / 12
        Dim n As Integer = 60

        Dim M As Double
        M = (P * r * (1 + r) ^ n) / ((1 + r) ^ n - 1)

        Dim total As Double = M * n

        txtMonthly.Text = "Monthly: " & M.ToString("0.00")
        txtTotal.Text = "Total: " & total.ToString("0.00")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DashBoardForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Student_Loan_module_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrintLoan_Click(sender As Object, e As EventArgs) Handles btnPrintLoan.Click
        If txtTotal.Text = "" Then
            MessageBox.Show("Please calculate first")
            Exit Sub
        End If

        If MessageBox.Show("Print receipt?", "Print", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim subTitleFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 10)

        Dim centerX As Integer = 300
        Dim y As Integer = 40

        '===== BORDER BOX =====
        e.Graphics.DrawRectangle(Pens.Black, 30, 30, 500, 700)

        '===== HEADER (CENTERED) =====
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center

        e.Graphics.DrawString("STUDENT LOAN RECEIPT", titleFont, Brushes.DarkBlue, centerX, y, format)

        y += 35
        e.Graphics.DrawString("Loan Processing System", subTitleFont, Brushes.Black, centerX, y, format)

        y += 25
        e.Graphics.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy"), bodyFont, Brushes.Black, centerX, y, format)

        y += 40

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 50, y, 500, y)
        y += 20

        '===== STUDENT DETAILS =====
        e.Graphics.DrawString("Student Name:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtStudentname.Text, bodyFont, Brushes.Black, 250, y)

        y += 25
        e.Graphics.DrawString("GPA:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtGPA.Text, bodyFont, Brushes.Black, 250, y)

        y += 25
        e.Graphics.DrawString("Family Income:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtFamilyincome.Text, bodyFont, Brushes.Black, 250, y)

        y += 25
        e.Graphics.DrawString("Loan Amount:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtLoanamount.Text, bodyFont, Brushes.Black, 250, y)

        y += 30

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 50, y, 500, y)
        y += 20

        '===== PAYMENT DETAILS =====
        e.Graphics.DrawString("Monthly Payment:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtMonthly.Text, bodyFont, Brushes.Black, 300, y)

        y += 25
        e.Graphics.DrawString("Total Payment:", bodyFont, Brushes.Black, 60, y)
        e.Graphics.DrawString(txtTotal.Text, bodyFont, Brushes.Black, 300, y)

        y += 30

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 50, y, 500, y)
        y += 25

        '===== STATUS =====
        e.Graphics.DrawString("Status:", subTitleFont, Brushes.Black, 60, y)

        Dim status As String = ""
        If Val(txtGPA.Text) >= 2.5 Then
            status = "Eligible"
        Else
            status = "Not Eligible"
        End If

        e.Graphics.DrawString(status, subTitleFont, Brushes.DarkGreen, 200, y)

        y += 40

        '===== FOOTER =====
        e.Graphics.DrawLine(Pens.Black, 50, y, 500, y)

        y += 25
        e.Graphics.DrawString("Thank you for using our loan service", bodyFont, Brushes.DarkBlue, centerX, y, format)

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub txtGPA_TextChanged(sender As Object, e As EventArgs) Handles txtGPA.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear input fields
        txtStudentname.Clear()
        txtGPA.Clear()
        txtFamilyincome.Clear()
        txtLoanamount.Clear()

        'Clear output fields
        txtMonthly.Clear()
        txtTotal.Clear()

        'Disable calculate button again
        btnRepayment.Enabled = False

        'Set focus back to first field
        txtStudentname.Focus()
    End Sub
End Class