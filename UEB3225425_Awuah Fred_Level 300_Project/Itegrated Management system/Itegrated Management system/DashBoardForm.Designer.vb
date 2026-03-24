<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoardForm))
        Me.btnHospital = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHospital
        '
        Me.btnHospital.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnHospital.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospital.Image = CType(resources.GetObject("btnHospital.Image"), System.Drawing.Image)
        Me.btnHospital.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnHospital.Location = New System.Drawing.Point(272, 82)
        Me.btnHospital.Name = "btnHospital"
        Me.btnHospital.Size = New System.Drawing.Size(423, 143)
        Me.btnHospital.TabIndex = 0
        Me.btnHospital.Text = "Hospital Billing Module"
        Me.btnHospital.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHospital.UseVisualStyleBackColor = False
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoan.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Image = CType(resources.GetObject("btnLoan.Image"), System.Drawing.Image)
        Me.btnLoan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLoan.Location = New System.Drawing.Point(272, 249)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(423, 139)
        Me.btnLoan.TabIndex = 1
        Me.btnLoan.Text = "Student Loan Module"
        Me.btnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLogout.Location = New System.Drawing.Point(272, 407)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(423, 127)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1203, 71)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DASHBOARD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DashBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1203, 620)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnHospital)
        Me.Name = "DashBoardForm"
        Me.Text = "DashBoardForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHospital As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
