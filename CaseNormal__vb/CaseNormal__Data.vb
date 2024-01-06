Imports System.IO
Imports System.Text
Imports System.Xml.Serialization




Public NotInheritable Class CaseNormal__Data
    Public Shared ReadOnly Current As CaseNormal__Data = Load()
    Private Const _xfp As String = ".\CaseNormal__Data.xml"
    Public Shared Function Load() As CaseNormal__Data
        Dim ro As CaseNormal__Data = Nothing
        If File.Exists(_xfp) Then
            Using tsr As New StreamReader(_xfp, Encoding.Default)
                Try
                    Dim txs As New XmlSerializer(GetType(CaseNormal__Data))
                    ro = CType(txs.Deserialize(tsr), CaseNormal__Data)
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
            ro = New CaseNormal__Data With {
                .SptsData = {"Tab", "NewLine", "Comma"},
                .Spt = "Tab",
                .InputText = "
normal_gatter_at_standard_edition
GATE_ON_NORAML_WAVE
VENOM_LET_THERE_BE_CARNAGE
                ".Trim()
            }
        End If
        Return ro
    End Function
    Public Sub Save()
        Using tsw As New StreamWriter(_xfp, False, Encoding.Default)
            Try
                Dim txs As New XmlSerializer(GetType(CaseNormal__Data))
                txs.Serialize(tsw, Me)
            Catch
            End Try
        End Using
    End Sub
    Public SptsData() As String
    Public Spt As String
    Public InputText As String
End Class
