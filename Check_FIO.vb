Module Check_FIO
    Public Function FIO_Proverka(ByVal TextField As TextBox) As Boolean
        Dim s, b, a As String                                                              'Объявление переменной s
        If TextField.Text = "" Then
            FIO_Proverka = False
            MsgBox("Введите ФИО!", vbCritical, "Ошибка")
            Exit Function
        Else
            For I = 1 To Len(TextField.Text)                                            'Цикл повторяется в зависимости от длины строки
                s = Mid(TextField.Text, I, 1)                                          'Присвоить переменной s символ с индексом i
            Next
            If ((s Like "[а-яА-Я .]")) Then                                               'Если s это русская буква или цифра тогда условие выполняется
                FIO_Proverka = True                                               'Присвоить True
                'a = Mid(TextField.Text, 1, 1)                                           'Отделим первый символ строки и переведем в заглавную букву]
                'b = Mid(TextField.Text, 2)                                              'Отделим все остальне символы
                'TextField.Text = UCase(a) & LCase(b)                                    'Вернуть новую строку
            Else 'Иначе
                FIO_Proverka = False                                          'Присвоить False
                MsgBox("Пожалуйста, введите ФИО русскими буквами.", vbCritical, "Ошибка")          'Сообщение об ошибке
                TextField.Focus()                                                           'Передача фокуса полю
                TextField.Clear()
            End If
        End If
    End Function
End Module
