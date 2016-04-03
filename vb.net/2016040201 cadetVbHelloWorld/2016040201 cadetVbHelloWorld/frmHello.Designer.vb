<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHello))
        Me.btnNotepad = New System.Windows.Forms.Button
        Me.btnPaint = New System.Windows.Forms.Button
        Me.btnCmd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnNotepad
        '
        Me.btnNotepad.Image = CType(resources.GetObject("btnNotepad.Image"), System.Drawing.Image)
        Me.btnNotepad.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNotepad.Location = New System.Drawing.Point(25, 12)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(77, 53)
        Me.btnNotepad.TabIndex = 0
        Me.btnNotepad.Text = "Notepad"
        Me.btnNotepad.UseVisualStyleBackColor = True
        '
        'btnPaint
        '
        Me.btnPaint.Location = New System.Drawing.Point(143, 12)
        Me.btnPaint.Name = "btnPaint"
        Me.btnPaint.Size = New System.Drawing.Size(79, 53)
        Me.btnPaint.TabIndex = 1
        Me.btnPaint.Text = "Paint"
        Me.btnPaint.UseVisualStyleBackColor = True
        '
        'btnCmd
        '
        Me.btnCmd.Location = New System.Drawing.Point(261, 12)
        Me.btnCmd.Name = "btnCmd"
        Me.btnCmd.Size = New System.Drawing.Size(79, 53)
        Me.btnCmd.TabIndex = 2
        Me.btnCmd.Text = "DOS Shell"
        Me.btnCmd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCmd)
        Me.Controls.Add(Me.btnPaint)
        Me.Controls.Add(Me.btnNotepad)
        Me.Name = "frmHello"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNotepad As System.Windows.Forms.Button
    Friend WithEvents btnPaint As System.Windows.Forms.Button
    Friend WithEvents btnCmd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
