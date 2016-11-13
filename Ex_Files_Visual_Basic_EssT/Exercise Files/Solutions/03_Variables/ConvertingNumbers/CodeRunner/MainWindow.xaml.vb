﻿Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim byte1 As Byte = 255
        Dim int1 As Integer = 256
        Dim dbl1 As Double = 55.5
        Dim str1 As String = txtInput.Text

        If IsNumeric(str1) Then
            Dim intFromString As Integer = Integer.Parse(str1)
            Output("You entered " + intFromString.ToString())
        Else
            Output("The value isn't numeric")
        End If

        Dim dbl2 As Double = int1
        Output("The value of dbl2 is: " + dbl2.ToString)

        Try
            Dim byte2 As Byte = Convert.ToByte(int1)
            Output("The value of byte2 is: " + byte2.ToString)
        Catch ex As Exception
            Output(ex.Message)
        End Try


    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
