Imports System.Runtime.InteropServices

Public Class PasteClass

    '╔═══════════════════════════════╗
    '║公共读写ini配置文件模块                                         ║
    '╚═══════════════════════════════╝
    '声明INI配置文件读写API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (
                                                                                                     ByVal lpApplicationName As String,
                                                                                                     ByVal lpKeyName As String,
                                                                                                     ByVal lpDefault As String,
                                                                                                     ByVal lpReturnedString As String,
                                                                                                     ByVal nSize As Int32,
                                                                                                     ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (
                                                                                                         ByVal lpApplicationName As String,
                                                                                                         ByVal lpKeyName As String,
                                                                                                         ByVal lpString As String,
                                                                                                         ByVal lpFileName As String) As Int32

    '声明读取配置文件全局函数
    Public Function GetINI(
                          ByVal Section As String,
                          ByVal AppName As String,
                          ByVal lpDefault As String,
                          ByVal FileName As String) As String
        Dim Str As String = Nothing
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    '声明写入配置文件全局函数
    Public Function WriteINI(
                            ByVal Section As String,
                            ByVal AppName As String,
                            ByVal lpDefault As String,
                            ByVal FileName As String) As Long

        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function
    '╔═══════════════════════════════╗
    '║公共移动无边框窗体模块                                         ║
    '╚═══════════════════════════════╝
    '声明窗体消息API函数
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (
                                              ByVal hwnd As IntPtr,
                                              ByVal wMsg As Integer,
                                              ByVal wParam As Integer,
                                              ByVal lParam As Integer) As Boolean
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
    Public Function IsMutex(ByVal name As String) As Boolean
        ' 只允许一个实例运行
        'http://msdn.microsoft.com/ZH-CN/library/bwe34f1k(v=VS.110,d=hv.2).aspx
        Dim requestInitialOwnership As Boolean = True
        Dim mutexWasCreated As Boolean
        Dim m As New Threading.Mutex(requestInitialOwnership, name, mutexWasCreated)

        If Not (requestInitialOwnership And mutexWasCreated) Then
            Return True  '返回true 在运行
        Else
            Return False '返回false 未运行
        End If

        ' 释放mutex
        m.ReleaseMutex()
    End Function
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
    '╔══════════════════════════════════════════════════════════════╗
    '║下面的代码示例演示如何使用 DllImportAttribute 特性导入 Win32 MessageBox 函数。 然后，代码示例将调用导入的方法。             ║
    '╚══════════════════════════════════════════════════════════════╝
    'http://msdn.microsoft.com/ZH-CN/library/e4takf5s(v=VS.110,d=hv.2).aspx

    Public Class Win32

        'http://msdn.microsoft.com/ZH-CN/library/42b9ea93(v=VS.110,d=hv.2).aspx
        Declare Auto Function MessageBox Lib "user32.dll" _
           (ByVal hWnd As Integer, ByVal txt As String, _
           ByVal caption As String, ByVal Typ As Integer) As IntPtr

        'http://msdn.microsoft.com/ZH-CN/library/7kedzzk0(v=VS.110,d=hv.2).aspx
        <DllImport("user32.dll", SetLastError:=True)> _
        Public Shared Function MessageBoxA(hWnd As IntPtr, text As String, _
               caption As String, type As UInteger) As Integer
        End Function

        ' PostMessage
        Declare Auto Function PostMessage Lib "user32.dll" Alias "PostMessage" (
                                                                                 ByVal hWnd As IntPtr,
                                                                                 ByVal wMsg As Integer,
                                                                                 ByVal wParam As Integer,
                                                                                 ByVal lParam As Integer) As Integer

        ' SendMessage
        <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
        Public Shared Function SendMessageA(ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Long) As Long
        End Function

        ' FindWindow
        Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" _
            (ByVal lpClassName As String, _
             ByVal lpWindowName As String _
             ) As Long


    End Class

End Class
