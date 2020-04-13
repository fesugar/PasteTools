
Public Class MainPT

    Dim Pt As New Paste.PasteClass ' 当前全局变量，功能模块
    Dim Bvalue As String '按钮序数
    ' Create the ToolTip and associate with the Form container.
    Dim toolTip1 As New ToolTip()

    '窗体即将关闭事件
    Private Sub MainPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing  '窗体即将关闭时事件
        '保存设置
        My.Settings.Save()
    End Sub

    '窗体鼠标移动事件
    Private Sub MainPT_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove '鼠标移动事件
        Pt.Mform(Me.Handle) '拖动窗体
    End Sub

    '窗体载入时事件
    Private Sub MainPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '如果出现错误，忽略错误，继续往下执行
        On Error Resume Next
        '进程判断，出现相同进程则退出

        Load_Data()

    End Sub
    'ComboxBOX Items 项
    Private Sub ListFiles(ByVal folderPath As String)
        ComboBox1.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            folderPath, FileIO.SearchOption.SearchTopLevelOnly, "*.ini")

        For Each fileName As String In fileNames
            Dim information = My.Computer.FileSystem.GetFileInfo(fileName)
            ComboBox1.Items.Add(information.Name.Replace(".ini", "").Trim)
        Next

    End Sub

    '选项卡
    Private Function TabPg()
        '如果出现错误，忽略错误，继续往下执行
        On Error Resume Next
        Dim Button(29) As Button '定义按钮,提示对象
        Dim i As Integer

        '选项卡1
        For i = Button.GetLowerBound(0) To Button.GetUpperBound(0)
            Button(i) = New Button
            'select 语句检测按钮数量
            Select Case i
                Case Is <= 14
                    TabPage1.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage1上
                    Button(i).Location = New System.Drawing.Point(3, i * 30 + 10) '按钮位置
                Case Is > 14 <= 29
                    TabPage1.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage1上
                    Button(i).Location = New System.Drawing.Point(87, i * 30 - 440) '按钮位置
                Case Else
                    Console.WriteLine("ERROR101.nothing")
            End Select
            '按钮设置开始
            With Button(i)
                .Cursor = System.Windows.Forms.Cursors.Hand '鼠标光标样式
                .Name = "Button" & i.ToString '按钮控件名
                .Size = New System.Drawing.Size(76, 24) '按钮尺寸大小
                .TabIndex = i '修改新加入控件的TabIndex值
                '.Text = Pt.GetINI("Buttons", "Button" & i.ToString, "Button" & i.ToString, ITEMpath) '修改默认文本。
                .Text = "Button" + i.ToString
                .UseVisualStyleBackColor = True '按钮视觉
                .FlatStyle = FlatStyle.Flat  '按钮外观
                .FlatAppearance.BorderColor = Color.Orange '按钮边框颜色
                .FlatAppearance.BorderSize = 1  '按钮边框大小
                .FlatAppearance.MouseDownBackColor = Color.LightSkyBlue '按钮按下时工作区颜色
                .FlatAppearance.MouseOverBackColor = Color.LightSalmon   '按钮位于时工作区颜色
                .UseVisualStyleBackColor = False '如果支持是否使用视觉样式背景
            End With
            '按钮设置结束
            REM http://msdn.microsoft.com/zh-cn/library/dxks2f7h(v=vs.110).aspx
            '悬停提示开始
            ' Set up the ToolTip text for the Button and Checkbox.
            'toolTip1.SetToolTip(Button(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString, "ButtonTip" & i.ToString, ITEMpath)) '修改默认文本。
            toolTip1.SetToolTip(Button(i), "ButtonTip" + i.ToString)
            'toolTip1.SetToolTip(Me.CheckBox1, "My checkBox1")
            '悬停提示结束
            REM http://msdn.microsoft.com/query/dev12.query?appId=Dev12IDEF1&l=ZH-CN&k=k(vb.AddHandler);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv3.5);k(DevLang-VB)&rd=true
            AddHandler Button(i).Click, AddressOf Click_Click
        Next

        '选项卡2
        For i = Button.GetLowerBound(0) To Button.GetUpperBound(0)
            Button(i) = New Button
            'select 语句检测按钮数量
            Select Case i
                Case Is <= 14
                    TabPage2.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage2上
                    Button(i).Location = New System.Drawing.Point(3, i * 30 + 10) '按钮位置
                Case Is > 14 <= 29
                    TabPage2.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage2上
                    Button(i).Location = New System.Drawing.Point(87, i * 30 - 440) '按钮位置
                Case Else
                    Console.WriteLine("ERROR101.nothing")
            End Select
            '按钮设置开始
            With Button(i)
                .Cursor = System.Windows.Forms.Cursors.Hand '鼠标光标样式
                .Name = "Button" & i.ToString + 30 '按钮控件名
                .Size = New System.Drawing.Size(76, 24) '按钮尺寸大小
                .TabIndex = i '修改新加入控件的TabIndex值
                '.Text = Pt.GetINI("Buttons", "Button" & i.ToString + 30, "Button" & i.ToString + 30, ITEMpath) '修改默认文本。
                .Text = "Button" + i.ToString + 30
                .UseVisualStyleBackColor = True '按钮视觉
                .FlatStyle = FlatStyle.Flat  '按钮外观
                .FlatAppearance.BorderColor = Color.Orange '按钮边框颜色
                .FlatAppearance.BorderSize = 1  '按钮边框大小
                .FlatAppearance.MouseDownBackColor = Color.LightSkyBlue '按钮按下时工作区颜色
                .FlatAppearance.MouseOverBackColor = Color.LightSalmon   '按钮位于时工作区颜色
                .UseVisualStyleBackColor = False '如果支持是否使用视觉样式背景
            End With
            '按钮设置结束
            REM http://msdn.microsoft.com/zh-cn/library/dxks2f7h(v=vs.110).aspx
            '悬停提示开始
            ' Set up the ToolTip text for the Button and Checkbox.
            'toolTip1.SetToolTip(Button(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString + 30, "ButtonTip" & i.ToString + 30, ITEMpath)) '修改默认文本。
            toolTip1.SetToolTip(Button(i), "ButtonTip" + i.ToString + 30)
            'toolTip1.SetToolTip(Me.CheckBox1, "My checkBox1")
            '悬停提示结束
            REM http://msdn.microsoft.com/query/dev12.query?appId=Dev12IDEF1&l=ZH-CN&k=k(vb.AddHandler);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv3.5);k(DevLang-VB)&rd=true
            AddHandler Button(i).Click, AddressOf Click_Click
        Next

        Return 0
    End Function

    '切换粘贴和修改模式时布局和参数
    Private Function Ut()
        Dim intCounter As Integer
        '读取相关配置数据
        LableBtName.Text = Pt.GetINI("alter", "label1", "BtName", filePath + "\config.ini")
        LabelHovertip.Text = Pt.GetINI("alter", "label2", "Hover tip", filePath + "\config.ini")
        LabelTxdata.Text = Pt.GetINI("alter", "label3", "The text data:", filePath + "\config.ini")
        LabelStatu.Text = Pt.GetINI("alter", "label4", "Status:", filePath + "\config.ini")
        ButtonAdd.Text = Pt.GetINI("alter", "Button1", "Add", filePath + "\config.ini")
        ButtonDelete.Text = Pt.GetINI("alter", "Button2", "Delete", filePath + "\config.ini")
        '获取资源数据
        TextBoxBtName.Text = Pt.GetINI("Buttons", "Button" + Bvalue, "", ITEMpath)
        TextBoxHovertip.Text = Pt.GetINI("Buttons", "ButtonTip" + Bvalue, "", ITEMpath)
        '为了预防错误，如果文件存在则进行读取
        If My.Computer.FileSystem.FileExists(filePath + "\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath)) = True Then
            richBoxTxData.Text = My.Computer.FileSystem.ReadAllText(filePath + "\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath),
                                System.Text.Encoding.Default)
        Else
            richBoxTxData.Text = Nothing
        End If

        '判断状态
        If My.Settings.CheckBox2Checked = True Then

            CheckBox2.Enabled = False
            ClientSize = New System.Drawing.Size(My.Settings.FormWidth, My.Settings.FormHeight)

            CheckBox2.Enabled = True
            '隐藏控件
            LableBtName.Hide()
            LabelHovertip.Hide()
            LabelTxdata.Hide()
            LabelStatu.Hide()
            TextBoxBtName.Hide()
            TextBoxHovertip.Hide()
            richBoxTxData.Hide()
            WebBrowser1.Hide()
            ButtonAdd.Hide()
            ButtonDelete.Hide()


            '主界面最小化.关闭按钮位置
            Btm.Location = New System.Drawing.Point(My.Settings.FormWidth - 45, 5)
            Btc.Location = New System.Drawing.Point(My.Settings.FormWidth - 25, 5)
        Else
            '判断状态

            CheckBox2.Enabled = False

            ClientSize = New System.Drawing.Size(WebBrowser1.Location.X + WebBrowser1.Width + ButtonDelete.Size.Height, My.Settings.FormHeight)
            CheckBox2.Enabled = True
            '显示控件
            LableBtName.Show()
            LabelHovertip.Show()
            LabelTxdata.Show()
            LabelStatu.Show()
            TextBoxBtName.Show()
            TextBoxHovertip.Show()
            richBoxTxData.Show()
            WebBrowser1.Show()
            ButtonAdd.Show()
            ButtonDelete.Show()


            '主界面最小化.关闭按钮位置
            Btm.Location = New System.Drawing.Point(WebBrowser1.Location.X + WebBrowser1.Width + ButtonDelete.Size.Height - 45, 5)
            Btc.Location = New System.Drawing.Point(WebBrowser1.Location.X + WebBrowser1.Width + ButtonDelete.Size.Height - 25, 5)
        End If

        Return 0
    End Function

    '重载数据
    Private Sub Load_Data()
        '重新初始化数据
        ITEMpath = filePath + "\Mode\" + My.Settings.ComboBox1Text + ".ini"
        Me.Text = Pt.GetINI("Main", "Title", "Paste", ITEMpath) '窗口标题
        TabPage1.Text = Pt.GetINI("TabControl1", "TabPage1", "TabPage1", ITEMpath) '集合1标题
        TabPage2.Text = Pt.GetINI("TabControl1", "TabPage2", "TabPage2", ITEMpath) '集合2标题
        TabPage3.Text = Pt.GetINI("TabControl1", "TabPage3", "TabPage3", ITEMpath) '集合3标题
        'Controls("Button" + Bvalue).Text = TextBox1.Text '使用 Controls 对象
        Dim i As Integer
        For i = 0 To 29
            'If Bvalue > 29 Then
            'If i > 29 Then
            Me.TabPage2.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString + 30, "Button" & i.ToString + 30, ITEMpath)
            toolTip1.SetToolTip(TabPage2.Controls.Item(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString + 30, "ButtonTip" & i.ToString + 30, ITEMpath)) '修改默认文本。
            'Else
            Me.TabPage1.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString, "Button" & i.ToString, ITEMpath)
            toolTip1.SetToolTip(TabPage1.Controls.Item(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString, "ButtonTip" & i.ToString, ITEMpath)) '修改默认文本。
            'End If
        Next

    End Sub

    Private ButtonSelect As Object = Nothing '声明私有变量 鼠标点击的前一按钮项

    '粘贴按钮单击事件
    Private Sub Click_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.TextChanged,
        BtData.Click, BtConfig.Click, MaskedTextBox1.TextChanged, CheckBox1.Click, CheckBox2.Click, CheckBox3.Click,
        LinkLabelAbout.Click, Btm.Click, Btc.Click, ButtonAdd.Click, ButtonDelete.Click, LabelMainPTColor.Click, LabelTb3Color.Click
        Try
            '手动触发垃圾回收机制
            GC.Collect()
            '第三页选项卡
            Select Case sender.name.ToString
                Case "BtData"
                    If My.Computer.FileSystem.DirectoryExists(filePath + "\data\") = False Then
                        Exit Sub
                    End If
                    'System.Diagnostics.Process.Start(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
                    System.Diagnostics.Process.Start(filePath + "\data\")
                Case "BtConfig"
                    If My.Computer.FileSystem.DirectoryExists(filePath + "\Mode\") = False Then
                        Exit Sub
                    End If
                    'System.Diagnostics.Process.Start(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
                    System.Diagnostics.Process.Start(filePath + "\Mode\")
                Case "Btm" '最小化
                    Me.WindowState = FormWindowState.Minimized
                Case "Btc" '关闭
                    Application.Exit()
                Case "ComboBox1"
                    '修改模式按钮单击事件
                    My.Settings.ComboBox1Text = ComboBox1.Text
                    Load_Data()

                Case "MaskedTextBox1"
                    My.Settings.MaskedTextBox1Text = Trim(MaskedTextBox1.Text)
                    '修改sleep 数值
                Case "CheckBox1" '快捷键勾选事件
                    If CheckBox1.CheckState = CheckState.Checked Then '选中
                        Pt.WriteINI("Send", "Send", "{ENTER}", filePath + "\config.ini")
                        My.Settings.CheckBox1Text = Pt.GetINI("CheckBoxText", "CBox11Text", "Enter key", filePath + "\config.ini")
                        CheckBox1.Text = My.Settings.CheckBox1Text '加载显示
                    ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then '半选中
                        Pt.WriteINI("Send", "Send", "^{ENTER}", filePath + "\config.ini")
                        My.Settings.CheckBox1Text = Pt.GetINI("CheckBoxText", "CBox10Text", "Ctrl + Enter key", filePath + "\config.ini")
                        CheckBox1.Text = My.Settings.CheckBox1Text '加载显示
                    ElseIf CheckBox1.CheckState = CheckState.Unchecked Then '未知
                        Pt.WriteINI("Send", "Send", "", filePath + "\config.ini")
                        My.Settings.CheckBox1Text = Pt.GetINI("CheckBoxText", "CBox12Text", "Nothing key", filePath + "\config.ini")
                        CheckBox1.Text = My.Settings.CheckBox1Text '加载显示
                    End If
                Case "CheckBox2" '模式勾选框事件
                    If CheckBox2.Checked = True Then
                        My.Settings.CheckBox2Text = Pt.GetINI("CheckBoxText", "CBox20Text", "Paste state", filePath + "\config.ini")
                        CheckBox2.Text = My.Settings.CheckBox2Text
                        Ut()
                    Else
                        My.Settings.CheckBox2Text = Pt.GetINI("CheckBoxText", "CBox21Text", "Data change state", filePath + "\config.ini")
                        CheckBox2.Text = My.Settings.CheckBox2Text
                        Ut()
                    End If
                Case "CheckBox3" '窗体保持最前勾选框
                    If CheckBox3.Checked = True Then
                        Me.TopMost = My.Settings.CheckBox3Checked
                    Else
                        Me.TopMost = My.Settings.CheckBox3Checked
                    End If
                Case "LabelMainPTColor" '主窗口自定义颜色
                    Dim MyDialog As New ColorDialog()
                    ' Keeps the user from selecting a custom color.
                    MyDialog.AllowFullOpen = True
                    ' Allows the user to get help. (The default is false.)
                    MyDialog.ShowHelp = True
                    ' Sets the initial color select to the current text color,
                    MyDialog.Color = Me.BackColor
                    ' Update the text box color if the user clicks OK 
                    If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        Me.BackColor = MyDialog.Color
                    End If
                Case "LabelTb3Color" '设置界面自定义颜色
                    Dim MyDialog As New ColorDialog()
                    ' Keeps the user from selecting a custom color.
                    MyDialog.AllowFullOpen = True
                    ' Allows the user to get help. (The default is false.)
                    MyDialog.ShowHelp = True
                    ' Sets the initial color select to the current text color,
                    MyDialog.Color = Me.TabPage3.BackColor
                    ' Update the text box color if the user clicks OK 
                    If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        Me.TabPage3.BackColor = MyDialog.Color
                    End If
                Case "LinkLabelAbout" '检测软件更新事件
                    '                On Error GoTo error1 '如运行中出现错误跳转到相应错误标记处执行
                    '                If My.Computer.FileSystem.FileExists(".\update.exe") = True Then '判断此文件存在时
                    '                    System.Diagnostics.Process.Start(".\update.exe") '启动此程序
                    '                Else
                    '                    MsgBox("I'm sorry, upgrade file is missing, please make sure that is not blocked by anti-virus software, or please try to reinstall.", MsgBoxStyle.Exclamation, "ERROR!")
                    '                End If
                    '                Exit Sub
                    'error1:         '错误标记
                    '                MsgBox(ErrorToString)
                    '                '增改，删除
                    'System.Diagnostics.Process.Start("http://bbs.guanjia.qq.com/?1552343")
                    MessageBox.Show(String.Format(
                                    "Product: {0}" + vbCrLf + "Version: {1}" + vbCrLf + "Copyright © 2014-2020 fesugar.com. All Rights Reserved.",
                                    Application.ProductName,
                                    Application.ProductVersion),
                                    "About-PasteTools", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "ButtonAdd"
                    '判断是否存在默认数据，如果没有数据则退出过程不操作
                    If Bvalue = Nothing Then
                        LabelStatu.Text = "Add" + "[Command failed]-Data not found." + DateTime.Now.Millisecond.ToString
                        Exit Sub
                    ElseIf Trim(TextBoxBtName.Text).Length = 0 Or Trim(TextBoxHovertip.Text).Length = 0 Then
                        LabelStatu.Text = "Add" + "[Command failed]-Input is not complete." + DateTime.Now.Millisecond.ToString
                        Exit Sub
                    End If
                    '执行添加
                    Pt.WriteINI("Buttons", "Button" + Bvalue, Trim(TextBoxBtName.Text), ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, Trim(TextBoxHovertip.Text), ITEMpath)
                    Pt.WriteINI("Buttons", "data" + Bvalue, ComboBox1.Text + Bvalue + ".dt", ITEMpath)
                    If Trim(richBoxTxData.TextLength) <> 0 Then
                        My.Computer.FileSystem.WriteAllText(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath), richBoxTxData.Text, False, System.Text.Encoding.Default)
                    Else
                        '判断是否存在数据，没有则不执行下面操作，退出，结束
                        If My.Computer.FileSystem.FileExists(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = True Then
                            My.Computer.FileSystem.DeleteFile(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath))
                        End If
                    End If
                    LabelStatu.Text = "Add" + "[Command successful]" + Now
                    '重新初始化数据
                    'Controls("Button" + Bvalue).Text = TextBox1.Text '使用 Controls 对象
                    Load_Data()

                Case "ButtonDelete"
                    '判断是否存在默认数据，如果没有数据则退出过程不操作
                    If Bvalue = Nothing Then
                        LabelStatu.Text = "Delete" + "[Command failed]-Data not found." + DateTime.Now.Millisecond.ToString
                        Exit Sub
                    End If
                    '执行删除
                    Pt.WriteINI("Buttons", "Button" + Bvalue, "Button" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, "ButtonTip" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "data" + Bvalue, ComboBox1.Text + Bvalue + ".dt", ITEMpath)
                    '判断是否存在数据，没有则不执行下面操作，退出，结束
                    If My.Computer.FileSystem.FileExists(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = True Then
                        My.Computer.FileSystem.DeleteFile(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath))
                    End If
                    LabelStatu.Text = "Delete" + "[Command successful]" + Now
                    '重新初始化数据
                    TextBoxBtName.Text = Nothing
                    TextBoxHovertip.Text = Nothing
                    richBoxTxData.Text = Nothing
                    'Controls("Button" + Bvalue).Text = TextBox1.Text '使用 Controls 对象
                    Load_Data()

                Case Else
                    '''''''
                    Bvalue = sender.name.ToString.Trim("B", "u", "t", "t", "o", "n").ToString
                    ''''''''''
                    If ButtonSelect IsNot Nothing Then
                        ButtonSelect.forecolor = Color.Black    '前面选择的菜单项前景色变为黑色
                    End If
                    sender.forecolor = Color.BlueViolet      '当前选择的菜单项前景色为亮亮蓝色
                    ButtonSelect = sender  '保存当前选择菜单项
                    ''''''''''''
                    If My.Settings.CheckBox2Checked = False Then '探测是粘贴还是修改状态 
                        Ut()
                        Exit Sub
                    End If
                    '判断是否存在数据，没有则不执行下面操作，退出，结束
                    If My.Computer.FileSystem.FileExists(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = False Then
                        Exit Sub
                    Else
                        fileReader = My.Computer.FileSystem.ReadAllText(filePath + "\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath),
                        System.Text.Encoding.Default)
                        '剪切板操作
                        My.Computer.Clipboard.Clear()
                        My.Computer.Clipboard.SetText(fileReader)
                        'System.Windows.Forms.SendKeys.Send("%{TAB}") '模拟快捷键 Alt+Tab 已舍弃使用
                        System.Windows.Forms.SendKeys.Send("%{ESC}") '模拟快捷键 Alt+Ese
                        'Threading.Thread.Sleep(GetINI("Thread", "Thread", "300", ITEMpath)) '程序挂起指定时间后继续 已舍弃使用
                        System.Windows.Forms.SendKeys.Send("^(v)") '模拟快捷键 Ctrl+V
                        Threading.Thread.Sleep(My.Settings.MaskedTextBox1Text) '程序挂起指定时间后继续执行
                        System.Windows.Forms.SendKeys.Send(Pt.GetINI("Send", "Send", "", filePath + "\config.ini")) '模拟快捷键 读取配置数据
                        '释放资源
                        fileReader = Nothing
                    End If
                    'Throw New NotImplementedException
            End Select
        Catch ex As UnauthorizedAccessException
            '判断程序是否有管理员权限。
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                '管理员
            Else
                '非管理员
                MessageBox.Show(Err.Description, Err.Number.ToString, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As System.ArgumentException
            MessageBox.Show(Err.Description, Err.Number.ToString, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Catch ex As Exception
            LabelStatu.Text = ex.Message.ToString + Now
        End Try
    End Sub

    '最小化、关闭按钮鼠标按下事件
    Private Sub Bt_MouseDown(sender As Object, e As MouseEventArgs) Handles Btc.MouseDown, Btm.MouseDown
        If sender.name.ToString = "Btc" Then
            Btc.Image = My.Resources.Resource.close_press
        ElseIf sender.name.ToString = "Btm" Then
            Btm.Image = My.Resources.Resource.minsize_press
        End If
    End Sub

    '最小化、关闭按钮鼠标悬停事件
    Private Sub Bt_MouseHover(sender As Object, e As EventArgs) Handles Btc.MouseHover, Btm.MouseHover
        If sender.name.ToString = "Btc" Then
            Btc.Image = My.Resources.Resource.close_hover
        ElseIf sender.name.ToString = "Btm" Then
            Btm.Image = My.Resources.Resource.minsize_hover
        End If
    End Sub

    '最小化、关闭按钮鼠标离开事件
    Private Sub Bt_MouseLeave(sender As Object, e As EventArgs) Handles Btc.MouseLeave, Btm.MouseLeave
        If sender.name.ToString = "Btc" Then
            Btc.Image = My.Resources.Resource.close_normal
        ElseIf sender.name.ToString = "Btm" Then
            Btm.Image = My.Resources.Resource.minsize_normal
        End If
    End Sub

    ' ///// Public Sub New /////
    Public Sub New()
        On Error Resume Next

        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。

        '写入注册表程序版本号
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools",
"Version", Nothing) <> Application.ProductVersion Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools",
     "Version", Windows.Forms.Application.ProductVersion)
        End If

        ListFiles(filePath + "\Mode\") '加载 ComboxBox 选项

        '加载初始设置信息
        ITEMpath = filePath + "\Mode\" + My.Settings.ComboBox1Text + ".ini" '模式路径
        ' Me.Text = Pt.GetINI("Main", "Title", "Paste", ITEMpath) '窗口标题
        ' TabPage1.Text = Pt.GetINI("TabControl1", "TabPage1", "TabPage1", ITEMpath) '集合1标题
        ' TabPage2.Text = Pt.GetINI("TabControl1", "TabPage2", "TabPage2", ITEMpath) '集合2标题
        ' TabPage3.Text = Pt.GetINI("TabControl1", "TabPage3", "TabPage3", ITEMpath) '集合3标题
        Label2.Text = String.Format("V:3.1({0})", My.Application.Info.Version.ToString) '版本号

        Me.TopMost = My.Settings.CheckBox3Checked '窗体显示最前

        Me.Top = 100 '窗体距离屏幕顶端距离

        '悬停提示的控件布局、设置
        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True

        '窗体宽高
        My.Settings.FormWidth = Me.Width
        My.Settings.FormHeight = Me.Height

        Ut()

        '
        'Buttons
        '
        TabPg() '动态加载按钮

        webload()

    End Sub

    '******************** 判断当前窗口是否激活 - 开始
    '********************
    'http://msdn.microsoft.com/ZH-CN/library/wka5e5ys(v=VS.110,d=hv.2).aspx
    ' Constant value was found in the "windows.h" header file.
    Private Const WM_ACTIVATEAPP As Integer = &H1C
    Private appActive As Boolean = True
    '字体
    Private title_font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        ' Paint a string in different styles depending on whether the
        ' application is active.
        If (appActive) Then
            ' e.Graphics.FillRectangle(SystemBrushes.ActiveCaption, 8, 9, 89, 20) '背景
            e.Graphics.DrawString(My.Settings.TitleText, title_font, SystemBrushes.ActiveCaptionText, 8, 9)
            '使用实例 e.Graphics.DrawString("This is a diagonal line drawn on the control", New Font("Arial", 10), Brushes.Red, New PointF(30.0F, 30.0F))
        Else
            'e.Graphics.FillRectangle(SystemBrushes.InactiveCaption, 8, 9, 89, 20) '背景
            e.Graphics.DrawString(My.Settings.TitleText, title_font, SystemBrushes.InactiveBorder, 8, 9)
        End If
    End Sub
    <System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")>
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Listen for operating system messages
        Select Case (m.Msg)
            ' The WM_ACTIVATEAPP message occurs when the application
            ' becomes the active application or becomes inactive.
            Case WM_ACTIVATEAPP

                ' The WParam value identifies what is occurring.
                appActive = (m.WParam.ToInt32() <> 0)

                ' Invalidate to get new text painted.
                Me.Invalidate()

        End Select
        MyBase.WndProc(m)
    End Sub
    '********************
    '********************判断当前窗口是否激活 - 结束

    Private Sub MainPT_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        Me.Refresh()
        Me.OnSizeChanged(e)
    End Sub


    '*** web

    Private content As String = ""


    Public Function GetContent() As String
        Return Me.content
    End Function


    Public Sub RequestContent(ByVal str As String)
        Me.content = str
        Me.richBoxTxData.Text = Me.content
    End Sub

    Private Sub richTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richBoxTxData.TextChanged, richBoxTxData.Click
        If Me.richBoxTxData.Focused Then
            Me.content = Me.richBoxTxData.Text
            Dim args As Object() = New Object() {Me.content}
            Me.WebBrowser1.Document.InvokeScript("setContent", args)
        End If
    End Sub

    Private Sub webBrowser1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowser1.Resize
        Me.WebBrowser1.Refresh()
    End Sub

    Private Sub webload()
        Me.WebBrowser1.Url = New Uri((Application.StartupPath & "\kindeditor\index.html"), UriKind.Absolute)
        Me.WebBrowser1.ObjectForScripting = Me
    End Sub
    '*** web end
End Class