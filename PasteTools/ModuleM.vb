
Module ModuleM
    '--------------------------------------------------
    Public filePath As String = Application.StartupPath '声明当前程序所在目录
    Public fileReader As String '声明文本读取全局变量
    Public ITEMpath As String '声明INI配置文件位置全局变量

    Public Sub main() 'Main 主函数

        '向控制台输出显示语句
        Console.WriteLine("**  Start True **")   'Console.WriteLine("string") 向控制台输出指定内容,并结束此行.

        Try

            'filePath 启动目录路径赋值
            If Not filePath.Trim().EndsWith("\") Then filePath += "\"
            filePath += ""

            ' 只允许一个实例运行
            'http://msdn.microsoft.com/ZH-CN/library/bwe34f1k(v=VS.110,d=hv.2).aspx
            Dim requestInitialOwnership As Boolean = True
            Dim mutexWasCreated As Boolean
            Dim m As New Threading.Mutex(requestInitialOwnership, "pastetools", _
                      mutexWasCreated)

            If Not (requestInitialOwnership And mutexWasCreated) Then
                MessageBox.Show(
                    "Error, this program has been running.",
                    "running",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return '返回
            End If

            REM 显示窗体
            Application.EnableVisualStyles() '启用可视样式
            'MainPT.Show()
            Application.Run(MainPT)

            ' 释放mutex
            m.ReleaseMutex()

        Catch ex As Exception
            '嵌入try catch 防止其他错误
            Try
                '将错误输入到日志文件
                Using w As IO.StreamWriter = IO.File.AppendText("Paste.log")
                    'Log("Test1", w)
                    Log(ErrorToString.ToString, w)
                End Using

                'Using r As IO.StreamReader = IO.File.OpenText("log.txt")
                '    DumpLog(r)
                'End Using

                '显示消息提示框
                MessageBox.Show("Initialization error" + vbCrLf + "The error code:" + Err.Number.ToString, _
                                "error:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Catch E As Exception
                MessageBox.Show(E.Message, Err.Number.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Application.Exit()
            End Try
        End Try
    End Sub

    '╔═══════════════════════════════╗
    '║打开并追加到日志文件             ║
    '╚═══════════════════════════════╝
    Private Sub Log(logMessage As String, w As IO.TextWriter)
        w.Write(vbCrLf + "Log Entry : ")
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), _
            DateTime.Now.ToLongDateString())
        w.WriteLine("  :")
        w.WriteLine("  :{0}", logMessage)
        w.WriteLine("-------------------------------")
    End Sub

    Private Sub DumpLog(r As IO.StreamReader)
        Dim line As String
        line = r.ReadLine()
        While Not (line Is Nothing)
            Console.WriteLine(line)
            line = r.ReadLine()
        End While
    End Sub

End Module
