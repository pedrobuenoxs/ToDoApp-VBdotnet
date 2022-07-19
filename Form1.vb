Public Class FrmToDo

    Dim Repository As New RepositoryClass


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Repository As New RepositoryClass
        Dim dados = Repository.ListarAtividades()
        dgvDados.DataSource = dados


    End Sub



    Private Sub clearForm()
        TxtID.Clear()
        TxtAtiv.Clear()
        TxtDesc.Clear()
        MskDate.Clear()
        TxtCateg.Clear()
        MskHour.Clear()
        StatusComboBox.SelectedIndex = -1

    End Sub



    Private Function ValidateForm() As Boolean
        Try
            If TxtAtiv.Text = "" Then
                Throw New Exception()
            ElseIf TxtDesc.Text = "" Then
                Throw New Exception()
            ElseIf TxtCateg.Text = "" Then
                Throw New Exception()
            ElseIf StatusComboBox.Text = "" Then
                MsgBox("Defina um status")
                Throw New Exception()
            End If
        Catch ex As Exception
            MsgBox("Todos os campos são obrigatórios")
            Return False
        End Try
        Return True
    End Function


    Private Sub dvgDados_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDados.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvDados.Rows(e.RowIndex)
            If IsDBNull(selectedRow.Cells("id").Value) Then
                MsgBox("Selecione uma linha válida")
            ElseIf IsDBNull(selectedRow.Cells("Atividade").Value) Then
                MsgBox("Selecione uma linha válida")

            ElseIf IsDBNull(selectedRow.Cells("Descrição").Value) Then
                MsgBox("Selecione uma linha válida")

            ElseIf IsDBNull(selectedRow.Cells("Data").Value) Then
                MsgBox("Selecione uma linha válida")

            ElseIf IsDBNull(selectedRow.Cells("Hora").Value) Then
                MsgBox("Selecione uma linha válida")

            ElseIf IsDBNull(selectedRow.Cells("Categoria").Value) Then
                MsgBox("Selecione uma linha válida")

            ElseIf IsDBNull(selectedRow.Cells("Status").Value) Then
                MsgBox("Selecione uma linha válida")

            Else
                TxtID.Text = selectedRow.Cells("Id").Value
                TxtAtiv.Text = selectedRow.Cells("Atividade").Value
                TxtDesc.Text = selectedRow.Cells("Descrição").Value
                MskDate.Text = selectedRow.Cells("Data").Value
                MskHour.Text = selectedRow.Cells("Hora").Value.ToString()
                TxtCateg.Text = selectedRow.Cells("Categoria").Value
                StatusComboBox.Text = selectedRow.Cells("Status").Value

            End If


        End If

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim objRepository As New RepositoryClass.ObjRecord
        objRepository.Ativ = TxtAtiv.Text
        objRepository.Desc = TxtDesc.Text
        objRepository.Data = MskDate.Text
        objRepository.Hora = MskHour.Text.ToString()
        objRepository.Categ = TxtCateg.Text
        objRepository.Status = StatusComboBox.Text
        'New DateTime(MskHour.Text).Parse("12:10")
        If ValidateForm() Then
            Repository.SalvarAtividade(objRepository)
        End If

        clearForm()
        Dim dados = Repository.ListarAtividades()
        dgvDados.DataSource = dados
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim objRepository As New RepositoryClass.ObjRecord
        objRepository.Id = TxtID.Text
        If ValidateForm() Then
            Repository.ExcluirAtividade(objRepository.Id)
        End If

        clearForm()
        Dim dados = Repository.ListarAtividades()
        dgvDados.DataSource = dados
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click

        If ValidateForm() Then
            If TxtID.Text = "" Then
                MsgBox("Selecione uma atividade para editar")
            End If
            Dim objRepository As New RepositoryClass.ObjRecord
            objRepository.Id = TxtID.Text
            objRepository.Ativ = TxtAtiv.Text
            objRepository.Desc = TxtDesc.Text
            objRepository.Data = MskDate.Text
            objRepository.Hora = MskHour.Text.ToString()
            objRepository.Categ = TxtCateg.Text
            objRepository.Status = StatusComboBox.Text
            Repository.EditarAtividade(objRepository)
        End If


        clearForm()
        Dim dados = Repository.ListarAtividades()
        dgvDados.DataSource = dados
    End Sub
End Class
