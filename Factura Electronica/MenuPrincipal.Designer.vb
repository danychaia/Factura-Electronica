<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnBaseDatos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGface = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEnviar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Gface = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbpg1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rbPage = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnBaseDatos, Me.BarButtonItem1, Me.btnGface, Me.btnEnviar, Me.btnBuscar, Me.BarButtonItem2, Me.BarButtonItem3, Me.btnCancelar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 10
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl.Size = New System.Drawing.Size(951, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnBaseDatos
        '
        Me.btnBaseDatos.AllowDrawArrow = False
        Me.btnBaseDatos.Caption = "Configurar"
        Me.btnBaseDatos.Id = 1
        Me.btnBaseDatos.ImageUri.Uri = "EditDataSource"
        Me.btnBaseDatos.Name = "btnBaseDatos"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "kkk"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnGface
        '
        Me.btnGface.Caption = "Configurar"
        Me.btnGface.Id = 3
        Me.btnGface.ImageUri.Uri = "Customization"
        Me.btnGface.Name = "btnGface"
        '
        'btnEnviar
        '
        Me.btnEnviar.Caption = "Enviar"
        Me.btnEnviar.Id = 4
        Me.btnEnviar.ImageUri.Uri = "Redo"
        Me.btnEnviar.Name = "btnEnviar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Caption = "Buscar"
        Me.btnBuscar.Id = 6
        Me.btnBuscar.ImageUri.Uri = "Find"
        Me.btnBuscar.Name = "btnBuscar"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Generar"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.ImageUri.Uri = "AddNewDataSource"
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Guardar"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.ImageUri.Uri = "Save"
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnCancelar
        '
        Me.btnCancelar.Caption = "Cancelar"
        Me.btnCancelar.Id = 9
        Me.btnCancelar.ImageUri.Uri = "Cancel"
        Me.btnCancelar.Name = "btnCancelar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.Gface, Me.RibbonPageGroup2, Me.rbpg1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Parametros"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnBaseDatos)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Base de Datos"
        '
        'Gface
        '
        Me.Gface.ItemLinks.Add(Me.btnGface)
        Me.Gface.Name = "Gface"
        Me.Gface.Text = "Gface"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Configuración"
        '
        'rbpg1
        '
        Me.rbpg1.ItemLinks.Add(Me.BarButtonItem3)
        Me.rbpg1.ItemLinks.Add(Me.btnCancelar)
        Me.rbpg1.Name = "rbpg1"
        Me.rbpg1.Text = "Herramientas"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rbPage})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Envio de Documentos"
        '
        'rbPage
        '
        Me.rbPage.ItemLinks.Add(Me.btnEnviar)
        Me.rbPage.ItemLinks.Add(Me.btnBuscar)
        Me.rbPage.Name = "rbPage"
        Me.rbPage.Text = "Herramientas"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 488)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(951, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'MenuPrincipal
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 519)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Menu Principal"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnBaseDatos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Gface As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnGface As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnEnviar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbPage As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbpg1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
