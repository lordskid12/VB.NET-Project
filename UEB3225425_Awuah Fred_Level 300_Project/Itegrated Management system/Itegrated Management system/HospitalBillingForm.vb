Public Class HospitalBillingForm
    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkXray_CheckedChanged(sender As Object, e As EventArgs) Handles chkXray.CheckedChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Check if fields are empty
        If txtPatientName.Text = "" Then
            MessageBox.Show("Please enter Patient Name")
            Exit Sub
        End If

        If cmbWard.Text = "" Then
            MessageBox.Show("Please select Ward Type")
            Exit Sub
        End If

        If txtDays.Text = "" Then
            MessageBox.Show("Please enter Number of Days")
            Exit Sub
        End If

        Dim wardRate As Integer
        Dim days As Integer
        Dim wardCharges As Double
        Dim treatmentCharges As Double = 0
        Dim subtotal As Double
        Dim vat As Double
        Dim finalBill As Double

        'Number of days admitted
        days = Val(txtDays.Text)

        'Ward type selection
        If cmbWard.Text = "General Ward" Then
            wardRate = 200
        ElseIf cmbWard.Text = "Semi-Private Ward" Then
            wardRate = 350
        ElseIf cmbWard.Text = "Private Ward" Then
            wardRate = 500
        End If

        'Calculate ward charges
        wardCharges = wardRate * days

        'Optional services
        If chkLab.Checked Then
            treatmentCharges = treatmentCharges + 150
        End If

        If chkXray.Checked Then
            treatmentCharges = treatmentCharges + 100
        End If

        If chkSurgery.Checked Then
            treatmentCharges = treatmentCharges + 1000
        End If

        'Subtotal
        subtotal = wardCharges + treatmentCharges

        'VAT calculation (12%)
        vat = subtotal * 0.12
        txtVAT.Text = vat.ToString("0.00")

        'Final Bill
        finalBill = subtotal + vat

        'Display final bill
        txtFinalBill.Text = finalBill.ToString()

        'Premium Billing Category
        If finalBill > 5000 Then
            MessageBox.Show("Premium Billing Category")
        End If

        txtFinalBill.Text = finalBill
    End Sub

    Private Sub HospitalBillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtFinalBill_TextChanged(sender As Object, e As EventArgs) Handles txtFinalBill.TextChanged, txtFinalBill.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpOptionalServices.Enter

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DashBoardForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmbWard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWard.SelectedIndexChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblFinalBill_Click(sender As Object, e As EventArgs) Handles lblFinalBill.Click, lblFinalBill.Click

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPatientName.Clear()
        cmbWard.SelectedIndex = -1
        txtDays.Clear()
        chkLab.Checked = False
        chkXray.Checked = False
        chkSurgery.Checked = False
        txtVAT.Clear()
        txtFinalBill.Clear()
        txtPatientName.Focus()
    End Sub

    Private Sub txtDays_TextChanged_1(sender As Object, e As EventArgs) Handles txtDays.TextChanged
        Dim numDays As Integer

        If Integer.TryParse(txtDays.Text, numDays) Then
            ' valid number of days
        Else
            MessageBox.Show("Please enter a valid number of days")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim titleFont As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim subTitleFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 10)

        Dim y As Integer = 40

        '===== HEADER =====
        e.Graphics.DrawString("LORDSKID DIAGNOSTIC HOSPITAL", titleFont, Brushes.DarkBlue, 150, y)

        y += 30
        e.Graphics.DrawString("HOSPITAL BILL RECEIPT", subTitleFont, Brushes.Black, 140, y)

        y += 25
        e.Graphics.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy"), bodyFont, Brushes.Black, 300, y)

        y += 40

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 40, y, 500, y)
        y += 20

        '===== PATIENT INFO =====
        e.Graphics.DrawString("Patient Name:", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(txtPatientName.Text, bodyFont, Brushes.Black, 200, y)

        y += 25
        e.Graphics.DrawString("Ward Type:", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(cmbWard.Text, bodyFont, Brushes.Black, 200, y)

        y += 25
        e.Graphics.DrawString("Days Admitted:", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(txtDays.Text, bodyFont, Brushes.Black, 200, y)

        y += 30

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 40, y, 500, y)
        y += 20

        '===== BILL DETAILS =====
        e.Graphics.DrawString("Ward Charges:", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(cmbWard.Text, bodyFont, Brushes.Black, 300, y)

        y += 25
        e.Graphics.DrawString("Treatment Charges:", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(grpOptionalServices.Text, bodyFont, Brushes.Black, 300, y)

        y += 25
        e.Graphics.DrawString("VAT (12%):", bodyFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(txtVAT.Text, bodyFont, Brushes.Black, 300, y)

        y += 30

        '===== LINE =====
        e.Graphics.DrawLine(Pens.Black, 40, y, 500, y)
        y += 25

        '===== FINAL BILL =====
        e.Graphics.DrawString("FINAL BILL:", subTitleFont, Brushes.Black, 50, y)
        e.Graphics.DrawString(txtFinalBill.Text, subTitleFont, Brushes.DarkRed, 300, y)

        y += 40

        '===== PREMIUM MESSAGE =====
        If Val(txtFinalBill.Text) > 5000 Then
            e.Graphics.DrawString("Premium Billing Category", bodyFont, Brushes.Red, 120, y)
            y += 30
        End If

        '===== FOOTER LINE =====
        e.Graphics.DrawLine(Pens.Black, 40, y, 500, y)
        y += 30

        '===== FOOTER =====
        e.Graphics.DrawString("Thank you for choosing our hospital!", bodyFont, Brushes.DarkBlue, 120, y)
        y += 40
        e.Graphics.DrawString("YOUR HEALTH IS OUR PRIORITY!!!", bodyFont, Brushes.DarkBlue, 120, y)
        y += 40

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If MessageBox.Show("Do you want to print receipt?", "Print", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Error during printing: " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub txtVAT_TextChanged(sender As Object, e As EventArgs) Handles txtVAT.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class