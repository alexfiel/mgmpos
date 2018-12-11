Imports System.Globalization
Imports System.Net

Public Class GetNetTime
    Public Shared Function GetUTC()
        ' connect to google servers
        ' you could use some SNTP time servers but can't be sure port will be open
        ' or you could just ping your own webserver
        Dim myNetRequest As WebRequest = HttpWebRequest.Create("http://www.example.com")
        ' read response header from connection
        Dim response = myNetRequest.GetResponse()
        ' read date/time header
        ' assume its UTC format
        Dim GlobalUTC As String = response.Headers("date").ToString
        ' convert string to datetime object
        Dim parsedDateTime As DateTime = DateTime.Parse(GlobalUTC)
        ' get UNIX time stamp
        Dim unixTime = (parsedDateTime - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Return unixTime
    End Function
End Class
