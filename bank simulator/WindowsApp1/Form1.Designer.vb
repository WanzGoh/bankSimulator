<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.UserPassword_Box = New System.Windows.Forms.TextBox()
        Me.UserID_Box = New System.Windows.Forms.TextBox()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreditBox = New System.Windows.Forms.TextBox()
        Me.BalanceBox = New System.Windows.Forms.TextBox()
        Me.AccountNumBox = New System.Windows.Forms.TextBox()
        Me.Branchbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccountTypeBox = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(575, 517)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Loginbtn)
        Me.TabPage1.Controls.Add(Me.UserPassword_Box)
        Me.TabPage1.Controls.Add(Me.UserID_Box)
        Me.TabPage1.Controls.Add(Me.Label_Password)
        Me.TabPage1.Controls.Add(Me.Label_ID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 491)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login Page"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 55)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Yuwan's Bank"
        '
        'Loginbtn
        '
        Me.Loginbtn.Location = New System.Drawing.Point(202, 311)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(100, 40)
        Me.Loginbtn.TabIndex = 4
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'UserPassword_Box
        '
        Me.UserPassword_Box.Location = New System.Drawing.Point(202, 226)
        Me.UserPassword_Box.Name = "UserPassword_Box"
        Me.UserPassword_Box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPassword_Box.Size = New System.Drawing.Size(100, 20)
        Me.UserPassword_Box.TabIndex = 3
        '
        'UserID_Box
        '
        Me.UserID_Box.Location = New System.Drawing.Point(202, 164)
        Me.UserID_Box.Name = "UserID_Box"
        Me.UserID_Box.Size = New System.Drawing.Size(100, 20)
        Me.UserID_Box.TabIndex = 2
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Location = New System.Drawing.Point(116, 233)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(53, 13)
        Me.Label_Password.TabIndex = 1
        Me.Label_Password.Text = "Password"
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(126, 164)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(43, 13)
        Me.Label_ID.TabIndex = 0
        Me.Label_ID.Text = "User ID"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AccountTypeBox)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.CreditBox)
        Me.TabPage2.Controls.Add(Me.BalanceBox)
        Me.TabPage2.Controls.Add(Me.AccountNumBox)
        Me.TabPage2.Controls.Add(Me.Branchbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(567, 491)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CreditLimit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AccoutNumber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Branch Number"
        '
        'CreditBox
        '
        Me.CreditBox.Location = New System.Drawing.Point(224, 192)
        Me.CreditBox.Name = "CreditBox"
        Me.CreditBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditBox.TabIndex = 3
        '
        'BalanceBox
        '
        Me.BalanceBox.Location = New System.Drawing.Point(224, 166)
        Me.BalanceBox.Name = "BalanceBox"
        Me.BalanceBox.Size = New System.Drawing.Size(100, 20)
        Me.BalanceBox.TabIndex = 2
        '
        'AccountNumBox
        '
        Me.AccountNumBox.Location = New System.Drawing.Point(224, 117)
        Me.AccountNumBox.Name = "AccountNumBox"
        Me.AccountNumBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountNumBox.TabIndex = 1
        '
        'Branchbox
        '
        Me.Branchbox.Location = New System.Drawing.Point(224, 91)
        Me.Branchbox.Name = "Branchbox"
        Me.Branchbox.Size = New System.Drawing.Size(100, 20)
        Me.Branchbox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "AccoutType"
        '
        'AccountTypeBox
        '
        Me.AccountTypeBox.Location = New System.Drawing.Point(224, 140)
        Me.AccountTypeBox.Name = "AccountTypeBox"
        Me.AccountTypeBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountTypeBox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 542)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Loginbtn As Button
    Friend WithEvents UserPassword_Box As TextBox
    Friend WithEvents UserID_Box As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CreditBox As TextBox
    Friend WithEvents BalanceBox As TextBox
    Friend WithEvents AccountNumBox As TextBox
    Friend WithEvents Branchbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AccountTypeBox As TextBox
    Friend WithEvents Label6 As Label
End Class
