Attribute VB_Name = "myUpdateDataEntryForm"
    ' This function retrieves the selected row number from the ListBox.
    Function GetSelectedRow() As Long
        Dim i As Long
        ' Loop through ListBox to find selected row
        For i = 0 To frmDataEntry.lstDatabase.ListCount - 1
            If frmDataEntry.lstDatabase.Selected(i) Then
                GetSelectedRow = i + 1  ' Return 1-based index
                Exit Function
            End If
        Next i
        GetSelectedRow = 0 ' Return 0 if no row is selected
    End Function
    
    Sub Edit_Data()
    ' Ensure a row is selected
    Dim selectedRow As Long
    selectedRow = GetSelectedRow() ' Assuming this is a function that returns the selected row index

    ' Check if a valid row is selected
    If selectedRow = 0 Then
        MsgBox "No row is selected. Please select a valid row.", vbOKOnly + vbInformation, "Edit"
        Exit Sub
    End If

    ' Load the data for the selected row into the form
    LoadSelectedRowData selectedRow

    ' Show the form (if it's hidden) to allow the user to update the data
    frmDataEntry.Show

    ' Update ListBox with the data from the form (after loading data)
    UpdateDataInListBox selectedRow
End Sub
    
    Sub ClearFormFields()
        ' Clear form fields before loading data
        With frmDataEntry
            .txtDOB.Value = ""
            .txtWakeUp.Value = ""
            .txtjogTata.Value = ""
            .txtjogRound.Value = ""
            .titleOf.Value = ""
            
            .optYesE.Value = False
            .optNoE.Value = False
            
            .optYesM.Value = False
            .optNoM.Value = False
            
            .imgStudent.Picture = LoadPicture("")  ' Clear image
            .txtImagePath.Value = ""
            
            .txtAddress.Value = ""
        End With
    End Sub
    
    
    Sub LoadSelectedRowData(selectedRow As Long)
        On Error GoTo ErrorHandler
    
        ' Ensure row is within bounds
        If selectedRow <= 0 Or selectedRow > frmDataEntry.lstDatabase.ListCount Then
            MsgBox "Invalid row selected. Please select a valid row.", vbExclamation, "Error"
            Exit Sub
        End If
    
        ' Clear form fields
        ClearFormFields
    
        ' Load data from ListBox into form fields
        With frmDataEntry
            ' Handle Date (Column 1)
            Dim entryDate As Variant
            entryDate = .lstDatabase.List(selectedRow - 1, 1)
            If IsNumeric(entryDate) Then
                ' Serial number date
                .txtDOB.Value = Format(CDate(entryDate), "dd-mmm-yyyy")
            ElseIf IsDate(entryDate) Then
                ' Date as string
                .txtDOB.Value = Format(CDate(entryDate), "dd-mmm-yyyy")
            Else
                Debug.Print "Invalid Date: " & entryDate
                .txtDOB.Value = ""  ' Leave blank if invalid
            End If
    
            ' Handle Wake Up Time (Column 2)
            Dim wakeUpTime As Variant
            wakeUpTime = .lstDatabase.List(selectedRow - 1, 2)
            If IsNumeric(wakeUpTime) Then
                ' Decimal time format
                .txtWakeUp.Value = Format(TimeSerial(Int(wakeUpTime * 24), (wakeUpTime * 1440) Mod 60, 0), "hh:mm AM/PM")
            ElseIf IsDate(wakeUpTime) Then
                ' Time as string
                .txtWakeUp.Value = Format(CDate(wakeUpTime), "hh:mm AM/PM")
            Else
                Debug.Print "Invalid Wake Up Time: " & wakeUpTime
                .txtWakeUp.Value = ""  ' Leave blank if invalid
            End If
    
            ' Handle Jogging Total Time (Column 4)
            Dim joggingTime As Variant
            joggingTime = .lstDatabase.List(selectedRow - 1, 4)
    
            If IsNumeric(joggingTime) Then
            ' Convert the numeric time to hours, minutes, and seconds
            Dim hours As Long, minutes As Long, seconds As Long
            hours = Int(joggingTime * 24)
            minutes = Int((joggingTime * 1440) Mod 60)
            seconds = Int((joggingTime * 86400) Mod 60)
        
            ' Format time as hh:mm:ss
            .txtjogTata.Value = Format(TimeSerial(hours, minutes, seconds), "hh:mm:ss")
        Else
            Debug.Print "Invalid Jogging Time: " & joggingTime
            .txtjogTata.Value = ""  ' Leave blank if invalid
        End If
    
    
            ' Handle Jogging Rounds (Column 5)
            Dim jogRounds As Variant
            jogRounds = .lstDatabase.List(selectedRow - 1, 5)
            If IsNumeric(jogRounds) Then
                .txtjogRound.Value = jogRounds
            Else
                Debug.Print "Invalid Jogging Rounds: " & jogRounds
                .txtjogRound.Value = ""
            End If
    
            ' Handle Title (Column 3)
            Dim title As Variant
            title = .lstDatabase.List(selectedRow - 1, 3)
            If Not IsError(title) Then
                .titleOf.Value = title
            Else
                Debug.Print "Invalid Title: " & title
                .titleOf.Value = ""
            End If
    
            ' Handle Exercise Status (Column 6)
            Dim exerciseStatus As Variant
            exerciseStatus = .lstDatabase.List(selectedRow - 1, 6)
            If exerciseStatus = "Yes" Then
                .optYesE.Value = True
            ElseIf exerciseStatus = "No" Then
                .optNoE.Value = True
            Else
                Debug.Print "Invalid Exercise Status: " & exerciseStatus
            End If
    
            ' Handle Meditation Status (Column 7)
            Dim meditationStatus As Variant
            meditationStatus = .lstDatabase.List(selectedRow - 1, 7)
            If meditationStatus = "Yes" Then
                .optYesM.Value = True
            ElseIf meditationStatus = "No" Then
                .optNoM.Value = True
            Else
                Debug.Print "Invalid Meditation Status: " & meditationStatus
            End If
    
            ' Handle Image Path (Column 8)
            Dim imgPath As Variant
            imgPath = .lstDatabase.List(selectedRow - 1, 8)

            ' Ensure imgPath is a string before proceeding
            If Not IsEmpty(imgPath) And VarType(imgPath) = vbString Then
                If Len(Dir(CStr(imgPath))) > 0 Then
                ' If the image exists, load it
                .imgStudent.Picture = LoadPicture(CStr(imgPath))
            Else
                ' Image path not found, show message
                MsgBox "Image not found at the specified path: " & vbCrLf & imgPath, vbExclamation, "Image Not Found"
                Debug.Print "Invalid Image Path: " & imgPath
                ' Clear the image control by setting it to Nothing (no image)
                Set .imgStudent.Picture = Nothing
            End If
            Else
            ' If imgPath is invalid (empty or non-string), show message
                MsgBox "No image path available or invalid image path.", vbExclamation, "Error"
                ' Clear the image control by setting it to Nothing (no image)
                Set .imgStudent.Picture = Nothing
            End If

            ' Set the image path value in the text box
            .txtImagePath.Value = CStr(imgPath)
    
            ' Handle Journal Entry (Column 9)
            Dim journalEntry As Variant
            journalEntry = .lstDatabase.List(selectedRow - 1, 9)
            If Not IsError(journalEntry) Then
                .txtAddress.Value = journalEntry
            Else
                Debug.Print "Invalid Journal Entry: " & journalEntry
                .txtAddress.Value = ""
            End If
        End With
        Exit Sub
        
