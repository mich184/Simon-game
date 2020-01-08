Public Class Form1
    Public joueurX As String
    Public joueurO As String
    Public Tableau(8) As String
    Public symbole As String
    Public compteur As Integer = 0
    Private Sub LineShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.CheckedChanged
        If X.Checked Then
            joueurX = InputBox("Quel est le nom du joueur des X ?")
            joueurO = InputBox("Quel est le nom du joueur des O ?")
            Label3.Text = joueurX
            symbole = "X"
            ButtonReset()
        End If
        X.Text = joueurX & " (X)"
        O.Text = joueurO & " (O)"
        X.Enabled = False
        O.Enabled = False
    End Sub

    Private Sub Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitter.Click
        If Button1.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button2.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button3.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button4.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button5.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button6.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button7.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button8.Enabled = True Then
            Form3.ShowDialog()
        ElseIf Button9.Enabled = True Then
            Form3.ShowDialog()
        Else
            End
        End If
    End Sub

    Private Sub O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O.CheckedChanged
        If O.Checked Then
            joueurO = InputBox("Quel est le nom du joueur des O ?")
            joueurX = InputBox("Quel est le nom du joueur des X ?")
            Label3.Text = joueurO
            symbole = "O"
            ButtonReset()
        End If
        X.Text = joueurX & " : X"
        O.Text = joueurO & " : O"
        X.Enabled = False
        O.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        MsgBox("veuillez selectionnner un symbole")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub inverser_Nomjoeur()
        If Label3.Text = joueurX Then
            Label3.Text = joueurO
        Else
            Label3.Text = joueurX
        End If
    End Sub

    Private Sub inverser_symbole()
        If symbole = "X" Then
            symbole = "O"
        Else
            symbole = "X"
        End If
    End Sub
    Private Sub combine()
        Tableau(0) = Button1.Text
        Tableau(1) = Button2.Text
        Tableau(2) = Button3.Text
        Tableau(3) = Button4.Text
        Tableau(4) = Button5.Text
        Tableau(5) = Button6.Text
        Tableau(6) = Button7.Text
        Tableau(7) = Button8.Text
        Tableau(8) = Button9.Text
        If Tableau(0) = "X" And Tableau(1) = "X" And Tableau(2) = "X" Then
            gagnant()
        ElseIf Tableau(3) = "X" And Tableau(4) = "X" And Tableau(5) = "X" Then
            gagnant()
        ElseIf Tableau(6) = "X" And Tableau(7) = "X" And Tableau(8) = "X" Then
            gagnant()
        ElseIf Tableau(0) = "X" And Tableau(3) = "X" And Tableau(6) = "X" Then
            gagnant()
        ElseIf Tableau(1) = "X" And Tableau(4) = "X" And Tableau(7) = "X" Then
            gagnant()
        ElseIf Tableau(2) = "X" And Tableau(5) = "X" And Tableau(8) = "X" Then
            gagnant()
        ElseIf Tableau(0) = "X" And Tableau(4) = "X" And Tableau(8) = "X" Then
            gagnant()
        ElseIf Tableau(6) = "X" And Tableau(4) = "X" And Tableau(2) = "X" Then
            gagnant()
        ElseIf Tableau(0) = "O" And Tableau(1) = "O" And Tableau(2) = "O" Then
            gagnant()
        ElseIf Tableau(3) = "O" And Tableau(4) = "O" And Tableau(5) = "O" Then
            gagnant()
        ElseIf Tableau(6) = "O" And Tableau(7) = "O" And Tableau(8) = "O" Then
            gagnant()
        ElseIf Tableau(0) = "O" And Tableau(3) = "O" And Tableau(6) = "O" Then
            gagnant()
        ElseIf Tableau(1) = "O" And Tableau(4) = "O" And Tableau(7) = "O" Then
            gagnant()
        ElseIf Tableau(2) = "O" And Tableau(5) = "O" And Tableau(8) = "O" Then
            gagnant()
        ElseIf Tableau(0) = "O" And Tableau(4) = "O" And Tableau(8) = "O" Then
            gagnant()
        ElseIf Tableau(6) = "O" And Tableau(4) = "O" And Tableau(2) = "O" Then
            gagnant()
        End If
    End Sub
    Private Sub gagnant()
        Label4.Text = Label3.Text & "a gagné en " & compteur & " coups"
        ButtonOut()
        Form2.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = symbole
        compteur = compteur + 1
        If compteur = 9 Then
            Label4.Text = "Partie nulle"
        End If
        combine()
        inverser_Nomjoeur()
        inverser_symbole()
        Button9.Enabled = False
    End Sub

    Private Sub Continuer_Click(sender As System.Object, e As System.EventArgs) Handles Continuer.Click
        ButtonReset()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub ButtonReset()
        Button1.Enabled = True
        Button1.Text = " "
        Button2.Enabled = True
        Button2.Text = " "
        Button3.Enabled = True
        Button3.Text = " "
        Button4.Enabled = True
        Button4.Text = " "
        Button5.Enabled = True
        Button5.Text = " "
        Button6.Enabled = True
        Button6.Text = " "
        Button7.Enabled = True
        Button7.Text = " "
        Button8.Enabled = True
        Button8.Text = " "
        Button9.Enabled = True
        Button9.Text = " "
        compteur = 0
        Label4.Text = " "
    End Sub

    Private Sub ButtonOut()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class