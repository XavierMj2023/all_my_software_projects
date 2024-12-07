Attribute VB_Name = "fileOps"
Sub createFolder()
    Dim strBaseFolder As String ' Base folder path for images
    Dim strFolder As String ' Final folder path including the image ID and current date
    
    ' Base folder path
    strBaseFolder = ThisWorkbook.Path & Application.PathSeparator & "Images"
    
    ' Generate a unique image ID
    Dim imageID As String
    Call GenerateID(imageID)
    
    ' Folder name structure with current date, user ID, and image ID
    strFolder = strBaseFolder & Application.PathSeparator & Format(Date, "yyyy_mm") & "_userid_" & frmDataEntry.txtGeneratedId.Value & "_imageid_" & imageID
    
    ' Check if the base folder exists, if not, create it
    If Dir(strBaseFolder, vbDirectory) = "" Then
        MkDir strBaseFolder
    End If
    
    ' Check if the specific folder exists, if not, create it
    If Dir(strFolder, vbDirectory) = "" Then
        MkDir strFolder
    End If
End Sub

