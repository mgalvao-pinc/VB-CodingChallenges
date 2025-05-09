Public Class _Default
    Inherits Page

    Function GenerateSpiral(endValue As Integer, gridSize As Integer) As Integer(,)
        Dim numbers As Integer(,) = New Integer(gridSize, gridSize) {}

        For i = 0 To gridSize
            For j = 0 To gridSize
                numbers(i, j) = -1
            Next
        Next

        Dim mid As Integer = gridSize / 2
        Dim x As Integer = mid
        Dim y As Integer = mid
        Dim val As Integer = 0
        Dim inc As Integer = 1
        Dim direction As Integer = 1

        numbers(x, y) = val
        val += 1

        While val <= endValue
            For yAxis = 1 To inc
                y += direction
                numbers(x, y) = val
                If val = endValue Then Return numbers
                val += 1
            Next

            For xAxis = 1 To inc
                x += direction
                numbers(x, y) = val
                If val = endValue Then Return numbers
                val += 1
            Next

            direction *= -1
            If Not (x = 0 And y = 0) Then
                inc += 1
            End If

        End While

    End Function

    Function CreateSpiralString(SpiralMatrix As Integer(,), endValue As Integer, gridSize As Integer) As String
        Dim padWidth As Integer = endValue.ToString().Length
        Dim stringSpiral As New StringBuilder

        For i = 0 To gridSize
            For j = 0 To gridSize
                If SpiralMatrix(i, j) >= 0 Then
                    stringSpiral.Append(SpiralMatrix(i, j).ToString().PadLeft(padWidth) & " ")
                Else
                    stringSpiral.Append(" ", padWidth).Append(" ")
                End If
            Next
            stringSpiral.AppendLine()
        Next

        Return stringSpiral.ToString()
    End Function

    Protected Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim maxValue As Integer
        If Not Integer.TryParse(txt_input.Text, maxValue) Or maxValue < 0 Then
            lb_error.Text = "Invalid input. Please enter a positive integer number."
        Else
            Dim size = Math.Ceiling(Math.Sqrt(maxValue + 1))
            If (size Mod 2 = 0) Then
                size += 1
            End If

            Dim gridSize As Integer = size - 1

            Dim spiral = GenerateSpiral(maxValue, gridSize)
            Dim spiralString = CreateSpiralString(spiral, maxValue, gridSize)
            txt_result.Text = spiralString
        End If
    End Sub

End Class