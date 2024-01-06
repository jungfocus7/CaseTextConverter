Imports System
Imports System.Text



''' <summary>
''' 케이스 문자열 변환기 (스네이크케이스, 파스칼케이스, 카멜케이스)
''' 2017/09/12 (heebumjung)
''' </summary>
Public NotInheritable Class CaseConverter
    Private Sub New()
    End Sub


    'Public Shared Function ConvertSnakeCase(wd As String) As String
    '    If String.IsNullOrWhiteSpace(wd) Then
    '        Return String.Empty
    '    Else
    '        Dim tca() As Char = wd.ToCharArray()
    '        For i As Integer = 0 To tca.Length - 1
    '            Dim tc As Char = tca(i)
    '            If i = 0 Then
    '                tc = Char.ToUpper(tc)
    '            Else
    '                tc = Char.ToLower(tc)
    '            End If
    '            tca(i) = tc
    '        Next
    '        Dim rs As String = Convert.ToString(tca)
    '        Return rs
    '    End If
    'End Function


    Public Shared Function ConvertPascalCase(wd As String) As String
        If String.IsNullOrWhiteSpace(wd) Then
            Return String.Empty
        Else
            Dim tca() As Char = wd.ToCharArray()
            For i As Integer = 0 To tca.Length - 1
                Dim tc As Char = tca(i)
                If i = 0 Then
                    tc = Char.ToUpper(tc)
                Else
                    tc = Char.ToLower(tc)
                End If
                tca(i) = tc
            Next
            Dim rs As String = Convert.ToString(tca)
            Return rs
        End If
    End Function


    Public Shared Function GetWordsExtract(ls As String, dm As String) As String()
        If String.IsNullOrWhiteSpace(ls) Then
            Return Nothing
        Else
            If Not String.IsNullOrWhiteSpace(dm) Then
                Dim rva() As String = ls.Split(
                    {dm}, StringSplitOptions.RemoveEmptyEntries)
                Return rva
            Else
                Const dxc As Char = "|"c
                Dim tsb As New StringBuilder()
                Dim bFirst As Boolean = True
                For Each tc As Char In ls
                    If bFirst Then
                        tsb.Append(tc)
                        bFirst = False
                    Else
                        If Char.IsUpper(tc) Then
                            tsb.Append(dxc)
                            tsb.Append(tc)
                        Else
                            tsb.Append(tc)
                        End If
                    End If
                Next
                If tsb.Length > 0 Then
                    Dim txb As String = tsb.ToString()
                    Dim rva() As String = txb.Split(
                        {dxc}, StringSplitOptions.RemoveEmptyEntries)
                    Return rva
                Else
                    Return Nothing
                End If
            End If
        End If
    End Function


    Public Shared Function ConvertCaseText(ls As String, dm As String, ot As String) As String
        Dim wds() As String = GetWordsExtract(ls, dm)
        If (wds Is Nothing) OrElse (wds.Length < 1) Then
            Return String.Empty
        Else
            Dim tsb As New StringBuilder()
            Dim bFirst As Boolean = True
            For Each wd As String In wds
                Select Case ot
                    Case CaseDataRoll.OutputType_SnakeUpperCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToUpper()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = CaseDataRoll.InputGubun_UnderBar & wd.ToUpper()
                            tsb.Append(ds)
                        End If
                    Case CaseDataRoll.OutputType_SnakeLowerCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToLower()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = CaseDataRoll.InputGubun_UnderBar & wd.ToUpper()
                            tsb.Append(ds)
                        End If
                    Case CaseDataRoll.OutputType_PascalCase
                        Dim ds As String = ConvertPascalCase(wd)
                        tsb.Append(ds)
                    Case CaseDataRoll.OutputType_CamelCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToLower()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = ConvertPascalCase(wd)
                            tsb.Append(ds)
                        End If
                End Select
            Next
            Return tsb.ToString()
        End If
    End Function



    'Public Shared Dm1 As Char = "|"c
    'Public Shared Dm2 As Char = "_"c
    'Public Shared Dm3 As Char = "-"c

    'Public Shared Function GetWordsExtract(wds As String, dm As Char) As String()
    '    If String.IsNullOrWhiteSpace(wds) Then
    '        Return Nothing
    '    Else
    '        If dm = Dm1 Then
    '            Dim tsb As New StringBuilder()
    '            Dim bFirst As Boolean = True
    '            For Each wd As Char In wds
    '                If bFirst Then
    '                    tsb.Append(wd)
    '                    bFirst = False
    '                Else
    '                    If Char.IsUpper(wd) Then
    '                        tsb.Append(dm)
    '                        tsb.Append(wd)
    '                    Else
    '                        tsb.Append(wd)
    '                    End If
    '                End If
    '            Next
    '            If tsb.Length > 0 Then
    '                Dim txb As String = tsb.ToString()
    '                Dim rxa() As String = txb.Split({dm}, StringSplitOptions.RemoveEmptyEntries)
    '                Return rxa
    '            Else
    '                Return Nothing
    '            End If
    '        Else
    '            Dim txb As String = wds
    '            Dim rxa() As String = txb.Split({dm}, StringSplitOptions.RemoveEmptyEntries)
    '            Return rxa
    '        End If
    '    End If
    'End Function


    'Public Shared Function ConvertCaseText(wds As String, ckndIn As EnCknd, ckndOut As EnCknd, tdm As Char) As String
    '    If String.IsNullOrWhiteSpace(wds) Then
    '        Return String.Empty
    '    Else
    '        Dim dmi As Char
    '        If ckndIn = EnCknd.SnakeCase Then
    '            dmi = tdm
    '        Else
    '            dmi = Dm1
    '        End If
    '        Dim txa() As String = GetWordsExtract(wds, dmi)
    '        If txa.Length > 0 Then
    '            Dim tsb As New StringBuilder()
    '            For i As Integer = 0 To txa.Length - 1
    '                Dim tx As String = txa(i)
    '                Dim ty As String = String.Empty
    '                If ckndOut = EnCknd.SnakeCase Then
    '                    If i = 0 Then
    '                        ty = tx.ToUpper()
    '                    Else
    '                        ty = tdm & tx.ToUpper()
    '                    End If
    '                ElseIf ckndOut = EnCknd.PascalCase Then
    '                    ty = ConvertPascalCase(tx)
    '                ElseIf ckndOut = EnCknd.CamelCase Then
    '                    If i = 0 Then
    '                        ty = tx.ToLower()
    '                    Else
    '                        ty = ConvertPascalCase(tx)
    '                    End If
    '                End If
    '                tsb.Append(ty)
    '            Next
    '            Return tsb.ToString()
    '        Else
    '            Return String.Empty
    '        End If
    '    End If
    'End Function

End Class
