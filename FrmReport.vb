Imports System.Data.OleDb
Public Class FrmReport
    Dim frmViewAll1 As New FrmViewAll
    Dim DADatasetAll As DataSetAllTableAdapters.Table1TableAdapter
    Dim conn1 As OleDbConnection
    Friend WithEvents commandWireWeight As OleDbCommand
    Friend WithEvents commandWireAmount As OleDbCommand
    Friend WithEvents commandCustomerAmount As OleDbCommand
    Friend WithEvents commandCustomerWeight As OleDbCommand
    Friend WithEvents commandAllWeight As OleDbCommand
    Friend WithEvents commandAllAmount As OleDbCommand

    Private Sub FrmReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
        'TODO: This line of code loads data into the 'DataSetAll.Table1' table. You can move, or remove it, as needed.
        '.Fill(Me.DataSetAll.Table1)
        'TODO: This line of code loads data into the 'DataSetWire.Wire' table. You can move, or remove it, as needed.
        Me.WireTableAdapter.Fill(Me.DataSetWire.Wire)
        'TODO: This line of code loads data into the 'DataSetCustomer.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DataSetCustomer.Customers)
        ClearFields()
        Init()
        SetTheYears()
        'GetTheTotals()

    End Sub

    Private Sub SetTheYears()
        'TODO: This line of code loads data into the 'DataSetAll.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSetAll.Table1)
        Dim year As Integer
        Dim len As Integer
        Dim mystr As String

        Me.CbYear.Items.Clear()
        For i = 0 To Me.DataSetAll.Table1.Rows.Count - 1
            mystr = Me.DataSetAll.Table1.Rows(i).Item("تاریخ")
            len = mystr.LastIndexOf("/")
            year = mystr.Substring(len + 1)
            If Me.CbYear.Items.Count > 0 Then
                'For j = 0 To Me.CbYear.Items.Count - 1
                '    If Me.CbYear.Items(j) = year Then
                '    Else
                '        Me.CbYear.Items.Add(year)
                If Me.CbYear.Items.Contains(year) Then
                Else
                    Me.CbYear.Items.Add(year)
                End If
                '    End If
                ' Next
            Else
                Me.CbYear.Items.Add(year)
            End If
        Next

    End Sub
    'Private Sub GetTheTotals()
    '    Dim dr As Integer
    '    Dim dr1 As Int64

    '    Try
    '        Me.conn1.Open()
    '        dr = Me.commandCustomerWeight.ExecuteScalar
    '        conn1.Close()
    '    Catch ex As Exception

    '        conn1.Close()
    '        Exit Sub

    '    End Try
    '    Me.LbWeight.Text = dr

    '    '''''''''''''Getting the TotalAmount'''''''''''''''''''''''''''''''
    '    Try
    '        dr1 = Me.CbCustomer.SelectedValue
    '        Me.commandCustomerAmount.Parameters("@CustomerCode").Value = dr1
    '        Me.conn1.Open()
    '        dr1 = Me.commandCustomerAmount.ExecuteScalar
    '        conn1.Close()
    '    Catch ex As Exception
    '        MsgBox("مشکلی در محاسبه وزن و مبلغ کل وجود دارد...")
    '    End Try
    '    Me.LbAmount.Text = dr1
    '    Me.LbAv.Text = dr1 \ dr
    '    ' Me.DADatasetAll.FillByWire(Me.DataSetAll.Table1, Me.CbWire.SelectedValue)


    'End Sub
    Private Sub Init()


        Me.conn1 = New System.Data.OleDb.OleDbConnection
        Me.commandWireWeight = New System.Data.OleDb.OleDbCommand
        Me.commandWireAmount = New System.Data.OleDb.OleDbCommand
        Me.commandCustomerWeight = New System.Data.OleDb.OleDbCommand
        Me.commandCustomerAmount = New System.Data.OleDb.OleDbCommand
        Me.commandAllWeight = New System.Data.OleDb.OleDbCommand
        Me.commandAllAmount = New System.Data.OleDb.OleDbCommand
        '
        'Conn1
        '
        Me.conn1.ConnectionString = My.Settings.Database12ConnectionString
        '
        'CommandWireWeight
        '

        Me.commandWireWeight.Connection = conn1
        Me.commandWireWeight.CommandText = "SELECT  SUM(Table1.[وزن]) FROM Table1 WHERE ([کد مفتول] = @WireCode)"
        Me.commandWireWeight.Parameters.Add("@WireCode", OleDbType.Integer)
        '
        'commandwireamount
        '
        Me.commandWireAmount.Connection = conn1
        Me.commandWireAmount.Parameters.Add("@WireCode", OleDbType.Integer)
        Me.commandWireAmount.CommandText = "SELECT SUM(Table1.[وزن] *Table1.[فی]) AS Amount FROM Table1 WHERE [کد مفتول] = @WireCode"
        '
        'CommandCustomerweight
        '
        Me.commandCustomerWeight.Connection = conn1
        Me.commandCustomerWeight.CommandText = "SELECT  SUM(Table1.[وزن]) FROM Table1 WHERE ([کد مشتری] = @CustomerCode)"
        Me.commandCustomerWeight.Parameters.Add("@CustomerCode", OleDbType.Integer)

        '
        'CommandCustomerAmount
        '
        Me.commandCustomerAmount.Connection = conn1
        Me.commandCustomerAmount.Parameters.Add("@CustomerCode", OleDbType.Integer)
        Me.commandCustomerAmount.CommandText = "SELECT SUM(Table1.[وزن] *Table1.[فی]) AS Amount FROM Table1 WHERE [کد مشتری] = @CustomerCode"
        '
        'CommandAllWeight
        Me.commandAllWeight.Connection = conn1
        Me.commandAllWeight.CommandText = "SELECT  SUM(Table1.[وزن]) FROM Table1"
        '
        'commandAllamount
        '
        Me.commandAllAmount.Connection = conn1
        Me.commandAllAmount.CommandText = "SELECT SUM(Table1.[وزن] *Table1.[فی]) AS Amount FROM Table1"
        '

    End Sub
    Private Sub ClearFields()
        Me.CbCustomer.SelectedIndex = -1
        Me.CbWire.SelectedIndex = -1
        Me.RbCustomer.Checked = False
        Me.RbWire.Checked = True
        Me.CbCustomer.Enabled = False
        Me.CbMonth.SelectedIndex = -1
        Me.CbYear.SelectedIndex = -1
        Me.RbDate.Checked = False
        Me.GbDate.Enabled = False
        DisableLabels()


    End Sub

    Private Sub BtnCncl_Click(sender As System.Object, e As System.EventArgs) Handles BtnCncl.Click
        Me.Close()

    End Sub

    'Private Sub BtnReport_Click(sender As System.Object, e As System.EventArgs) Handles BtnReport.Click
    '    'Dim DSRepWire1 As DataSet = New DSRepWire

    '    ' Dim Drow As DataRow = DSRepWire1.Tables(0).NewRow
    '    If Me.RbWire.Checked Then
    '        'Me.GbCustomer.Text = "Customer Name"
    '        Me.GbReport.Text = Me.CbWire.SelectedText
    '        ReportWire()

    '    End If
    '    If Me.RbCustomer.Checked Then
    '        'Me.GbReport.Text = "Wire type"
    '        Me.GbReport.Text = Me.CbCustomer.SelectedText
    '        Reportcustomer()

    '    End If
    'End Sub
    Private Sub Reportcustomer()
        Dim dr As Integer
        Dim dr1 As Int64
        If Me.CbCustomer.SelectedIndex = -1 Then
            Exit Sub
        Else
            Try
                dr = Me.CbCustomer.SelectedValue
                Me.commandCustomerWeight.Parameters("@CustomerCode").Value = dr
                Me.conn1.Open()
                dr = Me.commandCustomerWeight.ExecuteScalar
                conn1.Close()
            Catch ex As Exception
                NoValueReport()
                conn1.Close()
                Exit Sub

            End Try

            Me.LbWeight.Text = dr

            '''''''''''''Getting the TotalAmount'''''''''''''''''''''''''''''''
            Try
                dr1 = Me.CbCustomer.SelectedValue
                Me.commandCustomerAmount.Parameters("@CustomerCode").Value = dr1
                Me.conn1.Open()
                dr1 = Me.commandCustomerAmount.ExecuteScalar
                conn1.Close()
            Catch ex As Exception
                MsgBox("مشکلی در محاسبه مبلغ وجود دارد...")
            End Try
           
            Me.LbAmount.Text = dr1
            Me.LbAv.Text = dr1 \ dr
            EnableLabels()
            ' Me.DADatasetAll.FillByWire(Me.DataSetAll.Table1, Me.CbWire.SelectedValue)

        End If
    End Sub


    Private Sub ReportWire()
        Dim dr As Integer
        Dim dr1 As Int64
        If Me.CbWire.SelectedIndex = -1 Then
            Exit Sub
        Else
            Try
                dr = Me.CbWire.SelectedValue
                Me.commandWireWeight.Parameters("@WireCode").Value = dr
                Me.conn1.Open()
                dr = Me.commandWireWeight.ExecuteScalar
                conn1.Close()
            Catch ex As Exception
                NoValueReport()
                conn1.Close()
                Exit Sub

            End Try

            Me.LbWeight.Text = dr

            '''''''''''''Getting the TotalAmount'''''''''''''''''''''''''''''''
            Try
                dr1 = Me.CbWire.SelectedValue
                Me.commandWireAmount.Parameters("@WireCode").Value = dr1
                Me.conn1.Open()
                dr1 = Me.commandWireAmount.ExecuteScalar
                conn1.Close()
            Catch ex As Exception
                MsgBox("مشکلی در محاسبه مبلغ وجود دارد...")
            End Try
           
            Me.LbAmount.Text = dr1
            Me.LbAv.Text = dr1 \ dr
            EnableLabels()
            ' Me.DADatasetAll.FillByWire(Me.DataSetAll.Table1, Me.CbWire.SelectedValue)

        End If
    End Sub
    Private Sub reportDate()
        Dim mystr As String
        Dim len As Integer
        Dim RepDate As String
        Dim myDate As String
        Dim dr As Integer = 0
        Dim dr1 As Int64 = 0
        Dim temp As Int64 = 0
        RepDate = Me.CbMonth.SelectedIndex + 1
        RepDate &= "/" & Me.CbYear.Items(Me.CbYear.SelectedIndex)

        For i = 0 To Me.DataSetAll.Table1.Rows.Count - 1
            mystr = Me.DataSetAll.Table1.Rows(i).Item("تاریخ")
            len = mystr.IndexOf("/")
            myDate = mystr.Substring(len + 1)
            If myDate = RepDate Then
                temp = Me.DataSetAll.Table1.Rows(i).Item("وزن")
                dr += temp
                temp *= Me.DataSetAll.Table1.Rows(i).Item("فی")
                dr1 += temp
            End If
        Next
        If dr > 0 Then
            Me.LbWeight.Text = dr
            Me.LbAmount.Text = dr1
            Me.LbAv.Text = dr1 \ dr
            EnableLabels()
        Else
            Me.LbAmount.Text = 0
            Me.LbAv.Text = 0
            Me.LbWeight.Text = 0
            DisableLabels()
        End If
        

    End Sub
    Private Sub DisableLabels()
        Me.Label1.Enabled = False
        Me.Label2.Enabled = False
        Me.Label3.Enabled = False
        Me.Label4.Enabled = False
        Me.Label5.Enabled = False
        Me.Label6.Enabled = False
        Me.LbWeight.Enabled = False
        Me.LbAmount.Enabled = False
        Me.LbAv.Enabled = False
    End Sub
    Private Sub EnableLabels()
        Me.Label1.Enabled = True
        Me.Label2.Enabled = True
        Me.Label3.Enabled = True
        Me.Label4.Enabled = True
        Me.Label5.Enabled = True
        Me.Label6.Enabled = True
        Me.LbWeight.Enabled = True
        Me.LbAmount.Enabled = True
        Me.LbAv.Enabled = True
    End Sub

    Private Sub NoValueReport()
        If Me.RbCustomer.Checked Then
            Me.GbReport.Text = Me.CbCustomer.SelectedText.ToString
        End If
        If Me.RbWire.Checked Then
            Me.GbReport.Text = Me.CbWire.SelectedText
        End If
        DisableLabels()
        Me.LbAv.Text = 0
        Me.LbAmount.Text = 0
        Me.LbWeight.Text = 0

    End Sub

    Private Sub RbWire_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbWire.CheckedChanged
        If Me.RbWire.Checked Then
            Me.CbWire.Enabled = True
        Else
            Me.CbWire.SelectedIndex = -1
            Me.CbWire.Enabled = False

        End If
    End Sub

    Private Sub RbCustomer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbCustomer.CheckedChanged
        If Me.RbCustomer.Checked Then
            Me.CbCustomer.Enabled = True
        Else
            Me.CbCustomer.SelectedIndex = -1
            Me.CbCustomer.Enabled = False

        End If
    End Sub

    Private Sub CbCustomer_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CbCustomer.SelectedIndexChanged
        If Me.CbCustomer.SelectedIndex = -1 Then
            Me.GbReport.Text = ""

            DisableLabels()
            Exit Sub
        End If
        Me.GbReport.Text = Me.CbCustomer.SelectedText.ToString
        Reportcustomer()
    End Sub

    Private Sub CbWire_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CbWire.SelectedIndexChanged
        If Me.CbWire.SelectedIndex = -1 Then
            Me.GbReport.Text = ""
            DisableLabels()
            Exit Sub
        End If
        Me.GbReport.Text = Me.CbWire.SelectedText.ToString
        ReportWire()
    End Sub

    Private Sub BtnViewAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnViewAll.Click
        frmViewAll1.ShowDialog()

    End Sub

    Private Sub RbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDate.CheckedChanged
        If Me.RbDate.Checked Then
            Me.GbDate.Enabled = True
            Me.CbYear.SelectedIndex = 0
        Else
            Me.CbMonth.SelectedIndex = -1
            Me.CbYear.SelectedIndex = -1
            Me.GbDate.Enabled = False
        End If
    End Sub

    Private Sub CbYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbYear.SelectedIndexChanged
        If Me.CbYear.SelectedIndex > -1 Then
            If Me.CbMonth.SelectedIndex > -1 Then
                reportDate()
            Else
                Me.CbMonth.Focus()

            End If
        End If
    End Sub

    Private Sub CbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbMonth.SelectedIndexChanged
        If Me.CbYear.SelectedIndex > -1 Then
            If Me.CbMonth.SelectedIndex > -1 Then
                reportDate()
            Else
                Me.CbMonth.Focus()

            End If
        End If
    End Sub

End Class