<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAll = New Hamid1.DataSetAll()
        Me.BtnCncl = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.CbWire = New System.Windows.Forms.ComboBox()
        Me.WireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetWire = New Hamid1.DataSetWire()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbNumber = New System.Windows.Forms.Label()
        Me.Table1TableAdapter = New Hamid1.DataSetAllTableAdapters.Table1TableAdapter()
        Me.DataSetCustomer = New Hamid1.DataSetCustomer()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Hamid1.DataSetCustomerTableAdapters.CustomersTableAdapter()
        Me.WireTableAdapter = New Hamid1.DataSetWireTableAdapters.WireTableAdapter()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.CbCustomer = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "تاریخ :"
        '
        'TxtDate
        '
        Me.TxtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "تاریخ", True))
        Me.TxtDate.Location = New System.Drawing.Point(152, 33)
        Me.TxtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(109, 22)
        Me.TxtDate.TabIndex = 15
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataSetAll
        '
        'DataSetAll
        '
        Me.DataSetAll.DataSetName = "DataSetAll"
        Me.DataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnCncl
        '
        Me.BtnCncl.Location = New System.Drawing.Point(13, 195)
        Me.BtnCncl.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCncl.Name = "BtnCncl"
        Me.BtnCncl.Size = New System.Drawing.Size(100, 28)
        Me.BtnCncl.TabIndex = 27
        Me.BtnCncl.Text = "خروج"
        Me.BtnCncl.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(328, 163)
        Me.BtnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(63, 28)
        Me.BtnNext.TabIndex = 26
        Me.BtnNext.Text = "بعدی"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'TxtPrice
        '
        Me.TxtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "فی", True))
        Me.TxtPrice.Location = New System.Drawing.Point(129, 118)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(132, 22)
        Me.TxtPrice.TabIndex = 24
        '
        'TxtWeight
        '
        Me.TxtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "وزن", True))
        Me.TxtWeight.Location = New System.Drawing.Point(356, 116)
        Me.TxtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(132, 22)
        Me.TxtWeight.TabIndex = 22
        '
        'CbWire
        '
        Me.CbWire.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WireBindingSource, "نوع مفتول", True))
        Me.CbWire.DataSource = Me.WireBindingSource
        Me.CbWire.DisplayMember = "نوع مفتول"
        Me.CbWire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbWire.FormattingEnabled = True
        Me.CbWire.Location = New System.Drawing.Point(101, 73)
        Me.CbWire.Margin = New System.Windows.Forms.Padding(4)
        Me.CbWire.Name = "CbWire"
        Me.CbWire.Size = New System.Drawing.Size(160, 24)
        Me.CbWire.TabIndex = 19
        Me.CbWire.ValueMember = "کد مفتول"
        '
        'WireBindingSource
        '
        Me.WireBindingSource.DataMember = "Wire"
        Me.WireBindingSource.DataSource = Me.DataSetWire
        '
        'DataSetWire
        '
        Me.DataSetWire.DataSetName = "DataSetWire"
        Me.DataSetWire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "فی :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "وزن :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "مفتول :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "نام مشتری :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "کد:"
        '
        'LbNumber
        '
        Me.LbNumber.AutoSize = True
        Me.LbNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "کد", True))
        Me.LbNumber.Location = New System.Drawing.Point(430, 35)
        Me.LbNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbNumber.Name = "LbNumber"
        Me.LbNumber.Size = New System.Drawing.Size(56, 16)
        Me.LbNumber.TabIndex = 16
        Me.LbNumber.Text = "Number"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'DataSetCustomer
        '
        Me.DataSetCustomer.DataSetName = "DataSetCustomer"
        Me.DataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DataSetCustomer
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'WireTableAdapter
        '
        Me.WireTableAdapter.ClearBeforeFill = True
        '
        'BtnLast
        '
        Me.BtnLast.Location = New System.Drawing.Point(203, 163)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(58, 28)
        Me.BtnLast.TabIndex = 29
        Me.BtnLast.Text = "قبلی"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'CbCustomer
        '
        Me.CbCustomer.DataSource = Me.CustomersBindingSource
        Me.CbCustomer.DisplayMember = "نام مشتری"
        Me.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCustomer.FormattingEnabled = True
        Me.CbCustomer.Location = New System.Drawing.Point(328, 73)
        Me.CbCustomer.Name = "CbCustomer"
        Me.CbCustomer.Size = New System.Drawing.Size(170, 24)
        Me.CbCustomer.TabIndex = 30
        Me.CbCustomer.ValueMember = "کد مشتری"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'FrmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 229)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CbCustomer)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.BtnCncl)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.CbWire)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbNumber)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEdit"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents BtnCncl As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtWeight As System.Windows.Forms.TextBox
    Friend WithEvents CbWire As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbNumber As System.Windows.Forms.Label
    Friend WithEvents DataSetAll As Hamid1.DataSetAll
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Hamid1.DataSetAllTableAdapters.Table1TableAdapter
    Friend WithEvents DataSetCustomer As Hamid1.DataSetCustomer
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Hamid1.DataSetCustomerTableAdapters.CustomersTableAdapter
    Friend WithEvents DataSetWire As Hamid1.DataSetWire
    Friend WithEvents WireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WireTableAdapter As Hamid1.DataSetWireTableAdapters.WireTableAdapter
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents CbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
