Module GlobalFormValidation
    Function FormIsNumeric(view As Object, a As Object) As Boolean

        If IsNumeric(view.text) Then
            FormIsNumeric = True
        Else
            MsgBox("Field " & a & " harus berupa angka")
            view.Focus()
            FormIsNumeric = False
        End If

        Console.WriteLine("form is numeric : " & a & FormIsNumeric)
    End Function

    Function FormIsNull(view As Object, a As Object) As Boolean
        If Not view.text = "" Then
            FormIsNull = True
        Else
            MsgBox("Field " & a & " tidak boleh kosong")
            view.Focus()
            FormIsNull = False
        End If

        Console.WriteLine("form id null : " & a & FormIsNull)
    End Function

    Function costumFormMin(view As Object, min As Integer, a As Object) As Boolean
        If Not Integer.Parse(view.text) < min Then
            costumFormMin = True
        Else
            MsgBox("Field " & a & " mininal " & min)
            view.Focus()
            costumFormMin = False
        End If

        Console.WriteLine("form id min : " & a & costumFormMin)
    End Function
End Module
