Attribute VB_Name = "fontForEmojis"
Sub SetFontForEmojis()
    Dim wsData As Worksheet
    Set wsData = ThisWorkbook.Sheets("ForDropdownData")
    
    ' Set font for the entire column or range containing emojis
    wsData.Columns("A:A").Font.Name = "Segoe UI Emoji"
End Sub

