<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class openurl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtURl = New System.Windows.Forms.TextBox()
        Me.Btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtURl
        '
        Me.TxtURl.Location = New System.Drawing.Point(13, 13)
        Me.TxtURl.Name = "TxtURl"
        Me.TxtURl.Size = New System.Drawing.Size(386, 20)
        Me.TxtURl.TabIndex = 0
        '
        'Btnok
        '
        Me.Btnok.Location = New System.Drawing.Point(163, 39)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(75, 23)
        Me.Btnok.TabIndex = 1
        Me.Btnok.Text = "OK"
        Me.Btnok.UseVisualStyleBackColor = True
        '
        'openurl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 70)
        Me.Controls.Add(Me.Btnok)
        Me.Controls.Add(Me.TxtURl)
        Me.Name = "openurl"
        Me.Text = "openurl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtURl As TextBox
    Friend WithEvents Btnok As Button
End Class
