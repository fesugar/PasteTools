Public Class MainPT
    Dim Pt As New Paste.PasteClass ' 当前全局变量，功能模块
    Dim Bvalue As String '按钮序数

    Private Sub MainPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing  '窗体即将关闭时事件
        '保存设置
        My.Settings.Save()
    End Sub

    Private Sub MainPT_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove '鼠标移动事件
        Pt.Mform(Me.Handle) '拖动窗体
    End Sub

    Private Sub MainPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '如果出现错误，忽略错误，继续往下执行
        On Error Resume Next
        '进程判断，出现相同进程则退出
        ' 只允许一个实例运行
        If Pt.PrevInstance() Then
            MsgBox("Error, this program has been running.", MsgBoxStyle.Exclamation, "running") '消息提示
            Application.Exit()
            Exit Sub '退出过程，结束
        End If
        '写入注册表程序版本号
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools", _
"Version", Nothing) <> My.Application.Info.Version.ToString Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools", _
"Version", My.Application.Info.Version.ToString)
        End If
        If ComboBox1.Text = Nothing Then '如果没有值，默认为Item1
            My.Settings.ComboBox1Text = "Item1"
        End If
        '加载初始设置信息
        ITEMpath = ".\Mode\" + My.Settings.ComboBox1Text + ".ini" '模式路径
        Me.Text = Pt.GetINI("Main", "Title", "Paste", ITEMpath) '窗口标题
        TabPage1.Text = Pt.GetINI("TabControl1", "TabPage1", "TabPage1", ITEMpath) '集合1标题
        TabPage2.Text = Pt.GetINI("TabControl1", "TabPage2", "TabPage2", ITEMpath) '集合2标题
        TabPage3.Text = Pt.GetINI("TabControl1", "TabPage3", "TabPage3", ITEMpath) '集合3标题
        Mcolor.Text = Pt.GetINI("Main", "BackColor", "MainPTColor", ITEMpath) '主界面颜色修改
        Scolor.Text = Pt.GetINI("TabPage3", "BackColor", "TPsColor", ITEMpath) '设置界面颜色修改
        Label2.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString) '版本号
        Me.TopMost = My.Settings.CheckBox3Checked '窗体显示最前
        Me.Top = 100 '窗体距离屏幕顶端距离
        Ut()
        BT1()
        BT2()

    End Sub
    Public Function BT1()
        '如果出现错误，忽略错误，继续往下执行
        On Error Resume Next
        Dim Button(29) As Button '定义按钮,提示对象
        Dim i As Integer
        For i = Button.GetLowerBound(0) To Button.GetUpperBound(0)
            Button(i) = New Button
            'select 语句检测按钮数量
            Select Case i
                Case Is <= 14
                    TabPage1.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage1上
                    Button(i).Location = New System.Drawing.Point(3, i * 30 + 10) '按钮位置
                Case Is > 14 <= 29
                    TabPage1.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage1上
                    Button(i).Location = New System.Drawing.Point(83, i * 30 - 440) '按钮位置
                Case Else
                    Console.WriteLine("ERROR101.nothing")
            End Select
            '按钮设置开始
            Button(i).Cursor = System.Windows.Forms.Cursors.Hand '鼠标光标样式
            Button(i).Name = "Button" & i.ToString '按钮控件名
            Button(i).Size = New System.Drawing.Size(76, 24) '按钮尺寸大小
            Button(i).TabIndex = i '修改新加入控件的TabIndex值
            Button(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString, "Button" & i.ToString, ".\Mode\ITEM1.ini") '修改默认文本。
            Button(i).UseVisualStyleBackColor = True '按钮视觉
            Button(i).FlatStyle = FlatStyle.Flat  '按钮外观
            Button(i).FlatAppearance.BorderColor = Color.Orange '按钮边框颜色
            Button(i).FlatAppearance.BorderSize = 1  '按钮边框大小
            Button(i).FlatAppearance.MouseDownBackColor = Color.LightSkyBlue '按钮按下时工作区颜色
            Button(i).FlatAppearance.MouseOverBackColor = Color.LightSalmon   '按钮位于时工作区颜色
            '按钮设置结束
            REM http://msdn.microsoft.com/zh-cn/library/dxks2f7h(v=vs.110).aspx
            '悬停提示开始
            ' Create the ToolTip and associate with the Form container.
            Dim toolTip1 As New ToolTip()

            ' Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000
            toolTip1.InitialDelay = 1000
            toolTip1.ReshowDelay = 500
            ' Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = True

            ' Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(Button(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString, "ButtonTip" & i.ToString, ".\Mode\ITEM1.ini")) '修改默认文本。
            'toolTip1.SetToolTip(Me.CheckBox1, "My checkBox1")
            '悬停提示结束
            REM http://msdn.microsoft.com/query/dev12.query?appId=Dev12IDEF1&l=ZH-CN&k=k(vb.AddHandler);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv3.5);k(DevLang-VB)&rd=true
            AddHandler Button(i).Click, AddressOf Click_Click
        Next

        Return 0
    End Function
    Public Function BT2()
        '如果出现错误，忽略错误，继续往下执行
        On Error Resume Next
        Dim Button(29) As Button '定义按钮,提示对象
        Dim i As Integer
        For i = Button.GetLowerBound(0) To Button.GetUpperBound(0)
            Button(i) = New Button
            'select 语句检测按钮数量
            Select Case i
                Case Is <= 14
                    TabPage2.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage2上
                    Button(i).Location = New System.Drawing.Point(3, i * 30 + 10) '按钮位置
                Case Is > 14 <= 29
                    TabPage2.Controls.Add(Button(i)) '将一个按钮控件加入到TabPage2上
                    Button(i).Location = New System.Drawing.Point(83, i * 30 - 440) '按钮位置
                Case Else
                    Console.WriteLine("ERROR101.nothing")
            End Select
            '按钮设置开始
            Button(i).Cursor = System.Windows.Forms.Cursors.Hand '鼠标光标样式
            Button(i).Name = "Button" & i.ToString + 30 '按钮控件名
            Button(i).Size = New System.Drawing.Size(76, 24) '按钮尺寸大小
            Button(i).TabIndex = i '修改新加入控件的TabIndex值
            Button(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString + 30, "Button" & i.ToString + 30, ".\Mode\ITEM1.ini") '修改默认文本。
            Button(i).UseVisualStyleBackColor = True '按钮视觉
            Button(i).FlatStyle = FlatStyle.Flat  '按钮外观
            Button(i).FlatAppearance.BorderColor = Color.Orange '按钮边框颜色
            Button(i).FlatAppearance.BorderSize = 1  '按钮边框大小
            Button(i).FlatAppearance.MouseDownBackColor = Color.LightSkyBlue '按钮按下时工作区颜色
            Button(i).FlatAppearance.MouseOverBackColor = Color.LightSalmon   '按钮位于时工作区颜色
            '按钮设置结束
            REM http://msdn.microsoft.com/zh-cn/library/dxks2f7h(v=vs.110).aspx
            '悬停提示开始
            ' Create the ToolTip and associate with the Form container.
            Dim toolTip1 As New ToolTip()

            ' Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000
            toolTip1.InitialDelay = 1000
            toolTip1.ReshowDelay = 500
            ' Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = True

            ' Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(Button(i), Pt.GetINI("Buttons", "ButtonTip" & i.ToString + 30, "ButtonTip" & i.ToString + 30, ".\Mode\ITEM1.ini")) '修改默认文本。
            'toolTip1.SetToolTip(Me.CheckBox1, "My checkBox1")
            '悬停提示结束
            REM http://msdn.microsoft.com/query/dev12.query?appId=Dev12IDEF1&l=ZH-CN&k=k(vb.AddHandler);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv3.5);k(DevLang-VB)&rd=true
            AddHandler Button(i).Click, AddressOf Click_Click
        Next

        Return 0
    End Function
    '切换时布局和参数
    Public Function Ut()
        Dim intCounter As Integer
        BtName.Text = Pt.GetINI("alter", "label1", "BtName", ".\config.ini")
        Hovertip.Text = Pt.GetINI("alter", "label2", "Hover tip", ".\config.ini")
        Txdata.Text = Pt.GetINI("alter", "label3", "The text data:", ".\config.ini")
        Statu.Text = Pt.GetINI("alter", "label4", "Status:", ".\config.ini")
        Add.Text = Pt.GetINI("alter", "Button1", "Add", ".\config.ini")
        Delete.Text = Pt.GetINI("alter", "Button2", "Delete", ".\config.ini")
        If My.Settings.CheckBox2Checked = True Then
            If ClientSize = New System.Drawing.Size(500, 520) Then
                For intCounter = 13 To 1 Step -1
                    'Me.Refresh()
                    Threading.Thread.Sleep(10)
                    ClientSize = New System.Drawing.Size(Size.Width - 25, 520)
                Next
                BtName.Visible = False
                Hovertip.Visible = False
                Txdata.Visible = False
                Statu.Visible = False
                TextBox1.Visible = False
                TextBox2.Visible = False
                TextBox3.Visible = False
                Add.Visible = False
                Delete.Visible = False
            End If

            '主界面最小化.关闭按钮位置
            Btm.Location = New System.Drawing.Point(121, 8)
            Btc.Location = New System.Drawing.Point(147, 8)
        Else
            If ClientSize = New System.Drawing.Size(175, 520) Then
                For intCounter = 1 To 13 Step 1
                    'Me.Refresh()
                    Threading.Thread.Sleep(10)
                    ClientSize = New System.Drawing.Size(Size.Width + 25, 520)
                Next
                BtName.Visible = True
                Hovertip.Visible = True
                Txdata.Visible = True
                Statu.Visible = True
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox3.Visible = True
                Add.Visible = True
                Delete.Visible = True
            End If

            '主界面最小化.关闭按钮位置
            Btm.Location = New System.Drawing.Point(451, 8)
            Btc.Location = New System.Drawing.Point(474, 8)
        End If
        Return 0
    End Function
    Private ButtonSelect As Object = Nothing '声明私有变量 鼠标点击的前一按钮项
    '粘贴按钮单击事件
    Private Sub Click_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.LostFocus, _
        BtF1.Click, BtF2.Click, MaskedTextBox1.TextChanged, CheckBox1.Click, CheckBox2.Click, CheckBox3.Click, _
        LinkLabel1.Click, Btm.Click, Btc.Click, Add.Click, Delete.Click, Mcolor.Click, Scolor.Click
        Try
            '第三页选项卡
            Select Case sender.name.ToString
                Case "BtF1"
                    'System.Diagnostics.Process.Start(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
                    System.Diagnostics.Process.Start(Application.StartupPath & ".\data\")
                Case "BtF2"
                    'System.Diagnostics.Process.Start(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
                    System.Diagnostics.Process.Start(Application.StartupPath & ".\Mode\")
                Case "Btm" '最小化
                    Me.WindowState = FormWindowState.Minimized
                Case "Btc" '关闭
                    Application.Exit()
                Case "ComboBox1"
                    '修改模式按钮单击事件
                    My.Settings.ComboBox1Text = ComboBox1.Text
                    ITEMpath = ".\Mode\" + My.Settings.ComboBox1Text + ".ini"
                Case "MaskedTextBox1"
                    My.Settings.MaskedTextBox1Text = MaskedTextBox1.Text
                    '修改sleep 数值
                Case "CheckBox1" '快捷键勾选事件
                    If CheckBox1.Checked = True Then
                        Pt.WriteINI("Send", "Send", "^{ENTER}", ".\setting.ini")
                        My.Settings.CheckBox1Text = Pt.GetINI("CheckBoxText", "CBox10Text", "Ctrl + Enter key", ".\config.ini")
                        CheckBox1.Text = My.Settings.CheckBox1Text '加载显示
                    Else
                        Pt.WriteINI("Send", "Send", "{ENTER}", ".\setting.ini")
                        My.Settings.CheckBox1Text = Pt.GetINI("CheckBoxText", "CBox11Text", "Enter key", ".\config.ini")
                        CheckBox1.Text = My.Settings.CheckBox1Text '加载显示
                    End If
                Case "CheckBox2" '模式勾选框事件
                    If CheckBox2.Checked = True Then
                        My.Settings.CheckBox2Text = Pt.GetINI("CheckBoxText", "CBox20Text", "Paste state", ".\config.ini")
                        CheckBox2.Text = My.Settings.CheckBox2Text
                        Ut()
                    Else
                        My.Settings.CheckBox2Text = Pt.GetINI("CheckBoxText", "CBox21Text", "Data change state", ".\config.ini")
                        CheckBox2.Text = My.Settings.CheckBox2Text
                        Ut()
                    End If
                Case "CheckBox3" '窗体保持最前勾选框
                    If CheckBox3.Checked = True Then
                        Me.TopMost = My.Settings.CheckBox3Checked
                    Else
                        Me.TopMost = My.Settings.CheckBox3Checked
                    End If
                Case "Mcolor" '主窗口自定义颜色
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
                Case "Scolor" '主窗口自定义颜色
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
                Case "LinkLabel1" '检测软件更新事件
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
                    System.Diagnostics.Process.Start("http://bbs.guanjia.qq.com/?1552343")
                Case "Add"
                    '执行添加
                    Pt.WriteINI("Buttons", "Button" + Bvalue, TextBox1.Text, ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, TextBox2.Text, ITEMpath)
                    Pt.WriteINI("Buttons", "data" + Bvalue, "data" + Bvalue, ITEMpath)
                    If TextBox3.TextLength <> 0 Then
                        My.Computer.FileSystem.WriteAllText(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath), TextBox3.Text, False, System.Text.Encoding.Default)
                    Else
                        '判断是否存在数据，没有则不执行下面操作，退出，结束
                        If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = True Then
                            My.Computer.FileSystem.DeleteFile(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath))
                        End If
                    End If
                    Statu.Text = sender.name.ToString + "[Command successful]"
                    '重新初始化数据
                    'Controls("Button" + Bvalue).Text = TextBox1.Text '使用 Controls 对象
                    Dim i As Integer
                    For i = 0 To 29
                        If Bvalue > 29 Then
                            Me.TabPage2.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString + 30, "Button" & i.ToString + 30, ".\Mode\ITEM1.ini")
                        Else
                            Me.TabPage1.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString, "Button" & i.ToString, ".\Mode\ITEM1.ini")
                        End If
                    Next

                Case "Delete"
                    '执行删除
                    Pt.WriteINI("Buttons", "Button" + Bvalue, "Button" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, "ButtonTip" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "data" + Bvalue, "data" + Bvalue, ITEMpath)
                    '判断是否存在数据，没有则不执行下面操作，退出，结束
                    If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = True Then
                        My.Computer.FileSystem.DeleteFile(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath))
                    End If
                    Statu.Text = sender.name.ToString + "[Command successful]"
                    '重新初始化数据
                    TextBox1.Text = Nothing
                    TextBox2.Text = Nothing
                    TextBox3.Text = Nothing
                    'Controls("Button" + Bvalue).Text = TextBox1.Text '使用 Controls 对象
                    Dim i As Integer
                    For i = 0 To 29
                        If Bvalue > 29 Then
                            Me.TabPage2.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString + 30, "Button" & i.ToString + 30, ".\Mode\ITEM1.ini")
                        Else
                            Me.TabPage1.Controls.Item(i).Text = Pt.GetINI("Buttons", "Button" & i.ToString, "Button" & i.ToString, ".\Mode\ITEM1.ini")
                        End If
                    Next
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
                        TextBox1.Text = Pt.GetINI("Buttons", "Button" + Bvalue, "", ITEMpath)
                        TextBox2.Text = Pt.GetINI("Buttons", "ButtonTip" + Bvalue, "", ITEMpath)
                        '为了预防错误，如果文件存在则进行读取
                        If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath)) = True Then
                            TextBox3.Text = My.Computer.FileSystem.ReadAllText(".\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath), _
                                                System.Text.Encoding.Default)
                        Else
                            TextBox3.Text = Nothing
                        End If

                        Exit Sub
                    End If
                    '判断是否存在数据，没有则不执行下面操作，退出，结束
                    If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath)) = False Then
                        Exit Sub
                    Else
                        fileReader = My.Computer.FileSystem.ReadAllText(".\data\" & Pt.GetINI("Buttons", "data" + Bvalue, "", ITEMpath), _
                        System.Text.Encoding.Default)
                        '剪切板操作
                        My.Computer.Clipboard.Clear()
                        My.Computer.Clipboard.SetText(fileReader)
                        'System.Windows.Forms.SendKeys.Send("%{TAB}") '模拟快捷键 Alt+Tab 已舍弃使用
                        System.Windows.Forms.SendKeys.Send("%{ESC}") '模拟快捷键 Alt+Ese
                        'Threading.Thread.Sleep(GetINI("Thread", "Thread", "300", ITEMpath)) '程序挂起指定时间后继续 已舍弃使用
                        System.Windows.Forms.SendKeys.Send("^(v)") '模拟快捷键 Ctrl+V
                        Threading.Thread.Sleep(My.Settings.MaskedTextBox1Text) '程序挂起指定时间后继续执行
                        System.Windows.Forms.SendKeys.Send(Pt.GetINI("Send", "Send", "^{ENTER}", ".\setting.ini")) '模拟快捷键 读取配置数据
                        '释放资源
                        fileReader = Nothing
                    End If
                    'Throw New NotImplementedException
            End Select

        Catch ex As Exception
            Statu.Text = ex.Message.ToString
        End Try
    End Sub
End Class