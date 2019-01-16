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

            If txtCash.Text IsNot "" Then
                change = txtCash.Text - txtTotal.Text

                If change > 0 Then
                    lblChange.Text = change.ToString
                End If
            Else
                lblChange.Text = ""
            End If
        Else
            lblAmt.Text = ""
            lblVat.Text = ""
            lblDiscount.Text = ""
            lblChange.Text = ""
        End If

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        If txtCash.Text IsNot "" Then
            If txtTotal.Text IsNot "" Then
                change = txtCash.Text - txtTotal.Text

                If change >= 0 Then
                    lblChange.Text = change.ToString
                Else
                    lblChange.Text = ""
                End If
            Else
                lblChange.Text = ""
            End If
        Else
            lblChange.Text = ""
        End If
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
