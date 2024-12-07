Attribute VB_Name = "imageOps"
'Get Image Calendar Control Operation
Function GetSelectedDate() As String
    Dim sDate As String
    
    On Error Resume Next
    
    ' Call the calendar to pick the date and return it
    sDate = MyCalendar.DatePicker(frmDataEntry.txtDOB)
    
    ' If there was an error (e.g., no date picked), return an empty string
    If Err.Number <> 0 Then
        sDate = ""
    End If
    
    On Error GoTo 0
    
    GetSelectedDate = sDate
End Function

Sub validate_Image_beforeEntry()
    ' Perform validation using ValidateEntry function
    If Not ValidateEntry() Then
        ' If form is incomplete, exit and show message
        Exit Sub
    End If
    
    ' No need to call LoadImage here, it is handled in cmdLoadImage_Click
End Sub

Function ValidateAllAndImage() As Boolean
    ' Start by assuming the validation will succeed
    ValidateAllAndImage = True

    ' Validate all other fields
    With frmDataEntry
        ' Reset default colors for fields
        .txtWakeUp.BackColor = vbWhite
        .titleOf.BackColor = vbWhite
        .txtDOB.BackColor = vbWhite
        .txtjogTata.BackColor = vbWhite
        .txtjogRound.BackColor = vbWhite
        .txtAddress.BackColor = vbWhite

        ' Validate Date of Birth (DOB)
        If Trim(.txtDOB.Value) = "" Then
            MsgBox "Please select Date of Birth (DOB).", vbOKOnly + vbCritical, "Error: DOB"
            .txtDOB.BackColor = vbRed
            .txtDOB.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Wake-Up Time
        If Trim(.txtWakeUp.Value) = "" Then
            MsgBox "Please enter the wake-up time.", vbOKOnly + vbCritical, "Error: Wake-Up Time"
            .txtWakeUp.BackColor = vbRed
            .txtWakeUp.SetFocus
            ValidateAllAndImage = False
            Exit Function
        ElseIf Not IsValidTimeFormat(.txtWakeUp.Value) Then
            MsgBox "Invalid wake-up time. Use format hh:mm AM/PM.", vbOKOnly + vbCritical, "Error: Wake-Up Time"
            .txtWakeUp.BackColor = vbRed
            .txtWakeUp.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Today's Title
        If Trim(.titleOf.Value) = "" Then
            MsgBox "Please enter Today's Title.", vbOKOnly + vbCritical, "Error: Title"
            .titleOf.BackColor = vbRed
            .titleOf.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Jogging Round
        If Not ValidateJogRound(.txtjogRound.Value) Then
            MsgBox "Please enter '3' or '5' for Jogging Round.", vbOKOnly + vbCritical, "Error: Jogging Round"
            .txtjogRound.BackColor = vbRed
            .txtjogRound.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Jogging Total Time
        If Not ValidateJogTat(.txtjogTata.Value) Then
            MsgBox "Invalid jogging total time. Use format hh:mm:ss.", vbOKOnly + vbCritical, "Error: Jogging Time"
            .txtjogTata.BackColor = vbRed
            .txtjogTata.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Exercise Selection
        If Not (.optNoE.Value Or .optYesE.Value) Then
            MsgBox "Please select Exercise.", vbOKOnly + vbCritical, "Error: Exercise"
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Meditation Selection
        If Not (.optNoM.Value Or .optYesM.Value) Then
            MsgBox "Please select Meditation.", vbOKOnly + vbCritical, "Error: Meditation"
            ValidateAllAndImage = False
            Exit Function
        End If

        ' Validate Address
        If Trim(.txtAddress.Value) = "" Then
            MsgBox "Please enter Address.", vbOKOnly + vbCritical, "Error: Address"
            .txtAddress.BackColor = vbRed
            .txtAddress.SetFocus
            ValidateAllAndImage = False
            Exit Function
        End If
    End With
    
End Function

' Get Image Path from File Dialog
Function getImagePath() As String
    Dim filePath As String

    ' Open file dialog to select image
    filePath = Application.GetOpenFilename("Image Files (*.jpg; *.jpeg; *.png), *.jpg; *.jpeg; *.png", , "Select an Image")

    ' If the user canceled, return an empty string
    If filePath = "False" Then
        getImagePath = ""
    Else
        getImagePath = filePath
    End If
End Function

