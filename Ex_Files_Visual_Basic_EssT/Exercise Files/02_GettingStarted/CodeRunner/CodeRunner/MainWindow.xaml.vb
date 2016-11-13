Class MainWindow

    Dim names As ArrayList = New ArrayList()

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here
        'Dim fruits() As String = {"Apple", "Orange", "Pear"}
        'Output("the number of fruits is : " + fruits.Length.ToString())

        'Dim vegetable(2) As String
        'vegetable(0) = "Potato"
        'vegetable(1) = "Lettuce"
        'For veg As Integer = 0 To vegetable.Length - 1
        '    Dim vegName As String = vegetable(veg)
        '    Output(vegName)
        'Next
        names.Add(txtInput.Text)
        txtOutput.Text = ""
        txtInput.Text = ""
        For Each newName In names

            Output(newName)
        Next


    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
