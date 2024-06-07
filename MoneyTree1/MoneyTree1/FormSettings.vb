Imports System.Windows.Forms.DataVisualization.Charting
Imports Tulpep.NotificationWindow
Public Class FormSettings

    'For the blue theme
    Private Sub btnThemeBlue_Click(sender As Object, e As EventArgs) Handles btnThemeBlue.Click

        'Changing the colours and button colours of form1 
        FormHomescreen.BackColor = Color.LightBlue 'Changing the background colour of the form LightSeaGreen --> LightBlue
        FormHomescreen.LblFromDate.ForeColor = Color.CornflowerBlue
        FormHomescreen.Label1.ForeColor = Color.CornflowerBlue
        FormHomescreen.btnSettings.BackColor = Color.LightBlue
        FormHomescreen.Panel1.BackColor = Color.Snow
        FormHomescreen.Lbl_TotalIncome.ForeColor = Color.Snow
        FormHomescreen.Lbl_TotalExpense.ForeColor = Color.Snow
        FormHomescreen.btnCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png") 'Using a sky blue theme button instead of a teal one (the default)
        FormHomescreen.btnWishlist.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.btnBillCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.btnTransactions.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.btnBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.btnInvestments.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.btnLoadChart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormHomescreen.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendarblue.png")
        FormHomescreen.ChartExpense.Palette = ChartColorPalette.BrightPastel
        FormHomescreen.PBTree.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\wintertree.png")
        FormHomescreen.PBTree2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\wintertree.png")

        'FormCalculator - for calculating bills
        FormCalculator.BackColor = Color.LightBlue
        FormCalculator.TabPage1.BackColor = Color.Snow
        FormCalculator.TabPage2.BackColor = Color.Snow
        FormCalculator.TabPage3.BackColor = Color.Snow
        FormCalculator.TabPage4.BackColor = Color.Snow
        FormCalculator.TabPage5.BackColor = Color.Snow
        FormCalculator.TabPage6.BackColor = Color.Snow
        FormCalculator.btnSaveBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnEditBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnDeleteBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnGenReceipt.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnCalcMonthly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnCalcYearly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnClearMonthTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnClearYearTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnBillSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnBillDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnRefreshDGVBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.btnClearBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalculator.LblBillID.ForeColor = Color.CornflowerBlue
        FormCalculator.LblRent.ForeColor = Color.CornflowerBlue
        FormCalculator.LblWater.ForeColor = Color.CornflowerBlue
        FormCalculator.LblMobile.ForeColor = Color.CornflowerBlue
        FormCalculator.LblElectricity.ForeColor = Color.CornflowerBlue
        FormCalculator.LblGas.ForeColor = Color.CornflowerBlue
        FormCalculator.LblDate.ForeColor = Color.CornflowerBlue
        FormCalculator.Label1.ForeColor = Color.CornflowerBlue
        FormCalculator.Label3.ForeColor = Color.CornflowerBlue
        FormCalculator.Label4.ForeColor = Color.CornflowerBlue
        FormCalculator.Label5.ForeColor = Color.CornflowerBlue
        FormCalculator.Label6.ForeColor = Color.CornflowerBlue
        FormCalculator.Label7.ForeColor = Color.CornflowerBlue
        FormCalculator.LblBSearch.ForeColor = Color.CornflowerBlue
        FormCalculator.LblBDateSearch.ForeColor = Color.CornflowerBlue
        FormCalculator.LblCouncilTax.ForeColor = Color.CornflowerBlue

        'FormCalendar2
        FormCalendar2.BackColor = Color.LightBlue
        FormCalendar2.btnSaveEntry.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalendar2.btnBack.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormCalendar2.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendarblue.png")
        FormCalendar2.PBCalendar.BackColor = Color.Transparent

        'FormInvestments
        FormInvestments.BackColor = Color.LightBlue
        FormInvestments.DGVInvestments.BackgroundColor = Color.Snow
        FormInvestments.Panel1.BackColor = Color.Snow
        FormInvestments.btnSaveInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnDeleteInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnEditInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnClearInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnInvCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnInvSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnInvDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormInvestments.LblInvID.ForeColor = Color.CornflowerBlue
        FormInvestments.LblSymbol.ForeColor = Color.CornflowerBlue
        FormInvestments.LblEntryDate.ForeColor = Color.CornflowerBlue
        FormInvestments.LblEntryPrice.ForeColor = Color.CornflowerBlue
        FormInvestments.LblShares.ForeColor = Color.CornflowerBlue
        FormInvestments.LblCurrentPrice.ForeColor = Color.CornflowerBlue
        FormInvestments.LblDifference.ForeColor = Color.CornflowerBlue
        FormInvestments.LblPercentageReturn.ForeColor = Color.CornflowerBlue
        FormInvestments.LblPL.ForeColor = Color.CornflowerBlue
        FormInvestments.LblInvSearch.ForeColor = Color.Snow
        FormInvestments.LblInvDateSearch.ForeColor = Color.Snow

        'FormTransactions
        FormTransactions.BackColor = Color.LightBlue
        FormTransactions.Panel1.BackColor = Color.Snow
        FormTransactions.DGVTransactions.BackgroundColor = Color.Snow
        FormTransactions.btnSaveT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btnEditT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btnDeleteT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btnClearT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.Button4.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btn_Search.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btn_DateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btn_CalculateEI.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.btnShowTable.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormTransactions.LblTransactionsID.ForeColor = Color.CornflowerBlue
        FormTransactions.LblName.ForeColor = Color.CornflowerBlue
        FormTransactions.LblAmount.ForeColor = Color.CornflowerBlue
        FormTransactions.LblIncomeOrExpense.ForeColor = Color.CornflowerBlue
        FormTransactions.LblCategory.ForeColor = Color.CornflowerBlue
        FormTransactions.LblCurrency.ForeColor = Color.CornflowerBlue
        FormTransactions.LblDate.ForeColor = Color.CornflowerBlue
        FormTransactions.LblSearch.ForeColor = Color.Snow
        FormTransactions.LblDateSearch.ForeColor = Color.Snow
        FormTransactions.Lbl_TotalIncome.ForeColor = Color.Snow
        FormTransactions.Lbl_TotalExpense.ForeColor = Color.Snow

        'FormWishlist2
        FormWishlist2.BackColor = Color.LightBlue
        FormWishlist2.TabPage1.BackColor = Color.Snow
        FormWishlist2.TabPage2.BackColor = Color.Snow
        FormWishlist2.DGVWishlist.BackgroundColor = Color.Snow
        FormWishlist2.btnSaveWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnEditWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnDeleteWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnClearWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnPrint.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnAddItem.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnWishSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnWishDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormWishlist2.LblWishID.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblWishName.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblWishAmount.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblWishCategory.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblWishDate.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblAddToList.ForeColor = Color.CornflowerBlue
        FormWishlist2.Panel1.BackColor = Color.CornflowerBlue
        FormWishlist2.LblList.ForeColor = Color.CornflowerBlue
        FormWishlist2.LblWishSearch.ForeColor = Color.Snow
        FormWishlist2.LblWishDateSearch.ForeColor = Color.Snow

        'FormBudget
        FormBudget.BackColor = Color.LightBlue
        FormBudget.Panel1.BackColor = Color.Snow
        FormBudget.DGVBudgets.BackgroundColor = Color.Snow
        FormBudget.TabPage2.BackColor = Color.Snow
        FormBudget.btnSaveBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnEditBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnDeleteBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnBudgetSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnBudgetDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnCalcBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.btnCalcBudget2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        FormBudget.LblBudgetID.ForeColor = Color.CornflowerBlue
        FormBudget.LblTodaysDate.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetTitle.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetAmount.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetID.ForeColor = Color.CornflowerBlue
        FormBudget.GroupBox1.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetCalc.ForeColor = Color.CornflowerBlue
        FormBudget.LblBAmount.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetStart.ForeColor = Color.CornflowerBlue
        FormBudget.LblEndDate.ForeColor = Color.CornflowerBlue
        FormBudget.LblAmountSpentFBudget.ForeColor = Color.CornflowerBlue
        FormBudget.LblBudgetSearch.ForeColor = Color.Snow
        FormBudget.LblBudgetDateSearch.ForeColor = Color.Snow

        'FormSettings
        Me.BackColor = Color.LightBlue
        Me.PanelThemeButtons.BackColor = Color.Snow
        Me.PanelNotif.BackColor = Color.Snow
        Me.LblChangeTheme2.ForeColor = Color.CornflowerBlue
        Me.LblCurrentTime.ForeColor = Color.CornflowerBlue
        Me.LblTime.ForeColor = Color.CornflowerBlue
        Me.LblReminderMsg.ForeColor = Color.CornflowerBlue
        Me.NotifTimeSetByUser.ForeColor = Color.CornflowerBlue
        Me.btnThemeBlue.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        Me.btnThemeGreen.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        Me.btnThemePink.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        Me.btnStart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")
        Me.btnStop.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\bluethemebutton.png")

    End Sub

    'For the green theme
    Private Sub btnThemeGreen_Click(sender As Object, e As EventArgs) Handles btnThemeGreen.Click

        'Changing the colours and button colours of form1 
        FormHomescreen.BackColor = Color.SeaGreen
        FormHomescreen.LblFromDate.ForeColor = Color.SeaGreen
        FormHomescreen.Label1.ForeColor = Color.SeaGreen
        FormHomescreen.btnSettings.BackColor = Color.SeaGreen
        FormHomescreen.Panel1.BackColor = Color.MintCream
        FormHomescreen.Lbl_TotalIncome.ForeColor = Color.MintCream
        FormHomescreen.Lbl_TotalExpense.ForeColor = Color.MintCream
        FormHomescreen.btnCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnWishlist.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnBillCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnTransactions.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnInvestments.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.btnLoadChart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormHomescreen.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendargreen.png")
        FormHomescreen.PBTree.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\cherry-blossom.png")
        FormHomescreen.PBTree2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\cherry-blossom2.png")

        'FormCalculator
        FormCalculator.BackColor = Color.SeaGreen
        FormCalculator.TabPage1.BackColor = Color.MintCream
        FormCalculator.TabPage2.BackColor = Color.MintCream
        FormCalculator.TabPage3.BackColor = Color.MintCream
        FormCalculator.TabPage4.BackColor = Color.MintCream
        FormCalculator.TabPage5.BackColor = Color.MintCream
        FormCalculator.TabPage6.BackColor = Color.MintCream
        FormCalculator.btnSaveBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnEditBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnDeleteBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnGenReceipt.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnCalcMonthly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnCalcYearly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnClearMonthTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnClearYearTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnBillSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnBillDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnRefreshDGVBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.btnClearBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalculator.LblBillID.ForeColor = Color.SeaGreen
        FormCalculator.LblRent.ForeColor = Color.SeaGreen
        FormCalculator.LblWater.ForeColor = Color.SeaGreen
        FormCalculator.LblMobile.ForeColor = Color.SeaGreen
        FormCalculator.LblElectricity.ForeColor = Color.SeaGreen
        FormCalculator.LblGas.ForeColor = Color.SeaGreen
        FormCalculator.LblDate.ForeColor = Color.SeaGreen
        FormCalculator.Label1.ForeColor = Color.SeaGreen
        FormCalculator.Label3.ForeColor = Color.SeaGreen
        FormCalculator.Label4.ForeColor = Color.SeaGreen
        FormCalculator.Label5.ForeColor = Color.SeaGreen
        FormCalculator.Label6.ForeColor = Color.SeaGreen
        FormCalculator.Label7.ForeColor = Color.SeaGreen
        FormCalculator.LblBSearch.ForeColor = Color.SeaGreen
        FormCalculator.LblBDateSearch.ForeColor = Color.SeaGreen
        FormCalculator.LblCouncilTax.ForeColor = Color.SeaGreen

        'FormCalendar2
        FormCalendar2.BackColor = Color.SeaGreen
        FormCalendar2.btnSaveEntry.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalendar2.btnBack.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormCalendar2.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendargreen.png")
        FormCalendar2.PBCalendar.BackColor = Color.Transparent

        'FormInvestments
        FormInvestments.BackColor = Color.SeaGreen
        FormInvestments.DGVInvestments.BackgroundColor = Color.MintCream
        FormInvestments.Panel1.BackColor = Color.MintCream
        FormInvestments.btnSaveInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnDeleteInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnEditInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnClearInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnInvCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnInvSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnInvDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormInvestments.LblInvID.ForeColor = Color.SeaGreen
        FormInvestments.LblSymbol.ForeColor = Color.SeaGreen
        FormInvestments.LblEntryDate.ForeColor = Color.SeaGreen
        FormInvestments.LblEntryPrice.ForeColor = Color.SeaGreen
        FormInvestments.LblShares.ForeColor = Color.SeaGreen
        FormInvestments.LblCurrentPrice.ForeColor = Color.SeaGreen
        FormInvestments.LblDifference.ForeColor = Color.SeaGreen
        FormInvestments.LblPercentageReturn.ForeColor = Color.SeaGreen
        FormInvestments.LblPL.ForeColor = Color.SeaGreen
        FormInvestments.LblInvSearch.ForeColor = Color.MintCream
        FormInvestments.LblInvDateSearch.ForeColor = Color.MintCream

        'FormTransactions
        FormTransactions.BackColor = Color.SeaGreen
        FormTransactions.Panel1.BackColor = Color.MintCream
        FormTransactions.DGVTransactions.BackgroundColor = Color.MintCream
        FormTransactions.btnSaveT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btnEditT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btnDeleteT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btnClearT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.Button4.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btn_Search.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btn_DateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btn_CalculateEI.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.btnShowTable.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormTransactions.LblTransactionsID.ForeColor = Color.SeaGreen
        FormTransactions.LblName.ForeColor = Color.SeaGreen
        FormTransactions.LblAmount.ForeColor = Color.SeaGreen
        FormTransactions.LblIncomeOrExpense.ForeColor = Color.SeaGreen
        FormTransactions.LblCategory.ForeColor = Color.SeaGreen
        FormTransactions.LblCurrency.ForeColor = Color.SeaGreen
        FormTransactions.LblDate.ForeColor = Color.SeaGreen
        FormTransactions.LblSearch.ForeColor = Color.MintCream
        FormTransactions.LblDateSearch.ForeColor = Color.MintCream
        FormTransactions.Lbl_TotalIncome.ForeColor = Color.MintCream
        FormTransactions.Lbl_TotalExpense.ForeColor = Color.MintCream

        'FormWishlist2
        FormWishlist2.BackColor = Color.SeaGreen
        FormWishlist2.TabPage1.BackColor = Color.MintCream
        FormWishlist2.TabPage2.BackColor = Color.MintCream
        FormWishlist2.DGVWishlist.BackgroundColor = Color.MintCream
        FormWishlist2.btnSaveWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnEditWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnDeleteWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnClearWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnPrint.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnAddItem.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnWishSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnWishDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormWishlist2.LblWishID.ForeColor = Color.SeaGreen
        FormWishlist2.LblWishName.ForeColor = Color.SeaGreen
        FormWishlist2.LblWishAmount.ForeColor = Color.SeaGreen
        FormWishlist2.LblWishCategory.ForeColor = Color.SeaGreen
        FormWishlist2.LblWishDate.ForeColor = Color.SeaGreen
        FormWishlist2.LblAddToList.ForeColor = Color.SeaGreen
        FormWishlist2.Panel1.BackColor = Color.SeaGreen
        FormWishlist2.LblList.ForeColor = Color.SeaGreen
        FormWishlist2.LblWishSearch.ForeColor = Color.MintCream
        FormWishlist2.LblWishDateSearch.ForeColor = Color.MintCream

        'FormBudget
        FormBudget.BackColor = Color.SeaGreen
        FormBudget.Panel1.BackColor = Color.MintCream
        FormBudget.DGVBudgets.BackgroundColor = Color.MintCream
        FormBudget.TabPage2.BackColor = Color.MintCream
        FormBudget.btnSaveBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnEditBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnDeleteBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnBudgetSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnBudgetDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnCalcBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.btnCalcBudget2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        FormBudget.LblBudgetID.ForeColor = Color.SeaGreen
        FormBudget.LblTodaysDate.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetTitle.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetAmount.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetID.ForeColor = Color.SeaGreen
        FormBudget.GroupBox1.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetCalc.ForeColor = Color.SeaGreen
        FormBudget.LblBAmount.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetStart.ForeColor = Color.SeaGreen
        FormBudget.LblEndDate.ForeColor = Color.SeaGreen
        FormBudget.LblAmountSpentFBudget.ForeColor = Color.SeaGreen
        FormBudget.LblBudgetSearch.ForeColor = Color.MintCream
        FormBudget.LblBudgetDateSearch.ForeColor = Color.MintCream

        'FormSettings
        Me.BackColor = Color.SeaGreen
        Me.PanelThemeButtons.BackColor = Color.MintCream
        Me.PanelNotif.BackColor = Color.MintCream
        Me.LblChangeTheme2.ForeColor = Color.SeaGreen
        Me.LblCurrentTime.ForeColor = Color.SeaGreen
        Me.LblTime.ForeColor = Color.SeaGreen
        Me.LblReminderMsg.ForeColor = Color.SeaGreen
        Me.NotifTimeSetByUser.ForeColor = Color.SeaGreen
        Me.btnThemeBlue.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        Me.btnThemeGreen.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        Me.btnThemePink.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        Me.btnStart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")
        Me.btnStop.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\greenthemebutton.png")



    End Sub
    'For the pink theme

    Private Sub btnThemePink_Click(sender As Object, e As EventArgs) Handles btnThemePink.Click

        'Changing the colours and button colours of form1 
        FormHomescreen.BackColor = Color.PaleVioletRed
        FormHomescreen.LblFromDate.ForeColor = Color.PaleVioletRed
        FormHomescreen.Label1.ForeColor = Color.PaleVioletRed
        FormHomescreen.btnSettings.BackColor = Color.PaleVioletRed
        FormHomescreen.Panel1.BackColor = Color.MistyRose
        FormHomescreen.Lbl_TotalIncome.ForeColor = Color.MistyRose
        FormHomescreen.Lbl_TotalExpense.ForeColor = Color.MistyRose
        FormHomescreen.btnCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnWishlist.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnBillCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnTransactions.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnInvestments.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.btnLoadChart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormHomescreen.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendarpink.png")
        FormHomescreen.PBTree.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\sakurabranch.png")
        FormHomescreen.PBTree2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\sakurabranch2.png")

        'FormCalculator
        FormCalculator.BackColor = Color.PaleVioletRed
        FormCalculator.TabPage1.BackColor = Color.MistyRose
        FormCalculator.TabPage2.BackColor = Color.MistyRose
        FormCalculator.TabPage3.BackColor = Color.MistyRose
        FormCalculator.TabPage4.BackColor = Color.MistyRose
        FormCalculator.TabPage5.BackColor = Color.MistyRose
        FormCalculator.TabPage6.BackColor = Color.MistyRose
        FormCalculator.btnSaveBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnEditBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnDeleteBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnGenReceipt.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnCalcMonthly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnCalcYearly.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnClearMonthTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnClearYearTax.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnBillSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnBillDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnRefreshDGVBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.btnClearBill.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalculator.LblBillID.ForeColor = Color.PaleVioletRed
        FormCalculator.LblRent.ForeColor = Color.PaleVioletRed
        FormCalculator.LblWater.ForeColor = Color.PaleVioletRed
        FormCalculator.LblMobile.ForeColor = Color.PaleVioletRed
        FormCalculator.LblElectricity.ForeColor = Color.PaleVioletRed
        FormCalculator.LblGas.ForeColor = Color.PaleVioletRed
        FormCalculator.LblDate.ForeColor = Color.PaleVioletRed
        FormCalculator.Label1.ForeColor = Color.PaleVioletRed
        FormCalculator.Label3.ForeColor = Color.PaleVioletRed
        FormCalculator.Label4.ForeColor = Color.PaleVioletRed
        FormCalculator.Label5.ForeColor = Color.PaleVioletRed
        FormCalculator.Label6.ForeColor = Color.PaleVioletRed
        FormCalculator.Label7.ForeColor = Color.PaleVioletRed
        FormCalculator.LblBSearch.ForeColor = Color.PaleVioletRed
        FormCalculator.LblBDateSearch.ForeColor = Color.PaleVioletRed
        FormCalculator.LblCouncilTax.ForeColor = Color.PaleVioletRed

        'FormCalendar2
        FormCalendar2.BackColor = Color.PaleVioletRed
        FormCalendar2.btnSaveEntry.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalendar2.btnBack.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormCalendar2.PBCalendar.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\calendarpink.png")
        FormCalendar2.PBCalendar.BackColor = Color.Transparent

        'FormInvestments
        FormInvestments.BackColor = Color.PaleVioletRed
        FormInvestments.DGVInvestments.BackgroundColor = Color.MistyRose
        FormInvestments.Panel1.BackColor = Color.MistyRose
        FormInvestments.btnSaveInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnDeleteInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnEditInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnClearInv.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnInvCalculator.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnInvSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnInvDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormInvestments.LblInvID.ForeColor = Color.PaleVioletRed
        FormInvestments.LblSymbol.ForeColor = Color.PaleVioletRed
        FormInvestments.LblEntryDate.ForeColor = Color.PaleVioletRed
        FormInvestments.LblEntryPrice.ForeColor = Color.PaleVioletRed
        FormInvestments.LblShares.ForeColor = Color.PaleVioletRed
        FormInvestments.LblCurrentPrice.ForeColor = Color.PaleVioletRed
        FormInvestments.LblDifference.ForeColor = Color.PaleVioletRed
        FormInvestments.LblPercentageReturn.ForeColor = Color.PaleVioletRed
        FormInvestments.LblPL.ForeColor = Color.PaleVioletRed
        FormInvestments.LblInvSearch.ForeColor = Color.MistyRose
        FormInvestments.LblInvDateSearch.ForeColor = Color.MistyRose

        'FormTransactions
        FormTransactions.BackColor = Color.PaleVioletRed
        FormTransactions.Panel1.BackColor = Color.MistyRose
        FormTransactions.DGVTransactions.BackgroundColor = Color.MistyRose
        FormTransactions.btnSaveT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btnEditT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btnDeleteT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btnClearT.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.Button4.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btn_Search.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btn_DateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btn_CalculateEI.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.btnShowTable.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormTransactions.LblTransactionsID.ForeColor = Color.PaleVioletRed
        FormTransactions.LblName.ForeColor = Color.PaleVioletRed
        FormTransactions.LblAmount.ForeColor = Color.PaleVioletRed
        FormTransactions.LblIncomeOrExpense.ForeColor = Color.PaleVioletRed
        FormTransactions.LblCategory.ForeColor = Color.PaleVioletRed
        FormTransactions.LblCurrency.ForeColor = Color.PaleVioletRed
        FormTransactions.LblDate.ForeColor = Color.PaleVioletRed
        FormTransactions.LblSearch.ForeColor = Color.MistyRose
        FormTransactions.LblDateSearch.ForeColor = Color.MistyRose
        FormTransactions.Lbl_TotalIncome.ForeColor = Color.MistyRose
        FormTransactions.Lbl_TotalExpense.ForeColor = Color.MistyRose

        'FormWishlist2
        FormWishlist2.BackColor = Color.PaleVioletRed
        FormWishlist2.TabPage1.BackColor = Color.MistyRose
        FormWishlist2.TabPage2.BackColor = Color.MistyRose
        FormWishlist2.DGVWishlist.BackgroundColor = Color.MistyRose
        FormWishlist2.btnSaveWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnEditWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnDeleteWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnClearWish.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnPrint.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnAddItem.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnWishSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnWishDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormWishlist2.LblWishID.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblWishName.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblWishAmount.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblWishCategory.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblWishDate.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblAddToList.ForeColor = Color.PaleVioletRed
        FormWishlist2.Panel1.BackColor = Color.PaleVioletRed
        FormWishlist2.LblList.ForeColor = Color.PaleVioletRed
        FormWishlist2.LblWishSearch.ForeColor = Color.MistyRose
        FormWishlist2.LblWishDateSearch.ForeColor = Color.MistyRose

        'FormBudget
        FormBudget.BackColor = Color.PaleVioletRed
        FormBudget.Panel1.BackColor = Color.MistyRose
        FormBudget.DGVBudgets.BackgroundColor = Color.MistyRose
        FormBudget.TabPage2.BackColor = Color.MistyRose
        FormBudget.btnSaveBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnEditBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnDeleteBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnClear.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnBudgetSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnBudgetDateSearch.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnRefresh.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnCalcBudget.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.btnCalcBudget2.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        FormBudget.LblBudgetID.ForeColor = Color.PaleVioletRed
        FormBudget.LblTodaysDate.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetTitle.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetAmount.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetID.ForeColor = Color.PaleVioletRed
        FormBudget.GroupBox1.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetCalc.ForeColor = Color.PaleVioletRed
        FormBudget.LblBAmount.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetStart.ForeColor = Color.PaleVioletRed
        FormBudget.LblEndDate.ForeColor = Color.PaleVioletRed
        FormBudget.LblAmountSpentFBudget.ForeColor = Color.PaleVioletRed
        FormBudget.LblBudgetSearch.ForeColor = Color.MistyRose
        FormBudget.LblBudgetDateSearch.ForeColor = Color.MistyRose

        'FormSettings
        Me.BackColor = Color.PaleVioletRed
        Me.PanelThemeButtons.BackColor = Color.MistyRose
        Me.PanelNotif.BackColor = Color.MistyRose
        Me.LblChangeTheme2.ForeColor = Color.PaleVioletRed
        Me.LblCurrentTime.ForeColor = Color.PaleVioletRed
        Me.LblTime.ForeColor = Color.PaleVioletRed
        Me.LblReminderMsg.ForeColor = Color.PaleVioletRed
        Me.NotifTimeSetByUser.ForeColor = Color.PaleVioletRed
        Me.btnThemeBlue.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        Me.btnThemeGreen.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        Me.btnThemePink.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        Me.btnStart.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")
        Me.btnStop.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\pinkthemebutton.png")

    End Sub
    'For notification settings 

    Dim CurrentTime As String
    Dim MessageTime As String ' The time the user sets to display the notification

    'Diplays the current time on a label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CurrentTime = TimeOfDay.ToString("hh:mm:ss tt")
        LblCurrentTime.Text = CurrentTime
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MessageTime = TBTime.Text & " " & CBAMPM.Text
        NotifTimeSetByUser.Text = "Notification set for: " & MessageTime

        If CurrentTime = MessageTime Then
            Timer2.Stop()
            MsgBox(TBReminderMsg.Text)
            btnStart.Enabled = True
            btnStop.Enabled = False
            NotifTimeSetByUser.Text = ""
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer2.Start()
        btnStart.Enabled = False
        btnStop.Enabled = True

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer2.Stop()
        btnStart.Enabled = True
        btnStop.Enabled = False
        NotifTimeSetByUser.Text = ""
    End Sub

    Private Sub ShowNotifyIcon_Click(sender As Object, e As EventArgs) Handles ShowNotifyIcon.Click
        NotifyIcon1.Visible = True
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(3000) 'Displays the balloon message for 3000 milliseconds 
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False 'Double clciking the icon hides the icon
    End Sub

End Class