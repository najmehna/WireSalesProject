Public Class FrmAddCustomer

    Private Sub FrmAddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        makeItFarsi()
        Init()
    End Sub
    Private Sub Init()
        'TODO: This line of code loads data into the 'DataSetCustomer.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DataSetCustomer.Customers)
        Me.TxtName.Text = ""
        Me.LbCode.Text = Me.DataSetCustomer.Customers.Rows.Count + 1
    End Sub
    Private Sub SaveData()
        Dim Duplicate As Boolean = False
        Dim dr As DataRow = DataSetCustomer.Customers.NewRow
        For i = 0 To Me.DataSetCustomer.Customers.Rows.Count - 1
            With Me.DataSetCustomer.Customers.Rows(i)
                If .Item(1) = Me.TxtName.Text Then
                    Duplicate = True
                    MsgBox("این مشتری قبلا وارد شده است...")
                    Exit For
                End If
            End With
        Next
        If Duplicate = False Then
            dr.Item(0) = Me.LbCode.Text
            dr.Item(1) = Me.TxtName.Text
            DataSetCustomer.Customers.Rows.Add(dr)
            Me.CustomersTableAdapter.Update(Me.DataSetCustomer.Customers)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        If Me.TxtName.Text = "" Then
            MsgBox("لطفا نام مشتری جدید را وارد کنید...")
            Exit Sub
        End If
        SaveData()
        Init()
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class