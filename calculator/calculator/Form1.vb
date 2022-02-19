Public Class form1
    Public value1 As Double
    Public oper As String
    Public value2 As Double
    Public value3 As Double
    Public value4 As Double
    Public value5 As Double
    Public clearorder As Boolean
    Public radical As Boolean
    Public devide As Boolean


    ' continue from module for history

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showvalue(Button1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showvalue(Button3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        showvalue(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        showvalue(Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        showvalue(Button6)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        showvalue(Button7)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        showvalue(Button8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        showvalue(Button9)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        showvalue(Button10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showvalue(Button2)
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        operations(Button13)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        operations(Button14)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        operations(Button16)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        operations(Button15)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        value2 = Val(TextBox1.Text)
        clearorder = True
        calculate()
        history()

        value2 = 0
        If TextBox1.Text = "∞" Then
            TextBox1.Text = "ERROR"
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text = TextBox1.Text & "."
        End If


    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        operations2(Button27)
        value3 = TextBox1.Text
        TextBox1.Text = TextBox1.Text / 100
        operations(Button14)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = ""
        value1 = Nothing
        value2 = Nothing
        Timer1.Enabled = False

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text <> Nothing Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        Else
            TextBox1.Text = Nothing
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        operations2(Button17)
        If value4 = Nothing Then
            If TextBox1.Text <> Nothing Then value4 = Val(TextBox1.Text)
            TextBox1.Text = ""
        ElseIf TextBox1.Text = Nothing Then

        End If
        If value4 <> Nothing Then
            If TextBox1.Text = Nothing Then
                TextBox1.Text = value4
                TextBox1.Text = ""
            ElseIf TextBox1.Text <> Nothing Then
                value4 = Val(TextBox1.Text)
            End If
            Label2.Text = value4
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        value4 = Nothing
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        operations2(Button21)
        If value4 <> Nothing Then
            TextBox1.Text = value4 + TextBox1.Text
            history()
        ElseIf value4 = Nothing Then


        End If


    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        operations2(Button22)

        If value4 <> Nothing Then
            TextBox1.Text = value4 - TextBox1.Text
            history()
        ElseIf value4 = Nothing Then

        End If

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        value1 = Nothing
        value2 = Nothing
        value3 = Nothing
        value4 = Nothing
        value5 = Nothing
        clearorder = False
        radical = False
        devide = False

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        devide = True
        value5 = Val(TextBox1.Text)

        TextBox1.Text = 1 / Val(TextBox1.Text)
        clearorder = True
        history()

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        operations2(Button25)
        TextBox1.Text = Val(TextBox1.Text) * (-1)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        operations2(Button24)
        radical = True
        If TextBox1.Text = True Then
            TextBox1.Text = Val(TextBox1.Text) ^ (1 / 2)
        ElseIf TextBox1.Text = False Then



        End If
        clearorder = True
        history()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
