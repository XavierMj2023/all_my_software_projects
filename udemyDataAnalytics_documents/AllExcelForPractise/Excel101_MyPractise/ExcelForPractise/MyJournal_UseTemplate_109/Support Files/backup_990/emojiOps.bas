Attribute VB_Name = "emojiOps"
Sub AddEmojisAndDropdown()
    Dim wsData As Worksheet
    Dim wsTarget As Worksheet
    Dim emojiRange As Range
    Dim targetCell As Range
    Dim emojis As Variant
    Dim i As Long

    ' Define emojis to be added
    emojis = Array("?? Happy", "?? Too Happy", "?? Sad", "?? Too Sad", "?? Frustrated", "?? Bored", "?? Excited", "?? Calm", "?? Sleepy")

    ' Set worksheets
    Set wsData = ThisWorkbook.Sheets("ForDropdownData")
    Set wsTarget = ThisWorkbook.ActiveSheet ' Or specify your target sheet

    ' Add heading if it doesn't exist
    If wsData.Cells(1, 1).Value <> "Emojis" Then
        wsData.Cells(1, 1).Value = "Emojis"
    End If

    ' Clear existing emojis below the heading
    wsData.Range("A2:A" & wsData.Rows.Count).ClearContents

    ' Add emojis to the sheet
    For i = LBound(emojis) To UBound(emojis)
        wsData.Cells(i + 2, 1).Value = emojis(i)
    Next i

    ' Set font to Segoe UI Emoji for proper emoji rendering
    wsData.Columns("A:A").Font.Name = "Segoe UI Emoji"

    ' Define range of emojis
    Set emojiRange = wsData.Range("A2:A" & wsData.Cells(wsData.Rows.Count, "A").End(xlUp).row)

    ' Define the cell for the dropdown
    Set targetCell = wsTarget.Range("B2") ' Change B2 to your target cell

    ' Add Data Validation for dropdown
    With targetCell.Validation
        .Delete ' Clear existing validation
        .Add Type:=xlValidateList, AlertStyle:=xlValidAlertStop, Operator:=xlBetween, Formula1:="='" & wsData.Name & "'!" & emojiRange.Address
        .IgnoreBlank = True
        .InCellDropdown = True
        .ShowInput = True
        .ShowError = True
    End With

    MsgBox "Emojis added to the sheet and dropdown created successfully!", vbInformation, "Success"
End Sub

