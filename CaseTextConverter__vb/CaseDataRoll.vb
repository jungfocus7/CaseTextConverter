Imports System.IO
Imports System.Xml



Public NotInheritable Class BindItem
    Public Sub New(dsp As String, val As String)
        Display = dsp
        Value = val
    End Sub
    Public Sub New(val As String)
        Display = val
        Value = val
    End Sub
    Public Property Display As String
    Public Property Value As String
End Class


Public NotInheritable Class CaseDataRoll
    Private Sub New()
    End Sub

    Private Shared ReadOnly _xmlts As String = "
<Root>
    <InputText><![CDATA[{0}]]></InputText>
    <LineGubun><![CDATA[{1}]]></LineGubun>
    <InputGubun><![CDATA[{2}]]></InputGubun>
    <OutputType><![CDATA[{3}]]></OutputType>
</Root>
    ".Trim()
    Private Shared ReadOnly _xfp As String = ".\CaseDataRoll.xml"
    Public Shared Sub Save()
        Try
            Dim args As String() = {
                If(String.IsNullOrWhiteSpace(InputText), String.Empty, InputText),
                If(String.IsNullOrEmpty(LineGubun), String.Empty, LineGubun),
                If(String.IsNullOrEmpty(InputGubun), String.Empty, InputGubun),
                If(String.IsNullOrWhiteSpace(OutputType), String.Empty, OutputType)
            }
            Dim sxd As String = String.Format(_xmlts, args)
            File.WriteAllText(_xfp, sxd)
        Catch
        End Try
    End Sub
    Public Shared Sub Load()
        If File.Exists(_xfp) Then
            Try
                Dim lxd As New XmlDocument()
                lxd.Load(_xfp)
                InputText = lxd.SelectSingleNode("Root/InputText").InnerText
                LineGubun = lxd.SelectSingleNode("Root/LineGubun").InnerText
                InputGubun = lxd.SelectSingleNode("Root/InputGubun").InnerText
                OutputType = lxd.SelectSingleNode("Root/OutputType").InnerText
            Catch
            End Try
        Else
            Save()
            Load()
        End If
    End Sub

    Public Shared InputText As String = "
normal_gatter_at_standard_edition
GATE_ON_NORAML_WAVE
VENOM_LET_THERE_BE_CARNAGE
MicrosoftVisualStudio2017
Microsoft.VisualStudio.2019
System.Data.DataSetExtensions
SystemWindowsForms
    ".Trim()

    Public Shared Function GetLineGubunArr() As BindItem()
        Dim txa As BindItem() = {
            New BindItem("Tab", CaseConverter.LineGubun_Tab),
            New BindItem("NewLine", CaseConverter.LineGubun_NewLine),
            New BindItem("Comma", CaseConverter.LineGubun_Comma)
        }
        Return txa
    End Function
    Public Shared LineGubun As String = CaseConverter.LineGubun_Tab

    Public Shared Function GetInputGubunArr() As BindItem()
        Dim txa As BindItem() = {
            New BindItem("( _ ) UnderBar", CaseConverter.InputGubun_UnderBar),
            New BindItem("( - ) Hyphen", CaseConverter.InputGubun_Hyphen),
            New BindItem("( . ) Point", CaseConverter.InputGubun_Point),
            New BindItem("(   ) Space", CaseConverter.InputGubun_Space),
            New BindItem("Empty", CaseConverter.InputGubun_Empty)
        }
        Return txa
    End Function
    Public Shared InputGubun As String = CaseConverter.InputGubun_UnderBar

    Public Shared Function GetOutputTypeArr() As BindItem()
        Dim txa As BindItem() = {
            New BindItem(CaseConverter.OutputType_SnakeUpperCase),
            New BindItem(CaseConverter.OutputType_SnakeLowerCase),
            New BindItem(CaseConverter.OutputType_PascalCase),
            New BindItem(CaseConverter.OutputType_CamelCase)
        }
        Return txa
    End Function
    Public Shared OutputType As String = CaseConverter.OutputType_CamelCase
End Class
