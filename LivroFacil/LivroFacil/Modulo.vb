Imports System.Data.SqlClient

Module Modulo
    Public conexao As SqlConnection
    Public vBanco As String
    Public vServidor As String
    Public vUsuario As String
    Public vSenha As String
    Public sql As String

    
    Public Sub criarConexao()
        conexao = New SqlConnection
        conexao.ConnectionString = "Initial Catalog=" & vBanco & ";Data Source=" & vServidor & ";User ID=" & vUsuario & ";Password=" & vSenha & ";"
    End Sub


    
    Public Sub executaSQL(ByVal comando_SQL As String)
        Dim Command As New SqlClient.SqlCommand

        conexao.Open()
        Command.Connection = conexao
        Command.CommandText = comando_SQL
        Command.ExecuteNonQuery()
        conexao.Close()
    End Sub

    
    Public Function consultaSQL(ByVal comando_SQL As String) As DataTable

        Dim adaptador As New SqlDataAdapter
        Dim comando As New SqlCommand
        Dim ds As New DataSet
        Dim dt As New DataTable

        conexao.Open()
        comando.Connection = conexao
        comando.CommandText = comando_SQL
        adaptador.SelectCommand = comando
        adaptador.Fill(ds)
        adaptador.Dispose()
        dt = ds.Tables(0)
        conexao.Close()
        Return dt
    End Function

End Module