
Module Module1

    Dim RunPath As String = Nothing '注册表路径
    Sub Main()
        Try

            ' 只允许一个实例运行
            If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then End

            Console.WriteLine(1011)
            '判断进程，结束
            If System.Diagnostics.Process.GetProcessesByName("PasteTools").Length > 0 Then '存在时

                '提示是否结束进程
                If MsgBox("检测到 PasteTools（粘贴工具）正在运行，选择""确定""将关闭" + vbCrLf + "PasteTools（粘贴工具）进行更新，选择""取消""，将退出更新。", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "粘贴工具在线更新...") = MsgBoxResult.Ok Then
                    '执行命令
                    Dim p() As Diagnostics.Process = Diagnostics.Process.GetProcessesByName("PasteTools")
                    p(0).Kill()
                Else
                    MsgBox("您取消了 PasteTools（粘贴工具）的在线更新。", MsgBoxStyle.Information, "提示！")
                    Exit Sub
                End If

            End If

            Threading.Thread.Sleep(200)


            '读取注册表获取启动目录路径
            RunPath = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools", _
           "Path", Nothing)

            '判断注册表中的目录字符串是否真实存在
            If My.Computer.FileSystem.DirectoryExists(RunPath) Then
                Dim getInfo = My.Computer.FileSystem.GetDirectoryInfo(
                    RunPath)
                Console.WriteLine("The directory was created at " & getInfo.CreationTime)
                Console.WriteLine("The directory was last accessed at " & getInfo.LastAccessTime)
                Console.WriteLine("The directory was last written to at " & getInfo.LastWriteTime)
            Else
                MsgBox("检测到 PasteToolsUp（粘贴工具升级程序）所在路径错误，请尝试再次运行升级程序。", MsgBoxStyle.Critical, "粘贴工具在线更新失败")
                Exit Sub
            End If

            Dim source() As Byte = Nothing
            source = My.Resources.Ionic_Zip
            Dim fs As New IO.FileStream(System.Windows.Forms.Application.StartupPath + "\Ionic.Zip.dll", IO.FileMode.Create)
            fs.Write(source, 0, source.Length)
            fs.Close()
            'new
            Dim source1() As Byte = Nothing
            source1 = My.Resources.PasteTools
            Dim fs1 As New IO.FileStream(System.Windows.Forms.Application.StartupPath + "\PasteTools.zip", IO.FileMode.Create)
            fs1.Write(source1, 0, source1.Length)
            fs1.Close()

            Threading.Thread.Sleep(50)

            zip()

            Threading.Thread.Sleep(20)
            'run
            System.Diagnostics.Process.Start(RunPath + "\PasteTools.exe")
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub zip()
        Try
            Using zip As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(System.Windows.Forms.Application.StartupPath + "\PasteTools.zip")
                zip.StatusMessageTextWriter = System.Console.Out
                'Status Messages will be sent to the console during extraction
                zip.ExtractAll(RunPath, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
            End Using
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

End Module
