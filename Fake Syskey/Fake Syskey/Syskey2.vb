Public Class Syskey2
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirm.Click
        MsgBox("There has been an error securing the Windows Account Database, please contact your system administrator or try again later.", MsgBoxStyle.Critical, "SAM Lock Tool")
        End
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RadioButton1.Checked = True Then
            If RadioButton1.Checked = True Then
                RadioButton3.Enabled = False
                RadioButton4.Enabled = False
                Label4.Enabled = False
                Label5.Enabled = False
            End If

            If RadioButton1.Checked = False Then
                RadioButton3.Enabled = True
                RadioButton4.Enabled = True
                Label4.Enabled = True
                Label5.Enabled = True
            End If

            If RadioButton2.Checked = True Then
                Label1.Enabled = False
                Label2.Enabled = False
                Label3.Enabled = False
                TextBox2.Enabled = False
                TextBox1.Enabled = False
            End If

            If RadioButton2.Checked = False Then
                Label1.Enabled = True
                Label2.Enabled = True
                Label3.Enabled = True
                TextBox2.Enabled = True
                TextBox1.Enabled = True
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            TextBox2.Enabled = False
            TextBox1.Enabled = False
        End If

        If RadioButton2.Checked = False Then
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            TextBox2.Enabled = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
        End If

        If RadioButton1.Checked = False Then
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            Label4.Enabled = True
            Label5.Enabled = True
        End If
    End Sub
End Class