Public Class Form1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim forma As New frmSeleccionEscenario
        ' Add any initialization after the InitializeComponent() call.
        forma.TopLevel = False
        forma.Show()
        forma.Dock = DockStyle.Fill
        forma.Visible = True
        Panel1.Controls.Add(forma)
    End Sub

End Class
