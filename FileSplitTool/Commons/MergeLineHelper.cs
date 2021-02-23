using FileSplitTool.Models;
using System.Text;

namespace FileSplitTool.Commons
{
    public static class MergeLineHelper
    {
        public static string MergeLine(Input01 input01, Input02 input02)
        {
            var builder = new StringBuilder();
            builder.Append(input01.RecordNumber.Value);
            builder.Append(input01.CardNumber.Value);
            builder.Append(input01.ProductionCode.Value);
            builder.Append(input01.PAN.Value);
            builder.Append(input01.PanSequenceNumber.Value);
            builder.Append(input01.EffectiveDate.Value);
            builder.Append(input01.ExpiryDate.Value);
            builder.Append(input01.CardHoderName.Value);
            builder.Append(input01.CompanyName.Value);
            builder.Append(input01.CardNumberBackSide.Value);
            builder.Append(input01.CVV2.Value);
            builder.Append(input01.MagTrack1.Value);
            builder.Append(input01.MagTrack2.Value);
            builder.Append(input01.ICVV.Value);
            builder.Append(input01.CardID.Value);
            builder.Append(input01.Barcode.Value);
            builder.Append(input02.Fix1.Value);
            builder.Append(input02.Can.Value);
            builder.Append(input02.Fix2.Value);
            builder.Append(input02.ServiceCode.Value);
            builder.Append(input02.Fix3.Value);
            builder.Append(input02.CardNumber.Value);
            return builder.ToString();
        }
    }
}
