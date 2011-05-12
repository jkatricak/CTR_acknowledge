Imports System.IO
'TODO: testing/error checking

Public Class Form1
  Public intErrorCount As Integer = 0

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    PopulateErrorDescriptions()
  End Sub

  'Private Sub Form1_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
  '  lstErrors.Height = Me.Height - 139
  '  lstErrors.Width = Me.Width - 36
  '  btnNotepad.Location = New Point(16, 45 + lstErrors.Height + 6)
  'End Sub

  Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
    lstErrors.Items.Clear() 'Clear any ListBox items added by a previous file.
    btnNotepad.Enabled = True
    OpenFileDialog1.InitialDirectory = "M:\Exec\AUDIT\LORIW\E-Filing\ACKNOWLEDGEMENTS\"
    OpenFileDialog1.Filter = "Text (*.txt, *.asc) |*.txt;*.asc|(*.*) |*.*"
    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
      ToolStripStatusLabel1.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
      Dim sr As New StreamReader(OpenFileDialog1.FileName)
      Dim sBuffer As String
      While Not sr.EndOfStream
        sBuffer = sr.ReadLine
        Select Case sBuffer.Substring(0, 2)
          Case "1A"
            Call CheckForErrors("1A", sBuffer.Substring(26, 30))
          Case "2A"
            Call CheckForErrors("2A", sBuffer.Substring(10, 30))
          Case "2B"
            Call CheckForErrors("2B", sBuffer.Substring(9, 30))
          Case "3R"
            Call CheckForErrors("3R", sBuffer.Substring(31, 24))
          Case "9R"
            Call CheckForErrors("9R", sBuffer.Substring(31, 24))
          Case "9Z"
            lstErrors.Items.Add("Line 9Z does not contain error codes.")
          Case Else
            lstErrors.Items.Add("Unknown Record type: " & sBuffer.Substring(0, 2))
        End Select
      End While
      MessageBox.Show("Done!  " & intErrorCount & " errors found.")
    End If
  End Sub

  Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Application.Exit()
  End Sub

  Private Sub btnNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepad.Click
    System.Diagnostics.Process.Start("notepad.exe", OpenFileDialog1.FileName)
  End Sub

  Private Sub CheckForErrors(ByVal strRecordType As String, ByVal strErrors As String)
    Try
      If Integer.Parse(strErrors) = 0 Then
        'Line is all 0's, meaning no errors.
        lstErrors.Items.Add("Line " & strRecordType & ": No errors.")
      Else
        Call ParseErrors(strRecordType, strErrors)
      End If
    Catch ex As Exception
      'If strErrors contains non-numeric characters, Integer.Parse will raise an error.
      Call ParseErrors(strRecordType, strErrors)
    End Try
  End Sub

  Private Sub ParseErrors(ByVal strRecordType As String, ByVal strErrors As String)
    Dim i As Integer = 0
    While i + 2 < strErrors.Length
      If strErrors.Substring(i, 3) <> "000" And strErrors.Substring(i, 3) <> "   " Then
        intErrorCount += 1
        lstErrors.Items.Add("Line " & strRecordType & ": " & ErrorCodes.GetErrorDescription(strErrors.Substring(i, 3)))
      End If
      i += 3
    End While
  End Sub
End Class
