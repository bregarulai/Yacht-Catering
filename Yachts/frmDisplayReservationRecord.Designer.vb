<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayReservationRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblReservationHeading = New System.Windows.Forms.Label()
        Me.lstReservations = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblReservationHeading
        '
        Me.lblReservationHeading.AutoSize = True
        Me.lblReservationHeading.Font = New System.Drawing.Font("Cooper Black", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationHeading.ForeColor = System.Drawing.Color.Navy
        Me.lblReservationHeading.Location = New System.Drawing.Point(97, 39)
        Me.lblReservationHeading.Name = "lblReservationHeading"
        Me.lblReservationHeading.Size = New System.Drawing.Size(614, 64)
        Me.lblReservationHeading.TabIndex = 0
        Me.lblReservationHeading.Text = "Reservations Details"
        '
        'lstReservations
        '
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.ItemHeight = 20
        Me.lstReservations.Location = New System.Drawing.Point(108, 162)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.ScrollAlwaysVisible = True
        Me.lstReservations.Size = New System.Drawing.Size(487, 264)
        Me.lstReservations.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Azure
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(603, 452)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(160, 50)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmDisplayReservationRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 536)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstReservations)
        Me.Controls.Add(Me.lblReservationHeading)
        Me.Name = "frmDisplayReservationRecord"
        Me.Text = "Display Reservation File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReservationHeading As Label
    Friend WithEvents lstReservations As ListBox
    Friend WithEvents btnReturn As Button
End Class
