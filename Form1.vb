Public Class FrmToDo
    Private Sub AtualizarStripButton2_Click(sender As Object, e As EventArgs) Handles AtualizarStripButton2.Click

        If ValidarForm() Then
            MsgBox("Deu bom")

        End If

    End Sub


    Private Function ValidarForm() As Boolean
        Try
            If TxtAtiv.Text = "" Then
                Throw New Exception("An exception has occurred.")
            ElseIf Not IsDate(MskDate.Text) Then
                Throw New Exception("An exception has occurred.")
            ElseIf TxtCateg.Text = "" Then
                Throw New Exception("An exception has occurred.")
            ElseIf StatusComboBox.Text = "" Then
                MsgBox("Defina um status")
                Throw New Exception("An exception has occurred.")
            End If
        Catch ex As Exception
            MsgBox("Todos os campos são obrigatórios")
            Return False
        End Try
        Return True
    End Function
End Class
