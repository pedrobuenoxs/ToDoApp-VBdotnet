<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmToDo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmToDo))
        Me.GroupBoxForm = New System.Windows.Forms.GroupBox()
        Me.MskHour = New System.Windows.Forms.MaskedTextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.MskDate = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCateg = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtAtiv = New System.Windows.Forms.TextBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelCateg = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.LabelAtiv = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxForm.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxForm
        '
        Me.GroupBoxForm.Controls.Add(Me.MskHour)
        Me.GroupBoxForm.Controls.Add(Me.TxtID)
        Me.GroupBoxForm.Controls.Add(Me.StatusComboBox)
        Me.GroupBoxForm.Controls.Add(Me.MskDate)
        Me.GroupBoxForm.Controls.Add(Me.TxtCateg)
        Me.GroupBoxForm.Controls.Add(Me.TxtDesc)
        Me.GroupBoxForm.Controls.Add(Me.TxtAtiv)
        Me.GroupBoxForm.Controls.Add(Me.LabelStatus)
        Me.GroupBoxForm.Controls.Add(Me.LabelCateg)
        Me.GroupBoxForm.Controls.Add(Me.LabelDate)
        Me.GroupBoxForm.Controls.Add(Me.LabelDesc)
        Me.GroupBoxForm.Controls.Add(Me.LabelAtiv)
        Me.GroupBoxForm.Location = New System.Drawing.Point(12, 118)
        Me.GroupBoxForm.Name = "GroupBoxForm"
        Me.GroupBoxForm.Size = New System.Drawing.Size(398, 325)
        Me.GroupBoxForm.TabIndex = 0
        Me.GroupBoxForm.TabStop = False
        '
        'MskHour
        '
        Me.MskHour.Location = New System.Drawing.Point(221, 165)
        Me.MskHour.Mask = "00:00"
        Me.MskHour.Name = "MskHour"
        Me.MskHour.Size = New System.Drawing.Size(51, 27)
        Me.MskHour.TabIndex = 4
        '
        'TxtID
        '
        Me.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID.Location = New System.Drawing.Point(327, 16)
        Me.TxtID.Multiline = True
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(46, 27)
        Me.TxtID.TabIndex = 11
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"A Fazer", "Fazendo", "Feito", "Atrasado"})
        Me.StatusComboBox.Location = New System.Drawing.Point(124, 238)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(197, 28)
        Me.StatusComboBox.TabIndex = 6
        '
        'MskDate
        '
        Me.MskDate.Location = New System.Drawing.Point(124, 165)
        Me.MskDate.Mask = "00/00/0000"
        Me.MskDate.Name = "MskDate"
        Me.MskDate.Size = New System.Drawing.Size(91, 27)
        Me.MskDate.TabIndex = 3
        '
        'TxtCateg
        '
        Me.TxtCateg.Location = New System.Drawing.Point(124, 203)
        Me.TxtCateg.Name = "TxtCateg"
        Me.TxtCateg.Size = New System.Drawing.Size(197, 27)
        Me.TxtCateg.TabIndex = 5
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(124, 53)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(268, 106)
        Me.TxtDesc.TabIndex = 2
        '
        'TxtAtiv
        '
        Me.TxtAtiv.Location = New System.Drawing.Point(124, 16)
        Me.TxtAtiv.Name = "TxtAtiv"
        Me.TxtAtiv.Size = New System.Drawing.Size(197, 27)
        Me.TxtAtiv.TabIndex = 1
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(66, 238)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(52, 20)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status:"
        '
        'LabelCateg
        '
        Me.LabelCateg.AutoSize = True
        Me.LabelCateg.Location = New System.Drawing.Point(41, 203)
        Me.LabelCateg.Name = "LabelCateg"
        Me.LabelCateg.Size = New System.Drawing.Size(77, 20)
        Me.LabelCateg.TabIndex = 3
        Me.LabelCateg.Text = "Categoria:"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(27, 165)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(91, 20)
        Me.LabelDate.TabIndex = 2
        Me.LabelDate.Text = "Data / Hora:"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Location = New System.Drawing.Point(41, 53)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(77, 20)
        Me.LabelDesc.TabIndex = 1
        Me.LabelDesc.Text = "Descrição:"
        '
        'LabelAtiv
        '
        Me.LabelAtiv.AutoSize = True
        Me.LabelAtiv.Location = New System.Drawing.Point(42, 16)
        Me.LabelAtiv.Name = "LabelAtiv"
        Me.LabelAtiv.Size = New System.Drawing.Size(76, 20)
        Me.LabelAtiv.TabIndex = 0
        Me.LabelAtiv.Text = "Atividade:"
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(446, 19)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowHeadersWidth = 51
        Me.dgvDados.RowTemplate.Height = 29
        Me.dgvDados.Size = New System.Drawing.Size(942, 424)
        Me.dgvDados.TabIndex = 5
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.AutoSize = False
        Me.SaveToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(100, 80)
        Me.SaveToolStripButton.Text = "Salvar"
        Me.SaveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.AutoSize = False
        Me.DeleteToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(100, 80)
        Me.DeleteToolStripButton.Text = "Excluir"
        Me.DeleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.AutoSize = False
        Me.EditToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(100, 80)
        Me.EditToolStripButton.Text = "Editar"
        Me.EditToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.DeleteToolStripButton, Me.EditToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(27, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(352, 83)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 109)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'FrmToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.GroupBoxForm)
        Me.Name = "FrmToDo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToDo App"
        Me.GroupBoxForm.ResumeLayout(False)
        Me.GroupBoxForm.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxForm As GroupBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelDesc As Label
    Friend WithEvents LabelAtiv As Label
    Friend WithEvents LabelCateg As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents MskDate As MaskedTextBox
    Friend WithEvents TxtCateg As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtAtiv As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents MskHour As MaskedTextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents DeleteToolStripButton As ToolStripButton
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
End Class
