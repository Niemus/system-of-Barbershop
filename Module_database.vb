Imports System.Data.OleDb

Module Module_database
    Public Function Regf()

        Dim FIO As String
        Dim tel As String
        Dim adres As String
        Dim time As String
        Dim kod As String
        Dim sum As String


        FIO = Reg.TextBox1.Text
        tel = Reg.MaskedTextBox2.Text
        adres = Reg.TextBox3.Text
        time = Reg.MaskedTextBox1.Text
        kod = Reg.MaskedTextBox3.Text
        sum = Reg.TextBox6.Text



        Dim SozdOb As String
        'Создание объекта и передача ему строки соединения
        Dim Connection = New OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=Клиенты.mdb")
        Connection.Open()
        'создание объекта и присваивание ему SQL запроса
        SozdOb = "insert into [Клиенты](" & " [ФИО],[Номер телефона], [Адрес], [Время посещения], [Заказ], [Стоимость]) values ('" & FIO & "','" & tel & "','" & adres & "','" & time & "','" & kod & "','" & sum & "')"
        'создание объекта и передача ему SQL команды
        Dim command = New OleDbCommand(SozdOb)
        command.Connection = Connection
        Try
            'Выполнение SQL команды
            command.ExecuteNonQuery()
            MessageBox.Show("Данные занесены в базу!", "Запись добавленна.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Connection.Close()

    End Function
End Module
