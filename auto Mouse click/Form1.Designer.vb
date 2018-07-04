<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoClick
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.tmrClick = New System.Windows.Forms.Timer(Me.components)
        Me.txtclicks = New System.Windows.Forms.TextBox()
        Me.gbClicks = New System.Windows.Forms.GroupBox()
        Me.lblClicksComplete = New System.Windows.Forms.Label()
        Me.gbProperties = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClickAmount = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.lblClickAmount = New System.Windows.Forms.Label()
        Me.lblMS = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbClicks.SuspendLayout()
        Me.gbProperties.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(6, 85)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(87, 85)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(6, 19)
        Me.txtAmount.MaxLength = 28
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(211, 22)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.Text = "0"
        '
        'tmrClick
        '
        Me.tmrClick.Enabled = True
        Me.tmrClick.Interval = 1
        '
        'txtclicks
        '
        Me.txtclicks.Location = New System.Drawing.Point(128, 43)
        Me.txtclicks.Name = "txtclicks"
        Me.txtclicks.ReadOnly = True
        Me.txtclicks.Size = New System.Drawing.Size(89, 22)
        Me.txtclicks.TabIndex = 3
        '
        'gbClicks
        '
        Me.gbClicks.BackColor = System.Drawing.SystemColors.Control
        Me.gbClicks.Controls.Add(Me.lblClicksComplete)
        Me.gbClicks.Controls.Add(Me.txtAmount)
        Me.gbClicks.Controls.Add(Me.txtclicks)
        Me.gbClicks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbClicks.ForeColor = System.Drawing.Color.Black
        Me.gbClicks.Location = New System.Drawing.Point(6, 6)
        Me.gbClicks.Name = "gbClicks"
        Me.gbClicks.Size = New System.Drawing.Size(223, 73)
        Me.gbClicks.TabIndex = 4
        Me.gbClicks.TabStop = False
        Me.gbClicks.Text = "Total Clicks"
        '
        'lblClicksComplete
        '
        Me.lblClicksComplete.AutoSize = True
        Me.lblClicksComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicksComplete.Location = New System.Drawing.Point(6, 46)
        Me.lblClicksComplete.Name = "lblClicksComplete"
        Me.lblClicksComplete.Size = New System.Drawing.Size(116, 16)
        Me.lblClicksComplete.TabIndex = 5
        Me.lblClicksComplete.Text = "Clicks Completed:"
        '
        'gbProperties
        '
        Me.gbProperties.Controls.Add(Me.Label1)
        Me.gbProperties.Controls.Add(Me.txtClickAmount)
        Me.gbProperties.Controls.Add(Me.Panel1)
        Me.gbProperties.Controls.Add(Me.lblMS)
        Me.gbProperties.Controls.Add(Me.txtDelay)
        Me.gbProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProperties.Location = New System.Drawing.Point(6, 114)
        Me.gbProperties.Name = "gbProperties"
        Me.gbProperties.Size = New System.Drawing.Size(223, 91)
        Me.gbProperties.TabIndex = 5
        Me.gbProperties.TabStop = False
        Me.gbProperties.Text = "Properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Clicks"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseMnemonic = False
        '
        'txtClickAmount
        '
        Me.txtClickAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClickAmount.Location = New System.Drawing.Point(111, 52)
        Me.txtClickAmount.MaxLength = 7
        Me.txtClickAmount.Name = "txtClickAmount"
        Me.txtClickAmount.Size = New System.Drawing.Size(60, 22)
        Me.txtClickAmount.TabIndex = 11
        Me.txtClickAmount.Text = "1"
        Me.txtClickAmount.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblDelay)
        Me.Panel1.Controls.Add(Me.lblClickAmount)
        Me.Panel1.Location = New System.Drawing.Point(5, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 64)
        Me.Panel1.TabIndex = 10
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Location = New System.Drawing.Point(44, 6)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(50, 16)
        Me.lblDelay.TabIndex = 6
        Me.lblDelay.Text = "Delay :"
        '
        'lblClickAmount
        '
        Me.lblClickAmount.AutoSize = True
        Me.lblClickAmount.Location = New System.Drawing.Point(3, 35)
        Me.lblClickAmount.Name = "lblClickAmount"
        Me.lblClickAmount.Size = New System.Drawing.Size(91, 16)
        Me.lblClickAmount.TabIndex = 9
        Me.lblClickAmount.Text = "Click Amount :"
        '
        'lblMS
        '
        Me.lblMS.AutoSize = True
        Me.lblMS.Location = New System.Drawing.Point(173, 28)
        Me.lblMS.Name = "lblMS"
        Me.lblMS.Size = New System.Drawing.Size(26, 16)
        Me.lblMS.TabIndex = 8
        Me.lblMS.Text = "ms"
        Me.lblMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMS.UseMnemonic = False
        '
        'txtDelay
        '
        Me.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay.Location = New System.Drawing.Point(111, 23)
        Me.txtDelay.MaxLength = 4
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(60, 22)
        Me.txtDelay.TabIndex = 4
        Me.txtDelay.Text = "1"
        '
        'frmAutoClick
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(233, 207)
        Me.Controls.Add(Me.gbProperties)
        Me.Controls.Add(Me.gbClicks)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmAutoClick"
        Me.ShowIcon = False
        Me.Text = "Auto Click"
        Me.TopMost = True
        Me.gbClicks.ResumeLayout(False)
        Me.gbClicks.PerformLayout()
        Me.gbProperties.ResumeLayout(False)
        Me.gbProperties.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents tmrClick As System.Windows.Forms.Timer
    Friend WithEvents txtclicks As System.Windows.Forms.TextBox
    Friend WithEvents gbClicks As System.Windows.Forms.GroupBox
    Friend WithEvents lblClicksComplete As System.Windows.Forms.Label
    Friend WithEvents gbProperties As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClickAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDelay As System.Windows.Forms.Label
    Friend WithEvents lblClickAmount As System.Windows.Forms.Label
    Friend WithEvents lblMS As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
