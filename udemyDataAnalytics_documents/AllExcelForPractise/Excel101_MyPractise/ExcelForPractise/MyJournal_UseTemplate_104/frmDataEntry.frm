VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} frmDataEntry 
   Caption         =   "My Journal"
   ClientHeight    =   9090.001
   ClientLeft      =   120
   ClientTop       =   470
   ClientWidth     =   12140
   OleObjectBlob   =   "frmDataEntry.frx":0000
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "frmDataEntry"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdPrint_Click()
     Call PrintToPDF(Me)
End Sub

Private Sub cmdSubmit_Click()
    Call Submit_Data(Me)
End Sub

Private Sub UserForm_Initialize()
    ' Initialize form controls
    Call Journal_ResetForm.ResetForm(Me)
    
    ' Apply Palatino Linotype font to all controls
    Call ApplyPalatinoLinotype(Me)
End Sub
Private Sub cmdDelete_Click()
    Call DeleteSelectedRow(Me)
End Sub

Private Sub cmdEdit_Click()
    Call EditSelectedRow(Me)
End Sub
Private Sub cmdReset_Click()
    Call ResetForm(Me)
End Sub
