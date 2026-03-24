<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Loan_module_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Loan_module_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentname = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtFamilyincome = New System.Windows.Forms.TextBox()
        Me.txtLoanamount = New System.Windows.Forms.TextBox()
        Me.btnCheckelegibility = New System.Windows.Forms.Button()
        Me.btnRepayment = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrintLoan = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtMonthly = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GPA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Family Annual income:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Loan Amount Requested:"
        '
        'txtStudentname
        '
        Me.txtStudentname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentname.Location = New System.Drawing.Point(298, 118)
        Me.txtStudentname.Name = "txtStudentname"
        Me.txtStudentname.Size = New System.Drawing.Size(207, 30)
        Me.txtStudentname.TabIndex = 4
        '
        'txtGPA
        '
        Me.txtGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPA.Location = New System.Drawing.Point(298, 171)
        Me.txtGPA.MaxLength = 4
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(207, 30)
        Me.txtGPA.TabIndex = 5
        '
        'txtFamilyincome
        '
        Me.txtFamilyincome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilyincome.Location = New System.Drawing.Point(298, 224)
        Me.txtFamilyincome.Name = "txtFamilyincome"
        Me.txtFamilyincome.Size = New System.Drawing.Size(207, 30)
        Me.txtFamilyincome.TabIndex = 6
        '
        'txtLoanamount
        '
        Me.txtLoanamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanamount.Location = New System.Drawing.Point(298, 278)
        Me.txtLoanamount.Name = "txtLoanamount"
        Me.txtLoanamount.Size = New System.Drawing.Size(207, 30)
        Me.txtLoanamount.TabIndex = 7
        '
        'btnCheckelegibility
        '
        Me.btnCheckelegibility.BackColor = System.Drawing.Color.White
        Me.btnCheckelegibility.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckelegibility.Image = CType(resources.GetObject("btnCheckelegibility.Image"), System.Drawing.Image)
        Me.btnCheckelegibility.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCheckelegibility.Location = New System.Drawing.Point(107, 329)
        Me.btnCheckelegibility.Name = "btnCheckelegibility"
        Me.btnCheckelegibility.Size = New System.Drawing.Size(219, 91)
        Me.btnCheckelegibility.TabIndex = 8
        Me.btnCheckelegibility.Text = "Check elegibility"
        Me.btnCheckelegibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckelegibility.UseVisualStyleBackColor = False
        '
        'btnRepayment
        '
        Me.btnRepayment.BackColor = System.Drawing.Color.FloralWhite
        Me.btnRepayment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepayment.Image = CType(resources.GetObject("btnRepayment.Image"), System.Drawing.Image)
        Me.btnRepayment.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRepayment.Location = New System.Drawing.Point(481, 329)
        Me.btnRepayment.Name = "btnRepayment"
        Me.btnRepayment.Size = New System.Drawing.Size(205, 91)
        Me.btnRepayment.TabIndex = 9
        Me.btnRepayment.Text = "Calculate Repayment"
        Me.btnRepayment.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRepayment.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(564, 463)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(184, 109)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Purple
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(843, 75)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "STUDENT LOAN MODULE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrintLoan
        '
        Me.btnPrintLoan.BackColor = System.Drawing.Color.Aqua
        Me.btnPrintLoan.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintLoan.Location = New System.Drawing.Point(153, 541)
        Me.btnPrintLoan.Name = "btnPrintLoan"
        Me.btnPrintLoan.Size = New System.Drawing.Size(173, 40)
        Me.btnPrintLoan.TabIndex = 15
        Me.btnPrintLoan.Text = "Print Receipt"
        Me.btnPrintLoan.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Lime
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(400, 541)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 40)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.Location = New System.Drawing.Point(44, 442)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(202, 26)
        Me.lblMonthly.TabIndex = 17
        Me.lblMonthly.Text = "Monthly payment:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(52, 496)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(194, 26)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total Repayment:"
        '
        'txtMonthly
        '
        Me.txtMonthly.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthly.Location = New System.Drawing.Point(272, 442)
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.Size = New System.Drawing.Size(176, 34)
        Me.txtMonthly.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(272, 488)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(176, 34)
        Me.txtTotal.TabIndex = 20
        '
        'Student_Loan_module_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(827, 666)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtMonthly)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMonthly)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrintLoan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRepayment)
        Me.Controls.Add(Me.btnCheckelegibility)
        Me.Controls.Add(Me.txtLoanamount)
        Me.Controls.Add(Me.txtFamilyincome)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtStudentname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student_Loan_module_Form"
        Me.Text = "Student_Loan_module_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentname As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtFamilyincome As TextBox
    Friend WithEvents txtLoanamount As TextBox
    Friend WithEvents btnCheckelegibility As Button
    Friend WithEvents btnRepayment As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrintLoan As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents txtTotal As TextBox
End Class
