<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseDatos
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
        Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtPasswordDB = New DevExpress.XtraEditors.TextEdit()
        Me.txtuserDB = New DevExpress.XtraEditors.TextEdit()
        Me.txtCompañia = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSapUser = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContraseñaSap = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtPasswordDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuserDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompañia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSapUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContraseñaSap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(11, 17)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(36, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(8, 44)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(63, 13)
        Me.lblContraseña.TabIndex = 2
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtPasswordDB
        '
        Me.txtPasswordDB.Location = New System.Drawing.Point(75, 40)
        Me.txtPasswordDB.Name = "txtPasswordDB"
        Me.txtPasswordDB.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDB.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswordDB.TabIndex = 5
        '
        'txtuserDB
        '
        Me.txtuserDB.Location = New System.Drawing.Point(75, 14)
        Me.txtuserDB.Name = "txtuserDB"
        Me.txtuserDB.Size = New System.Drawing.Size(100, 20)
        Me.txtuserDB.TabIndex = 4
        '
        'txtCompañia
        '
        Me.txtCompañia.Location = New System.Drawing.Point(72, 13)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.Size = New System.Drawing.Size(100, 20)
        Me.txtCompañia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Compañia"
        '
        'txtSapUser
        '
        Me.txtSapUser.Location = New System.Drawing.Point(72, 38)
        Me.txtSapUser.Name = "txtSapUser"
        Me.txtSapUser.Size = New System.Drawing.Size(100, 20)
        Me.txtSapUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Usuario"
        '
        'txtContraseñaSap
        '
        Me.txtContraseñaSap.Location = New System.Drawing.Point(72, 64)
        Me.txtContraseñaSap.Name = "txtContraseñaSap"
        Me.txtContraseñaSap.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaSap.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseñaSap.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Contraseña"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtContraseñaSap)
        Me.PanelControl1.Controls.Add(Me.txtCompañia)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtSapUser)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 88)
        Me.PanelControl1.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(64, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "SAP BUSINESS ONE"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(64, 137)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "BASE DE DATOS"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblUsuario)
        Me.PanelControl2.Controls.Add(Me.lblContraseña)
        Me.PanelControl2.Controls.Add(Me.txtPasswordDB)
        Me.PanelControl2.Controls.Add(Me.txtuserDB)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 156)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(200, 66)
        Me.PanelControl2.TabIndex = 14
        '
        'frmBaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 318)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaseDatos"
        Me.Text = "Configuracion Base de Datos"
        CType(Me.txtPasswordDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuserDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompañia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSapUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContraseñaSap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtPasswordDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuserDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompañia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSapUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaSap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl

End Class
