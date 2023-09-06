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
        Me.btnWhoAmI = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblYearBornIn = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblTribe = New System.Windows.Forms.Label()
        Me.txtTribe = New System.Windows.Forms.TextBox()
        Me.txtYearBornIn = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWhoAmI
        '
        Me.btnWhoAmI.Location = New System.Drawing.Point(262, 362)
        Me.btnWhoAmI.Name = "btnWhoAmI"
        Me.btnWhoAmI.Size = New System.Drawing.Size(190, 47)
        Me.btnWhoAmI.TabIndex = 0
        Me.btnWhoAmI.Text = "Who am I?"
        Me.btnWhoAmI.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(205, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lstGender
        '
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 20
        Me.lstGender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.lstGender.Location = New System.Drawing.Point(386, 191)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(120, 84)
        Me.lstGender.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(386, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(205, 71)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(74, 20)
        Me.lblSurname.TabIndex = 4
        Me.lblSurname.Text = "Surname"
        '
        'lblYearBornIn
        '
        Me.lblYearBornIn.AutoSize = True
        Me.lblYearBornIn.Location = New System.Drawing.Point(205, 133)
        Me.lblYearBornIn.Name = "lblYearBornIn"
        Me.lblYearBornIn.Size = New System.Drawing.Size(95, 20)
        Me.lblYearBornIn.TabIndex = 5
        Me.lblYearBornIn.Text = "Year born in"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(205, 191)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(63, 20)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'lblTribe
        '
        Me.lblTribe.AutoSize = True
        Me.lblTribe.Location = New System.Drawing.Point(205, 316)
        Me.lblTribe.Name = "lblTribe"
        Me.lblTribe.Size = New System.Drawing.Size(44, 20)
        Me.lblTribe.TabIndex = 7
        Me.lblTribe.Text = "Tribe"
        '
        'txtTribe
        '
        Me.txtTribe.Location = New System.Drawing.Point(386, 316)
        Me.txtTribe.Name = "txtTribe"
        Me.txtTribe.Size = New System.Drawing.Size(100, 26)
        Me.txtTribe.TabIndex = 8
        '
        'txtYearBornIn
        '
        Me.txtYearBornIn.Location = New System.Drawing.Point(386, 133)
        Me.txtYearBornIn.Name = "txtYearBornIn"
        Me.txtYearBornIn.Size = New System.Drawing.Size(100, 26)
        Me.txtYearBornIn.TabIndex = 9
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(386, 71)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 26)
        Me.txtSurname.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtYearBornIn)
        Me.Controls.Add(Me.txtTribe)
        Me.Controls.Add(Me.lblTribe)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblYearBornIn)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnWhoAmI)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWhoAmI As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lstGender As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblYearBornIn As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTribe As Label
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents txtYearBornIn As TextBox
    Friend WithEvents txtSurname As TextBox
End Class
