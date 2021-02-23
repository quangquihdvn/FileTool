using FileSplitTool.Commons;

namespace FileSplitTool.Models
{
    public class Input01
    {
        public Input01()
        {
            RecordNumber = new Card { Length = Constants.RECORD_NUMBER_LENGTH, StartIndex = 0 };
            CardNumber = new Card { Length = Constants.CARD_NUMBER_01_LENGTH, StartIndex = RecordNumber.NextStartIndex };
            ProductionCode = new Card { Length = Constants.PRODUCTION_CODE_LENGTH, StartIndex = CardNumber.NextStartIndex };
            PAN = new Card { Length = Constants.PAN_LENGTH, StartIndex = ProductionCode.NextStartIndex };
            PanSequenceNumber = new Card { Length = Constants.PAN_SEQUENCE_NUMBER_LENGTH, StartIndex = PAN.NextStartIndex };
            EffectiveDate = new Card { Length = Constants.EFFECTIVE_DATE_LENGTH, StartIndex = PanSequenceNumber.NextStartIndex };
            ExpiryDate = new Card { Length = Constants.EXPIRY_DATE_LENGTH, StartIndex = EffectiveDate.NextStartIndex };
            CardHoderName = new Card { Length = Constants.CARDHORDER_LENGTH, StartIndex = ExpiryDate.NextStartIndex };
            CompanyName = new Card { Length = Constants.COMPANY_NAME_LENGTH, StartIndex = CardHoderName.NextStartIndex };
            CardNumberBackSide = new Card { Length = Constants.CARD_NUMBER_BACK_SIDE, StartIndex = CompanyName.NextStartIndex };
            CVV2 = new Card { Length = Constants.CVV2_LENGTH, StartIndex = CardNumberBackSide.NextStartIndex };
            MagTrack1 = new Card { Length = Constants.MAGTRACK1_LENGTH, StartIndex = CVV2.NextStartIndex };
            MagTrack2 = new Card { Length = Constants.MAGTRACK2_LENGTH, StartIndex = MagTrack1.NextStartIndex };
            ICVV = new Card { Length = Constants.ICVV_LENGTH, StartIndex = MagTrack2.NextStartIndex };
            CardID = new Card { Length = Constants.CARDID_LENGTH, StartIndex = ICVV.NextStartIndex };
            Barcode = new Card { Length = Constants.BARCODE_LENGTH, StartIndex = CardID.NextStartIndex };
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
            RecordNumber.SetValue(line);
            CardNumber.SetValue(line);
            ProductionCode.SetValue(line);
            PAN.SetValue(line);
            PanSequenceNumber.SetValue(line);
            EffectiveDate.SetValue(line);
            ExpiryDate.SetValue(line);
            CardHoderName.SetValue(line);
            CompanyName.SetValue(line);
            CardNumberBackSide.SetValue(line);
            CVV2.SetValue(line);
            MagTrack1.SetValue(line);
            MagTrack2.SetValue(line);
            ICVV.SetValue(line);
            CardID.SetValue(line);
            Barcode.SetValue(line);
        }
    }
}
