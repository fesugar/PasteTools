Public Class alter
    Dim Pt As New Paste.PasteClass ' 当前全局变量，功能模块
    Dim Bvalue As String = Pt.GetINI("Set", "sender", "", ".\setting.ini") '声明按钮数字字符串全局变量
    Public TextBox1, TextBox2, TextBox3 As New TextBox

    Public Function At()
        Try

            ' Create a new instance of the form.
            ' Create tree Labels.
            Dim label1 As New Label
            Dim label2 As New Label
            Dim label3 As New Label
            ' Create tree buttons to use as the alter、 delete and cancel buttons.
            Dim button1 As New Button()
            Dim button2 As New Button()
            Dim button3 As New Button()
            ' Create tree TextBoxs.
            Dim TextBox1 As New TextBox
            Dim TextBox2 As New TextBox
            Dim TextBox3 As New TextBox
            REM 进行布局设置
            '
            'Label1
            '
            label1.AutoSize = True
            label1.Location = New System.Drawing.Point(182, 63)
            label1.Name = "Label1"
            label1.Size = New System.Drawing.Size(41, 12)
            label1.TabIndex = 0
            label1.Text = Pt.GetINI("alter", "label1", "BtName", ".\config.ini")
            '
            'Label2
            '
            label2.AutoSize = True
            label2.Location = New System.Drawing.Point(325, 63)
            label2.Name = "Label2"
            label2.Size = New System.Drawing.Size(41, 12)
            label2.TabIndex = 1
            label2.Text = Pt.GetINI("alter", "label2", "Hover tip", ".\config.ini")
            '
            'Label3
            '
            label3.AutoSize = True
            label3.Location = New System.Drawing.Point(182, 93)
            label3.Name = "Label3"
            label3.Size = New System.Drawing.Size(41, 12)
            label3.TabIndex = 5
            label3.Text = Pt.GetINI("alter", "label3", "The text data:", ".\config.ini")
            '
            'TextBox1
            '
            TextBox1.Location = New System.Drawing.Point(242, 60)
            TextBox1.Name = "TextBox1"
            TextBox1.Size = New System.Drawing.Size(77, 21)
            TextBox1.TabIndex = 2
            TextBox1.Text = Pt.GetINI("Buttons", "Button" + Bvalue, "", ITEMpath)
            '
            'TextBox2
            '
            TextBox2.Location = New System.Drawing.Point(386, 60)
            TextBox2.Name = "TextBox2"
            TextBox2.Size = New System.Drawing.Size(100, 21)
            TextBox2.TabIndex = 3
            TextBox2.Text = Pt.GetINI("Buttons", "ButtonTip" + Bvalue, "", ITEMpath)
            '
            'TextBox3
            '
            TextBox3.Location = New System.Drawing.Point(184, 113)
            TextBox3.Multiline = True
            TextBox3.Name = "TextBox3"
            TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            TextBox3.Size = New System.Drawing.Size(300, 350)
            TextBox3.TabIndex = 9
            '为了预防错误，如果文件存在则进行读取
            If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath)) = True Then
                TextBox3.Text = My.Computer.FileSystem.ReadAllText(".\data\" & Pt.GetINI("Buttons", "Data" + Bvalue, "", ITEMpath), _
                                    System.Text.Encoding.Default)
            End If
            '
            'Button1
            '
            button1.Location = New System.Drawing.Point(200, 473)
            button1.Name = "Button1"
            button1.Size = New System.Drawing.Size(59, 28)
            button1.TabIndex = 6
            button1.Text = Pt.GetINI("alter", "Button1", "Add", ".\config.ini")
            button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            button2.Location = New System.Drawing.Point(289, 473)
            button2.Name = "Button2"
            button2.Size = New System.Drawing.Size(59, 28)
            button2.TabIndex = 7
            button2.Text = Pt.GetINI("alter", "Button2", "Delete", ".\config.ini")
            button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            button3.Location = New System.Drawing.Point(378, 473)
            button3.Name = "Button3"
            button3.Size = New System.Drawing.Size(59, 28)
            button3.TabIndex = 8
            button3.Text = Pt.GetINI("alter", "Button3", "Cancel", ".\config.ini")
            button3.UseVisualStyleBackColor = True
            '

            REM 添加标签
            ' Add label1 to the form.
            MainPT.Controls.Add(label1)
            ' Add label2 to the form.
            MainPT.Controls.Add(label2)
            ' Add label3 to the form.
            MainPT.Controls.Add(label3)
            REM 添加文本框
            ' Add TextBox1 to the form.
            MainPT.Controls.Add(TextBox1)
            ' Add TextBox2 to the form.
            MainPT.Controls.Add(TextBox2)
            ' Add TextBox3 to the form.
            MainPT.Controls.Add(TextBox3)
            REM 添加按钮
            ' Add button1 to the form.
            MainPT.Controls.Add(button1)
            ' Add button2 to the form.
            MainPT.Controls.Add(button2)
            ' Add button3 to the form.
            MainPT.Controls.Add(button3)

            AddHandler button1.Click, AddressOf Button_Click
            AddHandler button2.Click, AddressOf Button_Click
            AddHandler button3.Click, AddressOf Button_Click
        Catch ex As Exception
            '将错误输入到日志文件
            My.Computer.FileSystem.WriteAllText( _
                Application.StartupPath & "\Paste.log", _
                "Error||=======" + Now + vbCrLf + ex.Message + vbCrLf, True, System.Text.Encoding.Default)
        End Try
        Return 0
       
    End Function
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

    'Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    'Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    'Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Select Case sender.name.ToString
                Case "Button1"
                    Pt.WriteINI("Buttons", "Button" + "Button1", TextBox1.Text, ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, TextBox2.Text, ITEMpath)
                    Pt.WriteINI("Buttons", "dt" + Bvalue, "dt" + Bvalue, ITEMpath)
                    If TextBox3.Text.Length <> 0 Then
                        My.Computer.FileSystem.WriteAllText(".\data\" & Pt.GetINI("Buttons", "dt" + Bvalue, "", ITEMpath), TextBox3.Text, False, System.Text.Encoding.Default)
                    Else
                        '判断是否存在数据，没有则不执行下面操作，退出，结束
                        If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "dt" + Bvalue, "", ITEMpath)) = True Then
                            My.Computer.FileSystem.DeleteFile(".\data\" & Pt.GetINI("Buttons", "dt" + Bvalue, "", ITEMpath))
                        End If
                    End If
                Case "Button2"
                    Pt.WriteINI("Buttons", "Button" + Bvalue, "Button" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "ButtonTip" + Bvalue, "ButtonTip" + Bvalue, ITEMpath)
                    Pt.WriteINI("Buttons", "dt" + Bvalue, "dt" + Bvalue, ITEMpath)
                    '判断是否存在数据，没有则不执行下面操作，退出，结束
                    If My.Computer.FileSystem.FileExists(".\data\" & Pt.GetINI("Buttons", "dt" + Bvalue, "", ITEMpath)) = True Then
                        My.Computer.FileSystem.DeleteFile(".\data\" & Pt.GetINI("Buttons", "dt" + Bvalue, "", ITEMpath))
                    End If

                Case "Button3"
                    TextBox1.Text = Nothing
                    TextBox2.Text = Nothing
                    TextBox3.Text = Nothing
                Case Else
                    Console.WriteLine("ERROR:")
            End Select
        Catch ex As Exception
            '显示消息提示框
            MessageBox.Show(ErrorToString, _
                            "error:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class
