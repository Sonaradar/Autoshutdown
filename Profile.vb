Public Class Profile
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Long
    Private Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lplFilename As String) As Long
    Public Shared Function WriteOneString(ByVal section As String, ByVal key As String, ByVal value As String, ByVal filename As String) As Long
        Dim X As Boolean
        Dim Nbuff As New String(CType(" ", Char), 1000)
        Nbuff = value + Chr(0)
        X = WritePrivateProfileString(section, key, Nbuff, filename)
        WriteOneString = X
    End Function

    Public Shared Function ReadOneString(ByVal section As String, ByVal key As String, ByVal Filename As String) As String
        Dim X As Long, i As Integer

        Dim Buffer As New String(CType(" ", Char), 1000)
        X = GetPrivateProfileString(section, key, "", Buffer, 1000, Filename)
        i = InStr(Buffer, Chr(0))
        ReadOneString = Trim(Left(Buffer, i - 1))
    End Function
    Public Shared Function TimerFixer(ByVal Time As Integer) As String
        Dim FixedTime As String
        Dim Hour As Integer
        Dim Minute As Integer
        Dim FixedHour As String
        Dim FixedMinute As String
        Hour = Int(Time / 3600)
        Minute = Int((Time - Int(Time / 3600) * 3600) / 60)
        If Len(Str(Hour)) <= 1 Then
            FixedHour = "0" & Str(Hour)
        Else
            FixedHour = Str(Hour)
        End If
        If Len(Str(Minute)) <= 1 Then
            FixedMinute = "0" & Str(Minute)
        Else
            FixedMinute = Str(Minute)
        End If
        FixedTime = FixedHour & "：" & FixedMinute
        TimerFixer = FixedTime
    End Function
End Class
