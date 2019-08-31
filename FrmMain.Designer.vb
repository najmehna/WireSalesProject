<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.BtnCncl = New System.Windows.Forms.Button()
        Me.BtnAddCustomer = New System.Windows.Forms.Button()
        Me.ButnAddWire = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbCurrYear = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(125, 39)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(144, 54)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "فروش"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.Location = New System.Drawing.Point(125, 172)
        Me.BtnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(144, 54)
        Me.BtnReport.TabIndex = 1
        Me.BtnReport.Text = "گزارش"
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'BtnCncl
        '
        Me.BtnCncl.Location = New System.Drawing.Point(145, 274)
        Me.BtnCncl.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCncl.Name = "BtnCncl"
        Me.BtnCncl.Size = New System.Drawing.Size(100, 28)
        Me.BtnCncl.TabIndex = 2
        Me.BtnCncl.Text = "خروج"
        Me.BtnCncl.UseVisualStyleBackColor = True
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.Location = New System.Drawing.Point(125, 101)
        Me.BtnAddCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(144, 28)
        Me.BtnAddCustomer.TabIndex = 3
        Me.BtnAddCustomer.Text = "مشتری جدید"
        Me.BtnAddCustomer.UseVisualStyleBackColor = True
        '
        'ButnAddWire
        '
        Me.ButnAddWire.Location = New System.Drawing.Point(125, 137)
        Me.ButnAddWire.Margin = New System.Windows.Forms.Padding(4)
        Me.ButnAddWire.Name = "ButnAddWire"
        Me.ButnAddWire.Size = New System.Drawing.Size(144, 28)
        Me.ButnAddWire.TabIndex = 4
        Me.ButnAddWire.Text = "مفتول"
        Me.ButnAddWire.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(125, 233)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(144, 26)
        Me.BtnEdit.TabIndex = 5
        Me.BtnEdit.Text = "اصلاح"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'CbCurrYear
        '
        Me.CbCurrYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCurrYear.FormattingEnabled = True
        Me.CbCurrYear.Location = New System.Drawing.Point(-3, 101)
        Me.CbCurrYear.Name = "CbCurrYear"
        Me.CbCurrYear.Size = New System.Drawing.Size(121, 24)
        Me.CbCurrYear.TabIndex = 80
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 322)
        Me.Controls.Add(Me.CbCurrYear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.ButnAddWire)
        Me.Controls.Add(Me.BtnAddCustomer)
        Me.Controls.Add(Me.BtnCncl)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnAdd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فروش مفتولی"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents BtnCncl As System.Windows.Forms.Button
    Friend WithEvents BtnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents ButnAddWire As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CbCurrYear As System.Windows.Forms.ComboBox
End Class
