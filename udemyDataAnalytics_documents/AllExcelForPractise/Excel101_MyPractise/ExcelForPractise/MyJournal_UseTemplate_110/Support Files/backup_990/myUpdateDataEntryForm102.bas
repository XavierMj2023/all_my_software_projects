Attribute VB_Name = "myUpdateDataEntryForm"
Dim selectedRow As Long
Dim selectedID As String

' Function to retrieve the selected row number from the ListBox
Function GetSelectedRow() As Long
    Dim i As Long
    For i = 0 To frmDataEntry.lstDatabase.ListCount - 1
        If frmDataEntry.lstDatabase.Selected(i) Then
            GetSelectedRow = i + 1  ' Return 1-based index
            Exit Function
        End If
    Next i
    GetSelectedRow = 0 ' Return 0 if no row is selected
End Function

' Subroutine to load data from the selected row into the form fields
Sub LoadSelectedRowData(selectedRow As Long)
    On Error GoTo ErrorHandler

    ' Ensure the row is within bounds
    If selectedRow <= 0 Or selectedRow > frmDataEntry.lstDatabase.ListCount Then
        MsgBox "Invalid row selected. Please select a valid row.", vbExclamation, "Error"
        Exit Sub
    End If

    ' Clear form fields
    ClearFormFields

    ' Load data into form fields
    With frmDataEntry
    
        ' Date of Birth (Column 1)
        Dim entryDate As Variant
        entryDate = .lstDatabase.List(selectedRow - 1, 1)
        If IsNumeric(entryDate) Or IsDate(entryDate) Then
            .txtDOB.Value = Format(CDate(entryDate), "dd-mmm-yyyy")
        Else
            Debug.Print "Invalid Date: " & entryDate
            .txtDOB.Value = ""  ' Leave blank if invalid
        End If

        ' Wake Up Time (Column 2)
        Dim wakeUpTime As Variant
        wakeUpTime = .lstDatabase.List(selectedRow - 1, 2)
        If IsNumeric(wakeUpTime) Or IsDate(wakeUpTime) Then
            .txtWakeUp.Value = Format(CDate(wakeUpTime), "hh:mm AM/PM")
        Else
            Debug.Print "Invalid Wake Up Time: " & wakeUpTime
            .txtWakeUp.Value = ""  ' Leave blank if invalid
        End If

        ' Jogging Total Time (Column 4)
        Dim joggingTime As Variant
        joggingTime = .lstDatabase.List(selectedRow - 1, 4)
        If IsNumeric(joggingTime) Then
            Dim hours As Long, minutes As Long, seconds As Long
            hours = Int(joggingTime * 24)
            minutes = Int((joggingTime * 1440) Mod 60)
            seconds = Int((joggingTime * 86400) Mod 60)
            .txtjogTata.Value = Format(TimeSerial(hours, minutes, seconds), "hh:mm:ss")
        Else
            Debug.Print "Invalid Jogging Time: " & joggingTime
            .txtjogTata.Value = ""
        End If

        ' Jogging Rounds (Column 5)
        Dim jogRounds As Variant
        jogRounds = .lstDatabase.List(selectedRow - 1, 5)
        If IsNumeric(jogRounds) Then
            .txtjogRound.Value = jogRounds
        Else
            Debug.Print "Invalid Jogging Rounds: " & jogRounds
            .txtjogRound.Value = ""
        End If

        ' Title (Column 3)
        Dim title As Variant
        title = .lstDatabase.List(selectedRow - 1, 3)
        .titleOf.Value = IIf(Not IsError(title), title, "")
        
        ' Exercise Status (Column 6)
        Dim exerciseStatus As Variant
        exerciseStatus = .lstDatabase.List(selectedRow - 1, 6)
        .optYesE.Value = (exerciseStatus = "Yes")
        .optNoE.Value = (exerciseStatus = "No")
        
        ' Meditation Status (Column 7)
        Dim meditationStatus As Variant
        meditationStatus = .lstDatabase.List(selectedRow - 1, 7)
        .optYesM.Value = (meditationStatus = "Yes")
        .optNoM.Value = (meditationStatus = "No")

        ' Mood (Column 8)
        Dim mood As Variant
        mood = .lstDatabase.List(selectedRow - 1, 8)
        .cmbMood.Value = IIf(Not IsError(mood), mood, "")
        
        ' Thankful For (Column 9)
        Dim thankfulFor As Variant
        thankfulFor = .lstDatabase.List(selectedRow - 1, 9)
        .txtThankfulFor.Value = IIf(Not IsError(thankfulFor), thankfulFor, "")
    
        ' Journal Entry (Column 10)
        Dim journalEntry As Variant
        journalEntry = .lstDatabase.List(selectedRow - 1, 10)
        .txtAddress.Value = IIf(Not IsError(journalEntry), journalEntry, "")
    End With

    Exit Sub

