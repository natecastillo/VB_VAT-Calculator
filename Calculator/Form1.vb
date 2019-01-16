Public Class Form1

    Dim netVat As Double
    Dim addVat As Double
    Dim change As Integer
    Dim disPrice As Double

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text IsNot "" Then
            netVat = txtTotal.Text / 1.12
            addVat = netVat * 0.12
            disPrice = txtTotal.Text * 0.95

            lblAmt.Text = netVat.ToString("n")
            lblVat.Text = addVat.ToString("n")
            lblDiscount.Text = disPrice.ToString("n")
        Else
            lblAmt.Text = "0"
            lblVat.Text = "0"
            lblDiscount.Text = "0"
        End If
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        If txtCash.Text IsNot "" Then
            If txtTotal.Text IsNot "" Then
                change = txtCash.Text - txtTotal.Text

                If change >= 0 Then
                    lblChange.Text = change.ToString
                Else
                    lblChange.Text = "0"
                End If

            Else
                lblChange.Text = "0"
            End If
        Else
            lblChange.Text = "0"
        End If
    End Sub

End Class
