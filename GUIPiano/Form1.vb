Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SerialPort1.IsOpen() Then
            SerialPort1.Close()
        End If



        SerialPort1.PortName = TextBox1.Text
        SerialPort1.BaudRate = Val(TextBox2.Text)
        Try
            SerialPort1.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        If SerialPort1.IsOpen() Then
            Label3.Text = "Connected"
        Else
            Label3.Text = "Not Connected"
        End If
    End Sub

    Public Sub send_data(ByVal data_yang_dikirim As String)
        If SerialPort1.IsOpen() Then
            SerialPort1.Write(data_yang_dikirim + Environment.NewLine())
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = 9600
        TextBox1.Text = "COM6"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        send_data("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        send_data("2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        send_data("3")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        send_data("4")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        send_data("5")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        send_data("6")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        send_data("7")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        send_data("8")
    End Sub

    Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button2.KeyPress

    End Sub
End Class
