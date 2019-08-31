<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.BtnCncl = New System.Windows.Forms.Button()
        Me.RbCustomer = New System.Windows.Forms.RadioButton()
        Me.RbWire = New System.Windows.Forms.RadioButton()
        Me.CbCustomer = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCustomer = New Hamid1.DataSetCustomer()
        Me.WireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetWire = New Hamid1.DataSetWire()
        Me.CbWire = New System.Windows.Forms.ComboBox()
        Me.CustomersTableAdapter = New Hamid1.DataSetCustomerTableAdapters.CustomersTableAdapter()
        Me.WireTableAdapter = New Hamid1.DataSetWireTableAdapters.WireTableAdapter()
        Me.GbReport = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbAv = New System.Windows.Forms.Label()
        Me.LbAmount = New System.Windows.Forms.Label()
        Me.LbWeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnViewAll = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RbDate = New System.Windows.Forms.RadioButton()
        Me.CbMonth = New System.Windows.Forms.ComboBox()
        Me.LbMonth = New System.Windows.Forms.Label()
        Me.GbDate = New System.Windows.Forms.GroupBox()
        Me.DataSetAll = New Hamid1.DataSetAll()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Hamid1.DataSetAllTableAdapters.Table1TableAdapter()
        Me.CbYear = New System.Windows.Forms.ComboBox()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbReport.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDate.SuspendLayout()
        CType(Me.DataSetAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCncl
        '
        Me.BtnCncl.Location = New System.Drawing.Point(37, 290)
        Me.BtnCncl.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCncl.Name = "BtnCncl"
        Me.BtnCncl.Size = New System.Drawing.Size(100, 28)
        Me.BtnCncl.TabIndex = 2
        Me.BtnCncl.Text = "خروج"
        Me.BtnCncl.UseVisualStyleBackColor = True
        '
        'RbCustomer
        '
        Me.RbCustomer.AutoSize = True
        Me.RbCustomer.Location = New System.Drawing.Point(296, 69)
        Me.RbCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.RbCustomer.Name = "RbCustomer"
        Me.RbCustomer.Size = New System.Drawing.Size(67, 20)
        Me.RbCustomer.TabIndex = 5
        Me.RbCustomer.TabStop = True
        Me.RbCustomer.Text = "مشتری :"
        Me.RbCustomer.UseVisualStyleBackColor = True
        '
        'RbWire
        '
        Me.RbWire.AutoSize = True
        Me.RbWire.Location = New System.Drawing.Point(585, 69)
        Me.RbWire.Margin = New System.Windows.Forms.Padding(4)
        Me.RbWire.Name = "RbWire"
        Me.RbWire.Size = New System.Drawing.Size(60, 20)
        Me.RbWire.TabIndex = 6
        Me.RbWire.TabStop = True
        Me.RbWire.Text = "مفتول :"
        Me.RbWire.UseVisualStyleBackColor = True
        '
        'CbCustomer
        '
        Me.CbCustomer.DataSource = Me.CustomersBindingSource
        Me.CbCustomer.DisplayMember = "نام مشتری"
        Me.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCustomer.FormattingEnabled = True
        Me.CbCustomer.Location = New System.Drawing.Point(127, 64)
        Me.CbCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCustomer.Name = "CbCustomer"
        Me.CbCustomer.Size = New System.Drawing.Size(160, 24)
        Me.CbCustomer.TabIndex = 7
        Me.CbCustomer.ValueMember = "کد مشتری"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DataSetCustomer
        '
        'DataSetCustomer
        '
        Me.DataSetCustomer.DataSetName = "DataSetCustomer"
        Me.DataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CbWire
        '
        Me.CbWire.DataSource = Me.WireBindingSource
        Me.CbWire.DisplayMember = "نوع مفتول"
        Me.CbWire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbWire.FormattingEnabled = True
        Me.CbWire.Location = New System.Drawing.Point(416, 64)
        Me.CbWire.Margin = New System.Windows.Forms.Padding(4)
        Me.CbWire.Name = "CbWire"
        Me.CbWire.Size = New System.Drawing.Size(160, 24)
        Me.CbWire.TabIndex = 8
        Me.CbWire.ValueMember = "کد مفتول"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'WireTableAdapter
        '
        Me.WireTableAdapter.ClearBeforeFill = True
        '
        'GbReport
        '
        Me.GbReport.Controls.Add(Me.Label6)
        Me.GbReport.Controls.Add(Me.Label5)
        Me.GbReport.Controls.Add(Me.Label4)
        Me.GbReport.Controls.Add(Me.LbAv)
        Me.GbReport.Controls.Add(Me.LbAmount)
        Me.GbReport.Controls.Add(Me.LbWeight)
        Me.GbReport.Controls.Add(Me.Label3)
        Me.GbReport.Controls.Add(Me.Label2)
        Me.GbReport.Controls.Add(Me.Label1)
        Me.GbReport.Location = New System.Drawing.Point(80, 141)
        Me.GbReport.Margin = New System.Windows.Forms.Padding(4)
        Me.GbReport.Name = "GbReport"
        Me.GbReport.Padding = New System.Windows.Forms.Padding(4)
        Me.GbReport.Size = New System.Drawing.Size(565, 123)
        Me.GbReport.TabIndex = 9
        Me.GbReport.TabStop = False
        Me.GbReport.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ریال"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ریال"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "کیلوگرم"
        '
        'LbAv
        '
        Me.LbAv.AutoSize = True
        Me.LbAv.Location = New System.Drawing.Point(164, 90)
        Me.LbAv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAv.Name = "LbAv"
        Me.LbAv.Size = New System.Drawing.Size(60, 16)
        Me.LbAv.TabIndex = 7
        Me.LbAv.Text = "Average"
        '
        'LbAmount
        '
        Me.LbAmount.AutoSize = True
        Me.LbAmount.Location = New System.Drawing.Point(88, 39)
        Me.LbAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAmount.Name = "LbAmount"
        Me.LbAmount.Size = New System.Drawing.Size(53, 16)
        Me.LbAmount.TabIndex = 6
        Me.LbAmount.Text = "Amount"
        '
        'LbWeight
        '
        Me.LbWeight.AutoSize = True
        Me.LbWeight.Location = New System.Drawing.Point(357, 39)
        Me.LbWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbWeight.Name = "LbWeight"
        Me.LbWeight.Size = New System.Drawing.Size(50, 16)
        Me.LbWeight.TabIndex = 5
        Me.LbWeight.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "میانگین فی :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "جمع مبلغ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "جمع وزن :"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(547, 281)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 46)
        Me.BtnViewAll.TabIndex = 10
        Me.BtnViewAll.Text = "گزارش کامل"
        Me.BtnViewAll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'RbDate
        '
        Me.RbDate.AutoSize = True
        Me.RbDate.Location = New System.Drawing.Point(592, 111)
        Me.RbDate.Name = "RbDate"
        Me.RbDate.Size = New System.Drawing.Size(53, 20)
        Me.RbDate.TabIndex = 79
        Me.RbDate.TabStop = True
        Me.RbDate.Text = "سال :"
        Me.RbDate.UseVisualStyleBackColor = True
        '
        'CbMonth
        '
        Me.CbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMonth.FormattingEnabled = True
        Me.CbMonth.Items.AddRange(New Object() {"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"})
        Me.CbMonth.Location = New System.Drawing.Point(14, 10)
        Me.CbMonth.Name = "CbMonth"
        Me.CbMonth.Size = New System.Drawing.Size(121, 24)
        Me.CbMonth.TabIndex = 81
        '
        'LbMonth
        '
        Me.LbMonth.AutoSize = True
        Me.LbMonth.Location = New System.Drawing.Point(141, 13)
        Me.LbMonth.Name = "LbMonth"
        Me.LbMonth.Size = New System.Drawing.Size(31, 16)
        Me.LbMonth.TabIndex = 82
        Me.LbMonth.Text = "ماه :"
        '
        'GbDate
        '
        Me.GbDate.Controls.Add(Me.CbYear)
        Me.GbDate.Controls.Add(Me.LbMonth)
        Me.GbDate.Controls.Add(Me.CbMonth)
        Me.GbDate.Location = New System.Drawing.Point(269, 96)
        Me.GbDate.Name = "GbDate"
        Me.GbDate.Size = New System.Drawing.Size(317, 39)
        Me.GbDate.TabIndex = 83
        Me.GbDate.TabStop = False
        '
        'DataSetAll
        '
        Me.DataSetAll.DataSetName = "DataSetAll"
        Me.DataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataSetAll
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'CbYear
        '
        Me.CbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbYear.FormattingEnabled = True
        Me.CbYear.Location = New System.Drawing.Point(186, 10)
        Me.CbYear.Name = "CbYear"
        Me.CbYear.Size = New System.Drawing.Size(121, 24)
        Me.CbYear.TabIndex = 83
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 339)
        Me.Controls.Add(Me.GbDate)
        Me.Controls.Add(Me.RbDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnViewAll)
        Me.Controls.Add(Me.GbReport)
        Me.Controls.Add(Me.CbWire)
        Me.Controls.Add(Me.CbCustomer)
        Me.Controls.Add(Me.RbWire)
        Me.Controls.Add(Me.RbCustomer)
        Me.Controls.Add(Me.BtnCncl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetWire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbReport.ResumeLayout(False)
        Me.GbReport.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDate.ResumeLayout(False)
        Me.GbDate.PerformLayout()
        CType(Me.DataSetAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCncl As System.Windows.Forms.Button
    Friend WithEvents RbCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RbWire As System.Windows.Forms.RadioButton
    Friend WithEvents CbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents CbWire As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetCustomer As Hamid1.DataSetCustomer
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Hamid1.DataSetCustomerTableAdapters.CustomersTableAdapter
    Friend WithEvents DataSetWire As Hamid1.DataSetWire
    Friend WithEvents WireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WireTableAdapter As Hamid1.DataSetWireTableAdapters.WireTableAdapter
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدمشتریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدمفتولDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وزنDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GbReport As System.Windows.Forms.GroupBox
    Friend WithEvents LbAv As System.Windows.Forms.Label
    Friend WithEvents LbAmount As System.Windows.Forms.Label
    Friend WithEvents LbWeight As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnViewAll As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RbDate As System.Windows.Forms.RadioButton
    Friend WithEvents CbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents LbMonth As System.Windows.Forms.Label
    Friend WithEvents GbDate As System.Windows.Forms.GroupBox
    Friend WithEvents DataSetAll As Hamid1.DataSetAll
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Hamid1.DataSetAllTableAdapters.Table1TableAdapter
    Friend WithEvents CbYear As System.Windows.Forms.ComboBox
End Class
