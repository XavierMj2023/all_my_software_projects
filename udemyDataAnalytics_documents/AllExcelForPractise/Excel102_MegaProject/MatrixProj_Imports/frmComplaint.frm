VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} frmComplaint 
   Caption         =   "Complaint Management System"
   ClientHeight    =   6830
   ClientLeft      =   110
   ClientTop       =   460
   ClientWidth     =   11900
   OleObjectBlob   =   "frmComplaint.frx":0000
   ShowModal       =   0   'False
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "frmComplaint"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cmdReset_Click()
    
    Dim i As VbMsgBoxResult
    
    i = MsgBox("Do you want to reset the form?", vbYesNo + vbQuestion, "Reset")
    
    If i = vbNo Then Exit Sub
    
    Call Initialize_PendingComplaint
    
    
End Sub

Private Sub cmdSubmit_Click()
    
    Dim i As VbMsgBoxResult
    
    i = MsgBox("Do you want to submit the data?", vbYesNo + vbQuestion, "Submit")
    
    If i = vbNo Then Exit Sub
    
    
    If ValidatePending = False Then Exit Sub
    
    Dim sh As Worksheet
    
    Dim iRow As Long
    
    Set sh = ThisWorkbook.Sheets("Pending_Complaints")
    
    iRow = sh.Range("A" & Rows.Count).End(xlUp).Row + 1
    
    With frmComplaint
    
        sh.Range("A" & iRow).Value = .txtDate.Value
        sh.Range("B" & iRow).Value = .txtEmpName.Value
        sh.Range("C" & iRow).Value = .txtCustName.Value
        sh.Range("D" & iRow).Value = .txtEmail.Value
        sh.Range("E" & iRow).Value = .cmbCountry.Value
        sh.Range("F" & iRow).Value = .cmbReason.Value
        sh.Range("G" & iRow).Value = .cmbPriority.Value
        sh.Range("H" & iRow).Value = IIf(.chkVIP.Value, "Yes", "No")
        sh.Range("I" & iRow).Value = .txtDescription.Value
    
    End With
    
    Call Initialize_PendingComplaint
    
    
End Sub




Private Sub lstPendingComplaints_DblClick(ByVal Cancel As MSForms.ReturnBoolean)


    If Me.lstPendingComplaints.List(Me.lstPendingComplaints.ListIndex, 0) = "" Then Exit Sub
    
    Load frmResolve
    
    With frmResolve
    
        .txtDate.Value = [text(Today(), "DD-MMM-YYYY")]
        .txtDate.Enabled = False
        
        .txtEmpName.Value = Environ("username")
        .txtEmpName.Enabled = False
        
        .txtCustName.Value = Me.lstPendingComplaints.List(Me.lstPendingComplaints.ListIndex, 2)
        
        .txtCustName.Enabled = False
        
        .txtCustEmail.Value = Me.lstPendingComplaints.List(Me.lstPendingComplaints.ListIndex, 3)
        
        .txtCustEmail.Enabled = False
        
        .txtSummary.Value = ""
        
        .Show
    
    
    End With
    


End Sub

Private Sub MultiPage_Change()

    Dim i As Long, j As Long, k As Long
    
    If MultiPage.Value = 0 Then
    
        i = [Countif(Pending_Complaints!G:G, "High")]
        j = [Countif(Pending_Complaints!G:G, "Medium")]
        k = [Countif(Pending_Complaints!G:G, "Low")]
        
        With frmComplaint
        
            .frmSummary.Caption = "Pending Complaints Summary"
            .LblHigh.Caption = i
            .lblMedium.Caption = j
            .lblLow.Caption = k
            .lblOverall.Caption = i + j + k
            
        End With
    
    Else
    
        i = [Countif(Resolved_Complaints!G:G, "High")]
        j = [Countif(Resolved_Complaints!G:G, "Medium")]
        k = [Countif(Resolved_Complaints!G:G, "Low")]
        
        With frmComplaint
        
            .frmSummary.Caption = "Resoled Complaints Summary"
            .LblHigh.Caption = i
            .lblMedium.Caption = j
            .lblLow.Caption = k
            .lblOverall.Caption = i + j + k
            
        End With
    
    End If

End Sub

Private Sub UserForm_Initialize()

  Call Initialize_PendingComplaint

End Sub



