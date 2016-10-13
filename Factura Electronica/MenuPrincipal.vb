Public Class MenuPrincipal 
    Dim formularioBaseDatos = Nothing
    Dim formularioGface = Nothing
    Dim formActivo = String.Empty
    Private Sub btnBaseDatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaseDatos.ItemClick
        If formularioBaseDatos Is Nothing Then
            limpiarPanel()
            formularioBaseDatos = New frmBaseDatos
            formularioBaseDatos.MdiParent = Me
            formularioBaseDatos.Show()
            activarFormulario()
        End If
    End Sub

    Private Sub btnGface_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGface.ItemClick
        If formularioGface Is Nothing Then
            limpiarPanel()
            formularioGface = New frmGface
            formularioGface.MdiParent = Me
            formularioGface.Show()
            activarFormulario()
        End If
    End Sub


    Private Sub RibbonControl_SelectedPageChanged(sender As Object, e As EventArgs) Handles RibbonControl.SelectedPageChanged
        Dim indexPage = RibbonControl.SelectedPage.PageIndex
        limpiarPanel()
        If indexPage = 1 Then
            Dim facturaform As New frmCargaFacturas
            facturaform.MdiParent = Me
            facturaform.Show()
        End If

    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Try

            If formActivo = "frmBaseDatos" Then
                Dim frm2 As frmBaseDatos = CType(Me.ActiveMdiChild, frmBaseDatos)
                frm2.txtCompañia.Text = ""
                frm2.txtSapUser.Text = ""
                frm2.txtContraseñaSap.Text = ""
                frm2.txtuserDB.Text = ""
                frm2.txtPasswordDB.Text = ""
            Else
                If formActivo = "frmGface" Then

                End If
            End If
           
        Catch ex As Exception
        End Try
       
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        formularioBaseDatos = Nothing
        formularioGface = Nothing
    End Sub

    Private Sub limpiarPanel()
        For Each formre As Form In Me.MdiChildren
            formre.Hide()
            formre.Close()
        Next
        formularioBaseDatos = Nothing
        formularioGface = Nothing
    End Sub

    Private Sub activarFormulario()
        Dim form = Me.ActiveMdiChild
        formActivo = form.Name.ToString()
    End Sub

End Class