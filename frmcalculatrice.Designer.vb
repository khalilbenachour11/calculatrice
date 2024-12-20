<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcalculatrice
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Btn_plus = New Button()
        Btn_minus = New Button()
        Btn_mult = New Button()
        Btn_div = New Button()
        Btn_equal = New Button()
        txt_A = New TextBox()
        txt_B = New TextBox()
        Btn_reset = New Button()
        Lbl_res = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(38, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 41)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(40, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 41)
        Label2.TabIndex = 1
        Label2.Text = "B"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(58, 362)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 41)
        Label3.TabIndex = 2
        Label3.Text = "resultat"
        ' 
        ' Btn_plus
        ' 
        Btn_plus.BackColor = Color.IndianRed
        Btn_plus.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_plus.Location = New Point(357, 69)
        Btn_plus.Name = "Btn_plus"
        Btn_plus.Size = New Size(61, 52)
        Btn_plus.TabIndex = 4
        Btn_plus.Text = "+"
        Btn_plus.UseVisualStyleBackColor = False
        ' 
        ' Btn_minus
        ' 
        Btn_minus.BackColor = Color.IndianRed
        Btn_minus.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_minus.Location = New Point(357, 143)
        Btn_minus.Name = "Btn_minus"
        Btn_minus.Size = New Size(61, 52)
        Btn_minus.TabIndex = 5
        Btn_minus.Text = "-"
        Btn_minus.UseVisualStyleBackColor = False
        ' 
        ' Btn_mult
        ' 
        Btn_mult.BackColor = Color.IndianRed
        Btn_mult.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_mult.Location = New Point(469, 69)
        Btn_mult.Name = "Btn_mult"
        Btn_mult.Size = New Size(61, 49)
        Btn_mult.TabIndex = 6
        Btn_mult.Text = "*"
        Btn_mult.UseVisualStyleBackColor = False
        ' 
        ' Btn_div
        ' 
        Btn_div.BackColor = Color.IndianRed
        Btn_div.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_div.Location = New Point(469, 143)
        Btn_div.Name = "Btn_div"
        Btn_div.Size = New Size(61, 52)
        Btn_div.TabIndex = 7
        Btn_div.Text = "/"
        Btn_div.UseVisualStyleBackColor = False
        ' 
        ' Btn_equal
        ' 
        Btn_equal.BackColor = Color.IndianRed
        Btn_equal.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_equal.Location = New Point(357, 223)
        Btn_equal.Name = "Btn_equal"
        Btn_equal.Size = New Size(61, 52)
        Btn_equal.TabIndex = 8
        Btn_equal.Text = "="
        Btn_equal.UseVisualStyleBackColor = False
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(114, 72)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 9
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(114, 169)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(125, 27)
        txt_B.TabIndex = 10
        ' 
        ' Btn_reset
        ' 
        Btn_reset.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_reset.Location = New Point(469, 223)
        Btn_reset.Name = "Btn_reset"
        Btn_reset.Size = New Size(69, 52)
        Btn_reset.TabIndex = 11
        Btn_reset.Text = "reset"
        Btn_reset.UseVisualStyleBackColor = True
        ' 
        ' Lbl_res
        ' 
        Lbl_res.AutoSize = True
        Lbl_res.BackColor = Color.Green
        Lbl_res.Location = New Point(357, 379)
        Lbl_res.Name = "Lbl_res"
        Lbl_res.Size = New Size(0, 20)
        Lbl_res.TabIndex = 12
        ' 
        ' frmcalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 479)
        Controls.Add(Lbl_res)
        Controls.Add(Btn_reset)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Btn_equal)
        Controls.Add(Btn_div)
        Controls.Add(Btn_mult)
        Controls.Add(Btn_minus)
        Controls.Add(Btn_plus)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmcalculatrice"
        Text = "calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_plus As Button
    Friend WithEvents Btn_minus As Button
    Friend WithEvents Btn_mult As Button
    Friend WithEvents Btn_div As Button
    Friend WithEvents Btn_equal As Button
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents Btn_reset As Button
    Friend WithEvents Lbl_res As Label

End Class
