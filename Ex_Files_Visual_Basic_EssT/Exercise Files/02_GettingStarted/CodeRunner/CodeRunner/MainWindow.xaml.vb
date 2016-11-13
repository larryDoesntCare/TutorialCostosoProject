Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here
        Dim o As Object = New Object()
        If IsNothing(o) Then
            Output("No object exists")
        Else
            Output("Before assignment to value: " + o.GetType().ToString())
        End If

        o = 1
        Output("As Number : " + o.GetType().ToString())
        o = "Green"
        Output("As String : " + o.GetType().ToString())

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
