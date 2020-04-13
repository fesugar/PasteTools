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
        Me.richBoxTxData = New System.Windows.Forms.RichTextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatu = New System.Windows.Forms.Label()
        Me.Btc = New System.Windows.Forms.Button()
        Me.Btm = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(232, 600)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(224, 571)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(224, 571)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(224, 571)
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
        Me.GroupBox3.Location = New System.Drawing.Point(16, 184)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(189, 298)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = Global.PasteTools.My.MySettings.Default.GroupBox3Text
        '
        'LabelTb3Color
        '
        Me.LabelTb3Color.AutoSize = True
        Me.LabelTb3Color.Location = New System.Drawing.Point(8, 205)
        Me.LabelTb3Color.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTb3Color.Name = "LabelTb3Color"
        Me.LabelTb3Color.Size = New System.Drawing.Size(135, 15)
        Me.LabelTb3Color.TabIndex = 6
        Me.LabelTb3Color.Text = Global.PasteTools.My.MySettings.Default.LabelTb3ColorText
        '
        'LabelMainPTColor
        '
        Me.LabelMainPTColor.AutoSize = True
        Me.LabelMainPTColor.BackColor = System.Drawing.Color.Transparent
        Me.LabelMainPTColor.Location = New System.Drawing.Point(8, 179)
        Me.LabelMainPTColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMainPTColor.Name = "LabelMainPTColor"
        Me.LabelMainPTColor.Size = New System.Drawing.Size(120, 15)
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
        Me.CheckBox3.Location = New System.Drawing.Point(8, 142)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(134, 19)
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
        Me.CheckBox2.Location = New System.Drawing.Point(8, 115)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(89, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = Global.PasteTools.My.MySettings.Default.CheckBox2Text
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PasteTools.My.MySettings.Default, "MaskedTextBox1Text", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(148, 36)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.MaskedTextBox1.Mask = "100"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(33, 18)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.Text = Global.PasteTools.My.MySettings.Default.MaskedTextBox1Text
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(8, 72)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(173, 31)
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
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = Global.PasteTools.My.MySettings.Default.Label1Text
        '
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Location = New System.Drawing.Point(155, 547)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabelAbout.TabIndex = 6
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = Global.PasteTools.My.MySettings.Default.LinkLabelAboutText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(8, 545)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtConfig)
        Me.GroupBox2.Controls.Add(Me.BtData)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 92)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(189, 72)
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
        Me.BtConfig.Location = New System.Drawing.Point(99, 25)
        Me.BtConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.BtConfig.Name = "BtConfig"
        Me.BtConfig.Size = New System.Drawing.Size(83, 32)
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
        Me.BtData.Location = New System.Drawing.Point(8, 25)
        Me.BtData.Margin = New System.Windows.Forms.Padding(4)
        Me.BtData.Name = "BtData"
        Me.BtData.Size = New System.Drawing.Size(83, 32)
        Me.BtData.TabIndex = 0
        Me.BtData.Text = Global.PasteTools.My.MySettings.Default.BtDataText
        Me.BtData.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(189, 66)
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
        Me.ComboBox1.Location = New System.Drawing.Point(8, 25)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = Global.PasteTools.My.MySettings.Default.ComboBox1Text
        '
        'LableBtName
        '
        Me.LableBtName.AutoSize = True
        Me.LableBtName.Location = New System.Drawing.Point(243, 29)
        Me.LableBtName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LableBtName.Name = "LableBtName"
        Me.LableBtName.Size = New System.Drawing.Size(55, 15)
        Me.LableBtName.TabIndex = 4
        Me.LableBtName.Text = "BtName"
        Me.LableBtName.Visible = False
        '
        'LabelHovertip
        '
        Me.LabelHovertip.AutoSize = True
        Me.LabelHovertip.Location = New System.Drawing.Point(459, 29)
        Me.LabelHovertip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHovertip.Name = "LabelHovertip"
        Me.LabelHovertip.Size = New System.Drawing.Size(79, 15)
        Me.LabelHovertip.TabIndex = 5
        Me.LabelHovertip.Text = "Hover tip"
        Me.LabelHovertip.Visible = False
        '
        'LabelTxdata
        '
        Me.LabelTxdata.AutoSize = True
        Me.LabelTxdata.Location = New System.Drawing.Point(243, 58)
        Me.LabelTxdata.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTxdata.Name = "LabelTxdata"
        Me.LabelTxdata.Size = New System.Drawing.Size(119, 15)
        Me.LabelTxdata.TabIndex = 6
        Me.LabelTxdata.Text = "The text data:"
        Me.LabelTxdata.Visible = False
        '
        'TextBoxBtName
        '
        Me.TextBoxBtName.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBoxBtName.Location = New System.Drawing.Point(338, 23)
        Me.TextBoxBtName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBtName.Name = "TextBoxBtName"
        Me.TextBoxBtName.Size = New System.Drawing.Size(95, 25)
        Me.TextBoxBtName.TabIndex = 7
        Me.TextBoxBtName.Visible = False
        '
        'TextBoxHovertip
        '
        Me.TextBoxHovertip.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBoxHovertip.Location = New System.Drawing.Point(557, 23)
        Me.TextBoxHovertip.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxHovertip.Name = "TextBoxHovertip"
        Me.TextBoxHovertip.Size = New System.Drawing.Size(188, 25)
        Me.TextBoxHovertip.TabIndex = 8
        Me.TextBoxHovertip.Visible = False
        '
        'richBoxTxData
        '
        Me.richBoxTxData.BackColor = System.Drawing.Color.LavenderBlush
        Me.richBoxTxData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.richBoxTxData.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.richBoxTxData.Location = New System.Drawing.Point(246, 86)
        Me.richBoxTxData.Margin = New System.Windows.Forms.Padding(4)
        Me.richBoxTxData.Name = "richBoxTxData"
        Me.richBoxTxData.Size = New System.Drawing.Size(792, 152)
        Me.richBoxTxData.TabIndex = 9
        Me.richBoxTxData.Text = ""
        Me.richBoxTxData.Visible = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite
        Me.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Location = New System.Drawing.Point(799, 38)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 35)
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
        Me.ButtonDelete.Location = New System.Drawing.Point(934, 38)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 35)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        Me.ButtonDelete.Visible = False
        '
        'LabelStatu
        '
        Me.LabelStatu.AutoSize = True
        Me.LabelStatu.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.LabelStatu.Location = New System.Drawing.Point(243, 633)
        Me.LabelStatu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatu.Name = "LabelStatu"
        Me.LabelStatu.Size = New System.Drawing.Size(87, 15)
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
        Me.Btc.Location = New System.Drawing.Point(204, 6)
        Me.Btc.Margin = New System.Windows.Forms.Padding(4)
        Me.Btc.Name = "Btc"
        Me.Btc.Size = New System.Drawing.Size(20, 20)
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
        Me.Btm.Location = New System.Drawing.Point(179, 6)
        Me.Btm.Margin = New System.Windows.Forms.Padding(4)
        Me.Btm.Name = "Btm"
        Me.Btm.Size = New System.Drawing.Size(20, 20)
        Me.Btm.TabIndex = 2
        Me.Btm.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(245, 245)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(793, 379)
        Me.WebBrowser1.TabIndex = 25
        '
        'MainPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.PasteTools.My.MySettings.Default.MainPTBackColor
        Me.ClientSize = New System.Drawing.Size(233, 660)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.LabelStatu)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.richBoxTxData)
        Me.Controls.Add(Me.TextBoxHovertip)
        Me.Controls.Add(Me.TextBoxBtName)
        Me.Controls.Add(Me.LabelTxdata)
        Me.Controls.Add(Me.LabelHovertip)
        Me.Controls.Add(Me.LableBtName)
        Me.Controls.Add(Me.Btc)
        Me.Controls.Add(Me.Btm)
        Me.Controls.Add(Me.TabControl1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.PasteTools.My.MySettings.Default, "MainPTBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainPT"
        Me.Opacity = 0.95R
        Me.Padding = New System.Windows.Forms.Padding(27, 75, 27, 25)
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
    Friend WithEvents richBoxTxData As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatu As System.Windows.Forms.Label
    Friend WithEvents LabelMainPTColor As System.Windows.Forms.Label
    Friend WithEvents LabelTb3Color As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
End Class
