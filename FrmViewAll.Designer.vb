<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewAll))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ناممشتریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.نوعمفتولDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.وزنDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.فیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.مبلغDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAll2 = New Hamid1.DataSetAll2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbPrice = New System.Windows.Forms.Label()
        Me.LbWeight = New System.Windows.Forms.Label()
        Me.LbAmount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ReportAllTableAdapter = New Hamid1.DataSetAll2TableAdapters.ReportAllTableAdapter()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAll2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.کدDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.ناممشتریDataGridViewTextBoxColumn, Me.نوعمفتولDataGridViewTextBoxColumn, Me.وزنDataGridViewTextBoxColumn, Me.فیDataGridViewTextBoxColumn, Me.مبلغDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReportAllBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(794, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.ReadOnly = True
        Me.کدDataGridViewTextBoxColumn.Width = 50
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ناممشتریDataGridViewTextBoxColumn
        '
        Me.ناممشتریDataGridViewTextBoxColumn.DataPropertyName = "نام مشتری"
        Me.ناممشتریDataGridViewTextBoxColumn.HeaderText = "نام مشتری"
        Me.ناممشتریDataGridViewTextBoxColumn.Name = "ناممشتریDataGridViewTextBoxColumn"
        Me.ناممشتریDataGridViewTextBoxColumn.ReadOnly = True
        Me.ناممشتریDataGridViewTextBoxColumn.Width = 150
        '
        'نوعمفتولDataGridViewTextBoxColumn
        '
        Me.نوعمفتولDataGridViewTextBoxColumn.DataPropertyName = "نوع مفتول"
        Me.نوعمفتولDataGridViewTextBoxColumn.HeaderText = "نوع مفتول"
        Me.نوعمفتولDataGridViewTextBoxColumn.Name = "نوعمفتولDataGridViewTextBoxColumn"
        Me.نوعمفتولDataGridViewTextBoxColumn.ReadOnly = True
        '
        'وزنDataGridViewTextBoxColumn
        '
        Me.وزنDataGridViewTextBoxColumn.DataPropertyName = "وزن"
        Me.وزنDataGridViewTextBoxColumn.HeaderText = "وزن"
        Me.وزنDataGridViewTextBoxColumn.Name = "وزنDataGridViewTextBoxColumn"
        Me.وزنDataGridViewTextBoxColumn.ReadOnly = True
        '
        'فیDataGridViewTextBoxColumn
        '
        Me.فیDataGridViewTextBoxColumn.DataPropertyName = "فی"
        Me.فیDataGridViewTextBoxColumn.HeaderText = "فی"
        Me.فیDataGridViewTextBoxColumn.Name = "فیDataGridViewTextBoxColumn"
        Me.فیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مبلغDataGridViewTextBoxColumn
        '
        Me.مبلغDataGridViewTextBoxColumn.DataPropertyName = "مبلغ"
        Me.مبلغDataGridViewTextBoxColumn.HeaderText = "مبلغ"
        Me.مبلغDataGridViewTextBoxColumn.Name = "مبلغDataGridViewTextBoxColumn"
        Me.مبلغDataGridViewTextBoxColumn.ReadOnly = True
        Me.مبلغDataGridViewTextBoxColumn.Width = 150
        '
        'ReportAllBindingSource
        '
        Me.ReportAllBindingSource.DataMember = "ReportAll"
        Me.ReportAllBindingSource.DataSource = Me.DataSetAll2
        '
        'DataSetAll2
        '
        Me.DataSetAll2.DataSetName = "DataSetAll2"
        Me.DataSetAll2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "کیلوگرم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ریال"
        '
        'LbPrice
        '
        Me.LbPrice.AutoSize = True
        Me.LbPrice.Location = New System.Drawing.Point(164, 429)
        Me.LbPrice.Name = "LbPrice"
        Me.LbPrice.Size = New System.Drawing.Size(49, 16)
        Me.LbPrice.TabIndex = 3
        Me.LbPrice.Text = "Label3"
        '
        'LbWeight
        '
        Me.LbWeight.AutoSize = True
        Me.LbWeight.Location = New System.Drawing.Point(278, 429)
        Me.LbWeight.Name = "LbWeight"
        Me.LbWeight.Size = New System.Drawing.Size(49, 16)
        Me.LbWeight.TabIndex = 4
        Me.LbWeight.Text = "Label4"
        '
        'LbAmount
        '
        Me.LbAmount.AutoSize = True
        Me.LbAmount.Location = New System.Drawing.Point(28, 429)
        Me.LbAmount.Name = "LbAmount"
        Me.LbAmount.Size = New System.Drawing.Size(49, 16)
        Me.LbAmount.TabIndex = 5
        Me.LbAmount.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ریال"
        '
        'ReportAllTableAdapter
        '
        Me.ReportAllTableAdapter.ClearBeforeFill = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(28, 484)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 32)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "خروج"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'FrmViewAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 519)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbAmount)
        Me.Controls.Add(Me.LbWeight)
        Me.Controls.Add(Me.LbPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmViewAll"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش کامل"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAll2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbPrice As System.Windows.Forms.Label
    Friend WithEvents LbWeight As System.Windows.Forms.Label
    Friend WithEvents LbAmount As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSetAll2 As Hamid1.DataSetAll2
    Friend WithEvents ReportAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportAllTableAdapter As Hamid1.DataSetAll2TableAdapters.ReportAllTableAdapter
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ناممشتریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعمفتولDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وزنDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
