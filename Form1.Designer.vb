<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleinterest
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
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtSimple = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimple = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(46, 93)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(235, 20)
        Me.txtPrincipal.TabIndex = 0
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(46, 154)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(235, 20)
        Me.txtRate.TabIndex = 1
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(46, 214)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(235, 20)
        Me.txtPeriod.TabIndex = 2
        '
        'txtSimple
        '
        Me.txtSimple.Location = New System.Drawing.Point(343, 93)
        Me.txtSimple.Name = "txtSimple"
        Me.txtSimple.Size = New System.Drawing.Size(186, 20)
        Me.txtSimple.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(343, 200)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(186, 20)
        Me.txtTotal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Principal Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rate(in percentage)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Period (in Years)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Simple Interest Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Amount"
        '
        'btnSimple
        '
        Me.btnSimple.Location = New System.Drawing.Point(45, 252)
        Me.btnSimple.Name = "btnSimple"
        Me.btnSimple.Size = New System.Drawing.Size(101, 43)
        Me.btnSimple.TabIndex = 11
        Me.btnSimple.Text = "Simple Interest"
        Me.btnSimple.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(177, 252)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(83, 43)
        Me.btnTotal.TabIndex = 12
        Me.btnTotal.Text = "Total Amount"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(310, 252)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 43)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(443, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 43)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSimpleinterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 343)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSimple)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSimple)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Name = "frmSimpleinterest"
        Me.Text = "Simple Interest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents txtSimple As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
