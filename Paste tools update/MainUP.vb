Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Security.Cryptography

Public Class MainUP
    Dim Ver As String = Nothing '注册表版本
    Dim ServUrl As String = Nothing '服务器文件地址
    Dim ServVer As String = Nothing '服务器版本
    Dim ServMd5 As String = Nothing '服务器MD5
    Private document As XmlDocument = Nothing

    Private Sub MainUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '禁用升级按钮
            Btn_downBool(False)

            '写入注册表路径
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools",
    "Path", Nothing) <> My.Application.Info.DirectoryPath Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools",
        "Path", My.Application.Info.DirectoryPath)
            End If

            '获取注册表版本号
            Ver = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\FeSugar\Reply to paste tools",
    "Version", Nothing)

            ' 判断联网
            If My.Computer.Network.IsAvailable = False Then '网络连接状态为未连接
                err(1) '网络未连接
                Exit Sub
                'ElseIf My.Computer.Network.IsAvailable = True Then '网络连接状态为已经连接
            End If

            '创建线程
            'http://msdn.microsoft.com/ZH-CN/library/y5htx827(v=VS.110,d=hv.2).aspx
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf ThreadProc_clintUp))

        Catch ex As Exception
            err(0) '其他错误
        End Try
        GC.Collect()

        'Dim [source] As String = "Hello World!"

        'Using md5Hash As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()

        '    Dim hash As String = GetMd5Hash(md5Hash, source)

        '    Console.WriteLine("The MD5 hash of " + source + " is: " + hash + ".")

        'End Using


        ' PictureBox1.Image = Image.FromStream(New IO.MemoryStream(bytes))

    End Sub
    '[升级按钮]
    Private Sub Btn_down_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_down.Click
        Try
            ' Start the download operation in the background.
            Me.backgroundWorker1.RunWorkerAsync()

            ' Disable the button for the duration of the download.
            Me.Btn_down.Enabled = False

            ' Once you have started the background thread you 
            ' can exit the handler and the application will 
            ' wait until the RunWorkerCompleted event is raised.

            ' If you want to do something else in the main thread,
            ' such as update a progress bar, you can do so in a loop 
            ' while checking IsBusy to see if the background task is
            ' still running.
            While Me.backgroundWorker1.IsBusy
                ProgressBar1.Increment(1)
                ' Keep UI messages moving, so the form remains 
                ' responsive during the asynchronous operation.
                Application.DoEvents()
            End While
        Catch ex As Exception
            err(0)
        End Try
    End Sub
    '[退出按钮]
    Private Sub Btn_exit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_exit.Click
        Application.Exit()
    End Sub

    'backgroundWorker1_DoWork
    Private Sub backgroundWorker1_DoWork(
         ByVal sender As Object,
         ByVal e As DoWorkEventArgs) _
         Handles backgroundWorker1.DoWork
        Try
            My.Computer.Network.DownloadFile(
     ServUrl,
      My.Computer.FileSystem.SpecialDirectories.Temp & "\" + ServMd5.Substring(1, 6) + ".exe", "", "", False, 3000, True)

        Catch ex As Exception
            err(0)
        End Try
    End Sub

    'backgroundWorker1_RunWorkerCompleted
    Private Sub backgroundWorker1_RunWorkerCompleted(
        ByVal sender As Object,
        ByVal e As RunWorkerCompletedEventArgs) _
        Handles backgroundWorker1.RunWorkerCompleted
        On Error Resume Next
        ' Set progress bar to 100% in case it isn't already there.
        ProgressBar1.Value = 100

        If e.Error Is Nothing Then

            Using md5Hash As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
                Dim hash As String = GetMd5Hash(My.Computer.FileSystem.SpecialDirectories.Temp & "\" + ServMd5.Substring(1, 6) + ".exe")
                If hash <> ServMd5 Then
                    err(2)
                    Exit Sub
                End If
            End Using
            Threading.Thread.Sleep(500)
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\" + ServMd5.Substring(1, 6) + ".exe")
            Threading.Thread.Sleep(100)
            Application.Exit()

            'Console.WriteLine(output.ToString())
        Else
            MessageBox.Show("Failed to download file", "Download failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Enable the download button and reset the progress bar.
        Me.Btn_down.Enabled = True
        ProgressBar1.Value = 0
    End Sub

    'TextBox_Msg.Text 线程安全
    Private Sub SetText(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.TextBox_Msg.InvokeRequired Then
            Dim d As New ContextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.TextBox_Msg.Text = [text]
        End If
    End Sub

    'Label_tip.Text 线程安全
    Private Sub TipText(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Label_tip.InvokeRequired Then
            Dim d As New ContextCallback(AddressOf TipText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.Label_tip.Text = [text]
        End If
    End Sub

    'Btn_down.Enabled 线程安全
    Private Sub Btn_downBool(ByVal [Bool] As Boolean)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Btn_down.InvokeRequired Then
            Dim d As New ContextCallback(AddressOf Btn_downBool)
            Me.Invoke(d, New Object() {[Bool]})
        Else
            Me.Btn_down.Enabled = [Bool]
        End If
    End Sub

    'ProgressBar1.Visible 线程安全
    Private Sub ProgressBar1Bool(ByVal [ProgressBar1] As Boolean)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.ProgressBar1.InvokeRequired Then
            Dim d As New ContextCallback(AddressOf ProgressBar1Bool)
            Me.Invoke(d, New Object() {[ProgressBar1]})
        Else
            Me.ProgressBar1.Visible = [ProgressBar1]
        End If
    End Sub

    '统一显示错误信息的方法
    Private Function err(ByVal ErNumber As Integer) As Integer
        Select Case ErNumber
            Case 1 '网络未连接
                ' Me.TextBox_Msg.Text = "出现错误，在线升级失败。" + vbCrLf + vbCrLf + "请进入下载首页进行下载升级为最新版本。"
                Me.SetText("出现错误，在线升级失败。" + vbCrLf + "未成功连接至网络，请检查网络连接和防火墙设置。")
                'Me.Label_tip.Text = "在线升级失败"
                Me.TipText("检测更新失败")
            Case 2 '文件效验
                ' Me.TextBox_Msg.Text = "出现错误，在线升级失败。" + vbCrLf + vbCrLf + "请进入下载首页进行下载升级为最新版本。"
                Me.SetText("出现错误，在线升级失败。" + vbCrLf + "升级文件效验失败，请尝试重新运行升级程序。")
                'Me.Label_tip.Text = "在线升级失败"
                Me.TipText("检测更新失败")
            Case 3
                '预留
            Case Else
                ' Me.TextBox_Msg.Text = "出现错误，在线升级失败。" + vbCrLf + vbCrLf + "请进入下载首页进行下载升级为最新版本。"
                Me.SetText("出现错误，在线升级失败。" + vbCrLf + "请进入下载首页下载升级补丁升级为最新版本。")
                'Me.Label_tip.Text = "在线升级失败"
                Me.TipText("检测更新失败")
        End Select

        'Btn_down.Enabled = False
        Me.Btn_downBool(False)
        'ProgressBar1.Visible = False
        Me.ProgressBar1Bool(False)
        Return 0
    End Function
    '╔═══════════════════════════════╗
    '║  The MD5 hash        ║
    '╚═══════════════════════════════╝
    Private Function GetMd5Hash(ByVal md5Hash As Security.Cryptography.MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(System.Text.Encoding.Default.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New System.Text.StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function

    '获取文件MD5值的函数
    Private Function GetMd5Hash(ByVal FilePath As String) As String
        Dim Fstream As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
        Dim source(Fstream.Length - 1) As Byte
        Fstream.Read(source, 0, Fstream.Length)
        Fstream.Close()
        Dim data As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(source)
        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New System.Text.StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        ' Return the hexadecimal string.
        Return sBuilder.ToString()
    End Function

    ' This method does not trap for exceptions. If an exception is 
    ' encountered opening the file to be copied or writing to the 
    ' destination location, then the exception will be thrown to 
    ' the requestor.
    'Dim bytes = My.Computer.FileSystem.ReadAllBytes(
    '         "C:/Documents and Settings/selfportrait.jpg")
    'PictureBox1.Image = Image.FromStream(New IO.MemoryStream(bytes))


    Private Sub CopyBinaryFile(ByVal path As String,
                              ByVal copyPath As String,
                              ByVal bufferSize As Integer,
                              ByVal overwrite As Boolean)

        Dim inputFile = IO.File.Open(path, IO.FileMode.Open)

        If overwrite AndAlso My.Computer.FileSystem.FileExists(copyPath) Then
            My.Computer.FileSystem.DeleteFile(copyPath)
        End If

        ' Adjust array length for VB array declaration.
        Dim bytes = New Byte(bufferSize - 1) {}

        While inputFile.Read(bytes, 0, bufferSize) > 0
            My.Computer.FileSystem.WriteAllBytes(copyPath, bytes, True)
        End While

        inputFile.Close()
    End Sub

    '浏览下载页面
    Private Sub LinkLabel_url_Click(sender As Object, e As EventArgs) Handles LinkLabel_url.Click
        System.Diagnostics.Process.Start("https://fesugar.github.io/PasteTools/")
    End Sub

    '检测更新线程
    Private Sub ThreadProc_clintUp()
        Try

            document = New XmlDocument()

            ' Replace this file name with a valid file name.
            document.Load("https://github.com/fesugar/PasteTools/raw/master/PasteToolsUP.xml")
            ' Uncomment the following line to
            ' simulate a noticeable latency.
            'Thread.Sleep(5000);
            ' Dim output As System.Text.StringBuilder = New System.Text.StringBuilder()

            Dim xmlString As String = document.InnerXml

            ' Create an XmlReader
            Using reader As XmlReader = XmlReader.Create(New StringReader(xmlString))

                reader.ReadToFollowing("update")
                reader.MoveToFirstAttribute()
                ServVer = reader.Value
                'output.AppendLine("The genre value: " + ServVer)
                reader.ReadToFollowing("Log")
                reader.MoveToFirstAttribute()
                'TextBox_Msg.Text = reader.Value.ToString
                SetText(reader.Value.ToString)
                'output.AppendLine("Content of the title element: " + reader.Value.ToString())
                reader.ReadToFollowing("Url")
                reader.MoveToFirstAttribute()
                ServUrl = reader.Value.ToString
                'output.AppendLine("Content of the title element: " + reader.Value.ToString())
                reader.ReadToFollowing("Md5")
                reader.MoveToFirstAttribute()
                ServMd5 = reader.Value.ToString
                'output.AppendLine("Content of the title element: " + reader.Value.ToString())
            End Using
            If Ver = ServVer Then
                'Me.Label_tip.Text = "当前已是最新版本，无需升级。"
                TipText("当前已是最新版本，无需升级。")
                'Me.TextBox_Msg.Text = "当前版本:" + Ver + vbCrLf + "您已经安装了最新版本，感谢您对粘贴工具的支持。"
                SetText("当前版本:" + Ver + vbCrLf + "您已经安装了最新版本，感谢您对粘贴工具的支持。")
                'Me.ProgressBar1.Visible = False
                ProgressBar1Bool(False)
                'Me.Btn_down.Enabled = False
                Btn_downBool(False)
                Exit Sub
            End If
            '新版本
            TipText("发现新版本")
            '启用升级按钮
            Btn_downBool(True)


        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub
End Class