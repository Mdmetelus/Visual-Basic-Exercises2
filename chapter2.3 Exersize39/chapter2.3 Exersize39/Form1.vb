Public Class txtForm

    Private Sub btnOne_VisibleChanged(sender As Object, e As EventArgs) Handles btnOne.VisibleChanged
        
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        btnTwo.Visible = False
        btnOne.Visible = True
        BtnThree.Visible = True
        btnFour.Visible = True
    End Sub

    Private Sub btnTwo_VisibleChanged(sender As Object, e As EventArgs) Handles btnTwo.VisibleChanged
        
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        btnOne.Visible = False
        btnTwo.Visible = True
        BtnThree.Visible = True
        btnFour.Visible = True
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles BtnThree.Click
        btnOne.Visible = True
        btnTwo.Visible = True
        BtnThree.Visible = False
        btnFour.Visible = True
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        btnOne.Visible = True
        btnTwo.Visible = True
        BtnThree.Visible = True
        btnFour.Visible = False
    End Sub
End Class
