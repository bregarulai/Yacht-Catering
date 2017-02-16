<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYachts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYachts))
        Me.grpParty = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtHoursChartered = New System.Windows.Forms.TextBox()
        Me.txtPartyName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.grpYachts = New System.Windows.Forms.GroupBox()
        Me.lstAvailableLengths = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboYachtsType = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayYachtCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpParty.SuspendLayout()
        Me.grpYachts.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpParty
        '
        Me.grpParty.Controls.Add(Me.lblPrice)
        Me.grpParty.Controls.Add(Me.txtHoursChartered)
        Me.grpParty.Controls.Add(Me.txtPartyName)
        Me.grpParty.Controls.Add(Me.Label3)
        Me.grpParty.Controls.Add(Me.Label2)
        Me.grpParty.Controls.Add(Me.Label1)
        Me.grpParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParty.Location = New System.Drawing.Point(42, 166)
        Me.grpParty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpParty.Name = "grpParty"
        Me.grpParty.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpParty.Size = New System.Drawing.Size(621, 212)
        Me.grpParty.TabIndex = 0
        Me.grpParty.TabStop = False
        Me.grpParty.Text = "Party"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(197, 157)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(154, 25)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "$XXXXXXX.XX"
        Me.lblPrice.Visible = False
        '
        'txtHoursChartered
        '
        Me.txtHoursChartered.Location = New System.Drawing.Point(202, 112)
        Me.txtHoursChartered.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHoursChartered.Name = "txtHoursChartered"
        Me.txtHoursChartered.Size = New System.Drawing.Size(96, 30)
        Me.txtHoursChartered.TabIndex = 4
        '
        'txtPartyName
        '
        Me.txtPartyName.Location = New System.Drawing.Point(202, 68)
        Me.txtPartyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPartyName.Name = "txtPartyName"
        Me.txtPartyName.Size = New System.Drawing.Size(358, 30)
        Me.txtPartyName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calculated Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hours Chartered:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Party Name:"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Azure
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(729, 182)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(236, 48)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&OK"
        Me.ToolTip1.SetToolTip(Me.btnOk, "Hit OK to calculate price")
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Azure
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(729, 260)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(236, 48)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "clear the form")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Azure
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(729, 331)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(236, 48)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "exit the application")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Navy
        Me.lblHeading.Location = New System.Drawing.Point(170, 40)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(675, 82)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Yacht Chartering"
        '
        'grpYachts
        '
        Me.grpYachts.Controls.Add(Me.lstAvailableLengths)
        Me.grpYachts.Controls.Add(Me.Label5)
        Me.grpYachts.Controls.Add(Me.Label4)
        Me.grpYachts.Controls.Add(Me.cboYachtsType)
        Me.grpYachts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpYachts.Location = New System.Drawing.Point(42, 405)
        Me.grpYachts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpYachts.Name = "grpYachts"
        Me.grpYachts.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpYachts.Size = New System.Drawing.Size(542, 374)
        Me.grpYachts.TabIndex = 5
        Me.grpYachts.TabStop = False
        Me.grpYachts.Text = "Yachts"
        '
        'lstAvailableLengths
        '
        Me.lstAvailableLengths.FormattingEnabled = True
        Me.lstAvailableLengths.ItemHeight = 25
        Me.lstAvailableLengths.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.lstAvailableLengths.Location = New System.Drawing.Point(202, 132)
        Me.lstAvailableLengths.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstAvailableLengths.Name = "lstAvailableLengths"
        Me.lstAvailableLengths.Size = New System.Drawing.Size(68, 154)
        Me.lstAvailableLengths.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Available Lengths:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Yachts Type:"
        '
        'cboYachtsType
        '
        Me.cboYachtsType.FormattingEnabled = True
        Me.cboYachtsType.Location = New System.Drawing.Point(202, 63)
        Me.cboYachtsType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboYachtsType.Name = "cboYachtsType"
        Me.cboYachtsType.Size = New System.Drawing.Size(230, 33)
        Me.cboYachtsType.Sorted = True
        Me.cboYachtsType.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1014, 33)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintYachtTypeToolStripMenuItem, Me.PrintSummaryToolStripMenuItem, Me.DisplayYachtCountToolStripMenuItem, Me.DisplayReservationsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintYachtTypeToolStripMenuItem
        '
        Me.PrintYachtTypeToolStripMenuItem.Name = "PrintYachtTypeToolStripMenuItem"
        Me.PrintYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.PrintYachtTypeToolStripMenuItem.Text = "Print &Yacht Type"
        Me.PrintYachtTypeToolStripMenuItem.ToolTipText = "Print types of yachts available"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        Me.PrintSummaryToolStripMenuItem.ToolTipText = "Print Summary Information"
        '
        'DisplayYachtCountToolStripMenuItem
        '
        Me.DisplayYachtCountToolStripMenuItem.Name = "DisplayYachtCountToolStripMenuItem"
        Me.DisplayYachtCountToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.DisplayYachtCountToolStripMenuItem.Text = "&Display Yacht Count"
        Me.DisplayYachtCountToolStripMenuItem.ToolTipText = "Display number of yachts available"
        '
        'DisplayReservationsToolStripMenuItem
        '
        Me.DisplayReservationsToolStripMenuItem.Name = "DisplayReservationsToolStripMenuItem"
        Me.DisplayReservationsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.DisplayReservationsToolStripMenuItem.Text = "Display R&eservations"
        Me.DisplayReservationsToolStripMenuItem.ToolTipText = "Display reservation records"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit application"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextToolStripMenuItem, Me.ToolStripSeparator1, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.EditToolStripMenuItem.Text = "E&dit"
        '
        'ClearForNextToolStripMenuItem
        '
        Me.ClearForNextToolStripMenuItem.Name = "ClearForNextToolStripMenuItem"
        Me.ClearForNextToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.ClearForNextToolStripMenuItem.Text = "&Clear for Next"
        Me.ClearForNextToolStripMenuItem.ToolTipText = "Clear form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(246, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.AddYachtTypeToolStripMenuItem.Text = "&Add Yacht Type"
        Me.AddYachtTypeToolStripMenuItem.ToolTipText = "Add yacht type to the list"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        Me.RemoveYachtTypeToolStripMenuItem.ToolTipText = "Remove a yacht type from the list"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Information about the app"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.MainMenuStrip = Me.MenuStrip1
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument1
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.MainMenuStrip = Me.MenuStrip1
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(628, 472)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(327, 191)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'frmYachts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 899)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.grpYachts)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpParty)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmYachts"
        Me.Text = "Yachts"
        Me.grpParty.ResumeLayout(False)
        Me.grpParty.PerformLayout()
        Me.grpYachts.ResumeLayout(False)
        Me.grpYachts.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpParty As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHoursChartered As TextBox
    Friend WithEvents txtPartyName As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents grpYachts As GroupBox
    Friend WithEvents lstAvailableLengths As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboYachtsType As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayYachtCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearForNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPrice As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents DisplayReservationsToolStripMenuItem As ToolStripMenuItem
End Class
