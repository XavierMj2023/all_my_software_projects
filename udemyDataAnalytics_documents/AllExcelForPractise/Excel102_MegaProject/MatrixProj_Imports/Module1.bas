Attribute VB_Name = "Module1"


'To apply default color white to input controls avaialble in frmComplaint

Sub DefaultColor_Pending()

    With frmComplaint
    
        .txtDate.BackColor = vbWhite
        .txtCustName.BackColor = vbWhite
        .txtEmpName.BackColor = vbWhite
        .txtEmail.BackColor = vbWhite
        .txtDescription.BackColor = vbWhite
        
        .cmbCountry.BackColor = vbWhite
        .cmbReason.BackColor = vbWhite
        .cmbPriority.BackColor = vbWhite
    
    End With

End Sub


'Code to assign dynamic rowsource reference to Pending and Completed Comlaints

Sub ListBoxReference()


    Dim iRow_Pending As Long
    Dim iRow_Resolved As Long
    
    
    iRow_Pending = ThisWorkbook.Worksheets("Pending_Complaints").Range("A" & Rows.Count).End(xlUp).Row
    
    iRow_Resolved = ThisWorkbook.Worksheets("Resolved_Complaints").Range("A" & Rows.Count).End(xlUp).Row
    
    'Setting reference to the Pending Listbox controls
    
    frmComplaint.lstPendingComplaints.ColumnCount = 9
    frmComplaint.lstPendingComplaints.ColumnHeads = True
    
    If iRow_Pending = 1 Then
    
        frmComplaint.lstPendingComplaints.RowSource = "Pending_Complaints!A2:I2"
    
    Else
        
        frmComplaint.lstPendingComplaints.RowSource = "Pending_Complaints!A2:I" & iRow_Pending
    
    End If
    
    'Setting reference to the Resolved Listbox controls
    
    frmComplaint.lstResolvedComplaints.ColumnCount = 12
    frmComplaint.lstResolvedComplaints.ColumnHeads = True
    
    If iRow_Resolved = 1 Then
    
        frmComplaint.lstResolvedComplaints.RowSource = "Resolved_Complaints!A2:L2"
    
    Else
        
        frmComplaint.lstResolvedComplaints.RowSource = "Resolved_Complaints!A2:L" & iRow_Resolved
    
    End If


End Sub


'Sub Procedure to intitialize Input controls, refresh summary and re-assign the reference to listboxes

Sub Initialize_PendingComplaint()

    With frmComplaint
        
        .txtDate.Value = [text(Today(), "DD-MMM-YYYY")]
        .txtDate.Enabled = False
        
        .txtEmpName.Value = Environ("username")
        .txtEmpName.Enabled = False
        
        .txtCustName.Value = ""
        
        .txtDescription.Value = ""
        
        .txtEmail.Value = ""
        
        'Creating a dynamic name for Country and assigning it to country combobox
        
        Sheets("Support_Data").Range("A2", Sheets("Support_Data").Range("A" & Application.Rows.Count).End(xlUp)).Name = "Country"
        
        .cmbCountry.RowSource = "Country"
        .cmbCountry.Value = ""
        
        'Creating a dynamic name for Reasong and assigning it to Reason combobox
        
        Sheets("Support_Data").Range("C2", Sheets("Support_Data").Range("C" & Application.Rows.Count).End(xlUp)).Name = "Reason"
        
        .cmbReason.RowSource = "Reason"
        .cmbReason.Value = ""
        
        'adding items to cmbPriority
        
        .cmbPriority.Clear
        
        .cmbPriority.AddItem "High"
        .cmbPriority.AddItem "Medium"
        .cmbPriority.AddItem "Low"
        
        .cmbPriority.Value = ""
        
        .chkVIP.Value = False
        
        .MultiPage.Value = 1
        .MultiPage.Value = 0
        
        'Setting the reference of listboxes
        
        Call ListBoxReference
        
        'Assigning the default colors to input controls
        
        Call DefaultColor_Pending
        
    
    End With
    

End Sub



'Function to validate inputs provided by users

Function ValidatePending() As Boolean

    
    ValidatePending = True
    
    Call DefaultColor_Pending
    
    With frmComplaint
    
        If .txtCustName.Value = "" Then
        
            MsgBox "Please enter the customer name.", vbOKOnly, "Cusomter Name"
            
            .txtCustName.SetFocus
            .txtCustName.BackColor = vbRed
            ValidatePending = False
            Exit Function
            
          ElseIf .txtEmail.Value = "" Then
        
            MsgBox "Please enter the Email ID.", vbOKOnly, "Email ID"
            
            .txtEmail.SetFocus
            .txtEmail.BackColor = vbRed
            ValidatePending = False
            Exit Function
              
           ElseIf .cmbCountry.Value = "" Then
        
            MsgBox "Please select the country name form the drop-down.", vbOKOnly, "Country"
            
            .cmbCountry.SetFocus
            .cmbCountry.BackColor = vbRed
            ValidatePending = False
            Exit Function
        
            ElseIf .cmbReason.Value = "" Then
        
            MsgBox "Please select the reason name form the drop-down.", vbOKOnly, "Reason"
            
            .cmbReason.SetFocus
            .cmbReason.BackColor = vbRed
            ValidatePending = False
            Exit Function
            
            ElseIf .cmbPriority.Value = "" Then
        
            MsgBox "Please select the complaint priority form the drop-down.", vbOKOnly, "Priority"
            
            .cmbPriority.SetFocus
            .cmbPriority.BackColor = vbRed
            ValidatePending = False
            Exit Function
            
            ElseIf .txtDescription.Value = "" Then
        
            MsgBox "Please enter complaint description", vbOKOnly, "Description"
            
            .txtDescription.SetFocus
            .txtDescription.BackColor = vbRed
            ValidatePending = False
            Exit Function
            
            End If
    
    End With


End Function


Sub Show_Form()

    ' Hide the Excel application
    Application.Visible = False
    
    ' Show the UserForm
    frmComplaint.Show

End Sub

Private Sub frmComplaint_QueryClose(Cancel As Integer, CloseMode As Integer)
    ' Make Excel visible again when the UserForm is closed
    Application.Visible = True
End Sub























































