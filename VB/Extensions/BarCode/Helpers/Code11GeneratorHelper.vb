Imports Microsoft.VisualBasic
	Imports System.Collections
	Imports System.Drawing
	Imports DevExpress.XtraPrinting
	Imports DevExpress.XtraPrinting.BarCode
	Imports DevExpress.XtraRichEdit.Fields
Namespace BizPad

	Friend Class Code11GeneratorHelper
		Inherits Code11Generator
		Implements IBarCodeGenerator
		Public Sub New()
		End Sub

		Private Sub Initialize(ByVal switches As InstructionCollection) Implements IBarCodeGenerator.Initialize
		End Sub

		Public Function SupressAutoTextAlignment() As Boolean Implements IBarCodeGenerator.SupressAutoTextAlignment
			Return False
		End Function

		Private Function GetValidCharSet() As String Implements IBarCodeGenerator.GetValidCharSet
			Return MyBase.GetValidCharSet()
		End Function

		Private Function MakeBarCodePattern(ByVal text As String) As ArrayList Implements IBarCodeGenerator.MakeBarCodePattern
			Return MyBase.MakeBarCodePattern(text)
		End Function

		Private Sub DrawBarCode(ByVal gr As IGraphics, ByVal barBounds As RectangleF, ByVal textBounds As RectangleF, ByVal data As IBarCodeData, ByVal xModule As Single, ByVal yModule As Single) Implements IBarCodeGenerator.DrawBarCode
			MyBase.DrawBarCode(gr, barBounds, textBounds, data, xModule, yModule)
		End Sub

		Private Function MakeDisplayText(ByVal text As String) As String Implements IBarCodeGenerator.MakeDisplayText
			Return MyBase.MakeDisplayText(text)
		End Function

		Private Function FormatText(ByVal text As String) As String Implements IBarCodeGenerator.FormatText
			Return MyBase.FormatText(text)
		End Function

		Private Function IsValidPattern(ByVal pattern As ArrayList) As Boolean Implements IBarCodeGenerator.IsValidPattern
			Return MyBase.IsValidPattern(pattern)
		End Function

		Private Function IsValidText(ByVal text As String) As Boolean Implements IBarCodeGenerator.IsValidText
			Return BarCodeGeneratorHelper.IsValidText(Me, text)
		End Function

		Private Function IsValidTextFormat(ByVal text As String) As Boolean Implements IBarCodeGenerator.IsValidTextFormat
			Return MyBase.IsValidTextFormat(text)
		End Function

		Private Function CalcBarCodeWidth(ByVal pattern As ArrayList) As Single Implements IBarCodeGenerator.CalcBarCodeWidth
			Return MyBase.CalcBarCodeWidth(pattern)
		End Function

		Private Function CalcBarCodeHeight(ByVal pattern As ArrayList) As Single Implements IBarCodeGenerator.CalcBarCodeHeight
			Return MyBase.CalcBarCodeHeight(pattern)
		End Function
	End Class
End Namespace