Sub LoadImage()
    ' Ensure the image upload happens only after the form is validated
    If Not ValidateAllAndImage() Then
        MsgBox "Please complete all details before uploading the image.", vbOKOnly + vbExclamation, "Incomplete Details"
        Exit Sub
    End If

    Dim imgSourcePath As String ' Path of the selected image
    Dim imgExtension As String ' File extension of the selected image
    Dim imageID As String ' Unique ID for the image
    Dim folderPath As String ' Path for the main image folder
    Dim subFolderPath As String ' Path for the sub-folder containing the image
    Dim imgDestination As String ' Full destination path for the image
    Dim imageSize As Double ' Image size in KB
    Dim iRow As Long ' Row number in the "ImagesDatabase" sheet
    Dim retryCount As Integer ' Retry counter for copying the image

    ' Prompt the user to select an image
    imgSourcePath = Trim(getImagePath())
    If Len(imgSourcePath) = 0 Then Exit Sub ' Exit if no image is selected

    ' Ensure the folder for saving images exists (based on current date and image ID)
    Call createFolder

    ' Generate a unique image ID based on the user ID
    Call GenerateID(imageID)

    ' Define the main folder path based on the current date and image ID
    folderPath = ThisWorkbook.Path & "\Images\" & Format(Date, "yyyy_mm") & "_userid_" & frmDataEntry.txtGeneratedId.Value & "_imageid_" & imageID
    subFolderPath = folderPath & "\" & Format(Date, "yyyy_mm_dd") & "_imageid_" & imageID

    ' Check if the main folder exists and is writable
    If Dir(folderPath, vbDirectory) = "" Then
        MsgBox "Main folder does not exist or is not writable: " & folderPath, vbOKOnly + vbCritical, "Folder Error"
        Exit Sub
    End If

    ' Create the sub-folder if it doesn't exist
    On Error Resume Next
    MkDir subFolderPath
    If Err.Number <> 0 Then
        MsgBox "Failed to create sub-folder: " & subFolderPath & vbCrLf & "Error: " & Err.Description, vbOKOnly + vbCritical, "Folder Creation Error"
        Exit Sub
    End If
    On Error GoTo 0

    ' Extract the image extension (e.g., .jpg, .png)
    imgExtension = "." & Split(imgSourcePath, ".")(UBound(Split(imgSourcePath, ".")))

    ' Define the destination path for saving the image in the sub-folder
    imgDestination = subFolderPath & "\" & "image_" & Format(Date, "yyyy_mm_dd") & "_imageid_" & imageID & imgExtension

    ' Copy the selected image to the destination folder with retry mechanism
    retryCount = 0
    On Error Resume Next
    Do While retryCount < 3 And Err.Number <> 0
        FileCopy imgSourcePath, imgDestination
        retryCount = retryCount + 1
    Loop
    If Err.Number <> 0 Then
        MsgBox "Error copying image. " & Err.Description, vbOKOnly + vbCritical, "File Copy Error"
        MsgBox "Failed to copy the image after 3 attempts.", vbOKOnly + vbCritical, "File Copy Error"
        Exit Sub
    End If
    On Error GoTo 0

    ' Calculate the image size in KB
    imageSize = FileLen(imgDestination) / 1024 ' FileLen returns size in bytes; convert to KB
    If imageSize <= 0 Then
        MsgBox "Failed to calculate image size. The file may be corrupted or the copy operation may have failed.", vbOKOnly + vbCritical, "Image Size Calculation Error"
        Exit Sub
    End If

    ' Update the image control on the form
    frmDataEntry.imgStudent.PictureSizeMode = fmPictureSizeModeStretch
    frmDataEntry.imgStudent.Picture = LoadPicture(imgDestination)

    ' Save the image path in the form's text box (if available)
    If Not frmDataEntry.Controls("txtImagePath") Is Nothing Then
        frmDataEntry.txtImagePath.Value = imgDestination
    End If

    ' Add image details to the "ImagesDatabase" sheet
    With shImagesDatabase
        ' Find the next available row in the "ImagesDatabase" sheet
        iRow = .Cells(.Rows.Count, "A").End(xlUp).row + 1
        
        ' Add image details to the "ImagesDatabase" sheet
        .Cells(iRow, 1).Value = frmDataEntry.txtGeneratedId.Value ' User ID
        .Cells(iRow, 2).Value = frmDataEntry.txtDOB.Value ' Date Of Entry
        .Cells(iRow, 3).Value = imageID ' Image ID
        .Cells(iRow, 4).Value = "image_" & Format(Date, "yyyy_mm_dd") & "_imageid_" & imageID & imgExtension ' Image Name
        .Cells(iRow, 5).Value = imageSize & " KB" ' Image Size
        .Cells(iRow, 6).Value = imgDestination ' Image URL
        .Cells(iRow, 7).Value = imgDestination ' Image
    End With

    MsgBox "Image uploaded successfully!" & vbCrLf & "Image Size: " & imageSize & " KB", vbOKOnly + vbInformation, "Success"
End Sub

