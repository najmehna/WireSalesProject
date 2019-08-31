Public Class FrmMain
    Dim frmAdd1 As New FrmAdd
    Dim frmReport1 As New FrmReport
    Dim frmCustomer As New FrmAddCustomer
    Dim frmWire As New FrmAddWire
    Dim frmedit1 As New FrmEdit


    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        frmAdd1.ShowDialog()

    End Sub

    Private Sub BtnCncl_Click(sender As System.Object, e As System.EventArgs) Handles BtnCncl.Click
        Me.Close()
    End Sub

    Private Sub BtnReport_Click(sender As System.Object, e As System.EventArgs) Handles BtnReport.Click
        frmReport1.ShowDialog()

    End Sub

    Private Sub BtnAddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddCustomer.Click
        frmCustomer.ShowDialog()

    End Sub

    Private Sub ButnAddWire_Click(sender As System.Object, e As System.EventArgs) Handles ButnAddWire.Click
        frmWire.ShowDialog()

    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        frmedit1.ShowDialog()
    End Sub

    Private Sub LoadYearCombo()
        Me.CbCurrYear.Items.Clear()
        Dim filename As String
        Dim filereader As String() = System.IO.Directory.GetFiles(My.Application.Info.DirectoryPath & "\DB")
        For Each filename In filereader
            filename = filename.Substring(My.Application.Info.DirectoryPath.Count + 15, 4)
            Me.CbCurrYear.Items.Add(filename)

        Next
        Dim percal As Globalization.PersianCalendar = New Globalization.PersianCalendar
        Dim myYear As String = percal.GetYear(Now)
        For i = 0 To Me.CbCurrYear.Items.Count - 1
            If Me.CbCurrYear.Items(i) = myYear Then
                Me.CbCurrYear.SelectedIndex = i
                Exit For
            End If
        Next

    End Sub

    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LoadYearCombo()

    End Sub
End Class