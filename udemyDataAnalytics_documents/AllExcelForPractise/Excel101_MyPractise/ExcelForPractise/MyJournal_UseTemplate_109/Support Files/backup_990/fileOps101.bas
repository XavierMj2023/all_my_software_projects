Attribute VB_Name = "fileOps"
' Create Folder
Sub createFolder()
    Dim strFolder As String
    strFolder = ThisWorkbook.Path & Application.PathSeparator & "img_dec"
    If Dir(strFolder, vbDirectory) = "" Then
        MkDir strFolder
    End If
End Sub
