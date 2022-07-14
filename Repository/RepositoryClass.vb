Imports System.Data.SqlClient

Public Class RepositoryClass
    Public Class ObjRecord
        Public Id As Integer = 0
        Public Ativ As String = String.Empty
        Public Desc As String = String.Empty
        Public Data As String = String.Empty
        Public Categ As String = String.Empty
        Public Status As String = String.Empty
    End Class



    'Variável com a string de conexão ao banco
    Public Const strConexao As String = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"
    'Variável que receberá a Instrução SQL, que será passada de acordo com o método usado
    Public strInstrucao As String = String.Empty
    'Objeto instanciado da classe SqlConnection, com a string de conexão como parâmetro
    Public objConexao As New SqlConnection(strConexao)
    'Objeto instanciado da classe SqlCommand, com a instrução SQL e o objeto de conexão como parâmetro
    Public objCommand As New SqlCommand(strInstrucao, objConexao)



    Public Sub GravarCliente(ByVal clientes As ObjRecord)

        strInstrucao = "INSERT INTO Atividades VALUES (@Ativ, @Descr, @Data, @Categ, @Status)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Ativ", clientes.Ativ)
        objCommand.Parameters.AddWithValue("@Descr", clientes.Desc)
        objCommand.Parameters.AddWithValue("@Data", clientes.Data)
        objCommand.Parameters.AddWithValue("@Categ", clientes.Categ)
        objCommand.Parameters.AddWithValue("@Status", clientes.Status)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub


    Public Sub ExcluirCliente(ByVal Id As Integer)

        strInstrucao = "DELETE FROM Atividades WHERE IdCliente = @IdCliente"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@IdCliente", Id)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub
End Class
