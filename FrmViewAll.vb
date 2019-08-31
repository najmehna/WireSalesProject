Public Class FrmViewAll

    Private Sub FrmViewAll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAll2.ReportAll' table. You can move, or remove it, as needed.
        Me.ReportAllTableAdapter.Fill(Me.DataSetAll2.ReportAll)
        Dim weight As Integer = 0
        Dim price As Integer = 0
        Dim Amount As Int64 = 0
        For i = 0 To Me.DataSetAll2.ReportAll.Rows.Count - 1
            weight += Me.DataSetAll2.ReportAll.Rows(i).Item("وزن")
            Amount += Me.DataSetAll2.ReportAll.Rows(i).Item("مبلغ")
        Next
        price = Amount \ weight
        Me.LbAmount.Text = Amount
        Me.LbPrice.Text = price
        Me.LbWeight.Text = weight

    End Sub
    
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class