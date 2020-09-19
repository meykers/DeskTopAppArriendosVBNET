<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forminquilinos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdentificacionLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim InventarioLabel As System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.IdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.cmbApartamento = New System.Windows.Forms.ComboBox()
        Me.nudValor = New System.Windows.Forms.NumericUpDown()
        Me.PisoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioTextBox = New System.Windows.Forms.TextBox()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        IdentificacionLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        InventarioLabel = New System.Windows.Forms.Label()
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdentificacionLabel
        '
        IdentificacionLabel.AutoSize = True
        IdentificacionLabel.Location = New System.Drawing.Point(17, 25)
        IdentificacionLabel.Name = "IdentificacionLabel"
        IdentificacionLabel.Size = New System.Drawing.Size(73, 13)
        IdentificacionLabel.TabIndex = 14
        IdentificacionLabel.Text = "Identificacion:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(39, 50)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(55, 13)
        NombresLabel.TabIndex = 15
        NombresLabel.Text = "Nombres :"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(201, 25)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(368, 25)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(20, 88)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 13)
        Label1.TabIndex = 19
        Label1.Text = "Apartamento :"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.Location = New System.Drawing.Point(245, 85)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(33, 13)
        PisoLabel.TabIndex = 25
        PisoLabel.Text = "Piso :"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(32, 120)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(58, 13)
        DireccionLabel.TabIndex = 28
        DireccionLabel.Text = "Direccion :"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(386, 85)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(37, 13)
        ValorLabel.TabIndex = 29
        ValorLabel.Text = "Valor :"
        '
        'InventarioLabel
        '
        InventarioLabel.AutoSize = True
        InventarioLabel.Location = New System.Drawing.Point(29, 166)
        InventarioLabel.Name = "InventarioLabel"
        InventarioLabel.Size = New System.Drawing.Size(60, 13)
        InventarioLabel.TabIndex = 30
        InventarioLabel.Text = "Inventario :"
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(466, 208)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Location = New System.Drawing.Point(357, 208)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'IdentificacionTextBox
        '
        Me.IdentificacionTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IdentificacionTextBox.Location = New System.Drawing.Point(95, 21)
        Me.IdentificacionTextBox.Name = "IdentificacionTextBox"
        Me.IdentificacionTextBox.Size = New System.Drawing.Size(85, 20)
        Me.IdentificacionTextBox.TabIndex = 0
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NombresTextBox.Location = New System.Drawing.Point(95, 46)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(446, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TelefonoTextBox.Location = New System.Drawing.Point(255, 21)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.TelefonoTextBox.TabIndex = 1
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmailTextBox.Location = New System.Drawing.Point(408, 21)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(133, 20)
        Me.EmailTextBox.TabIndex = 2
        '
        'cmbApartamento
        '
        Me.cmbApartamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbApartamento.FormattingEnabled = True
        Me.cmbApartamento.Location = New System.Drawing.Point(95, 80)
        Me.cmbApartamento.Name = "cmbApartamento"
        Me.cmbApartamento.Size = New System.Drawing.Size(121, 21)
        Me.cmbApartamento.TabIndex = 4
        '
        'nudValor
        '
        Me.nudValor.Enabled = False
        Me.nudValor.Location = New System.Drawing.Point(426, 81)
        Me.nudValor.Maximum = New Decimal(New Integer() {705032704, 1, 0, 0})
        Me.nudValor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudValor.Name = "nudValor"
        Me.nudValor.ReadOnly = True
        Me.nudValor.Size = New System.Drawing.Size(115, 20)
        Me.nudValor.TabIndex = 24
        Me.nudValor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PisoTextBox
        '
        Me.PisoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PisoTextBox.Location = New System.Drawing.Point(281, 81)
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.ReadOnly = True
        Me.PisoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PisoTextBox.TabIndex = 23
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.Location = New System.Drawing.Point(95, 107)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ReadOnly = True
        Me.DireccionTextBox.Size = New System.Drawing.Size(446, 39)
        Me.DireccionTextBox.TabIndex = 26
        '
        'InventarioTextBox
        '
        Me.InventarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InventarioTextBox.Location = New System.Drawing.Point(95, 152)
        Me.InventarioTextBox.Multiline = True
        Me.InventarioTextBox.Name = "InventarioTextBox"
        Me.InventarioTextBox.ReadOnly = True
        Me.InventarioTextBox.Size = New System.Drawing.Size(446, 46)
        Me.InventarioTextBox.TabIndex = 27
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'Forminquilinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 246)
        Me.Controls.Add(Me.nudValor)
        Me.Controls.Add(PisoLabel)
        Me.Controls.Add(Me.PisoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(InventarioLabel)
        Me.Controls.Add(Me.InventarioTextBox)
        Me.Controls.Add(Me.cmbApartamento)
        Me.Controls.Add(Label1)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(IdentificacionLabel)
        Me.Controls.Add(Me.IdentificacionTextBox)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Forminquilinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion de inquilino"
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents IdentificacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
    Friend WithEvents PisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InventarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
End Class
