Public Class FrmcodeudorList
    Dim conexion As New Conexion()

    Private Sub FrmcodeudorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load     
        DsArriendos.Codeudor.Clear()
        conexion.SelectAll("Select * from Codeudores", DsArriendos.Codeudor)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmNuevo = New frmCodeudorDialog()
        frmNuevo.NombresTextBox.Focus()
        frmNuevo.ShowDialog()
        If (frmNuevo.DialogResult = Windows.Forms.DialogResult.OK) Then
            Dim SQL As String = String.Format("insert into Codeudores (nombres,barrio,telefono,email, inquilino_id) values('{0}', '{1}', '{2}', '{3}', {4})", frmNuevo.NombresTextBox.Text.Trim, frmNuevo.DireccionTextBox.Text.Trim, frmNuevo.TelefonoTextBox.Text.Trim, frmNuevo.EmailTextBox.Text.Trim, 1)
            conexion.AccionSQL(SQL)
            Call FrmcodeudorList_Load(Nothing, Nothing)
            MessageBox.Show("La informacion del codeudor ha sido almacenada exitoxamente...", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (CodeudorBindingSource.Count > 0) Then
            Dim Editar = New frmCodeudorDialog()            
            Editar.NombresTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(1).Value
            Editar.DireccionTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(2).Value
            Editar.TelefonoTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(3).Value
            Editar.EmailTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(4).Value
            Dim ID As Integer = Convert.ToInt16(CodeudorDataGridView.CurrentRow.Cells(0).Value)
            Dim Inquilino_id As Integer = 1
            Editar.ShowDialog()
            If (Editar.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("Update codeudores set nombres= '{0}', barrio='{1}', telefono='{2}', email='{3}', inquilino_id = '{4}' where id = {5}", Editar.NombresTextBox.Text.Trim(), Editar.DireccionTextBox.Text.Trim(), Editar.TelefonoTextBox.Text.Trim(), Editar.EmailTextBox.Text.Trim(), Inquilino_id, ID)
                conexion.AccionSQL(SQL)
                Call FrmcodeudorList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion del codeudor del inquilino ha sido actualizada...", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (CodeudorBindingSource.Count > 0) Then
            If MessageBox.Show("Confirme que desea eliminar esta informacion", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim ID As Integer = Convert.ToInt16(CodeudorDataGridView.CurrentRow.Cells(0).Value)
                Dim SQL = String.Format("Delete from codeudores where ID = {0}", ID)
                conexion.AccionSQL(SQL)
                Call FrmcodeudorList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion de codeudor ha sido eliminada correctamente exitosamente...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If (CmbBuscar.SelectedIndex < 0) Then
            MessageBox.Show("Por favor seleccione un criterio para realizar busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            If (Txtcriterio.Text.Trim() = String.Empty) Then
                MessageBox.Show("Por favor escriba el criterio para realizar la busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else
                Dim SQL As String = ""
                Select Case CmbBuscar.SelectedIndex
                    Case 0
                        SQL = String.Format("Select * from codeudor where nit like '{0}%'", Txtcriterio.Text.Trim())
                       
                    Case 1
                        SQL = String.Format("Select * from codeudor where nombres like '{0}%'", Txtcriterio.Text.Trim())
                End Select
                DsArriendos.Apartamentos.Clear()
                conexion.SelectAll(SQL, DsArriendos.Apartamentos)
                CodeudorDataGridView.Focus()
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If (CodeudorBindingSource.Count > 0) Then
            Dim Editar = New frmCodeudorDialog()
            Editar.NombresTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(1).Value
            Editar.DireccionTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(2).Value
            'Editar.nudValor.Value = Convert.ToInt16(CodeudorDataGridView.CurrentRow.Cells(4).Value)
            Editar.TelefonoTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(3).Value
            Editar.EmailTextBox.Text = CodeudorDataGridView.CurrentRow.Cells(4).Value
            Editar.cmbInquilino.Text = CodeudorDataGridView.CurrentRow.Cells(5).Value
            Dim ID As Integer = Convert.ToInt16(CodeudorDataGridView.CurrentRow.Cells(0).Value)
            Dim inquilino_id As Integer = 1 'Luego lo sustuiremos por el ID del usuario logueado en el sistema
            Editar.ShowDialog()

            If (Editar.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("Update Codeudor set nombres = '{0}', barrio ='{1}', telefono = {2}, email='{3}', inquilino_id ='{4}' where id = {6}", Editar.NombresTextBox.Text.Trim(), Editar.DireccionTextBox.Text.Trim(), Editar.TelefonoTextBox.Text.Trim(), Editar.EmailTextBox.Text.Trim(), Editar.cmbInquilino.Text.Trim(), inquilino_id, ID)
                conexion.AccionSQL(SQL)
                Call FrmcodeudorList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion del codeudor ha sido actualizada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class