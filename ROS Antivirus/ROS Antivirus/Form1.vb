Imports System.IO
Imports System.Security.Cryptography

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

    'Start Hash Generator
    Function makemd5(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)
        Try
            Dim hash
            If hash_type.ToLower = "md5" Then
                hash = md5.Create()
            ElseIf hash_type.ToLower = "sha1" Then
                hash = SHA1.Create()
            ElseIf hash_type.ToLower = "sha256" Then
                hash = SHA256.Create()
            Else
                MsgBox("Backend Error: Unknown Hash Type - " & hash_type, MsgBoxStyle.Critical)
                Return "Error"
            End If
            Dim hashValue() As Byte
            Dim fileStream As FileStream = File.OpenRead(file_name)
            fileStream.Position = 0
            hashValue = hash.ComputeHash(fileStream)
            Dim hash_hex = PrintByteArray(hashValue)
            fileStream.Close()
            Return hash_hex
        Catch ex As Exception
            Return "Error"
        End Try
    End Function
    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function
    'End Hash Generator

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Backtostart()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Backtostart()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub Backtostart()
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.BackColor = Color.FromArgb(244, 244, 244)
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BackColor = Color.Transparent
    End Sub
End Class
