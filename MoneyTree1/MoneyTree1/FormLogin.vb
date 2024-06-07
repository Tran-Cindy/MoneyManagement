Imports MySql.Data.MySqlClient
Public Class FormLogin
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader


        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "select * from moneytree.logininfo where idlogininfo = '" & TBID.Text & "' and username = '" & TB_Username.Text & "' and password = '" & TB_Password.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            Dim count As Integer
            While sqlReader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Logging in...")
                FormHomescreen.Show()
            Else
                MessageBox.Show("Incorrect username, password or ID, please re-enter.")
            End If
            If TBID.Text = "" Then
                MessageBox.Show("ID can not be left blank.")
            End If
            If TB_Username.Text = "" Then
                MessageBox.Show("Username can not be left blank")
            End If
            If TB_Password.Text = "" Then
                MessageBox.Show("Password can not be left blank")
            End If


            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            'Dispose of the query now that the operation is done
            sqlconn.Dispose()
        End Try
    End Sub

    'Animating the coins 
    Private Sub CoinMover1_Tick(sender As Object, e As EventArgs) Handles CoinMover1.Tick

        Dim CoinsArray(9) As PictureBox

        'All the picture boxes for the coins are assigned to the array coins
        CoinsArray(0) = PBCoin1
        CoinsArray(1) = PBCoin2
        CoinsArray(2) = PBCoin3
        CoinsArray(3) = PBCoin4
        CoinsArray(4) = PBCoin5
        CoinsArray(5) = PBCoin6
        CoinsArray(6) = PBCoin7
        CoinsArray(7) = PBCoin8
        CoinsArray(8) = PBCoin9
        CoinsArray(9) = PBCoin10

        'for loop then moves all the picture boxes at the same speed
        For x As Integer = 0 To 9
            CoinsArray(x).Top += 3
            If CoinsArray(x).Top >= Me.Height Then
                CoinsArray(x).Top = -CoinsArray(x).Height
            End If
        Next

    End Sub
End Class