Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Public Class WebPost
    ' Methods
    Public Shared Function ApiPost(ByVal url As String, ByVal parameters As IDictionary(Of String, String)) As String
        Dim ret As String
        Try
            Dim charset As Encoding = Encoding.UTF8
            Dim request As HttpWebRequest = Nothing
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf WebPost.CheckValidationResult)
            request = TryCast(WebRequest.Create(url.Trim), HttpWebRequest)
            request.ProtocolVersion = HttpVersion.Version10
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            request.UserAgent = WebPost.DefaultUserAgent
            If ((Not parameters Is Nothing) AndAlso (parameters.Count <> 0)) Then
                Dim buffer As New StringBuilder
                Dim key As String
                For Each key In parameters.Keys
                    buffer.AppendFormat(If((buffer.Length > 0), "&{0}={1}", "{0}={1}"), key, parameters.Item(key))
                Next
                Dim data As Byte() = charset.GetBytes(buffer.ToString)
                Using stream As Stream = request.GetRequestStream
                    stream.Write(data, 0, data.Length)
                End Using
            End If
            Dim response As HttpWebResponse = TryCast(request.GetResponse, HttpWebResponse)
            ret = New StreamReader(response.GetResponseStream).ReadToEnd
        Catch exception1 As Exception
            Throw
        End Try
        Return ret
    End Function

    Private Shared Function CheckValidationResult(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal errors As SslPolicyErrors) As Boolean
        Return True
    End Function


    ' Fields
    Private Shared ReadOnly DefaultUserAgent As String = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)"
End Class

