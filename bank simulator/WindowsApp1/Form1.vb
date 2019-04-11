Public Class Form1
    Dim conObj As New ADODB.Connection
    Dim accountObj As New ADODB.Recordset
    Dim transObj As New ADODB.Recordset

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conObj.Provider = "Microsoft.ACE.OLEDB.12.0"
        conObj.ConnectionString = "../../bankAccount1.accdb"
        conObj.Open()
        accountObj.Open("SELECT * FROM AccountHolder",
                       conObj,
                       ADODB.CursorTypeEnum.adOpenDynamic,
                       ADODB.LockTypeEnum.adLockOptimistic)
        transObj.Open("SELECT * FROM Transcript",
                       conObj,
                       ADODB.CursorTypeEnum.adOpenDynamic,
                       ADODB.LockTypeEnum.adLockOptimistic)
        TabControl1.TabPages.Remove(TabPage2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click

        accountObj.MoveFirst()
        accountObj.Find("clientID = '" + UserID_Box.Text + "'")

        If UserID_Box.Text = accountObj.Fields("clientID").Value.ToString And
            UserPassword_Box.Text = accountObj.Fields("Password").Value.ToString Then

            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.TabPages.Add(TabPage2)



        Else
            MessageBox.Show("Please Check your ID or Password", "WARNING", MessageBoxButtons.OK)

        End If

        showall()

    End Sub

    Sub showall()

        Branchbox.Text = accountObj.Fields("BranchNumber").Value.ToString
        AccountNumBox.Text = accountObj.Fields("AccountNumber").Value.ToString
        AccountTypeBox.Text = accountObj.Fields("AccountType").Value.ToString
        BalanceBox.Text = accountObj.Fields("Balance").Value.ToString
        CreditBox.Text = accountObj.Fields("CreditLimit").Value.ToString

    End Sub
End Class
