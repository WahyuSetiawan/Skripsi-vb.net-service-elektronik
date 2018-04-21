Module PublicFunction
    Dim appPathReport As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "") & "\Laporan\"

    Function getLaporanPath(ByVal file As String) As String
        Dim path As String = ""

        path = appPathReport & file

        If System.IO.File.Exists(path) Then
            getLaporanPath = path
        Else
            MsgBox("File laporan tidak ditemukan di path : " & path)
            getLaporanPath = ""
        End If
    End Function
End Module
