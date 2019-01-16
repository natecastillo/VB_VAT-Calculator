<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lbl_cash = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(138, 25)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(250, 53)
        Me.txtTotal.TabIndex = 0
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(138, 84)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(250, 53)
        Me.txtCash.TabIndex = 1
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(12, 28)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(120, 46)
        Me.lbl_total.TabIndex = 3
        Me.lbl_total.Text = "Total:"
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(12, 212)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(42, 46)
        Me.lblAmt.TabIndex = 6
        Me.lblAmt.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 46)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Add: VAT"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(12, 304)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(42, 46)
        Me.lblVat.TabIndex = 8
        Me.lblVat.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 46)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Change:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(12, 396)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(42, 46)
        Me.lblChange.TabIndex = 10
        Me.lblChange.Text = "0"
        '
        'lbl_cash
        '
        Me.lbl_cash.AutoSize = True
        Me.lbl_cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash.Location = New System.Drawing.Point(12, 87)
        Me.lbl_cash.Name = "lbl_cash"
        Me.lbl_cash.Size = New System.Drawing.Size(124, 46)
        Me.lbl_cash.TabIndex = 4
        Me.lbl_cash.Text = "Cash:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 46)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount: Net of VAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Discounted Price:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(12, 488)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(42, 46)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 547)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_cash)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtTotal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VAT Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lblAmt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lbl_cash As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDiscount As Label
End Class
