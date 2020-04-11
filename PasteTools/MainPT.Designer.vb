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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelTb3Color = New System.Windows.Forms.Label()
        Me.LabelMainPTColor = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtConfig = New System.Windows.Forms.Button()
        Me.BtData = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LableBtName = New System.Windows.Forms.Label()
        Me.LabelHovertip = New System.Windows.Forms.Label()
        Me.LabelTxdata = New System.Windows.Forms.Label()
        Me.TextBoxBtName = New System.Windows.Forms.TextBox()
        Me.TextBoxHovertip = New System.Windows.Forms.TextBox()
        Me.TextBoxTxData = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatu = New System.Windows.Forms.Label()
        Me.Btc = New System.Windows.Forms.Button()
        Me.Btm = New System.Windows.Forms.Button()
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
        Me.TabControl1.Size = New System.Drawing.Size(174, 482)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(166, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(166, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Buttons
        '
        TabPg() '动态加载按钮
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = Global.PasteTools.My.MySettings.Default.TabPage3BackColor
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.LinkLabelAbout)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.PasteTools.My.MySettings.Default, "TabPage3BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(166, 456)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LabelTb3Color)
        Me.GroupBox3.Controls.Add(Me.LabelMainPTColor)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 238)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = Global.PasteTools.My.MySettings.Default.GroupBox3Text
        '
        'LabelTb3Color
        '
        Me.LabelTb3Color.AutoSize = True
        Me.LabelTb3Color.Location = New System.Drawing.Point(6, 164)
        Me.LabelTb3Color.Name = "LabelTb3Color"
        Me.LabelTb3Color.Size = New System.Drawing.Size(107, 12)
        Me.LabelTb3Color.TabIndex = 6
        Me.LabelTb3Color.Text = Global.PasteTools.My.MySettings.Default.LabelTb3ColorText
        '
        'LabelMainPTColor
        '
        Me.LabelMainPTColor.AutoSize = True
        Me.LabelMainPTColor.BackColor = System.Drawing.Color.Transparent
        Me.LabelMainPTColor.Location = New System.Drawing.Point(6, 143)
        Me.LabelMainPTColor.Name = "LabelMainPTColor"
        Me.LabelMainPTColor.Size = New System.Drawing.Size(95, 12)
        Me.LabelMainPTColor.TabIndex = 5
        Me.LabelMainPTColor.Text = Global.PasteTools.My.MySettings.Default.LabelMainPTColorText
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
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PasteTools.My.MySettings.Default, "MaskedTextBox1Text", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(111, 29)
        Me.MaskedTextBox1.Mask = "100"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(25, 14)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.Text = Global.PasteTools.My.MySettings.Default.MaskedTextBox1Text
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(6, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(130, 25)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = Global.PasteTools.My.MySettings.Default.CheckBox1Text
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.ThreeState = True
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
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Location = New System.Drawing.Point(107, 439)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(47, 12)
        Me.LinkLabelAbout.TabIndex = 6
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = Global.PasteTools.My.MySettings.Default.LinkLabelAboutText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtConfig)
        Me.GroupBox2.Controls.Add(Me.BtData)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = Global.PasteTools.My.MySettings.Default.GroupBox2Text
        '
        'BtConfig
        '
        Me.BtConfig.BackColor = System.Drawing.Color.Transparent
        Me.BtConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtConfig.FlatAppearance.BorderSize = 0
        Me.BtConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtConfig.Location = New System.Drawing.Point(74, 20)
        Me.BtConfig.Name = "BtConfig"
        Me.BtConfig.Size = New System.Drawing.Size(62, 26)
        Me.BtConfig.TabIndex = 1
        Me.BtConfig.Text = Global.PasteTools.My.MySettings.Default.BtConfigText
        Me.BtConfig.UseVisualStyleBackColor = False
        '
        'BtData
        '
        Me.BtData.BackColor = System.Drawing.Color.Transparent
        Me.BtData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtData.FlatAppearance.BorderSize = 0
        Me.BtData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtData.Location = New System.Drawing.Point(6, 20)
        Me.BtData.Name = "BtData"
        Me.BtData.Size = New System.Drawing.Size(62, 26)
        Me.BtData.TabIndex = 0
        Me.BtData.Text = Global.PasteTools.My.MySettings.Default.BtDataText
        Me.BtData.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 53)
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
        Me.ComboBox1.Location = New System.Drawing.Point(6, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 20)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = Global.PasteTools.My.MySettings.Default.ComboBox1Text
        '
        'LableBtName
        '
        Me.LableBtName.AutoSize = True
        Me.LableBtName.Location = New System.Drawing.Point(182, 60)
        Me.LableBtName.Name = "LableBtName"
        Me.LableBtName.Size = New System.Drawing.Size(41, 12)
        Me.LableBtName.TabIndex = 4
        Me.LableBtName.Text = "BtName"
        Me.LableBtName.Visible = False
        '
        'LabelHovertip
        '
        Me.LabelHovertip.AutoSize = True
        Me.LabelHovertip.Location = New System.Drawing.Point(315, 60)
        Me.LabelHovertip.Name = "LabelHovertip"
        Me.LabelHovertip.Size = New System.Drawing.Size(59, 12)
        Me.LabelHovertip.TabIndex = 5
        Me.LabelHovertip.Text = "Hover tip"
        Me.LabelHovertip.Visible = False
        '
        'LabelTxdata
        '
        Me.LabelTxdata.AutoSize = True
        Me.LabelTxdata.Location = New System.Drawing.Point(182, 90)
        Me.LabelTxdata.Name = "LabelTxdata"
        Me.LabelTxdata.Size = New System.Drawing.Size(89, 12)
        Me.LabelTxdata.TabIndex = 6
        Me.LabelTxdata.Text = "The text data:"
        Me.LabelTxdata.Visible = False
        '
        'TextBoxBtName
        '
        Me.TextBoxBtName.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBoxBtName.Location = New System.Drawing.Point(237, 57)
        Me.TextBoxBtName.Name = "TextBoxBtName"
        Me.TextBoxBtName.Size = New System.Drawing.Size(72, 21)
        Me.TextBoxBtName.TabIndex = 7
        Me.TextBoxBtName.Visible = False
        '
        'TextBoxHovertip
        '
        Me.TextBoxHovertip.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBoxHovertip.Location = New System.Drawing.Point(373, 57)
        Me.TextBoxHovertip.Name = "TextBoxHovertip"
        Me.TextBoxHovertip.Size = New System.Drawing.Size(94, 21)
        Me.TextBoxHovertip.TabIndex = 8
        Me.TextBoxHovertip.Visible = False
        '
        'TextBoxTxData
        '
        Me.TextBoxTxData.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxTxData.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.TextBoxTxData.Location = New System.Drawing.Point(184, 109)
        Me.TextBoxTxData.Multiline = True
        Me.TextBoxTxData.Name = "TextBoxTxData"
        Me.TextBoxTxData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTxData.Size = New System.Drawing.Size(282, 350)
        Me.TextBoxTxData.TabIndex = 9
        Me.TextBoxTxData.Visible = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite
        Me.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Location = New System.Drawing.Point(200, 468)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(56, 28)
        Me.ButtonAdd.TabIndex = 10
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        Me.ButtonAdd.Visible = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Location = New System.Drawing.Point(388, 468)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 28)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        Me.ButtonDelete.Visible = False
        '
        'LabelStatu
        '
        Me.LabelStatu.AutoSize = True
        Me.LabelStatu.ForeColor = System.Drawing.Color.LavenderBlush
        Me.LabelStatu.Location = New System.Drawing.Point(182, 502)
        Me.LabelStatu.Name = "LabelStatu"
        Me.LabelStatu.Size = New System.Drawing.Size(65, 12)
        Me.LabelStatu.TabIndex = 12
        Me.LabelStatu.Text = "Status Bar"
        Me.LabelStatu.Visible = False
        '
        'Btc
        '
        Me.Btc.BackColor = System.Drawing.Color.Transparent
        Me.Btc.FlatAppearance.BorderSize = 0
        Me.Btc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btc.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btc.Image = Global.PasteTools.My.Resources.Resource.close_normal
        Me.Btc.Location = New System.Drawing.Point(153, 5)
        Me.Btc.Name = "Btc"
        Me.Btc.Size = New System.Drawing.Size(15, 16)
        Me.Btc.TabIndex = 3
        Me.Btc.UseVisualStyleBackColor = False
        '
        'Btm
        '
        Me.Btm.BackColor = System.Drawing.Color.Transparent
        Me.Btm.FlatAppearance.BorderSize = 0
        Me.Btm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btm.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btm.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btm.Image = Global.PasteTools.My.Resources.Resource.minsize_normal
        Me.Btm.Location = New System.Drawing.Point(134, 5)
        Me.Btm.Name = "Btm"
        Me.Btm.Size = New System.Drawing.Size(15, 16)
        Me.Btm.TabIndex = 2
        Me.Btm.UseVisualStyleBackColor = False
        '
        'MainPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.PasteTools.My.MySettings.Default.MainPTBackColor
        Me.ClientSize = New System.Drawing.Size(175, 520)
        Me.Controls.Add(Me.LabelStatu)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxTxData)
        Me.Controls.Add(Me.TextBoxHovertip)
        Me.Controls.Add(Me.TextBoxBtName)
        Me.Controls.Add(Me.LabelTxdata)
        Me.Controls.Add(Me.LabelHovertip)
        Me.Controls.Add(Me.LableBtName)
        Me.Controls.Add(Me.Btc)
        Me.Controls.Add(Me.Btm)
        Me.Controls.Add(Me.TabControl1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.PasteTools.My.MySettings.Default, "MainPTBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainPT"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MainPT"
        Me.TopMost = True
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
    Friend WithEvents LinkLabelAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtConfig As System.Windows.Forms.Button
    Friend WithEvents BtData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Btm As System.Windows.Forms.Button
    Friend WithEvents Btc As System.Windows.Forms.Button
    Friend WithEvents LableBtName As System.Windows.Forms.Label
    Friend WithEvents LabelHovertip As System.Windows.Forms.Label
    Friend WithEvents LabelTxdata As System.Windows.Forms.Label
    Friend WithEvents TextBoxBtName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHovertip As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTxData As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatu As System.Windows.Forms.Label
    Friend WithEvents LabelMainPTColor As System.Windows.Forms.Label
    Friend WithEvents LabelTb3Color As System.Windows.Forms.Label

End Class
