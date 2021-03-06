﻿Class MainWindow

    Dim states As Collection = New Collection()
    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtOutput.Text = ""
    End Sub

    Sub btnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click
        states.Clear()
        states.Add("California", "CA")
        states.Add("Oregon", "OR")
        states.Add("Washington", "WA")
        OutputStates()
    End Sub

    Private Sub btnGet_Click(sender As Object, e As RoutedEventArgs) Handles btnGet.Click
        Dim stateID As String = txtInput.Text
        If states.Contains(stateID) Then
            Output("You requested: " + states.Item(stateID))
        Else
            Output("Not found")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As RoutedEventArgs) Handles btnRemove.Click
        If states.Contains(txtInput.Text) Then
            states.Remove(txtInput.Text)
            txtOutput.Text = ""
            Output(txtInput.Text + " removed; here's what's left")
            OutputStates()
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As RoutedEventArgs) Handles btnShow.Click
        OutputStates()
    End Sub

    Sub OutputStates()
        For Each s As String In states
            Output(s)
        Next
    End Sub

End Class
