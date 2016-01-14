Public Class clsConexion
    Public Sub conectarbd()
        Try
            conbd.ConnectionString = "server=localhost" & ";" _
            & "port=3306; user id=root" & ";" _
            & "password=;" _
            & "database=bdautoservicio" & ";" _
            & "Allow Zero Datetime=False;Convert Zero Datetime=True;"
        Catch ex As Exception
            MsgBox("Error de conexión.")
        End Try
    End Sub
   'soporte
End Class
