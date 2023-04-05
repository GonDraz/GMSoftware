Imports System.Net

Public Class frmMain
    Private dataModel As New DataModel

    Sub changeHome()
        'tắt nút 
        btnPay.Checked = False
        btnMotorbike.Checked = False
        btnOwner.Checked = False
        btnCash.Checked = False
        btnSettings.Checked = False

        'tắt bảng
        dataView.Visible = False

        'tắt panel
        pnlPay.Visible = False

        'bật panel
        pnlMain.Visible = True

    End Sub

    Sub changePanel(button As Guna.UI2.WinForms.Guna2Button)
        'tắt nút 
        btnPay.Checked = False
        btnMotorbike.Checked = False
        btnOwner.Checked = False
        btnCash.Checked = False
        button.Checked = True
        btnSettings.Checked = False

        'tắt panel
        pnlPay.Visible = False
        pnlMain.Visible = False

        Select Case button.Name
            Case btnPay.Name
                pnlPay.Visible = True
            Case btnMotorbike.Name
            Case btnOwner.Name
            Case btnCash.Name
            Case btnSettings.Name
        End Select

        'bật bảng
        dataView.Visible = True
    End Sub


    Private Sub frmMain(sender As Object, e As EventArgs) Handles MyBase.Load
        dataModel.loadData()
        changeHome()
    End Sub

    Private Sub lbNameSoftware_Click(sender As Object, e As EventArgs) Handles lbNameSoftware.Click
        changeHome()

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        changePanel(btnPay)
    End Sub

    Private Sub btnMotorbike_Click(sender As Object, e As EventArgs) Handles btnMotorbike.Click
        changePanel(btnMotorbike)

    End Sub

    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        changePanel(btnOwner)

    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        changePanel(btnCash)

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        changePanel(btnSettings)
        dataView.DataSource = dataModel.getData("user")
    End Sub


End Class
