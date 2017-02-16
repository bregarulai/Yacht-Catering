' Program Name:     Yachts
' Author:           Flavio Aquino
' Date:             10/26/2016
' Purpose:          ask the user to enter the name of the party and the hours per
'                   charter and boat type and lenght.  It then calculate price per
'                   charter, total revenue, total hours, and average hours.

Public Class frmYachts
    Private totalRevenue As Decimal = 0D
    Private yachtCount As Integer = 0
    Private totalHours As Integer = 0
    Private averageHours As Decimal = 0D

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' event handler to terminate the application and close the window.
        Dim objWriter As New IO.StreamWriter("C:\VB Programs\Yachts B\YachtsTypes.txt")
        Dim yachtCount As Integer = cboYachtsType.Items.Count
        For Each line In cboYachtsType.Items
            If IO.File.Exists("C:\VB Programs\Yachts B\YachtsTypes.txt") = True Then
                objWriter.WriteLine(line.ToString())
            End If
        Next
        objWriter.Close()
        Application.Exit()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnExit_Click(sender, e)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' event handler to calculate price and summary information
        Dim numberOfHours As Integer = 0
        Dim price As Decimal = 0D
        Dim strNonNumericMessage As String = "Error - Enter a number for Hours Chartered."
        Dim strNullMessage As String = "Error - Enter a number greater than zero."
        Dim strErrorMessageHeading As String = "Invalid Input"
        Dim objWriter As New IO.StreamWriter("C:\VB Programs\Yachts B\Reservation.txt", True)
        Dim strDate As String = Date.Now.ToString("MMMM dd',' yyyy 'at' h:mm tt")
        ' to validate for a party name
        If txtPartyName.Text = "" Then
            MsgBox("Enter a Party Name.", , "Enter a Valid input")
            txtPartyName.Focus()
        ElseIf lstAvailableLengths.SelectedIndex < 0 Then
            MsgBox("Select a yacht lenght.", , "Error")
        ElseIf cboYachtsType.SelectedIndex < 0 Then
            MsgBox("Select a yacht Type.", , "Error")
        Else
            Try
                numberOfHours = Convert.ToInt32(txtHoursChartered.Text)
                ' to validate for 0 or negative input
                If numberOfHours > 0 Then
                    price = CalculateCost(numberOfHours)
                    totalHours += numberOfHours
                    totalRevenue += price
                    yachtCount += 1
                    averageHours = totalHours / yachtCount
                    lblPrice.Text = price.ToString("C")
                    lblPrice.Visible = True
                    ' to write data to a text file
                    If IO.File.Exists("C:\VB Programs\Yachts B\Reservation.txt") Then
                        objWriter.WriteLine(txtPartyName.Text)
                        objWriter.WriteLine(txtHoursChartered.Text)
                        objWriter.WriteLine(cboYachtsType.SelectedItem)
                        objWriter.WriteLine(lstAvailableLengths.SelectedItem)
                        objWriter.WriteLine(lblPrice.Text)
                        objWriter.WriteLine(strDate)
                        objWriter.WriteLine()
                    Else
                        MsgBox("The file is not available", , "Error")
                        Close()
                    End If
                    txtHoursChartered.Clear()
                    txtPartyName.Clear()
                    txtPartyName.Focus()
                    btnClear.Enabled = True
                Else
                    MsgBox(strNullMessage, , strErrorMessageHeading)
                    txtHoursChartered.Clear()
                    txtHoursChartered.Focus()
                End If
            Catch ex As Exception
                MsgBox(strNonNumericMessage, , strErrorMessageHeading)
                txtHoursChartered.Clear()
                txtHoursChartered.Focus()
            End Try
        End If
        objWriter.Close()

    End Sub

    Private Function CalculateCost(ByVal hours As Integer) As Decimal
        ' function to calculate and return cost per charter
        Dim cost As Decimal
        Dim availableLenght As Integer = 0
        availableLenght = Convert.ToInt32(lstAvailableLengths.SelectedItem)
        Select Case availableLenght
            Case 22
                cost = hours * 95.0
            Case 24
                cost = hours * 137.0
            Case 30
                cost = hours * 160.0
            Case 32
                cost = hours * 192.0
            Case 36
                cost = hours * 250.0
            Case 38
                cost = hours * 400.0
            Case 45
                cost = hours * 550.0
        End Select
        Return cost
    End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' event handler to clear form and reset class variables
        totalRevenue = 0D
        yachtCount = 0
        totalHours = 0
        averageHours = 0D
        txtHoursChartered.Clear()
        txtPartyName.Clear()
        txtPartyName.Focus()
        lblPrice.Text = ""
    End Sub

    Private Sub ClearForNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearForNextToolStripMenuItem.Click
        ' event handler to clear form and reset class variables
        btnClear_Click(sender, e)
    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        'event handler to add a yacht type to yacht type combo box
        If cboYachtsType.Text = "" Then
            MsgBox("Enter a yacht name to be added", , "Invalid Input")
        Else
            cboYachtsType.Items.Add(cboYachtsType.Text)
            cboYachtsType.Text = ""
        End If
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        ' event handler to remove yacht type from yacht type combo box
        If cboYachtsType.Text = "" Then
            MsgBox("Enter a yacht name to be removed", , "Invalid Input")
        Else
            cboYachtsType.Items.Remove(cboYachtsType.Text)
            cboYachtsType.Text = ""
        End If
    End Sub

    Private Sub DisplayYachtCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayYachtCountToolStripMenuItem.Click
        ' event handler to display yacht count in a message box
        Dim yachtTypeCount As Integer
        yachtTypeCount = cboYachtsType.Items.Count
        Dim strYachtCount As String
        strYachtCount = yachtTypeCount.ToString()
        MsgBox("Number of yachts: " & strYachtCount, , "Yacht Count")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' event handler to open modal about form
        frmAbout.ShowDialog()
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        ' handler to show a preview of the summary information to the user before
        ' printing it.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintYachtTypeToolStripMenuItem.Click
        ' handler to show preview of yach types available to user
        ' before printing it.
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString("Summary Report", New Font("Arial", 32),
                              Brushes.Black, 225, 125)
        e.Graphics.DrawString("by Flavio Aquino", New Font("Arial", 20),
                              Brushes.Black, 300, 175)
        e.Graphics.DrawString("Total hours chartered: ", New Font("Arial", 16),
                              Brushes.Black, 100, 250)
        e.Graphics.DrawString(totalHours.ToString(), New Font("Arial", 16),
                              Brushes.Black, 400, 250)
        e.Graphics.DrawString("Average hours chartered: ", New Font("Arial", 16),
                              Brushes.Black, 100, 300)
        e.Graphics.DrawString(averageHours.ToString("F"), New Font("Arial", 16),
                              Brushes.Black, 400, 300)
        e.Graphics.DrawString("Total revenue: ", New Font("Arial", 16),
                              Brushes.Black, 100, 350)
        e.Graphics.DrawString(totalRevenue.ToString("C"), New Font("Arial", 16),
                              Brushes.Black, 400, 350)
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        ' event handler to show the yacht type report on print preview
        e.Graphics.DrawString("Yacht Type Report", New Font("Arial", 32),
                              Brushes.Black, 200, 125)
        e.Graphics.DrawString("by Flavio Aquino", New Font("Arial", 20),
                              Brushes.Black, 300, 175)
        Dim space As Integer = 250
        For i As Integer = 0 To cboYachtsType.Items.Count - 1
            e.Graphics.DrawString(cboYachtsType.Items(i).ToString(),
                                  New Font("Arial", 16), Brushes.Black, 100, space)
            space += 50
        Next
    End Sub

    Private Sub frmYachts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' hold splashscreen for 5 seconds
        Threading.Thread.Sleep(5000)

        ' to read yachts type from a file
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\VB Programs\Yachts B\YachtsTypes.txt"
        Dim strFileError As String = "File not available.  Restart when the file is available"
        ' to verify the file exist
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' to read file line by line
            Do While objReader.Peek <> -1
                cboYachtsType.Items.Add(objReader.ReadLine())
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError, , "File Error.")
        End If
    End Sub

    Private Sub DisplayReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayReservationsToolStripMenuItem.Click
        ' to display reservations in a modal form
        Dim frmSecond As New frmDisplayReservationRecord
        Hide()
        frmSecond.ShowDialog()
    End Sub
End Class
