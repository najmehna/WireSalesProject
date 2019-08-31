Public Class FrmAddWire

    Private Sub FrmAddWire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        makeItFarsi()
       
        Init()
    End Sub
    Private Sub Init()
        'TODO: This line of code loads data into the 'DataSetWire.Wire' table. You can move, or remove it, as needed.
        Me.WireTableAdapter.Fill(Me.DataSetWire.Wire)
        Me.TxtType.Text = ""
        Me.LbCode.Text = Me.DataSetWire.Wire.Rows.Count + 1
    End Sub
    Private Sub SaveData()
        Dim Duplicate As Boolean = False
        Dim dr As DataRow = DataSetWire.Wire.NewRow
        For i = 0 To Me.DataSetWire.Wire.Rows.Count - 1
            With Me.DataSetWire.Wire.Rows(i)
                If .Item(1) = Me.TxtType.Text Then
                    Duplicate = True
                    MsgBox("این نوع مفتول قبلا وارد شده است...")
                    Exit For
                End If
            End With
        Next
        If Duplicate = False Then
            dr.Item(0) = Me.LbCode.Text
            dr.Item(1) = Me.TxtType.Text
            DataSetWire.Wire.Rows.Add(dr)
            Me.WireTableAdapter.Update(Me.DataSetWire.Wire)
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Me.TxtType.Text = "" Then
            MsgBox("لطفا نوع مفتول جدید را وارد کنید...")
            Exit Sub
        End If
        SaveData()
        Init()
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class