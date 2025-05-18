Public Class About
    Inherits Page

    Function CheckPalindrome(value As Integer) As Boolean
        Dim original As Integer
        Dim reversed As Integer
        original = value
        reversed = 0

        While value > 0
            Dim digit As Integer
            digit = value Mod 10
            reversed = (reversed * 10) + digit
            value = Math.Floor(value / 10)
        End While

        Return original = reversed
    End Function

    Protected Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim number As Integer
        If Integer.TryParse(txt_input.Text, number) And number >= 0 Then
            lb_error.Text = ""
            Dim result As Boolean
            result = CheckPalindrome(number)
            If result Then
                lb_response.Text = number & " is a palindrome."
            Else
                lb_response.Text = number & " is not a palindrome."
            End If
        Else
            lb_error.Text = "Invalid input. Please enter a positive integer number."
        End If
    End Sub
End Class