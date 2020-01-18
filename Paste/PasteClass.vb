Public Class PasteClass

    '╔═══════════════════════════════╗
    '║公共读写ini配置文件模块                                         ║
    '╚═══════════════════════════════╝
    '声明INI配置文件读写API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    '声明读取配置文件全局函数
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = Nothing
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    '声明写入配置文件全局函数
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function
    '╔═══════════════════════════════╗
    '║公共移动无边框窗体模块                                         ║
    '╚═══════════════════════════════╝
    '声明窗体消息API函数
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" ( _
                                              ByVal hwnd As IntPtr, _
                                              ByVal wMsg As Integer, _
                                              ByVal wParam As Integer, _
                                              ByVal lParam As Integer) _
                                              As Boolean
    Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Const WM_SYSCOMMAND = &H112
    Const SC_MOVE = &HF010&
    Const HTCAPTION = 2
    Public Function Mform(ByVal hwnd As IntPtr) As Long
        ReleaseCapture()
        Mform = SendMessage(hwnd, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Function
    '╔═══════════════════════════════╗
    '║使用 System.Threading.Mutex 互斥，禁止程序同时运行             ║
    '╚═══════════════════════════════╝
    '需要Imports System.Threading
    'Private Function IsMyMutex() As Boolean
    '    Dim IsExist As Boolean
    '    Dim MyMutex As New Mutex(True, "OnlyRun", IsExist)
    '    If IsExist Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function
    '╔═══════════════════════════════╗
    '║用 GetProcessesByName方法 取得当前程序名称，                  ║
    '║Process.GetCurrentProcess().ProcessName。GetProcessesByName    ║
    '║方法 回傳陣列，所以若有大於1就表示有兩個程式在執行             ║
    '╚═══════════════════════════════╝
    Function PrevInstance() As Boolean
        If UBound(System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
