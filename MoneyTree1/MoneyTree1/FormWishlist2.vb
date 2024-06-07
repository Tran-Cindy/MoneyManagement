Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class FormWishlist2
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand
    Private Sub btnSaveWish_Click(sender As Object, e As EventArgs) Handles btnSaveWish.Click
        'Connects to the database moneytree
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.wishlistinfo (idwishlistinfo,wishname,wishamount,wishcategory,wishdate) values('" & TBWishlistID.Text & "', '" & TBWishName.Text & "','" & TBWishAmount.Text & "', '" & TBWishCategory.Text & "', '" & WishDatePicker.Text & "')"
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
    'Edit a wishlist entry
    Private Sub btnEditWish_Click(sender As Object, e As EventArgs) Handles btnEditWish.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.wishlistinfo set idwishlistinfo='" & TBWishlistID.Text & "',wishname='" & TBWishName.Text & "',wishamount='" & TBWishAmount.Text & "',wishcategory='" & TBWishCategory.Text & "',wishdate='" & WishDatePicker.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Wishlist data edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Delete a wishlist entry depending the wishlist ID the user enters 
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
            MessageBox.Show("Wishlist data deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'Clear all boxes to input text
    Private Sub Clear()
        TBWishlistID.Text = ""
        TBWishName.Text = ""
        TBWishAmount.Text = ""
        TBWishCategory.Text = ""
        WishDatePicker.ResetText()
    End Sub
    Private Sub btnClearWish_Click(sender As Object, e As EventArgs) Handles btnClearWish.Click
        Clear()
    End Sub

    Private Sub FormWishlist2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'As the form loads the datagridview also loads whatever data is contained within it 
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim WishlistDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.wishlistinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(WishlistDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = WishlistDataSet
            DGVWishlist.DataSource = bSource
            sqlAdapter.Update(WishlistDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim WishlistDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.wishlistinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(WishlistDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = WishlistDataSet
            DGVWishlist.DataSource = bSource
            sqlAdapter.Update(WishlistDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub DGVInvestments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVWishlist.CellClick
        'Fills the textbox with a wishlist item clicked 
        If e.RowIndex >= 0 Then

            Dim Row As DataGridViewRow
            Row = Me.DGVWishlist.Rows(e.RowIndex)

            TBWishlistID.Text = Row.Cells("idwishlistinfo").Value.ToString
            TBWishName.Text = Row.Cells("wishname").Value.ToString
            TBWishAmount.Text = Row.Cells("wishamount").Value.ToString
            TBWishCategory.Text = Row.Cells("wishcategory").Value.ToString
            WishDatePicker.Text = Row.Cells("wishdate").Value.ToString

        End If
    End Sub

    Private Sub btnWishSearch_Click(sender As Object, e As EventArgs) Handles btnWishSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim WishlistSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar)
            sqlQuery = "select * from moneytree.wishlistinfo where idwishlistinfo = '" & TBWishSearch.Text & "' or wishname = '" & TBWishSearch.Text & "' or wishamount = '" & TBWishSearch.Text & "' or wishcategory = '" & TBWishSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(WishlistSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = WishlistSearchDataSet
            DGVWishlist.DataSource = b2Source
            sqlAdapter.Update(WishlistSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnWishDateSearch_Click(sender As Object, e As EventArgs) Handles btnWishDateSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim WishlistDateSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            sqlQuery = "select * from moneytree.wishlistinfo where wish = '" & TBWishDateSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(WishlistDateSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = WishlistDateSearchDataSet
            DGVWishlist.DataSource = b2Source
            sqlAdapter.Update(WishlistDateSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    ' For typing items into a list for printing 
    Private Sub InputItem_TextChanged(sender As Object, e As EventArgs) Handles InputItem.TextChanged
        'To cause the cursor to be automatically at the textbox to input
        InputItem.Focus()
    End Sub
    'Add an item to the list for printing
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'Causes the item added to go into the next line
        TBList.Text = InputItem.Text & Environment.NewLine & TBList.Text
        'Clears the textbox to input a new item to the list
        InputItem.Clear()
        InputItem.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the textbox and the list 
        InputItem.Text = ""
        TBList.Text = ""
    End Sub
    'Print the list out, connected to a default printer on the users device 
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub
    'Format of the page printed 
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Wishlist", New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 25)
        e.Graphics.DrawString("--------------------------------", New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 45)
        e.Graphics.DrawString(TBList.Text, New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 25)
    End Sub
End Class