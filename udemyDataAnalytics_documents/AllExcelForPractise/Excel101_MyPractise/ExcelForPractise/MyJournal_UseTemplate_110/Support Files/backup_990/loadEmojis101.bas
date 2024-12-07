Attribute VB_Name = "loadEmojis"
Sub LoadEmojisToSheet()
    Dim ws As Worksheet
    Dim rng As Range
    Dim emojis As Variant
    Dim i As Long

    ' Set the worksheet
    Set ws = ThisWorkbook.Sheets("ForDropdownData")
    
    ' Define the range where emojis are stored (e.g., A2:A100)
    Set rng = ws.Range("A2:A100") ' Adjust the range as needed

    ' Clear existing data in the range to prevent duplicates
    rng.ClearContents
    
    ' Array of emojis to load into the sheet
    emojis = Array( _
        "??", "??", "??", "??", "??", _
        "??", "??", "??", "??", "??" _
    ) ' Example emojis

    ' Loop through the array and load each emoji into the worksheet
    For i = LBound(emojis) To UBound(emojis)
        rng.Cells(i + 1, 1).Value = emojis(i)
    Next i
    
    ' Set the font to Segoe UI Emoji or another font that supports emojis
    rng.Font.Name = "Segoe UI Emoji"
End Sub

