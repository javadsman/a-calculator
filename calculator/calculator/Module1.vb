Module Module1
    Sub showvalue(ByVal butt As Button)
        If form1.clearorder = False Then

            form1.TextBox1.Text = Val(form1.TextBox1.Text & butt.Text)
        ElseIf form1.clearorder = True Then
            form1.TextBox1.Clear()
            form1.clearorder = False
            form1.TextBox1.Text = Val(form1.TextBox1.Text & butt.Text)
        End If

    End Sub
    Sub operations(ByVal butt As Button)
        form1.value1 = Val(form1.TextBox1.Text)
        form1.oper = butt.Text
        form1.TextBox1.Text = ""
    End Sub
    Sub calculate()
        Select Case form1.oper
            Case "+"
                form1.TextBox1.Text = form1.value1 + Val(form1.TextBox1.Text)
            Case "-"
                form1.TextBox1.Text = form1.value1 - Val(form1.TextBox1.Text)
            Case "÷"
                form1.TextBox1.Text = form1.value1 / Val(form1.TextBox1.Text)
            Case "x"
                form1.TextBox1.Text = form1.value1 * Val(form1.TextBox1.Text)
        End Select
    End Sub
    Sub history()
        If form1.radical = False Then
            If form1.devide = False Then
                form1.TextBox2.Text =
                form1.value1 & form1.oper & form1.value2 & "=" & form1.TextBox1.Text & vbCrLf &
                form1.TextBox2.Text
            End If
        End If


        If form1.radical = True Then
                form1.TextBox2.Text =
                form1.oper & form1.value1 & "=" & form1.TextBox1.Text & vbCrLf &
                form1.TextBox2.Text
                form1.radical = False

            ElseIf form1.devide = True Then
            form1.TextBox2.Text =
        "1" & "÷" & form1.value5 & "=" & form1.TextBox1.Text & vbCrLf &
        form1.TextBox2.Text
            form1.devide = False
            form1.value5 = Nothing

        End If


    End Sub
    Sub operations2(ByVal butt As Button)
        form1.value1 = Val(form1.TextBox1.Text)
        form1.oper = butt.Text

    End Sub
End Module
