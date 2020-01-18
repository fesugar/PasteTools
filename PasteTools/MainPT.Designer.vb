<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPT
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPT))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Scolor = New System.Windows.Forms.Label()
        Me.Mcolor = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtF2 = New System.Windows.Forms.Button()
        Me.BtF1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Btm = New System.Windows.Forms.Button()
        Me.Btc = New System.Windows.Forms.Button()
        Me.BtName = New System.Windows.Forms.Label()
        Me.Hovertip = New System.Windows.Forms.Label()
        Me.Txdata = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Statu = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(175, 482)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(167, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(167, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = Global.PasteTools.My.MySettings.Default.TabPage3BackColor
        Me.TabPage3.Controls.Add(Me.LinkLabel1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.PasteTools.My.MySettings.Default, "TabPage3BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(167, 456)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(27, 423)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 12)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = Global.PasteTools.My.MySettings.Default.LinkLabel1Text
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Scolor)
        Me.GroupBox3.Controls.Add(Me.Mcolor)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 238)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = Global.PasteTools.My.MySettings.Default.GroupBox3Text
        '
        'Scolor
        '
        Me.Scolor.AutoSize = True
        Me.Scolor.Location = New System.Drawing.Point(23, 162)
        Me.Scolor.Name = "Scolor"
        Me.Scolor.Size = New System.Drawing.Size(53, 12)
        Me.Scolor.TabIndex = 6
        Me.Scolor.Text = "TPsColor"
        '
        'Mcolor
        '
        Me.Mcolor.AutoSize = True
        Me.Mcolor.BackColor = System.Drawing.Color.Transparent
        Me.Mcolor.Location = New System.Drawing.Point(23, 139)
        Me.Mcolor.Name = "Mcolor"
        Me.Mcolor.Size = New System.Drawing.Size(71, 12)
        Me.Mcolor.TabIndex = 5
        Me.Mcolor.Text = "MainPTColor"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = Global.PasteTools.My.MySettings.Default.CheckBox3Checked
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.PasteTools.My.MySettings.Default, "CheckBox3Checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(6, 114)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = Global.PasteTools.My.MySettings.Default.CheckBox3Text
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = Global.PasteTools.My.MySettings.Default.CheckBox2Checked
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.PasteTools.My.MySettings.Default, "CheckBox2Checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(6, 92)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = Global.PasteTools.My.MySettings.Default.CheckBox2Text
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PasteTools.My.MySettings.Default, "MaskedTextBox1Text", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(109, 26)
        Me.MaskedTextBox1.Mask = "100"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.Text = Global.PasteTools.My.MySettings.Default.MaskedTextBox1Text
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.PasteTools.My.MySettings.Default.CheckBox1Checked
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.PasteTools.My.MySettings.Default, "CheckBox1Checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = Global.PasteTools.My.MySettings.Default.CheckBox1Text
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = Global.PasteTools.My.MySettings.Default.Label1Text
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtF2)
        Me.GroupBox2.Controls.Add(Me.BtF1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = Global.PasteTools.My.MySettings.Default.GroupBox2Text
        '
        'BtF2
        '
        Me.BtF2.BackColor = System.Drawing.Color.Transparent
        Me.BtF2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtF2.FlatAppearance.BorderSize = 0
        Me.BtF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtF2.Location = New System.Drawing.Point(79, 20)
        Me.BtF2.Name = "BtF2"
        Me.BtF2.Size = New System.Drawing.Size(66, 26)
        Me.BtF2.TabIndex = 1
        Me.BtF2.Text = Global.PasteTools.My.MySettings.Default.BtF2Text
        Me.BtF2.UseVisualStyleBackColor = False
        '
        'BtF1
        '
        Me.BtF1.BackColor = System.Drawing.Color.Transparent
        Me.BtF1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtF1.FlatAppearance.BorderSize = 0
        Me.BtF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtF1.Location = New System.Drawing.Point(3, 20)
        Me.BtF1.Name = "BtF1"
        Me.BtF1.Size = New System.Drawing.Size(66, 26)
        Me.BtF1.TabIndex = 0
        Me.BtF1.Text = Global.PasteTools.My.MySettings.Default.BtF1Text
        Me.BtF1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = Global.PasteTools.My.MySettings.Default.GroupBox1Text
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PasteTools.My.MySettings.Default, "ComboBox1Text", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Item1", "Item2", "Item3"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 20)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = Global.PasteTools.My.MySettings.Default.ComboBox1Text
        '
        'Btm
        '
        Me.Btm.BackColor = System.Drawing.Color.Transparent
        Me.Btm.FlatAppearance.BorderSize = 0
        Me.Btm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.Btm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink
        Me.Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btm.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btm.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btm.Location = New System.Drawing.Point(121, 8)
        Me.Btm.Name = "Btm"
        Me.Btm.Size = New System.Drawing.Size(25, 21)
        Me.Btm.TabIndex = 2
        Me.Btm.Text = "—"
        Me.Btm.UseVisualStyleBackColor = False
        '
        'Btc
        '
        Me.Btc.BackColor = System.Drawing.Color.Transparent
        Me.Btc.FlatAppearance.BorderSize = 0
        Me.Btc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink
        Me.Btc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed
        Me.Btc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btc.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btc.Location = New System.Drawing.Point(147, 8)
        Me.Btc.Name = "Btc"
        Me.Btc.Size = New System.Drawing.Size(25, 21)
        Me.Btc.TabIndex = 3
        Me.Btc.Text = "×"
        Me.Btc.UseVisualStyleBackColor = False
        '
        'BtName
        '
        Me.BtName.AutoSize = True
        Me.BtName.Location = New System.Drawing.Point(182, 59)
        Me.BtName.Name = "BtName"
        Me.BtName.Size = New System.Drawing.Size(41, 12)
        Me.BtName.TabIndex = 4
        Me.BtName.Text = "BtName"
        Me.BtName.Visible = False
        '
        'Hovertip
        '
        Me.Hovertip.AutoSize = True
        Me.Hovertip.Location = New System.Drawing.Point(325, 59)
        Me.Hovertip.Name = "Hovertip"
        Me.Hovertip.Size = New System.Drawing.Size(59, 12)
        Me.Hovertip.TabIndex = 5
        Me.Hovertip.Text = "Hover tip"
        Me.Hovertip.Visible = False
        '
        'Txdata
        '
        Me.Txdata.AutoSize = True
        Me.Txdata.Location = New System.Drawing.Point(182, 89)
        Me.Txdata.Name = "Txdata"
        Me.Txdata.Size = New System.Drawing.Size(89, 12)
        Me.Txdata.TabIndex = 6
        Me.Txdata.Text = "The text data:"
        Me.Txdata.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBox1.Location = New System.Drawing.Point(242, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 21)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBox2.Location = New System.Drawing.Point(386, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox3.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.TextBox3.Location = New System.Drawing.Point(184, 109)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(300, 350)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Visible = False
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(200, 468)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(59, 28)
        Me.Add.TabIndex = 10
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        Me.Add.Visible = False
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(402, 468)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(59, 28)
        Me.Delete.TabIndex = 11
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        Me.Delete.Visible = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Enabled = False
        Me.Title.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Title.Location = New System.Drawing.Point(5, 7)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(89, 20)
        Me.Title.TabIndex = 1
        Me.Title.Text = Global.PasteTools.My.MySettings.Default.TitleText
        '
        'Statu
        '
        Me.Statu.AutoSize = True
        Me.Statu.Location = New System.Drawing.Point(181, 502)
        Me.Statu.Name = "Statu"
        Me.Statu.Size = New System.Drawing.Size(65, 12)
        Me.Statu.TabIndex = 12
        Me.Statu.Text = "Status Bar"
        Me.Statu.Visible = False
        '
        'MainPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.PasteTools.My.MySettings.Default.MainPTBackColor
        Me.ClientSize = New System.Drawing.Size(175, 520)
        Me.Controls.Add(Me.Statu)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Txdata)
        Me.Controls.Add(Me.Hovertip)
        Me.Controls.Add(Me.BtName)
        Me.Controls.Add(Me.Btc)
        Me.Controls.Add(Me.Btm)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.TabControl1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.PasteTools.My.MySettings.Default, "MainPTBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainPT"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MainPT"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtF2 As System.Windows.Forms.Button
    Friend WithEvents BtF1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Btm As System.Windows.Forms.Button
    Friend WithEvents Btc As System.Windows.Forms.Button
    Friend WithEvents BtName As System.Windows.Forms.Label
    Friend WithEvents Hovertip As System.Windows.Forms.Label
    Friend WithEvents Txdata As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Statu As System.Windows.Forms.Label
    Friend WithEvents Mcolor As System.Windows.Forms.Label
    Friend WithEvents Scolor As System.Windows.Forms.Label

End Class
