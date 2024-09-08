VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} frmResolve 
   Caption         =   "Resolve Complaint"
   ClientHeight    =   4440
   ClientLeft      =   110
   ClientTop       =   460
   ClientWidth     =   8880.001
   OleObjectBlob   =   "frmResolve.frx":0000
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "frmResolve"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdSubmit_Click()
    
    
    Dim msgResult As VbMsgBoxResult
    
    msgResult = MsgBox("Do you want to submit the data?", vbYesNo + vbQuestion, "Resolve complaint")
    
    If msgResult = vbNo Then Exit Sub
    
    If Me.txtSummary.Value = "" Then
    
        Me.txtSummary.SetFocus
        Me.txtSummary.BackColor = vbRed
        
        MsgBox "Summary field is blank.", vbOKOnly + vbInformation, "Submit"
        
        Exit Sub
    
    End If
    
    Dim iRow As Long
    Dim sh As Worksheet
    Dim lstRow As Long
    
    Me.txtSummary.BackColor = vbWhite
    
    Set sh = ThisWorkbook.Sheets("Resolved_Complaints")
    
    iRow = sh.Range("A" & Rows.Count).End(xlUp).Row + 1
    
    With frmComplaint.lstPendingComplaints
    
    
        lstRow = .ListIndex
        
        sh.Range("A" & iRow).Value = Format(.List(lstRow, 0), "dd-mmm-yyyy")
        sh.Range("B" & iRow).Value = .List(lstRow, 1)
        sh.Range("C" & iRow).Value = .List(lstRow, 2)
        sh.Range("D" & iRow).Value = .List(lstRow, 3)
        sh.Range("E" & iRow).Value = .List(lstRow, 4)
        sh.Range("F" & iRow).Value = .List(lstRow, 5)
        sh.Range("G" & iRow).Value = .List(lstRow, 6)
        sh.Range("H" & iRow).Value = .List(lstRow, 7)
        sh.Range("I" & iRow).Value = .List(lstRow, 8)
        
        sh.Range("J" & iRow).Value = frmResolve.txtSummary.Value
        sh.Range("K" & iRow).Value = frmResolve.txtEmpName.Value
        sh.Range("L" & iRow).Value = frmResolve.txtDate.Value
        
    
    End With
    
    
    ThisWorkbook.Sheets("Pending_Complaints").Rows(lstRow + 2).EntireRow.Delete
    
    Call Initialize_PendingComplaint
    
    Unload Me
    
    
End Sub
