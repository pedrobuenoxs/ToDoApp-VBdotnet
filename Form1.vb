Public Class FrmToDo
    Private Const ID = 0
    Private Const Ativ = 1
    Private Const Desc = 2
    Private Const Data = 3
    Private Const Categ = 4
    Private Const Status = 5

    Private Sub AtualizarStripButton2_Click(sender As Object, e As EventArgs) Handles AtualizarStripButton2.Click

        If ValidateForm() Then
            If TxtID.Text = "" Then
                setRecord()
            End If
            'upDateRecord()
        End If

        clearForm()

    End Sub

    Private Sub clearForm()
        TxtID.Clear()
        TxtAtiv.Clear()
        TxtDesc.Clear()
        MskDate.Clear()
        TxtCateg.Clear()
        StatusComboBox.SelectedIndex = -1

    End Sub

    Private Sub setRecord()
        With ListView1
            .Items.Add(New ListViewItem({New Date, TxtAtiv.Text, TxtDesc.Text, MskDate.Text, TxtCateg.Text, StatusComboBox.Text}))
        End With
    End Sub


    Private Function ValidateForm() As Boolean
        Try
            If TxtAtiv.Text = "" Then
                Throw New Exception()
            ElseIf Not IsDate(MskDate.Text) Then
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

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        getRecordItem()
    End Sub

    Private Sub getRecordItem()
        With ListView1

            Dim Row = .Items.IndexOf(.SelectedItems(0))
            TxtID.Text = .Items(Row).SubItems(ID).Text
            TxtAtiv.Text = .Items(Row).SubItems(Ativ).Text
            TxtDesc.Text = .Items(Row).SubItems(Desc).Text
            MskDate.Text = .Items(Row).SubItems(Data).Text
            TxtCateg.Text = .Items(Row).SubItems(Categ).Text
            StatusComboBox.Text = .Items(Row).SubItems(Status).Text
        End With

    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim Repository As New RepositoryClass
        Dim ObjRecord As New RepositoryClass.ObjRecord

        ObjRecord.Ativ = TxtAtiv.Text
        ObjRecord.Desc = TxtDesc.Text
        ObjRecord.Data = MskDate.Text
        ObjRecord.Categ = TxtCateg.Text
        ObjRecord.Status = StatusComboBox.Text



        Repository.GravarCliente(ObjRecord)
    End Sub
End Class
