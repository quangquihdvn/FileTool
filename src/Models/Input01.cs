using FileSplitTool.Commons;

namespace FileSplitTool.Models
{
    public class Input01
    {
        public Input01(int maxLength)
        {
            RecordNumber = new Card { Length = Constants.Input01Length.RECORD_NUMBER_LENGTH, StartIndex = 0 };
            CardNumber = new Card { Length = Constants.Input01Length.CARD_NUMBER_01_LENGTH, StartIndex = RecordNumber.NextStartIndex };
            ProductionCode = new Card { Length = Constants.Input01Length.PRODUCTION_CODE_LENGTH, StartIndex = CardNumber.NextStartIndex };
            PAN = new Card { Length = Constants.Input01Length.PAN_01_LENGTH, StartIndex = ProductionCode.NextStartIndex };
            PanSequenceNumber = new Card { Length = Constants.Input01Length.PAN_SEQUENCE_NUMBER_LENGTH, StartIndex = PAN.NextStartIndex };
            EffectiveDate = new Card { Length = Constants.Input01Length.EFFECTIVE_DATE_LENGTH, StartIndex = PanSequenceNumber.NextStartIndex };
            ExpiryDate = new Card { Length = Constants.Input01Length.EXPIRY_DATE_LENGTH, StartIndex = EffectiveDate.NextStartIndex };
            CardHoderName = new Card { Length = Constants.Input01Length.CARDHORDER_LENGTH, StartIndex = ExpiryDate.NextStartIndex };
            CompanyName = new Card { Length = Constants.Input01Length.COMPANY_NAME_LENGTH, StartIndex = CardHoderName.NextStartIndex };
            CardNumberBackSide = new Card { Length = Constants.Input01Length.CARD_NUMBER_BACK_SIDE, StartIndex = CompanyName.NextStartIndex };
            CVV2 = new Card { Length = Constants.Input01Length.CVV2_LENGTH, StartIndex = CardNumberBackSide.NextStartIndex };
            MagTrack1 = new Card { Length = Constants.Input01Length.MAGTRACK1_LENGTH, StartIndex = CVV2.NextStartIndex };
            MagTrack2 = new Card { Length = Constants.Input01Length.MAGTRACK2_LENGTH, StartIndex = MagTrack1.NextStartIndex };
            ICVV = new Card { Length = Constants.Input01Length.ICVV_LENGTH, StartIndex = MagTrack2.NextStartIndex };
            CardID = new Card { Length = Constants.Input01Length.CARDID_LENGTH, StartIndex = ICVV.NextStartIndex };
            var barCodeLength = maxLength
                - RecordNumber.Length
                - CardNumber.Length
                - ProductionCode.Length
                - PAN.Length
                - PanSequenceNumber.Length
                - EffectiveDate.Length
                - ExpiryDate.Length
                - CardHoderName.Length
                - CompanyName.Length
                - CardNumberBackSide.Length
                - CVV2.Length
                - MagTrack1.Length
                - MagTrack2.Length
                - ICVV.Length
                - CardID.Length;
            Barcode = new Card { Length = barCodeLength, StartIndex = CardID.NextStartIndex };
        }

        public Card RecordNumber { get; set; } 
        public Card CardNumber { get; set; } 
        public Card ProductionCode { get; set; } 
        public Card PAN { get; set; } 
        public Card PanSequenceNumber { get; set; } 
        public Card EffectiveDate { get; set; } 
        public Card ExpiryDate  { get; set; } 
        public Card CardHoderName { get; set; } 
        public Card CompanyName { get; set; } 
        public Card CardNumberBackSide { get; set; } 
        public Card CVV2 { get; set; }
        public Card MagTrack1 { get; set; }
        public Card MagTrack2 { get; set; }
        public Card ICVV { get; set; }
        public Card CardID  { get; set; }
        public Card Barcode { get; set; }

        public void SetValue(string line)
        {
            RecordNumber.SubValue(line);
            CardNumber.SubValue(line);
            ProductionCode.SubValue(line);
            PAN.SubValue(line);
            PanSequenceNumber.SubValue(line);
            EffectiveDate.SubValue(line);
            ExpiryDate.SubValue(line);
            CardHoderName.SubValue(line);
            CompanyName.SubValue(line);
            CardNumberBackSide.SubValue(line);
            CVV2.SubValue(line);
            MagTrack1.SubValueAndAddSpecialChar(line,"%");
            MagTrack2.SubValueAndAddSpecialChar(line, ";");
            ICVV.SubValue(line);
            CardID.SubValue(line);
            Barcode.SubValue(line);
        }
    }
}
