Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlFundo.Controls.Clear()
        ResetarTab()
        TabDashboard.Visible = True
        frmDashboard.TopLevel = False
        frmDashboard.Dock = DockStyle.Fill
        pnlFundo.Controls.Add(frmDashboard)
        frmDashboard.Show()
    End Sub
    Private Sub ResetarTab()
        tabPrincipal.Visible = False
        TabRelatorios.Visible = False
        TabSuporte.Visible = False
        TabSistema.Visible = False
        TabDashboard.Visible = False
    End Sub

    Private Sub AdicionarFormPainel(ByRef formulario As Object)
        frmSessao.TopLevel = False
        frmSessao.Dock = DockStyle.Fill
        pnlFundo.Controls.Add(frmSessao)
        frmSessao.Show()
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        pnlFundo.Controls.Clear()
        ResetarTab()
        TabRelatorios.Visible = True
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlFundo.Controls.Clear()
        ResetarTab()
        TabDashboard.Visible = True

        ResetarTab()
        TabDashboard.Visible = True
        frmDashboard.TopLevel = False
        frmDashboard.Dock = DockStyle.Fill
        pnlFundo.Controls.Add(frmDashboard)
        frmDashboard.Show()
    End Sub

    Private Sub btnSuporte_Click(sender As Object, e As EventArgs) Handles btnSuporte.Click
        pnlFundo.Controls.Clear()
        ResetarTab()
        TabSuporte.Visible = True
    End Sub

    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click
        pnlFundo.Controls.Clear()
        ResetarTab()
        TabSistema.Visible = True
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        pnlFundo.Controls.Clear()
        ResetarTab()
        tabPrincipal.Visible = True
    End Sub

    Private Sub btnPrincCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrincCliente.ItemClick
        pnlFundo.Controls.Clear()
        frmExemplo2.TopLevel = False
        frmExemplo2.Dock = DockStyle.Fill
        pnlFundo.Controls.Add(frmExemplo2)
        frmExemplo2.Show()

    End Sub

    Private Sub btnPrincSessao_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrincSessao.ItemClick
        pnlFundo.Controls.Clear()
        frmSessao.TopLevel = False
        frmSessao.Dock = DockStyle.Fill
        pnlFundo.Controls.Add(frmSessao)
        frmSessao.Show()
    End Sub
End Class
