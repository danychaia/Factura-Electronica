Public Class frmGface 

    Private Sub frmGface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Table1 As New DataTable
        Table1.Columns.Add("Prueba")

        Dim fila = Table1.NewRow
        fila(0) = "a"
        GridControl1.DataSource = Table1

    End Sub
End Class