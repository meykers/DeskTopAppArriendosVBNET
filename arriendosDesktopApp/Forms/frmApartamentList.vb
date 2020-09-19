Public Class frmApartamentList
    Dim conexion As New Conexion()

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmNuevo = New frmApartmenDialog()
        frmNuevo.ApartamentoTextBox.Focus()
        frmNuevo.ShowDialog()
        If (frmNuevo.DialogResult = Windows.Forms.DialogResult.OK) Then
            Dim SQL As String = String.Format("insert into apartamentos (apartamento, piso, valor, direccion, inventario, usuario_id) values('{0}', '{1}', {2}, '{3}', '{4}', {5})", frmNuevo.ApartamentoTextBox.Text.Trim, frmNuevo.PisoTextBox.Text.Trim, frmNuevo.nudValor.Value, frmNuevo.DireccionTextBox.Text.Trim, frmNuevo.InventarioTextBox.Text.Trim, 1)
            conexion.AccionSQL(SQL)
            Call frmApartamentList_Load(Nothing, Nothing)
            MessageBox.Show("La informacion de apartamento ha sido almacenada", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click, btnSeleccionar.Click

        If (ApartamentosBindingSource.Count > 0) Then
            Dim Editar = New frmApartmenDialog()
            Editar.ApartamentoTextBox.Text = ApartamentosDataGridView.CurrentRow.Cells(1).Value
            Editar.PisoTextBox.Text = ApartamentosDataGridView.CurrentRow.Cells(2).Value
            Editar.nudValor.Value = Convert.ToInt16(ApartamentosDataGridView.CurrentRow.Cells(4).Value)
            Editar.DireccionTextBox.Text = ApartamentosDataGridView.CurrentRow.Cells(3).Value
            Editar.InventarioTextBox.Text = ApartamentosDataGridView.CurrentRow.Cells(5).Value
            Dim ID As Integer = Convert.ToInt16(ApartamentosDataGridView.CurrentRow.Cells(0).Value)
            Dim Usuario_id As Integer = 1 'Luego lo sustuiremos por el ID del usuario logueado en el sistema
            Editar.ShowDialog()

            If (Editar.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("Update apartamentos set apartamento = '{0}', piso ='{1}', valor = {2}, direccion='{3}', inventario ='{4}', usuario_id = {5} where id = {6}", Editar.ApartamentoTextBox.Text.Trim(), Editar.PisoTextBox.Text.Trim(), Editar.nudValor.Value, Editar.DireccionTextBox.Text.Trim(), Editar.InventarioTextBox.Text.Trim(), Usuario_id, ID)
                conexion.AccionSQL(SQL)
                Call frmApartamentList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion de apartamento ha sido actualizada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub frmApartamentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnShowAll.Click
        DsArriendos.Apartamentos.Clear()
        conexion.SelectAll("Select * from apartamentos", DsArriendos.Apartamentos)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (cmbBuscarPor.SelectedIndex < 0) Then
            MessageBox.Show("Por favor seleccione un criterio para realizar busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            If (txtCriterio.Text.Trim() = String.Empty) Then
                MessageBox.Show("Por favor escriba el criterio para realizar la busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else
                Dim SQL As String = ""
                Select Case cmbBuscarPor.SelectedIndex
                    Case 0 'Apartamento
                        SQL = String.Format("Select * from apartamentos where apartamento like '{0}%'", txtCriterio.Text.Trim())
                    Case 1 'Valor
                        SQL = String.Format("Select * from apartamentos where valor <= {0}", txtCriterio.Text.Trim())
                    Case 2 'Inventario
                        SQL = String.Format("Select * from apartamentos where inventario like '{0}%'", txtCriterio.Text.Trim())
                End Select
                DsArriendos.Apartamentos.Clear()
                conexion.SelectAll(SQL, DsArriendos.Apartamentos)
                ApartamentosDataGridView.Focus()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (ApartamentosBindingSource.Count > 0) Then
            If MessageBox.Show("Confirme que desea eliminar esta informacion", "Confirme",  MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim ID As Integer = Convert.ToInt16(ApartamentosDataGridView.CurrentRow.Cells(0).Value)
                Dim SQL = String.Format("Delete from apartamentos where ID = {0}", ID)
                conexion.AccionSQL(SQL)
                Call frmApartamentList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion de apartamento ha sido eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ApartamentosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApartamentosDataGridView.CellContentClick

    End Sub
End Class
'Termine el CRUD de la tabla de apartamentos, ahora tu debes trabajar asi exactamente en el CRUD para la tabla de Usuarios.
'Espero que en tu familia todo este bien. Bendiciones
'Create
'Retrieve
'Update
'Delete