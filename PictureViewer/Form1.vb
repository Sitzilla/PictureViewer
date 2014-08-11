Public Class Form1

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        'shows the Open File dialog.   If the user clicks OK, it loads the picture that the user chooses
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'if the user selectes the check box, the size of the Picture Box is set to stretch.  If not
        'then it is set to normal

        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        'closes the form
        Close()
    End Sub

    Private Sub backgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        'Shows the color dialog box.  If the user clicks OK, it changes the Picture Box
        'control's background to the color that the user chose
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'Clears the picture
        PictureBox1.Image = Nothing
    End Sub
End Class
