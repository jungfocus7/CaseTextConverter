Imports System
Imports System.IO
Imports System.Text
Imports System.Xml.Serialization




''' <summary>
''' 구분자 종류
''' </summary>
Public Enum EnSpt
    Tab = 1
    NewLine = 2
    Comma = 3
End Enum



''' <summary>
''' 케이스 종류
''' </summary>
Public Enum EnCknd
    SnakeCase = 1
    PascalCase = 2
    CamelCase = 3
End Enum



''' <summary>
''' 케이스 텍스트 변환기
''' </summary>
Public NotInheritable Class CaseTextConverter__Data
    Public Shared ReadOnly Current As CaseTextConverter__Data = Load()
    Private Const _xfp As String = ".\CaseTextConverter__Data.xml"
    Public Shared Function Load() As CaseTextConverter__Data
        Dim ro As CaseTextConverter__Data = Nothing
        If File.Exists(_xfp) Then
            Using tsr As New StreamReader(_xfp, Encoding.Default)
                Try
                    Dim txs As New XmlSerializer(GetType(CaseTextConverter__Data))
                    ro = CType(txs.Deserialize(tsr), CaseTextConverter__Data)
                    Dim tit As String = ro.InputText
                    If String.IsNullOrWhiteSpace(tit) Then
                        ro.InputText = String.Empty
                    Else
                        ro.InputText = tit.Replace(vbLf, vbCrLf)
                    End If

                    Return ro
                Catch
                End Try
            End Using
        Else
            ro = New CaseTextConverter__Data With {
                .Spt = EnSpt.NewLine,
                .CkndIn = EnCknd.SnakeCase,
                .CkndOut = EnCknd.CamelCase,
                .InputText = "
normal_gatter_at_standard_edition
GATE_ON_NORAML_WAVE
VENOM_LET_THERE_BE_CARNAGE
MICROSOFT-WINDOWS-OFFICE
                ".Trim()
            }
        End If
        Return ro
    End Function

    Public Sub Save()
        Using tsw As New StreamWriter(_xfp, False, Encoding.Default)
            Try
                Dim txs As New XmlSerializer(GetType(CaseTextConverter__Data))
                txs.Serialize(tsw, Me)
            Catch
            End Try
        End Using
    End Sub

    Public ReadOnly Property SptArr As EnSpt()
        Get
            Dim arr As Array = [Enum].GetValues(GetType(EnSpt))
            Return CType(arr, EnSpt())
        End Get
    End Property

    Public Spt As EnSpt
    Public ReadOnly Property CkndArr As EnCknd()
        Get
            Dim arr As Array = [Enum].GetValues(GetType(EnCknd))
            Return CType(arr, EnCknd())
        End Get
    End Property

    Public CkndIn As EnCknd
    Public CkndOut As EnCknd
    Public InputText As String

    Public ReadOnly Property GubunArr As Char()
        Get
            Return {CaseConverter.Dm2, CaseConverter.Dm3}
        End Get
    End Property
    Public Gubun As Char = CaseConverter.Dm2
End Class
