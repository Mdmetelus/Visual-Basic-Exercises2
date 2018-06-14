<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtForm
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.BtnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(32, 60)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(106, 71)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "Push Me"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(157, 61)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(105, 70)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "Push Me"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'BtnThree
        '
        Me.BtnThree.Location = New System.Drawing.Point(32, 151)
        Me.BtnThree.Name = "BtnThree"
        Me.BtnThree.Size = New System.Drawing.Size(106, 72)
        Me.BtnThree.TabIndex = 2
        Me.BtnThree.Text = "Push Me"
        Me.BtnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(157, 151)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(105, 72)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "Push Me"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'txtForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.BtnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "txtForm"
        Me.RightToLeftLayout = True
        Me.Text = "Push Me"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents BtnThree As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button

End Class
