Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblYearBornIn.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblGender.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTribe.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGender.SelectedIndexChanged

    End Sub

    Private Sub btnWhoAmI_Click(sender As Object, e As EventArgs) Handles btnWhoAmI.Click
        'Declare Variables
        Dim strName As String
        Dim strSurname As String
        Dim iBirthYear As Integer
        Dim strGender As String
        Dim strTribe As String
        Dim iThisYear As Integer
        Dim iAge As Integer

        strName = txtName.Text
        strSurname = txtSurname.Text
        iBirthYear = txtYearBornIn.Text
        strGender = lstGender.SelectedItem
        strTribe = txtTribe.Text
        iThisYear = Year(Today)
        iAge = iThisYear - iBirthYear

        'Print the Introduction
        If strGender = "Female" Then
            MessageBox.Show("Hi! " & strName & " " & strSurname & ",you are a " & iAge & " years old lady who speaks " & strTribe & ".")
        ElseIf strGender = "Male" Then
            MessageBox.Show("Hi! " & strName & " " & strSurname & ",you are a " & iAge & " years old gentle man who speaks " & strTribe & ".")
        Else
            MessageBox.Show("Hi! " & strName & " " & strSurname & ",you are a " & iAge & " years old being who speaks " & strTribe & ".")
        End If
    End Sub
End Class
