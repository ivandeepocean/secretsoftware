Public Class SampleHome
    Dim isHomeOpen As Boolean
    Dim isInventory As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New HomeView())
        btnHome.BackgroundImage = My.Resources.homeBlue
        isHomeOpen = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles btnHome.MouseHover
        Me.btnHome.BackgroundImage = My.Resources.homeBlue

    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        If isHomeOpen Then
            Exit Sub
        End If
        Me.btnHome.BackgroundImage = My.Resources.homeBlack
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnInventory.MouseHover
        Me.btnInventory.BackgroundImage = My.Resources.inventoryBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnInventory.MouseLeave
        If isInventory Then
            Exit Sub
        End If
        Me.btnInventory.BackgroundImage = My.Resources.inventoryBlack
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnAbout.MouseHover
        Me.btnAbout.BackgroundImage = My.Resources.aboutBlue

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnAbout.MouseLeave
        Me.btnAbout.BackgroundImage = My.Resources.aboutBlack
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles btnReports.MouseHover
        Me.btnReports.BackgroundImage = My.Resources.reportBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles btnReports.MouseLeave
        Me.btnReports.BackgroundImage = My.Resources.reportBlack
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles btnSettings.MouseHover
        Me.btnSettings.BackgroundImage = My.Resources.settingsBlue

    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        Me.btnSettings.BackgroundImage = My.Resources.settingsBlack
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles btnSignOut.MouseHover
        Me.btnSignOut.BackgroundImage = My.Resources.signoutBlue
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles btnSignOut.MouseLeave
        Me.btnSignOut.BackgroundImage = My.Resources.signoutBlack
    End Sub

    Private Sub Button6_MouseClick(sender As Object, e As MouseEventArgs) Handles btnHome.MouseClick
        isInventory = False
        isHomeOpen = True

        ChangeToBlack()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New HomeView())
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles btnInventory.MouseClick
        isHomeOpen = False
        isInventory = True

        ChangeToBlack()
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New InventoryView())
    End Sub



    Sub ChangeToBlack()
        If isHomeOpen Then
            btnInventory.BackgroundImage = My.Resources.inventoryBlack
            btnReports.BackgroundImage = My.Resources.reportBlack
            btnSettings.BackgroundImage = My.Resources.settingsBlack
            btnAbout.BackgroundImage = My.Resources.aboutBlack
            btnSignOut.BackgroundImage = My.Resources.signoutBlack
            btnHome.BackgroundImage = My.Resources.homeBlue
        ElseIf isInventory Then
            btnInventory.BackgroundImage = My.Resources.inventoryBlue
            btnReports.BackgroundImage = My.Resources.reportBlack
            btnSettings.BackgroundImage = My.Resources.settingsBlack
            btnAbout.BackgroundImage = My.Resources.aboutBlack
            btnSignOut.BackgroundImage = My.Resources.signoutBlack
            btnHome.BackgroundImage = My.Resources.homeBlack
        End If
    End Sub
End Class