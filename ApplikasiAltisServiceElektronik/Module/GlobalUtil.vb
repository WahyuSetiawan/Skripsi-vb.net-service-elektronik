Module GlobalUtil
    Sub readOnlyAllTextBox(form As Form)
        For Each myTxtBox As TextBox In form.Controls.OfType(Of TextBox)
            myTxtBox.ReadOnly = True
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each myTxtBox As TextBox In group.Controls.OfType(Of TextBox)
                myTxtBox.ReadOnly = True
            Next
        Next
    End Sub

    Sub disableAllButton(form As Form)
        For Each myBtn As Button In form.Controls.OfType(Of Button)
            myBtn.Enabled = False
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each myBtn As Button In group.Controls.OfType(Of Button)
                myBtn.Enabled = False
            Next
        Next
    End Sub

    Sub enableAllTextBox(form As Form)
        For Each myTxtBox As TextBox In form.Controls.OfType(Of TextBox)
            myTxtBox.ReadOnly = False
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each myTxtBox As TextBox In group.Controls.OfType(Of TextBox)
                myTxtBox.ReadOnly = False
            Next
        Next
    End Sub

    Sub enableAllButton(form As Form)
        For Each myBtn As Button In form.Controls.OfType(Of Button)
            myBtn.Enabled = True
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each myBtn As Button In group.Controls.OfType(Of Button)
                myBtn.Enabled = True
            Next
        Next
    End Sub

    Sub disableAllCMB(form As Form)
        For Each control As ComboBox In form.Controls.OfType(Of ComboBox)
            control.Enabled = False
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each control As ComboBox In group.Controls.OfType(Of ComboBox)
                control.Enabled = False
            Next
        Next
    End Sub


    Sub enableAllCMB(form As Form)
        For Each control As ComboBox In form.Controls.OfType(Of ComboBox)
            control.Enabled = True
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each control As ComboBox In group.Controls.OfType(Of ComboBox)
                control.Enabled = True
            Next
        Next
    End Sub

    Sub disableAllList(form As Form)
        For Each control As ListView In form.Controls.OfType(Of ListView)
            control.Enabled = False
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each control As ListView In group.Controls.OfType(Of ListView)
                control.Enabled = False
            Next
        Next
    End Sub


    Sub enableAllList(form As Form)
        For Each control As ListView In form.Controls.OfType(Of ListView)
            control.Enabled = True
        Next

        For Each group As GroupBox In form.Controls.OfType(Of GroupBox)
            For Each control As ListView In group.Controls.OfType(Of ListView)
                control.Enabled = True
            Next
        Next
    End Sub
End Module
