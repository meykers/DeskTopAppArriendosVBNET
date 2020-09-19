<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmenDialog
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnosticse.DebuggerNonUserCode()> _
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
        Dim ApartamentoLabel As System.Windows.Forms.Label
        Dim PisoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim InventarioLabel As System.Windows.Forms.Label
        Me.ApartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PisoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioTextBox = New System.Windows.Forms.TextBox()
        Me.nudValor = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        ApartamentoLabel = New System.Windows.Forms.Label()
        PisoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        InventarioLabel = New System.Windows.Forms.Label()
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApartamentoLabel
        '
        ApartamentoLabel.AutoSize = True
        ApartamentoLabel.Location = New System.Drawing.Point(22, 34)
        ApartamentoLabel.Name = "ApartamentoLabel"
        ApartamentoLabel.Size = New System.Drawing.Size(70, 13)
        ApartamentoLabel.TabIndex = 1
        ApartamentoLabel.Text = "Apartamento:"
        '
        'PisoLabel
        '
        PisoLabel.AutoSize = True
        PisoLabel.Location = New System.Drawing.Point(214, 34)
        PisoLabel.Name = "PisoLabel"
        PisoLabel.Size = New System.Drawing.Size(30, 13)
        PisoLabel.TabIndex = 3
        PisoLabel.Text = "Piso:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(22, 59)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Direccion:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(356, 34)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 7
        ValorLabel.Text = "Valor:"
        '
        'InventarioLabel
        '
        InventarioLabel.AutoSize = True
        InventarioLabel.Location = New System.Drawing.Point(22, 104)
        InventarioLabel.Name = "InventarioLabel"
        InventarioLabel.Size = New System.Drawing.Size(57, 13)
        InventarioLabel.TabIndex = 9
        InventarioLabel.Text = "Inventario:"
        '
        'ApartamentoTextBox
        '
        Me.ApartamentoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApartamentoTextBox.Location = New System.Drawing.Point(97, 30)
        Me.ApartamentoTextBox.Name = "ApartamentoTextBox"
        Me.ApartamentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApartamentoTextBox.TabIndex = 0
        '
        'PisoTextBox
        '
        Me.PisoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PisoTextBox.Location = New System.Drawing.Point(250, 30)
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PisoTextBox.TabIndex = 1
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.Location = New System.Drawing.Point(97, 56)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(414, 39)
        Me.DireccionTextBox.TabIndex = 3
        '
        'InventarioTextBox
        '
        Me.InventarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InventarioTextBox.Location = New System.Drawing.Point(97, 101)
        Me.InventarioTextBox.Multiline = True
        Me.InventarioTextBox.Name = "InventarioTextBox"
        Me.InventarioTextBox.Size = New System.Drawing.Size(414, 46)
        Me.InventarioTextBox.TabIndex = 4
        '
        'nudValor
        '
        Me.nudValor.Location = New System.Drawing.Point(396, 30)
        Me.nudValor.Maximum = New Decimal(New Integer() {705032704, 1, 0, 0})
        Me.nudValor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudValor.Name = "nudValor"
        Me.nudValor.Size = New System.Drawing.Size(115, 20)
        Me.nudValor.TabIndex = 2
        Me.nudValor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Location = New System.Drawing.Point(327, 162)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(436, 162)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmApartmenDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(543, 207)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.nudValor)
        Me.Controls.Add(ApartamentoLabel)
        Me.Controls.Add(Me.ApartamentoTextBox)
        Me.Controls.Add(PisoLabel)
        Me.Controls.Add(Me.PisoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(InventarioLabel)
        Me.Controls.Add(Me.InventarioTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmApartmenDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion del apartamento"
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApartamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PisoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InventarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
End Class
