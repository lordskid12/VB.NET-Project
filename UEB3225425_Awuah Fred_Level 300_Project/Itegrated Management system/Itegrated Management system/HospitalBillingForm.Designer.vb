<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalBillingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HospitalBillingForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.cmbWard = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkLab = New System.Windows.Forms.CheckBox()
        Me.chkXray = New System.Windows.Forms.CheckBox()
        Me.chkSurgery = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblFinalBill = New System.Windows.Forms.Label()
        Me.txtFinalBill = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpOptionalServices = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpOptionalServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PatientName:"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(180, 93)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(202, 34)
        Me.txtPatientName.TabIndex = 1
        '
        'cmbWard
        '
        Me.cmbWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWard.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWard.FormattingEnabled = True
        Me.cmbWard.Items.AddRange(New Object() {"General Ward", "Semi-Private Ward", "Private Ward"})
        Me.cmbWard.Location = New System.Drawing.Point(180, 133)
        Me.cmbWard.Name = "cmbWard"
        Me.cmbWard.Size = New System.Drawing.Size(213, 31)
        Me.cmbWard.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Days Admitted:"
        '
        'chkLab
        '
        Me.chkLab.AutoSize = True
        Me.chkLab.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkLab.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLab.Location = New System.Drawing.Point(6, 29)
        Me.chkLab.Name = "chkLab"
        Me.chkLab.Size = New System.Drawing.Size(75, 30)
        Me.chkLab.TabIndex = 5
        Me.chkLab.Text = "Lab"
        Me.chkLab.UseVisualStyleBackColor = False
        '
        'chkXray
        '
        Me.chkXray.AutoSize = True
        Me.chkXray.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkXray.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXray.Location = New System.Drawing.Point(6, 62)
        Me.chkXray.Name = "chkXray"
        Me.chkXray.Size = New System.Drawing.Size(85, 30)
        Me.chkXray.TabIndex = 6
        Me.chkXray.Text = "Xray"
        Me.chkXray.UseVisualStyleBackColor = False
        '
        'chkSurgery
        '
        Me.chkSurgery.AutoSize = True
        Me.chkSurgery.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkSurgery.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSurgery.Location = New System.Drawing.Point(6, 105)
        Me.chkSurgery.Name = "chkSurgery"
        Me.chkSurgery.Size = New System.Drawing.Size(113, 30)
        Me.chkSurgery.TabIndex = 7
        Me.chkSurgery.Text = "surgery"
        Me.chkSurgery.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Tomato
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), System.Drawing.Image)
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCalculate.Location = New System.Drawing.Point(527, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(212, 101)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblFinalBill
        '
        Me.lblFinalBill.AutoSize = True
        Me.lblFinalBill.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalBill.Location = New System.Drawing.Point(25, 426)
        Me.lblFinalBill.Name = "lblFinalBill"
        Me.lblFinalBill.Size = New System.Drawing.Size(139, 32)
        Me.lblFinalBill.TabIndex = 9
        Me.lblFinalBill.Text = "Final Bill:"
        '
        'txtFinalBill
        '
        Me.txtFinalBill.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalBill.Location = New System.Drawing.Point(193, 426)
        Me.txtFinalBill.Name = "txtFinalBill"
        Me.txtFinalBill.ReadOnly = True
        Me.txtFinalBill.Size = New System.Drawing.Size(222, 34)
        Me.txtFinalBill.TabIndex = 10
        Me.txtFinalBill.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ward Type:"
        '
        'grpOptionalServices
        '
        Me.grpOptionalServices.BackColor = System.Drawing.Color.RoyalBlue
        Me.grpOptionalServices.Controls.Add(Me.chkSurgery)
        Me.grpOptionalServices.Controls.Add(Me.chkLab)
        Me.grpOptionalServices.Controls.Add(Me.chkXray)
        Me.grpOptionalServices.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptionalServices.Location = New System.Drawing.Point(31, 202)
        Me.grpOptionalServices.Name = "grpOptionalServices"
        Me.grpOptionalServices.Size = New System.Drawing.Size(404, 139)
        Me.grpOptionalServices.TabIndex = 12
        Me.grpOptionalServices.TabStop = False
        Me.grpOptionalServices.Text = "Optional Services"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Purple
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-10, -3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1165, 70)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "HOSPITAL BILLING MODULE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(534, 368)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(165, 101)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.Black
        Me.lblVAT.Location = New System.Drawing.Point(40, 368)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(62, 26)
        Me.lblVAT.TabIndex = 16
        Me.lblVAT.Text = "VAT:"
        '
        'txtVAT
        '
        Me.txtVAT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(127, 368)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(115, 30)
        Me.txtVAT.TabIndex = 17
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(442, 509)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 56)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtDays
        '
        Me.txtDays.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.Location = New System.Drawing.Point(717, 90)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 34)
        Me.txtDays.TabIndex = 19
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(193, 509)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(152, 55)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
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
        'HospitalBillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1151, 710)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.lblVAT)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFinalBill)
        Me.Controls.Add(Me.lblFinalBill)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbWard)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpOptionalServices)
        Me.Name = "HospitalBillingForm"
        Me.Text = " "
        Me.grpOptionalServices.ResumeLayout(False)
        Me.grpOptionalServices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents cmbWard As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkLab As CheckBox
    Friend WithEvents chkXray As CheckBox
    Friend WithEvents chkSurgery As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblFinalBill As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpOptionalServices As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDays As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtFinalBill As TextBox
End Class
