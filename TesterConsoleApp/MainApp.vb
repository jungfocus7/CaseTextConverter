Imports System
Imports System.Collections.Generic
Imports System.Text



Public NotInheritable Class MainApp
    Private Sub New()
    End Sub


    Public Shared Sub Main(args() As String)
        Dim tb01 As Boolean = String.IsNullOrEmpty(" ")
        Dim tb02 As Boolean = String.IsNullOrEmpty(vbNewLine)
        Dim tb03 As Boolean = String.IsNullOrEmpty(vbCr)
        Dim tb04 As Boolean = String.IsNullOrEmpty(vbCrLf)
        Dim tb05 As Boolean = String.IsNullOrEmpty(vbNullChar)
        Dim tb06 As Boolean = String.IsNullOrEmpty(vbNullString)
        Dim tb07 As Boolean = False
        Dim ts01 As String = vbNullChar

        Dim tb11 As Boolean = String.IsNullOrWhiteSpace(" ")
        Dim tb12 As Boolean = String.IsNullOrWhiteSpace(vbNewLine)
        Dim tb13 As Boolean = String.IsNullOrWhiteSpace(vbCr)
        Dim tb14 As Boolean = String.IsNullOrWhiteSpace(vbCrLf)
        Dim tb15 As Boolean = String.IsNullOrWhiteSpace(vbNullChar)
        Dim tb16 As Boolean = String.IsNullOrWhiteSpace(vbNullString)
        Dim tb17 As Boolean = True

        'Console.WriteLine("~~~~~")

        'Dim txx As String = "getNaverWavveCenterCaseTextConverter"
        'Dim tpxgx As Char = "|"c

        'Dim tsb As New StringBuilder()
        'Dim bFirst As Boolean = True
        'For Each tx As Char In txx
        '    If bFirst Then
        '        tsb.Append(tx)
        '        bFirst = False
        '    Else
        '        If Char.IsUpper(tx) Then
        '            tsb.Append(tpxgx)
        '            tsb.Append(tx)
        '        Else
        '            tsb.Append(tx)
        '        End If
        '    End If
        'Next

        'Dim wds As String = tsb.ToString()

        'Dim txa() As String = wds.Split({tpxgx}, StringSplitOptions.RemoveEmptyEntries)


        'Dim txa1() As String = GetWordsExtract("getNaverWavveCenterCaseTextConverter", pxg1)
        'Dim txa2() As String = GetWordsExtract("GET_NAVER_WAVVE_CENTER_CASE_TEXT_CONVERTER", pxg2)
        'Dim txa3() As String = GetWordsExtract("GET-NAVER-WAVVE-CENTER-CASE-TEXT-CONVERTER", pxg3)
    End Sub



    'Public Shared pxg1 As Char = "|"c
    'Public Shared pxg2 As Char = "_"c
    'Public Shared pxg3 As Char = "-"c

    'Public Shared Function GetWordsExtract(wdas As String, pxg As Char) As String()
    '    If String.IsNullOrWhiteSpace(wdas) Then
    '        Return Nothing
    '    Else
    '        If pxg = pxg1 Then
    '            Dim tsb As New StringBuilder()
    '            Dim bFirst As Boolean = True
    '            For Each tx As Char In wdas
    '                If bFirst Then
    '                    tsb.Append(tx)
    '                    bFirst = False
    '                Else
    '                    If Char.IsUpper(tx) Then
    '                        tsb.Append(pxg)
    '                        tsb.Append(tx)
    '                    Else
    '                        tsb.Append(tx)
    '                    End If
    '                End If
    '            Next
    '            If tsb.Length > 0 Then
    '                Dim wds As String = tsb.ToString()
    '                Dim txa() As String = wds.Split({pxg}, StringSplitOptions.RemoveEmptyEntries)
    '                Return txa
    '            Else
    '                Return Nothing
    '            End If
    '        Else
    '            Dim wds As String = wdas
    '            Dim txa() As String = wds.Split({pxg}, StringSplitOptions.RemoveEmptyEntries)
    '            Return txa
    '        End If
    '    End If
    'End Function


End Class
