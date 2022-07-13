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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBoxForm = New System.Windows.Forms.GroupBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AtualizarStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxForm.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBoxForm
        '
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
        Me.GroupBoxForm.Size = New System.Drawing.Size(499, 325)
        Me.GroupBoxForm.TabIndex = 0
        Me.GroupBoxForm.TabStop = False
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Todo", "In Progress", "Delayed"})
        Me.StatusComboBox.Location = New System.Drawing.Point(124, 238)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(197, 28)
        Me.StatusComboBox.TabIndex = 10
        '
        'MskDate
        '
        Me.MskDate.Location = New System.Drawing.Point(124, 165)
        Me.MskDate.Mask = "00/00/0000 00:00"
        Me.MskDate.Name = "MskDate"
        Me.MskDate.Size = New System.Drawing.Size(197, 27)
        Me.MskDate.TabIndex = 9
        '
        'TxtCateg
        '
        Me.TxtCateg.Location = New System.Drawing.Point(124, 203)
        Me.TxtCateg.Name = "TxtCateg"
        Me.TxtCateg.Size = New System.Drawing.Size(197, 27)
        Me.TxtCateg.TabIndex = 8
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(124, 53)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(370, 106)
        Me.TxtDesc.TabIndex = 6
        '
        'TxtAtiv
        '
        Me.TxtAtiv.Location = New System.Drawing.Point(124, 16)
        Me.TxtAtiv.Name = "TxtAtiv"
        Me.TxtAtiv.Size = New System.Drawing.Size(197, 27)
        Me.TxtAtiv.TabIndex = 5
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(66, 246)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(52, 20)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status:"
        '
        'LabelCateg
        '
        Me.LabelCateg.AutoSize = True
        Me.LabelCateg.Location = New System.Drawing.Point(76, 210)
        Me.LabelCateg.Name = "LabelCateg"
        Me.LabelCateg.Size = New System.Drawing.Size(42, 20)
        Me.LabelCateg.TabIndex = 3
        Me.LabelCateg.Text = "Tipo:"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(27, 172)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(91, 20)
        Me.LabelDate.TabIndex = 2
        Me.LabelDate.Text = "Data / Hora:"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Location = New System.Drawing.Point(41, 60)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(77, 20)
        Me.LabelDesc.TabIndex = 1
        Me.LabelDesc.Text = "Descrição:"
        '
        'LabelAtiv
        '
        Me.LabelAtiv.AutoSize = True
        Me.LabelAtiv.Location = New System.Drawing.Point(42, 23)
        Me.LabelAtiv.Name = "LabelAtiv"
        Me.LabelAtiv.Size = New System.Drawing.Size(76, 20)
        Me.LabelAtiv.TabIndex = 0
        Me.LabelAtiv.Text = "Atividade:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Location = New System.Drawing.Point(517, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(621, 429)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ativ"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Desc"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 215
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tipo"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.AutoSize = False
        Me.SalvarToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(150, 79)
        Me.SalvarToolStripButton.Text = "&Salvar"
        Me.SalvarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirStripButton1
        '
        Me.ExcluirStripButton1.AutoSize = False
        Me.ExcluirStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExcluirStripButton1.Image = CType(resources.GetObject("ExcluirStripButton1.Image"), System.Drawing.Image)
        Me.ExcluirStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirStripButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ExcluirStripButton1.Name = "ExcluirStripButton1"
        Me.ExcluirStripButton1.Size = New System.Drawing.Size(150, 79)
        Me.ExcluirStripButton1.Text = "Excluir"
        Me.ExcluirStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AtualizarStripButton2
        '
        Me.AtualizarStripButton2.AutoSize = False
        Me.AtualizarStripButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AtualizarStripButton2.Image = CType(resources.GetObject("AtualizarStripButton2.Image"), System.Drawing.Image)
        Me.AtualizarStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtualizarStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtualizarStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtualizarStripButton2.Name = "AtualizarStripButton2"
        Me.AtualizarStripButton2.Size = New System.Drawing.Size(150, 79)
        Me.AtualizarStripButton2.Text = "Atualizar"
        Me.AtualizarStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 82)
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripButton, Me.toolStripSeparator1, Me.ExcluirStripButton1, Me.ToolStripSeparator2, Me.AtualizarStripButton2})
        Me.ToolStrip.Location = New System.Drawing.Point(9, 19)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(497, 82)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 82)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1163, 26)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripStatusLabel1.Text = "Message"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'FrmToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 513)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBoxForm)
        Me.Name = "FrmToDo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToDo App"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxForm.ResumeLayout(False)
        Me.GroupBoxForm.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExcluirStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AtualizarStripButton2 As ToolStripButton
End Class
