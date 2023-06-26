Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PlaceholderText = "Сумма вклада"
        TextBox2.PlaceholderText = "Процент"
        TextBox3.PlaceholderText = "Срок"
        Button1.Text = "Рассчитать"
        With ListView1
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Год")
            .Columns.Add("Сумма")
        End With
        Maximum()
    End Sub

    Private Sub Calc(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P = Val(TextBox1.Text)
        Dim r = Val(TextBox2.Text) / 100
        Dim n = Val(TextBox3.Text)
        ListView1.Items.Add(New ListViewItem({0, P}))
        For i = 1 To n
            Dim A = P * Math.Pow(1 + r / 12, i * 12)
            ListView1.Items.Add(New ListViewItem({i, A}))
        Next i

    End Sub
    Sub Maximum()
        Dim X As Single, Y As Single, Max As Single
        X = InputBox("Введите первое число", "Ввод чисел для сравнения")
        Y = InputBox("Введите второе число", "Ввод чисел для сравнения")
        Select Case X > Y
            Case True
                Max = X
            Case False
                Max = Y
        End Select
        MsgBox("Наибольшее из двух чисел: " & Max, , "Результат сравнения")
    End Sub

    ''' <summary>
    ''' Пример алгоритма с Case"
    ''' </summary>
    Sub Goroskop()
        Dim Year As Integer
        Year = InputBox("Введите год", "Организация ввода")
        Select Case Year Mod 12
            Case 0
                MsgBox("Год Обезьяны", , "Результат")
            Case 1
                MsgBox("Год Петуха", , "Результат")
            Case 2
                MsgBox("Год Собаки", , "Результат")
            Case 3
                MsgBox("Год Свиньи", , "Результат")
            Case 4
                MsgBox("Год Крысы", , "Результат")
            Case 5
                MsgBox("Год Коровы", , "Результат")
            Case 6
                MsgBox("Год Тигра", , "Результат")
            Case 7
                MsgBox("Год Зайца", , "Результат")
            Case 8
                MsgBox("Год Дракона", , "Результат")
            Case 9
                MsgBox("Год Змеи", , "Результат")
            Case 10
                MsgBox("Год Лошади", , "Результат")
            Case 11
                MsgBox("Год Овцы", , "Результат")
            Case 12
        End Select
    End Sub
End Class
