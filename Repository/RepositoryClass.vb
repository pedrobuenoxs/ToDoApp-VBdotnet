Imports System.Data.SqlClient

Public Class RepositoryClass
    Public Class ObjRecord
        Public Id As Integer = 0
        Public Ativ As String = String.Empty
        Public Desc As String = String.Empty
        Public Data As String = String.Empty
        Public Hora As String = String.Empty
        Public Categ As String = String.Empty
        Public Status As String = String.Empty
    End Class
    Private da As SqlDataAdapter
    Private dr As SqlDataReader




    'Variável com a string de conexão ao banco
    Public Const strConexao As String = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"
    'Variável que receberá a Instrução SQL, que será passada de acordo com o método usado
    Public strInstrucao As String = String.Empty
    'Objeto instanciado da classe SqlConnection, com a string de conexão como parâmetro
    Public objConexao As New SqlConnection(strConexao)
    'Objeto instanciado da classe SqlCommand, com a instrução SQL e o objeto de conexão como parâmetro
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Public Function ListarAtividades() As DataTable
        Dim dt As New DataTable
        strInstrucao = "SELECT * from Atividades"
        objCommand.Connection = objConexao
        objCommand.CommandText = strInstrucao

        da = New SqlDataAdapter(objCommand)

        objConexao.Open()
        Dim ds As New DataSet()
        da.Fill(ds)
        dt = ds.Tables(0)
        objConexao.Close()

        Return dt
    End Function

    Public Sub SalvarAtividade(ByVal clientes As ObjRecord)

        strInstrucao = "INSERT INTO Atividades VALUES (@Ativ, @Descr, @Data,@Hora, @Categ, @Status)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Ativ", clientes.Ativ)
        objCommand.Parameters.AddWithValue("@Descr", clientes.Desc)
        objCommand.Parameters.AddWithValue("@Data", clientes.Data)
        objCommand.Parameters.AddWithValue("@Hora", clientes.Hora)
        objCommand.Parameters.AddWithValue("@Categ", clientes.Categ)
        objCommand.Parameters.AddWithValue("@Status", clientes.Status)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objCommand.Parameters.Clear()
        objConexao.Close()

    End Sub


    Public Sub ExcluirAtividade(ByVal Id As Integer)

        strInstrucao = "DELETE FROM Atividades WHERE Id = @IdAtividade"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@IdAtividade", Id)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objCommand.Parameters.Clear()
        objConexao.Close()

    End Sub
    Public Sub EditarAtividade(ByVal clientes As ObjRecord)

        strInstrucao = "UPDATE Atividades 
                        SET Atividade = @Ativ ,Descrição = @Descr, Data = @Data,Hora = @Hora,Categoria = @Categ, Status = @Status
                        WHERE Id = @IdAtividade"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@IdAtividade", clientes.Id)
        objCommand.Parameters.AddWithValue("@Ativ", clientes.Ativ)
        objCommand.Parameters.AddWithValue("@Descr", clientes.Desc)
        objCommand.Parameters.AddWithValue("@Data", clientes.Data)
        objCommand.Parameters.AddWithValue("@Hora", clientes.Hora)
        objCommand.Parameters.AddWithValue("@Categ", clientes.Categ)
        objCommand.Parameters.AddWithValue("@Status", clientes.Status)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objCommand.Parameters.Clear()
        objConexao.Close()

    End Sub

    Public Function ListarAtividadesAtrasadas()
        Dim sql_result As SqlDataReader
        strInstrucao = "SELECT COUNT(*) FROM Atividades WHERE Status = @Status "
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objCommand.Parameters.AddWithValue("@Status", "Atrasado")

        objConexao.Open()
        'objCommand.ExecuteNonQuery()
        sql_result = objCommand.ExecuteReader()
        objCommand.Parameters.Clear()
        objConexao.Close()
        Return sql_result

    End Function
End Class
