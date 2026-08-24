<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblEnemy = New System.Windows.Forms.Label
        Me.lblAngle1 = New System.Windows.Forms.Label
        Me.lblDistance = New System.Windows.Forms.Label
        Me.lblScreen = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnemy.Location = New System.Drawing.Point(15, 26)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(41, 15)
        Me.lblEnemy.TabIndex = 0
        Me.lblEnemy.Text = "Enemy"
        '
        'lblAngle1
        '
        Me.lblAngle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAngle1.AutoSize = True
        Me.lblAngle1.Location = New System.Drawing.Point(12, 412)
        Me.lblAngle1.Name = "lblAngle1"
        Me.lblAngle1.Size = New System.Drawing.Size(34, 13)
        Me.lblAngle1.TabIndex = 4
        Me.lblAngle1.Text = "Angle"
        '
        'lblDistance
        '
        Me.lblDistance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(60, 412)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(49, 13)
        Me.lblDistance.TabIndex = 5
        Me.lblDistance.Text = "Distance"
        '
        'lblScreen
        '
        Me.lblScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScreen.AutoSize = True
        Me.lblScreen.Location = New System.Drawing.Point(395, 412)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.Size = New System.Drawing.Size(41, 13)
        Me.lblScreen.TabIndex = 6
        Me.lblScreen.Text = "Screen"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Angle"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Distance"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer.Location = New System.Drawing.Point(398, 184)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(38, 15)
        Me.lblPlayer.TabIndex = 1
        Me.lblPlayer.Text = "Player"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 434)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAngle1)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblEnemy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnemy As System.Windows.Forms.Label
    Friend WithEvents lblAngle1 As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblScreen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label

End Class
