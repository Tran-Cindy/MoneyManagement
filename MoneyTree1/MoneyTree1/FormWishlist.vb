Imports MySql.Data.MySqlClient
Public Class FormWishlist
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    Private Sub btnSaveWish_Click(sender As Object, e As EventArgs) Handles btnSaveWish.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.wishlistinfo (idwishlistinfo,wishname,wishamount,wishcategory,wishcurrency,wishdate) values('" & TBWishlistID.Text & "', '" & TBWishName.Text & "','" & TBWishAmount.Text & "', '" & TBWishCategory.Text & "', '" & WishDatePicker.Text & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Wishlist item saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnEditWish_Click(sender As Object, e As EventArgs) Handles btnEditWish.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.wishlistinfo set idwishlistinfo='" & TBWishlistID.Text & "',name='" & TBWishName.Text & "',amount='" & TBWishAmount.Text & "',category='" & TBWishCategory.Text & "',date='" & WishDatePicker.Text & "' where idtransactionsinfo='" & TBWishlistID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Wishlist item details edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnDeleteWish_Click(sender As Object, e As EventArgs) Handles btnDeleteWish.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "delete from moneytree.wishlistinfo where idwishlistinfo='" & TBWishlistID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Wishlist item deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub
End Class