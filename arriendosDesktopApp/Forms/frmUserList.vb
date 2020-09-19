Public Class frmUserList
    Dim conexion As New Conexion()
    
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtUsuario.Text.Trim().Length > 0 Then
            Dim SQL As String = String.Format("Select * from usuarios where usuario like '%{0}'", txtUsuario.Text.Trim)
            DsArriendos.Usuarios.Clear()
            conexion.SelectAll(SQL, DsArriendos.Usuarios)
            UsuariosDataGridView.Focus()
        Else
            MessageBox.Show("Escriba el nombre de usuario antes de realizar una busqueda de informacion", "Nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnMostrarTodos.Click
        DsArriendos.Usuarios.Clear()
        conexion.SelectAll("Select * from usuarios", DsArriendos.Usuarios)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmNuevo = New frmUserDialog()
        frmNuevo.NitTextBox.Focus()
        frmNuevo.ShowDialog()
        If (frmNuevo.DialogResult = Windows.Forms.DialogResult.OK) Then
            Dim SQL As String = String.Format("insert into  Usuarios (nit, nombres, usuario, password) values('{0}', '{1}', '{2}', '{3}')", frmNuevo.NitTextBox.Text.Trim, frmNuevo.NombresTextBox.Text.Trim, frmNuevo.UsuarioTextBox.Text.Trim, frmNuevo.PasswordTextBox.Text.Trim)
            conexion.AccionSQL(SQL)
            Call frmUserList_Load(Nothing, Nothing)
            MessageBox.Show("La informacion del usuario ha sido almacenada", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (UsuariosBindingSource.Count > 0) Then
            If MessageBox.Show("Confirme que desea eliminar un personal del usuarios...", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim ID As Integer = Convert.ToInt16(UsuariosDataGridView.CurrentRow.Cells(0).Value)
                Dim SQL = String.Format("Delete from Usuarios where ID = {0}", ID)
                conexion.AccionSQL(SQL)
                Call frmUserList_Load(Nothing, Nothing)
                MessageBox.Show("El personal del sistemas, ha sido eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click, btnSeleccionar.Click
        If (UsuariosBindingSource.Count > 0) Then
            Dim Editar = New frmUserDialog()
            Editar.NitTextBox.Text = UsuariosDataGridView.CurrentRow.Cells(1).Value
            Editar.UsuarioTextBox.Text = UsuariosDataGridView.CurrentRow.Cells(3).Value
            Editar.NombresTextBox.Text = UsuariosDataGridView.CurrentRow.Cells(2).Value            
            Editar.PasswordTextBox.Text = UsuariosDataGridView.CurrentRow.Cells(4).Value

            Dim ID As Integer = Convert.ToInt16(UsuariosDataGridView.CurrentRow.Cells(0).Value)
            Dim Usuario_id As Integer = 1
            Editar.ShowDialog()
            If (Editar.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("Update Usuarios set nit='{0}', nombres = '{1}', usuario ='{2}', password = '{3}' where id ={4}", Editar.NitTextBox.Text.Trim(), Editar.NombresTextBox.Text.Trim(), Editar.UsuarioTextBox.Text, Editar.PasswordTextBox.Text.Trim(), ID)
                conexion.AccionSQL(SQL)
                Call frmUserList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion de Usuarios ha sido actualizada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class