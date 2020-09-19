Imports System.Data
Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlException

Public Class Conexion
    Private oConexion As New SqlConnection("Data Source=.;Initial Catalog=arriendos;Integrated Security=True")
    
    Private Function Conectar() As Boolean
        Try
            If (oConexion.State = ConnectionState.Open) Then
                oConexion.Close()
            End If

            oConexion.Open()
            Return True
        Catch ex As Exception
            MsgBox("NO NOS HEMOS CONETADO A LA BASE DE DATOS... ")
            Return False
        End Try
    End Function

    Public Sub AccionSQL(ByVal SQL As String)
        If (Conectar() = True) Then
            Try
                Dim cmdSQL = New SqlCommand(SQL, oConexion)
                cmdSQL.ExecuteNonQuery()
                oConexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Public Sub SelectAll(ByVal SQLSelect As String, ByRef dt As DataTable)
        If (Conectar() = True) Then
            Dim da = New SqlDataAdapter(SQLSelect, oConexion)
            da.Fill(dt)
            oConexion.Close()
        End If
    End Sub
    Public Function SelectConLector(ByVal SqlSelect As String) As SqlDataReader        
        If (Conectar() = True) Then
            Dim cmdSQL As New SqlCommand(SqlSelect, oConexion)
            Dim SqlReader = cmdSQL.ExecuteReader
            Return SqlReader
        End If
    End Function

    Public Sub CerrarConexion()
        oConexion.Close()
    End Sub
End Class
