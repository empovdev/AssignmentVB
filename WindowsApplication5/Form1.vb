Imports System.Data.SqlClient
Public Class Form1
    Dim connection As New SqlConnection("Server=LAPTOP-9A6706AP; Database = InventoryMn; Integrated Security = true")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim i As Integer
    Dim result As Integer

    Private Sub loadData(sql As String, dtg As DataGridView)
        Try
            connection.Open()
            cmd = New SqlCommand()
            da = New SqlDataAdapter
            dt = New DataTable

            With cmd
                .Connection = connection
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub saveData(sql As String)
        Try
            connection.Open()
            cmd = New SqlCommand()

            With cmd
                .Connection = connection
                .CommandText = sql
                result = .ExecuteNonQuery()
            End With

            If result > 0 Then
                MsgBox("Data has been saved in the database!")
            Else
                MsgBox("Error to execute the query!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            MsgBox("Connection Open!")
            connection.Close()
        Catch ex As Exception
            MsgBox("Can not open connection!")
        End Try
    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        sql = "INSERT INTO tblperson (Fname,Lname) values ('" & txtfname.Text & "','" & txtlname.Text & "')"
        saveData(sql)


        sql = "SELECT Fname as Firstname, Lname as Lastname FROM tblperson"
        loadData(sql, dtgList)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT Fname as Firstname, Lname as Lastname FROM tblperson"
        loadData(sql, dtgList)
    End Sub

End Class
