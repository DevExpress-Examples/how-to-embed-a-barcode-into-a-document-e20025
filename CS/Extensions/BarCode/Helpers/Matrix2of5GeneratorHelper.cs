namespace BizPad {
    using System.Collections;
    using System.Drawing;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraPrinting.BarCode;
    using DevExpress.XtraRichEdit.Fields;
    using System;

    internal class Matrix2of5GeneratorHelper : Matrix2of5Generator, IBarCodeGenerator {
        public Matrix2of5GeneratorHelper() {
        }

        void IBarCodeGenerator.Initialize(InstructionCollection switches) {
            float r = 0f;
            if (!float.TryParse(switches.GetString("r") ?? String.Empty, out r)) {
                r = 0f;
            }

            if (r < 2.2f) {
                r = 2.5f;
            }

            this.WideNarrowRatio = r;
        }

        string IBarCodeGenerator.GetValidCharSet() {
            return base.GetValidCharSet();
        }

        ArrayList IBarCodeGenerator.MakeBarCodePattern(string text) {
            return base.MakeBarCodePattern(text);
        }

        void IBarCodeGenerator.DrawBarCode(IGraphics gr, RectangleF barBounds, RectangleF textBounds, IBarCodeData data, float xModule, float yModule) {
            base.DrawBarCode(gr, barBounds, textBounds, data, xModule, yModule);
        }

        public bool SupressAutoTextAlignment() {
            return false;
        }

        string IBarCodeGenerator.MakeDisplayText(string text) {
            return base.MakeDisplayText(text);
        }

        string IBarCodeGenerator.FormatText(string text) {
            return base.FormatText(text);
        }

        bool IBarCodeGenerator.IsValidPattern(ArrayList pattern) {
            return base.IsValidPattern(pattern);
        }

        bool IBarCodeGenerator.IsValidText(string text) {
            return BarCodeGeneratorHelper.IsValidText(this, text);
        }

        bool IBarCodeGenerator.IsValidTextFormat(string text) {
            return base.IsValidTextFormat(text);
        }

        float IBarCodeGenerator.CalcBarCodeWidth(ArrayList pattern) {
            return base.CalcBarCodeWidth(pattern);
        }

        float IBarCodeGenerator.CalcBarCodeHeight(ArrayList pattern) {
            return base.CalcBarCodeHeight(pattern);
        }
    }
}
