Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class OperateIniFile
    ' Methods
    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Long
    End Function

    Public Shared Function ReadIniData(ByVal section As String, ByVal key As String, ByVal noText As String, ByVal iniFilePath As String) As String
        If (iniFilePath.IndexOf("\"c) = -1) Then
            iniFilePath = (AppDomain.CurrentDomain.SetupInformation.ApplicationBase & iniFilePath)
        End If
        If Not File.Exists(iniFilePath) Then
            File.CreateText(iniFilePath)
        End If
        Dim temp As New StringBuilder(&H400)
        OperateIniFile.GetPrivateProfileString(section, key, noText, temp, &H400, iniFilePath)
        Return temp.ToString
    End Function

    Public Shared Function WriteIniData(ByVal section As String, ByVal key As String, ByVal value As String, ByVal iniFilePath As String) As Boolean
        If (iniFilePath.IndexOf("\"c) = -1) Then
            iniFilePath = (AppDomain.CurrentDomain.SetupInformation.ApplicationBase & iniFilePath)
        End If
        If Not File.Exists(iniFilePath) Then
            File.CreateText(iniFilePath)
        End If
        Return (OperateIniFile.WritePrivateProfileString(section, key, value, iniFilePath) <> 0)
    End Function

    <DllImport("kernel32")>
    Private Shared Function WritePrivateProfileString(ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    End Function

End Class
