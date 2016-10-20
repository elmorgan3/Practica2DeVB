Public Class Form2
    Private Sub BtnOrd_Click(sender As Object, e As EventArgs) Handles ButtonOrd.Click
        Dim numeros(7) As Integer, I, J, aux As Integer
        'cremaos la array y metemos los numeros que han introducido

        Try
            numeros(0) = TextBox1.Text
            TextBox1.BackColor = Color.White

        Catch
            TextBox1.Focus()
            TextBox1.BackColor = Color.Red
            MsgBox("Hay un error en el numero 1")
            Exit Sub
        End Try


        Try
            numeros(1) = TextBox2.Text
            TextBox2.BackColor = Color.White

        Catch
            TextBox2.Focus()
            TextBox2.BackColor = Color.Red
            MsgBox("Hay un error en el numero 2")
            Exit Sub
        End Try


        Try
            numeros(2) = TextBox3.Text
            TextBox3.BackColor = Color.White

        Catch
            TextBox3.Focus()
            TextBox3.BackColor = Color.Red
            MsgBox("Hay un error en el numero 3")
            Exit Sub
        End Try

        Try
            numeros(3) = TextBox4.Text
            TextBox4.BackColor = Color.White

        Catch
            TextBox4.Focus()
            TextBox4.BackColor = Color.Red
            MsgBox("Hay un error en el numero 4")
            Exit Sub
        End Try


        Try

            numeros(4) = TextBox5.Text
            TextBox5.BackColor = Color.White

        Catch
            TextBox5.Focus()
            TextBox5.BackColor = Color.Red
            MsgBox("Hay un error en el numero 5")
            Exit Sub
        End Try


        Try

            numeros(5) = TextBox6.Text
            TextBox6.BackColor = Color.White

        Catch
            TextBox6.Focus()
            TextBox6.BackColor = Color.Red
            MsgBox("Hay un error en el numero 6")
            Exit Sub
        End Try


        Try

            numeros(6) = TextBox7.Text
            TextBox7.BackColor = Color.White

        Catch
            TextBox7.Focus()
            TextBox7.BackColor = Color.Red
            MsgBox("Hay un error en el numero 7")
            Exit Sub
        End Try


        Try

            numeros(7) = TextBox8.Text
            TextBox8.BackColor = Color.White

        Catch
            TextBox8.Focus()
            TextBox8.BackColor = Color.Red
            MsgBox("Hay un error en el numero 8")

            Exit Sub
        End Try





        'Hacemos un bucle dentro para otro para ordenar todos los numeros
        If (RadioButton_Asc.Checked = True) Then
            For I = 0 To 7
                For J = 0 To 7
                    If numeros(I) < numeros(J) Then
                        aux = numeros(J)
                        numeros(J) = numeros(I)
                        numeros(I) = aux
                    End If
                Next J
            Next I



        ElseIf (RadioButton_Asc.Checked = False) Then
            For I = 0 To 7
                For J = 0 To 7
                    If numeros(I) > numeros(J) Then
                        aux = numeros(J)
                        numeros(J) = numeros(I)
                        numeros(I) = aux
                    End If
                Next J
            Next I


        End If

        TextBox1.Text = numeros(0)
        TextBox2.Text = numeros(1)
        TextBox3.Text = numeros(2)
        TextBox4.Text = numeros(3)
        TextBox5.Text = numeros(4)
        TextBox6.Text = numeros(5)
        TextBox7.Text = numeros(6)
        TextBox8.Text = numeros(7)
    End Sub

    Private Sub ButtonDivisibles_Click(sender As Object, e As EventArgs) Handles ButtonDivisibles.Click
        Dim numDivisible, operacion, i As Double
        Dim numeros(7) As Integer
        Dim contador As Integer = 0
        'cremaos la array y metemos los numeros que han introducido
        numeros(0) = TextBox1.Text
        numeros(1) = TextBox2.Text
        numeros(2) = TextBox3.Text
        numeros(3) = TextBox4.Text
        numeros(4) = TextBox5.Text
        numeros(5) = TextBox6.Text
        numeros(6) = TextBox7.Text
        numeros(7) = TextBox8.Text

        'Ahora comprobamos que el numero que han introduido no en un 0
        If (TextBoxDivisor.Text = "0" Or TextBoxDivisor.Text = "") Then
            MsgBox("No se puede divir entre cero")
        Else
            If (TextBoxDivisor.Text <> "0") Then
                For i = 0 To 7
                    operacion = numeros(i) / TextBoxDivisor.Text
                    If numeros(i) Mod TextBoxDivisor.Text = 0 Then
                        contador = contador + 1
                    End If
                Next i
            End If
        End If
        'Mostramos en un msgBox cuantos ha habido
        MsgBox(contador)

    End Sub

    Private Sub ButtonDia_Click(sender As Object, e As EventArgs) Handles ButtonDia.Click
        If TextBoxMes.Text = "1" Or TextBoxMes.Text = "3" Or TextBoxMes.Text = "5" Or TextBoxMes.Text = "7" Or TextBoxMes.Text = "8" Or TextBoxMes.Text = "10" Or TextBoxMes.Text = "12" Then
            MsgBox("31")

        ElseIf TextBoxMes.Text = "4" Or TextBoxMes.Text = "6" Or TextBoxMes.Text = "9" Or TextBoxMes.Text = "11" Then
            MsgBox("30")
        ElseIf TextBoxMes.Text = "2" Then
            MsgBox("28")
        Else
            MsgBox("No existe el mes indicado")
        End If
    End Sub
End Class
