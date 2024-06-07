Imports MySql.Data.MySqlClient

Public Class FormCalendar
    Private Sub btnAddToCalendar_Click(sender As Object, e As EventArgs) Handles btnAddToCalendar.Click
        FormAddToCalendar.Show()
    End Sub

    Private Sub FormCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDayPanels(42)
    End Sub

    Private Sub CreateDayPanels(ByVal DaysAmount As Integer)
        For a As Integer = 1 To DaysAmount
            Dim FlowL As New FlowLayoutPanel
            FlowL.Name = $"FlowLayoutPanel2{a}"
            FlowL.Size = New Size(210, 182)
            FlowL.BackColor = Color.White
            FlowL.BorderStyle = BorderStyle.FixedSingle
            FlowLayoutPanel2.Controls.Add(FlowL)
        Next
    End Sub

End Class