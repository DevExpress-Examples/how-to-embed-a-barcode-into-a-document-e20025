namespace BizPad {
    using System.Collections;
    using System.Drawing;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraPrinting.BarCode;
    using DevExpress.XtraRichEdit.Fields;
    using System.Collections.Generic;
    using System;

    internal class CodeMSIGeneratorHelper : CodeMSIGenerator, IBarCodeGenerator {
        static Dictionary<string, MSICheckSum> CheckSums = new Dictionary<string, MSICheckSum>();
        static CodeMSIGeneratorHelper() {
            CheckSums.Add("none", MSICheckSum.None);
            CheckSums.Add("10", MSICheckSum.Modulo10);
            CheckSums.Add("1010", MSICheckSum.DoubleModulo10);
        }

        public CodeMSIGeneratorHelper() {
        }

        void IBarCodeGenerator.Initialize(InstructionCollection switches) {
            string c = switches.GetString("c") ?? String.Empty;

            MSICheckSum checksum = MSICheckSum.Modulo10;
            if (CheckSums.ContainsKey(c.ToLower())) {
                checksum = CheckSums[c.ToLower()];
            }

            this.MSICheckSum = checksum;
        }

        public bool SupressAutoTextAlignment() {
            return false;
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
