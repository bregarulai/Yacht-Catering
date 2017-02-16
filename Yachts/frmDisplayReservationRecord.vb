Public Class frmDisplayReservationRecord
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' to return to main form
        Dim frmFirst As New frmYachts
        Hide()
        frmFirst.ShowDialog()
    End Sub

    Private Sub frmDisplayReservationRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' to read reservation file and display data 
        ' in list box
        Dim objReader As IO.StreamReader
        If IO.File.Exists("C:\VB Programs\Yachts B\Reservation.txt") = True Then
            objReader = IO.File.OpenText("C:\VB Programs\Yachts B\Reservation.txt")
            Do While objReader.Peek <> -1
                lstReservations.Items.Add(objReader.ReadLine())
            Loop
            objReader.Close()
        Else
            MsgBox("File is not available", , "Error")
        End If





    End Sub
End Class