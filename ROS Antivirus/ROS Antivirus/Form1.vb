Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateHashes()
        If Not My.Computer.FileSystem.FileExists(IO.Directory.GetCurrentDirectory() + "virushashes.txt") Or Not GetDownloadSize("https://raw.githubusercontent.com/Richienb/virusshare-hashes/master/virushashes.txt") = FileLen("virushashes.txt") Then
            My.Computer.Network.DownloadFile(address:="https://raw.githubusercontent.com/Richienb/virusshare-hashes/master/virushashes.txt", destinationFileName:="virushashes.txt", userName:=String.Empty, password:=String.Empty, showUI:=False, connectionTimeout:=100000, overwrite:=True)
        End If
    End Sub

    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.Transparent
    End Sub
End Class