ErrorHandler:
        MsgBox "Error loading data: " & Err.Description & vbCrLf & "Check the Debug Window for details.", vbCritical, "Error"
        Debug.Print "Error Description: " & Err.Description
        Debug.Print "Error Source: " & Err.Source
        Resume Next
    End Sub

Sub UpdateDataInListBox(selectedRow As Long)
    On Error GoTo ErrorHandler

    ' Ensure row is selected
    If selectedRow = 0 Then
        MsgBox "No row selected.", vbExclamation, "Update Error"
        Exit Sub
    End If

    ' Update ListBox with new data from form
    With frmDataEntry
        frmDataEntry.lstDatabase.List(selectedRow - 1, 1) = .titleOf.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 3) = .txtDOB.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 4) = .txtWakeUp.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 5) = .txtjogTata.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 6) = .txtjogRound.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 7) = IIf(.optYesM.Value, "Yes", "No")
        frmDataEntry.lstDatabase.List(selectedRow - 1, 9) = .txtAddress.Value
        frmDataEntry.lstDatabase.List(selectedRow - 1, 10) = .txtImagePath.Value
    End With

    ' Now check if the image exists after the data is updated
    Dim imgPath As String
    imgPath = frmDataEntry.txtImagePath.Value

    ' Check if the image exists at the specified path
    If Len(Dir(imgPath)) > 0 Then
        MsgBox "Image exists at the specified path: " & vbCrLf & imgPath, vbInformation, "Image Exists"
    Else
        MsgBox "Image not found at the specified path: " & vbCrLf & imgPath, vbExclamation, "Image Not Found"
    End If

    MsgBox "Data updated successfully.", vbInformation, "Update Success"
    Exit Sub

ErrorHandler:
    MsgBox "Error updating data.", vbCritical, "Update Error"
End Sub
