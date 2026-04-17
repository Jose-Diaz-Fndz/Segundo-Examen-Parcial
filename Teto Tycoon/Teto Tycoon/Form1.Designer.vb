<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Teto = New System.Windows.Forms.Label()
        Me.MikuDayo = New System.Windows.Forms.ComboBox()
        Me.SoldierTeto = New System.Windows.Forms.Button()
        Me.MikuEatingTeto = New System.Windows.Forms.PictureBox()
        Me.Baguettes = New System.Windows.Forms.PictureBox()
        Me.PPPTeto = New System.Windows.Forms.Label()
        Me.SrSeed = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GUMI = New System.Windows.Forms.Label()
        CType(Me.MikuEatingTeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Baguettes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Teto
        '
        Me.Teto.AutoSize = True
        Me.Teto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teto.ForeColor = System.Drawing.Color.Salmon
        Me.Teto.Location = New System.Drawing.Point(114, 9)
        Me.Teto.Name = "Teto"
        Me.Teto.Size = New System.Drawing.Size(178, 29)
        Me.Teto.TabIndex = 0
        Me.Teto.Text = "Total of eating :"
        '
        'MikuDayo
        '
        Me.MikuDayo.FormattingEnabled = True
        Me.MikuDayo.Items.AddRange(New Object() {"Normal", "Crazy (x2)", "EXTREME (x3)"})
        Me.MikuDayo.Location = New System.Drawing.Point(62, 89)
        Me.MikuDayo.Name = "MikuDayo"
        Me.MikuDayo.Size = New System.Drawing.Size(121, 21)
        Me.MikuDayo.TabIndex = 1
        '
        'SoldierTeto
        '
        Me.SoldierTeto.Location = New System.Drawing.Point(62, 143)
        Me.SoldierTeto.Name = "SoldierTeto"
        Me.SoldierTeto.Size = New System.Drawing.Size(119, 48)
        Me.SoldierTeto.TabIndex = 2
        Me.SoldierTeto.Text = "Eating"
        Me.SoldierTeto.UseVisualStyleBackColor = True
        '
        'MikuEatingTeto
        '
        Me.MikuEatingTeto.Image = Global.Teto_Tycoon.My.Resources.Resources.Miku_eating_Teto_omg
        Me.MikuEatingTeto.Location = New System.Drawing.Point(240, 54)
        Me.MikuEatingTeto.Name = "MikuEatingTeto"
        Me.MikuEatingTeto.Size = New System.Drawing.Size(258, 192)
        Me.MikuEatingTeto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MikuEatingTeto.TabIndex = 4
        Me.MikuEatingTeto.TabStop = False
        Me.MikuEatingTeto.Visible = False
        '
        'Baguettes
        '
        Me.Baguettes.Enabled = False
        Me.Baguettes.Image = Global.Teto_Tycoon.My.Resources.Resources.Teto
        Me.Baguettes.Location = New System.Drawing.Point(260, 54)
        Me.Baguettes.Name = "Baguettes"
        Me.Baguettes.Size = New System.Drawing.Size(189, 192)
        Me.Baguettes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Baguettes.TabIndex = 3
        Me.Baguettes.TabStop = False
        Me.Baguettes.Visible = False
        '
        'PPPTeto
        '
        Me.PPPTeto.AutoSize = True
        Me.PPPTeto.ForeColor = System.Drawing.SystemColors.Control
        Me.PPPTeto.Location = New System.Drawing.Point(32, 214)
        Me.PPPTeto.Name = "PPPTeto"
        Me.PPPTeto.Size = New System.Drawing.Size(78, 13)
        Me.PPPTeto.TabIndex = 5
        Me.PPPTeto.Text = "Tiempo Activo:"
        '
        'SrSeed
        '
        Me.SrSeed.AutoSize = True
        Me.SrSeed.ForeColor = System.Drawing.Color.Cyan
        Me.SrSeed.Location = New System.Drawing.Point(135, 214)
        Me.SrSeed.Name = "SrSeed"
        Me.SrSeed.Size = New System.Drawing.Size(34, 13)
        Me.SrSeed.TabIndex = 6
        Me.SrSeed.Text = "00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'GUMI
        '
        Me.GUMI.AutoSize = True
        Me.GUMI.Font = New System.Drawing.Font("Modak", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUMI.ForeColor = System.Drawing.Color.Salmon
        Me.GUMI.Location = New System.Drawing.Point(284, 5)
        Me.GUMI.Name = "GUMI"
        Me.GUMI.Size = New System.Drawing.Size(34, 41)
        Me.GUMI.TabIndex = 8
        Me.GUMI.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(510, 258)
        Me.Controls.Add(Me.GUMI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SrSeed)
        Me.Controls.Add(Me.PPPTeto)
        Me.Controls.Add(Me.MikuEatingTeto)
        Me.Controls.Add(Me.Baguettes)
        Me.Controls.Add(Me.SoldierTeto)
        Me.Controls.Add(Me.MikuDayo)
        Me.Controls.Add(Me.Teto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MikuEatingTeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Baguettes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Teto As Label
    Friend WithEvents MikuDayo As ComboBox
    Friend WithEvents SoldierTeto As Button
    Friend WithEvents Baguettes As PictureBox
    Friend WithEvents MikuEatingTeto As PictureBox
    Friend WithEvents PPPTeto As Label
    Friend WithEvents SrSeed As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents GUMI As Label
End Class
