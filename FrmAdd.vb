Imports System.Data.OleDb
Public Class FrmAdd
    Dim DADatasetAll As New DataSetAllTableAdapters.Table1TableAdapter
    Private Sub FrmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetWire.Wire' table. You can move, or remove it, as needed.
        Me.WireTableAdapter.FillSort(Me.DataSetWire.Wire)
        'TODO: This line of code loads data into the 'DataSetCustomer.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillSort(Me.DataSetCustomer.Customers)

        makeitFarsi()

        ClearFields()
    End Sub
    

    Private Sub ClearFields()
        Me.DADatasetAll.Fill(Me.DataSetAll.Table1)
        Me.LbNumber.Text = Me.DataSetAll.Table1.Rows.Count + 1
        Me.TxtPrice.Text = ""
        Me.TxtWeight.Text = ""
        Me.TxtDate.Text = ""
        Me.CbCustomer.SelectedIndex = -1
        Me.CbWire.SelectedIndex = -1
        Me.TxtDate.Focus()

    End Sub
    Private Function CheckFields() As Boolean
        If Me.TxtWeight.Text = "" Then
            MsgBox("لطفا وزن را وارد کنید...")
            Return False
        End If
        If Me.TxtPrice.Text = "" Then
            MsgBox("لطفا فی را وارد کنید...")
            Return False

        End If
        If Me.CbWire.SelectedIndex = -1 Then
            MsgBox("لطفا نوع مفتول را انتخاب کنید...")
            Return False
        End If
        If Me.CbCustomer.SelectedIndex = -1 Then
            MsgBox("لطفا مشتری را انتخاب کنید...")
            Return False
        End If
        If Me.TxtDate.Text = "" Then
            MsgBox("لطفا تاریخ را وارد کنید...")
            Return False
        ElseIf Not isValidDate(Me.TxtDate.Text) Then
            Return False
        End If
        Return True
    End Function
    Private Sub SaveData()
        Dim dr As DataRow = Me.DataSetAll.Table1.NewRow
        With dr
            .Item(1) = Me.TxtDate.Text
            .Item(2) = Me.CbCustomer.SelectedValue
            .Item(3) = Me.CbWire.SelectedValue
            .Item(4) = Me.TxtWeight.Text
            .Item(5) = Me.TxtPrice.Text

        End With
        Try
            Me.DataSetAll.Table1.Rows.Add(dr)

            Me.DADatasetAll.Update(Me.DataSetAll)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    
    Private Sub BtnAddPlus_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddPlus.Click
        If CheckFields() Then
            SaveData()
            ClearFields()
        End If
    End Sub

    Private Sub BtnCncl_Click(sender As System.Object, e As System.EventArgs) Handles BtnCncl.Click
        Me.Close()
    End Sub

    Private Sub TxtWeight_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWeight.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrice.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            e.Handled = True
        End If
    End Sub
End Class
