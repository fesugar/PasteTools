Module ModuleM
    '--------------------------------------------------
    Public readValue As String '声明读取模式注册表值全局变量
    Public fileReader As String '声明文本读取全局变量
    Public ITEMpath As String '声明INI配置文件位置全局变量
    Public Sub main()     'Main 主函数
        Try
            '向控制台输出显示语句
            Console.WriteLine("**  run **")   'Console.WriteLine("string") 向控制台输出指定内容,并结束此行.
            REM 显示窗体
            Application.EnableVisualStyles()
            'MainPT.Show()
            Application.Run(MainPT)
        Catch ex As Exception
            '将错误输入到日志文件
            My.Computer.FileSystem.WriteAllText( _
                Application.StartupPath & "\Paste.log", _
                "Error||=======" + Now + vbCrLf + ErrorToString.ToString + vbCrLf, True, System.Text.Encoding.Default)
            '显示消息提示框
            MessageBox.Show("Initialization error" + vbCrLf + "The error code:" + Err.Number.ToString, _
                            "error:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Module
