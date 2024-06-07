Imports System.IO
Public Class FormCalendar2

    'System IO used for file handling so it needs to be imported 

    Dim m1 As MsgBoxResult
    Dim filecalendar As String

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'Add or open an entry in the calendar, on the date selected by the user
        filecalendar = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        Try
            If File.Exists(filecalendar & ".txt") = True Then
                MonthCalendar1.Enabled = True
                MonthCalendar1.Hide()
                EntryText.Enabled = True
                EntryText.Show()
                btnSaveEntry.Enabled = True
                btnSaveEntry.Show()
                btnBack.Enabled = True
                btnBack.Show()
                EntryText.Text = File.ReadAllText(filecalendar & ".txt")
            Else
                m1 = MsgBox("Would you like to enter an entry for this date?", MsgBoxStyle.YesNo)
                If m1 = MsgBoxResult.Yes Then
                    MonthCalendar1.Enabled = False
                    MonthCalendar1.Hide()
                    EntryText.Enabled = True
                    EntryText.Show()
                    EntryText.Text = ""
                    btnSaveEntry.Enabled = True
                    btnSaveEntry.Show()
                    btnBack.Enabled = True
                    btnBack.Show()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Goes back to show the calendar by month
        EntryText.Enabled = False
        EntryText.Hide()
        btnSaveEntry.Enabled = False
        btnSaveEntry.Hide()
        btnBack.Enabled = False
        btnBack.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()

    End Sub

    Private Sub btnSaveEntry_Click(sender As Object, e As EventArgs) Handles btnSaveEntry.Click
        Try
            If EntryText.Text = "" Then
                If File.Exists(filecalendar & ".txt") = True Then
                    File.Delete(filecalendar & ".txt")
                End If
            End If
            If EntryText.Text.Length > 0 Then
                File.WriteAllText(filecalendar & ".txt", EntryText.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub FormCalendar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m2 As MsgBoxResult
        filecalendar = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        'If the todays date has any entries a message pops up asking the user if they would like to view it 
        If Date.Today = MonthCalendar1.TodayDate And File.Exists(filecalendar & ".txt") = True Then
            m2 = MsgBox("You have entries for today. Would you like to view them?", MsgBoxStyle.YesNo)
            If m2 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                EntryText.Enabled = True
                EntryText.Show()
                btnSaveEntry.Enabled = True
                btnSaveEntry.Show()
                btnBack.Enabled = True
                btnBack.Show()
                EntryText.Text = File.ReadAllText(filecalendar & ".txt")
            End If
        End If
    End Sub
End Class