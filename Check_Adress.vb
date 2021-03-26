Module Check_Adress
    Public Function Adress_Proverka(ByVal TextField As TextBox) As Boolean
        Dim s As String                                                              'Объявление переменной s
        If TextField.Text = "" Then
            Adress_Proverka = False
            MsgBox("Введите адрес!", vbCritical, "Ошибка")
            Exit Function
        Else
            For I = 1 To Len(TextField.Text)                                            'Цикл повторяется в зависимости от длины строки
                s = Mid(TextField.Text, I, 1)                                          'Присвоить переменной s символ с индексом i
            Next
            If ((s Like "[а-яА-Я .0-9]")) Then                                               'Если s это русская буква или цифра тогда условие выполняется
                Adress_Proverka = True                                               'Присвоить True
                'a = Mid(TextField.Text, 1, 1)                                           'Отделим первый символ строки и переведем в заглавную букву]
                'b = Mid(TextField.Text, 2)                                              'Отделим все остальне символы
                'TextField.Text = UCase(a) & LCase(b)                                    'Вернуть новую строку
            Else 'Иначе
                Adress_Proverka = False                                          'Присвоить False
                MsgBox("Пожалуйста, введите адрес русскими буквами.", vbCritical, "Ошибка")          'Сообщение об ошибке
                TextField.Focus()                                                           'Передача фокуса полю
                TextField.Clear()
            End If
        End If
    End Function
End Module
