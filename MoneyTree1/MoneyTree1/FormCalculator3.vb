Public Class FormCalculator3
    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operations As Integer
    Dim operatorselector As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'If the Calculator text is not 0, then a one is added to it
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "1"
        Else
            DisplayCalc.Text = "1" 'If the calculator text is a 0 it is replaced with one
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "2"
        Else
            DisplayCalc.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "3"
        Else
            DisplayCalc.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "4"
        Else
            DisplayCalc.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "5"
        Else
            DisplayCalc.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "6"
        Else
            DisplayCalc.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "7"
        Else
            DisplayCalc.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "8"
        Else
            DisplayCalc.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "9"
        Else
            DisplayCalc.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If DisplayCalc.Text <> 0 Then
            DisplayCalc.Text += "0"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        DisplayCalc.Text = "0"
    End Sub

    Private Sub btnDecimalPoint_Click(sender As Object, e As EventArgs) Handles btnDecimalPoint.Click
        'if the text does not contain a decimal it can be added, you cannot have more than one decimal point in a number
        If Not (DisplayCalc.Text.Contains(".")) Then
            DisplayCalc.Text += "."
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstnum = DisplayCalc.Text
        DisplayCalc.Text = "0"
        operatorselector = True
        operations = 1 'operation 1 is +
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        firstnum = DisplayCalc.Text
        DisplayCalc.Text = "0"
        operatorselector = True
        operations = 2 'operation 2 is -
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        firstnum = DisplayCalc.Text
        DisplayCalc.Text = "0"
        operatorselector = True
        operations = 3 'operation 3 is *
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstnum = DisplayCalc.Text
        DisplayCalc.Text = "0"
        operatorselector = True
        operations = 4 'operation 4 is /
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operatorselector = True Then
            secondnum = DisplayCalc.Text
            Select Case operations
                Case 1 'Addition
                    DisplayCalc.Text = firstnum + secondnum
                Case 2 'Subtraction
                    DisplayCalc.Text = firstnum - secondnum
                Case 3 'Multiplication
                    DisplayCalc.Text = firstnum * secondnum
                Case 4 'Division
                    If secondnum = 0 Then
                        DisplayCalc.Text = "Math ERROR"
                    Else
                        DisplayCalc.Text = firstnum / secondnum
                    End If
            End Select
            operatorselector = False
        End If
    End Sub

End Class