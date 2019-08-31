<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddWire
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddWire))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbCode = New System.Windows.Forms.Label()
        Me.TxtType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DataSetWire = New Hamid1.DataSetWire()
        Me.WireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WireTableAdapter = New Hamid1.DataSetWireTableAdapters.WireTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "نوع مفتول :"
        '
        'LbCode
        '
        Me.LbCode.AutoSize = True
        Me.LbCode.Location = New System.Drawing.Point(193, 37)
        Me.LbCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCode.Name = "LbCode"
        Me.LbCode.Size = New System.Drawing.Size(49, 16)
        Me.LbCode.TabIndex = 10
        Me.LbCode.Text = "Label2"
        '
        'TxtType
        '
        Me.TxtType.Location = New System.Drawing.Point(112, 70)
        Me.TxtType.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.Size = New System.Drawing.Size(132, 22)
        Me.TxtType.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "کد مفتول :"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(73, 122)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 28)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "خروج"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(213, 122)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 28)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "ذخیره"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DataSetWire
        '
        Me.DataSetWire.DataSetName = "DataSetWire"
        Me.DataSetWire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WireBindingSource
        '
        Me.WireBindingSource.DataMember = "Wire"
        Me.WireBindingSource.DataSource = Me.DataSetWire
        '
        'WireTableAdapter
        '
        Me.WireTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'FrmAddWire
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 172)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbCode)
        Me.Controls.Add(Me.TxtType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddWire"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مفتول"
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbCode As System.Windows.Forms.Label
    Friend WithEvents TxtType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents DataSetWire As Hamid1.DataSetWire
    Friend WithEvents WireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WireTableAdapter As Hamid1.DataSetWireTableAdapters.WireTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