ErrorHandler:
    MsgBox "Error loading data: " & Err.Description & vbCrLf & "Check the Debug Window for details.", vbCritical, "Error"
    Debug.Print "Error Description: " & Err.Description
    Debug.Print "Error Source: " & Err.Source
    Resume Next
End Sub

' Subroutine to handle Edit action
Sub Handle_Edit()
    On Error GoTo ErrorHandler

    ' Get the selected row from the ListBox
    selectedRow = GetSelectedRow()

    ' Check if a row is selected
    If selectedRow = 0 Then
        MsgBox "No row is selected. Please select a valid row.", vbOKOnly + vbInformation, "Edit"
        Exit Sub
    End If

    ' Fetch and load data from the selected row into form fields
    selectedID = frmDataEntry.lstDatabase.List(selectedRow - 1, 0)
    frmDataEntry.txtGeneratedId.Value = selectedID
    Call LoadSelectedRowData(selectedRow)
    
    ' Change the Submit button caption to "Update"
    frmDataEntry.cmdSubmit.Caption = "Update"

    Exit Sub

ErrorHandler:
    MsgBox "Error updating data: " & Err.Description, vbCritical, "Edit Error"
    Debug.Print "Error " & Err.Number & ": " & Err.Description
    Resume Next
End Sub

Sub Edit_And_Update_Data()
    On Error GoTo ErrorHandler

    ' Check if a row is selected
    If selectedRow <= 0 Then
        MsgBox "Please select a row to edit.", vbExclamation, "No Row Selected"
        Exit Sub
    End If

    Dim frm As Object
    Set frm = frmDataEntry  ' Reference to the form object

    ' Validate the selected row is not empty
    If IsEmpty(selectedRow) Or selectedRow < 1 Then
        MsgBox "Invalid selected row.", vbExclamation, "Error"
        Exit Sub
    End If

    ' Update each column in the selected row with the form field values
    With frm
        .lstDatabase.List(selectedRow - 1, 1) = .txtWakeUp.Value   ' Column 2: Wake Up Time
        .lstDatabase.List(selectedRow - 1, 2) = .txtDOB.Value    ' Column 3: Date of Entry
        .lstDatabase.List(selectedRow - 1, 3) = .txtjogRound.Value  ' Column 4: Jogging Rounds
        .lstDatabase.List(selectedRow - 1, 4) = .txtjogTata.Value  ' Column 5: Jogging Total Time
        .lstDatabase.List(selectedRow - 1, 5) = .titleOf.Value   ' Column 6: Title
        .lstDatabase.List(selectedRow - 1, 6) = IIf(.optYesE.Value, "Yes", "No")  ' Column 7: Exercise Status
        .lstDatabase.List(selectedRow - 1, 7) = IIf(.optYesM.Value, "Yes", "No")  ' Column 8: Meditation Status
        .lstDatabase.List(selectedRow - 1, 8) = .cmbMood.Value  ' Column 9: Mood
        .lstDatabase.List(selectedRow - 1, 9) = .txtThankfulFor.Value  ' Column 10: Thankful For
        .lstDatabase.List(selectedRow - 1, 10) = .txtAddress.Value  ' Column 11: Journal Entry
    End With

    ' Validate the updated data
    If Not ValidEntry() Then
        Exit Sub
    End If

    ' If validation passes, show success message
    MsgBox "Data updated successfully.", vbInformation, "Update Success"
    
    Call Reset_Form
    
    Exit Sub

ErrorHandler:
    ' Enhanced error handling to provide more details
    Dim errMsg As String
    errMsg = "Error updating data." & vbCrLf & "Error Number: " & Err.Number & vbCrLf & "Description: " & Err.Description
    MsgBox errMsg, vbCritical, "Update Error"
End Sub
