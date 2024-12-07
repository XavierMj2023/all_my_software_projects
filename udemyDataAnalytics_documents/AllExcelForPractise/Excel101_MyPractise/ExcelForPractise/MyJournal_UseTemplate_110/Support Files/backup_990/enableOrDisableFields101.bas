Attribute VB_Name = "enableOrDisableFields"
Sub EnableFormFields(enableFields As Boolean)
    ' Enable or disable form fields based on the parameter
    With frmDataEntry
        .txtDOB.Enabled = enableFields
        .txtWakeUp.Enabled = enableFields
        .titleOf.Enabled = enableFields
        .txtAddress.Enabled = enableFields
        ' Add other fields as needed
    End With
End Sub
