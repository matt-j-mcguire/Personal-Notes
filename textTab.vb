Imports System.ComponentModel
Imports System.Text


Public Class textTab
    Private _FileName As String
    Private _loading As Boolean

    Public Sub New()
        InitializeComponent()
        _WasOpened = True
    End Sub

    Public Sub New(filename As String)
        InitializeComponent()
        Me._FileName = filename
        Try
            _loading = True
            Dim str As String = My.Computer.FileSystem.ReadAllText(filename)
            Dim f As New key()
            If f.ShowDialog() = DialogResult.OK Then
                _WasOpened = True
                txt.Text = Converted(str, f.KeyValue)
                Key = f.KeyValue
            End If
            Dim fl As New FileInfo(filename)
            Me.FullText = fl.FullName
            Me.Text = fl.Name
            _loading = False
        Catch ex As Exception
        End Try
    End Sub

    Public ReadOnly Property WasOpened() As Boolean

    Public Overrides ReadOnly Property TabText As Object
        Get
            If Not String.IsNullOrEmpty(Key) Then
                Return MyBase.TabText
            Else
                Return MyBase.TabText & " (!)"
            End If
        End Get
    End Property

    Public Overrides Sub Closing(e As CancelEventArgs)
        MyBase.Closing(e)
        If Me.DirtyBit = True Then
            If MessageBox.Show("do you want to save before closing?", "save", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Save()
                If Me.DirtyBit Then e.Cancel = True
            End If
        End If
    End Sub

    Public Overrides Sub Save(Optional ByVal SaveAs As Boolean = False)
        If String.IsNullOrEmpty(Key) Then
            If MessageBox.Show("do you want to save without a file key?", "key?", MessageBoxButtons.YesNo) = DialogResult.No Then
                Exit Sub
            End If
        End If
        If SaveAs Or String.IsNullOrEmpty(_FileName) Then
            Dim ex As New SaveFileDialog
            If ex.ShowDialog = DialogResult.OK Then
                _FileName = ex.FileName
                Me.FullText = _FileName
                Dim flx As New FileInfo(_FileName)
                Me.Text = flx.Name
            End If
        End If

        Savethefile()
    End Sub

    Private Sub Savethefile()
        If Not String.IsNullOrEmpty(_FileName) Then
            Me.DirtyBit = False
            Dim s As String = Converted(txt.Text, Key)
            My.Computer.FileSystem.WriteAllText(_FileName, s, False)
        End If
    End Sub

    Public Sub ChangeKey()
        Dim ex As New key
        ex.KeyValue = Key
        If ex.ShowDialog(Me) = DialogResult.OK Then Key = ex.KeyValue
        Me.CleanTab.Invalidate()
    End Sub


    Public Property Key As String

    ''' <summary>
    ''' converts one string into another
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="key"></param>
    ''' <returns>function optomized with no branching</returns>
    Private Function Converted(ByVal str As String, key As String) As String
        If Not String.IsNullOrEmpty(key) Then
            Dim b() As Byte = ASCIIEncoding.ASCII.GetBytes(str)
            Dim k() As Byte = ASCIIEncoding.ASCII.GetBytes(key)
            Array.Sort(k)
            Dim kl As Integer = k.Length
            Dim index As Integer = 0

            Dim l As Integer = b.Length - 1
            For i As Integer = 0 To l
                b(i) = b(i) Xor k(index)
                index = (index + 1) Mod kl
            Next

            Return ASCIIEncoding.ASCII.GetString(b)
        Else
            Return str
        End If
    End Function



    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt.TextChanged
        If Not _loading Then
            Me.DirtyBit = True
        End If
    End Sub
End Class
