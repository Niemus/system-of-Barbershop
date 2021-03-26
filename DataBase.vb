Imports System.Text

Public Class DataBase

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub DataBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "КлиентыDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
        Me.КлиентыTableAdapter.Fill(Me.КлиентыDataSet.Клиенты)

        Dim connection As New OleDb.OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=Клиенты.mdb")
        connection.Open()
        'создание объекта и передача ему SQL-командымии
        Dim command As New System.Data.OleDb.OleDbCommand("Select [ФИО],[Номер телефона], [Адрес], [Время посещения], [Заказ], [Стоимость] From [Клиенты]", connection)
        'Выполнение SQL-команды
        Dim datareader As OleDb.OleDbDataReader = command.ExecuteReader
        Dim datatable As New DataTable
        'Заполняем шапку таблицы
        datatable.Columns.Add(datareader.GetName(0))
        datatable.Columns.Add(datareader.GetName(1))
        datatable.Columns.Add(datareader.GetName(2))
        datatable.Columns.Add(datareader.GetName(3))
        datatable.Columns.Add(datareader.GetName(4))
        datatable.Columns.Add(datareader.GetName(5))

        While datareader.Read() = True
            'Заполняем ячейки таблицы
            datatable.Rows.Add(New String() {datareader.GetValue(0), datareader.GetValue(1), datareader.GetValue(2), datareader.GetValue(3), datareader.GetValue(4), datareader.GetValue(5)})
        End While
        datareader.Close() : connection.Close()
        DataGridView1.DataSource = datatable


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim Con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Клиенты.mdb; ")
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [Клиенты]", Con)
        da.Fill(ds, "Клиенты")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Клиенты"

    End Sub

    Private Sub AnomButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim Group As String = ""
        Dim Result As String = ""
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value = "" And row.Cells(2).Value = "" And row.Cells(3).Value = "" Then
                Group = row.Cells(0).Value
            Else
                Result &= Group & row.Cells(0).Value & " | " & row.Cells(1).Value & " | " & row.Cells(2).Value & " | " & row.Cells(3).Value & " | " & row.Cells(4).Value & " | " & row.Cells(5).Value & " | " & row.Cells(6).Value & " руб." & vbNewLine
            End If
        Next
        IO.File.WriteAllText("C:\Users\rasso\Desktop\Клиенты.txt", Result, Encoding.Default)
    End Sub
End Class