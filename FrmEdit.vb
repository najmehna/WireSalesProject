Public Class FrmEdit

    Private Sub FrmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetWire.Wire' table. You can move, or remove it, as needed.
        Me.WireTableAdapter.FillSort(Me.DataSetWire.Wire)
        'TODO: This line of code loads data into the 'DataSetCustomer.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillSort(Me.DataSetCustomer.Customers)
        'TODO: This line of code loads data into the 'DataSetAll.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSetAll.Table1)
        SetCombos()
        Me.BtnLast.Enabled = False
        'MsgBox(Me.Table1BindingSource.Position)
    End Sub
    Private Sub SetCombos()
        Me.CbWire.SelectedValue = Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position).Item(3)
        Me.CbCustomer.SelectedValue = Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position).Item(2)

    End Sub

    Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click
        With Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position)
            .Item(2) = Me.CbCustomer.SelectedValue
            .Item(3) = Me.CbWire.SelectedValue
            Me.Table1TableAdapter.Update(Me.DataSetAll.Table1)
        End With
        If Me.Table1BindingSource.Position = Me.DataSetAll.Table1.Rows.Count - 1 Then
            Me.BtnNext.Enabled = False
        Else
            Me.BtnNext.Enabled = True
            If Me.Table1BindingSource.Position >= 0 Then
                Me.BtnLast.Enabled = True
            End If

        End If
        Me.Table1BindingSource.Position += 1
        SetCombos()
        'MsgBox("Customer =  " & Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position).Item(2).ToString)


    End Sub

    Private Sub BtnLast_Click(sender As System.Object, e As System.EventArgs) Handles BtnLast.Click
        With Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position)
            .Item(2) = Me.CbCustomer.SelectedValue
            .Item(3) = Me.CbWire.SelectedValue
            Me.Table1TableAdapter.Update(Me.DataSetAll.Table1)
        End With
        If Me.Table1BindingSource.Position = 1 Then
            Me.BtnLast.Enabled = False
        Else
            Me.BtnLast.Enabled = True
            If Me.Table1BindingSource.Position <= Me.DataSetAll.Table1.Rows.Count - 1 Then
                Me.BtnNext.Enabled = True
            End If
        End If
        Me.Table1BindingSource.Position -= 1
        SetCombos()
        ' MsgBox("Customer =  " & Me.DataSetAll.Table1.Rows(Me.Table1BindingSource.Position).Item(2).ToString)

    End Sub

    Private Sub BtnCncl_Click(sender As System.Object, e As System.EventArgs) Handles BtnCncl.Click
        Me.Close()
    End Sub

End Class