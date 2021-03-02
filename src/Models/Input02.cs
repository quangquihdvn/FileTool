using FileSplitTool.Commons;

namespace FileSplitTool.Models
{
    public class Input02
    {
        public Input02(int maxLength)
        {
            RecordNumber = new Card { Length = Constants.Input02Length.RECORD_NUMBER_LENGTH, StartIndex = 0 };
            Fix = new Card { Length = Constants.Input02Length.FIX_LENGTH, StartIndex = RecordNumber.NextStartIndex };
            PAN = new Card { Length = Constants.Input02Length.PAN_02_LENGTH, StartIndex = Fix.NextStartIndex };
            Fix1 = new Card { Length = Constants.Input02Length.FIX_LENGTH, StartIndex = PAN.NextStartIndex };
            Can = new Card { Length = Constants.Input02Length.CAN_LENGTH, StartIndex = Fix1.NextStartIndex };
            Fix2 = new Card { Length = Constants.Input02Length.FIX_LENGTH, StartIndex = Can.NextStartIndex };
            ServiceCode = new Card { Length = Constants.Input02Length.SERVICE_CODE_LENGTH, StartIndex = Fix2.NextStartIndex };
            Fix3 = new Card { Length = Constants.Input02Length.FIX_LENGTH, StartIndex = ServiceCode.NextStartIndex };
            var cardNumberLength = maxLength 
                - Constants.Input02Length.RECORD_NUMBER_LENGTH 
                - Constants.Input02Length.PAN_02_LENGTH
                - Constants.Input02Length.FIX_LENGTH * 4
                - Constants.Input02Length.CAN_LENGTH 
                - Constants.Input02Length.SERVICE_CODE_LENGTH;
            CardNumber = new Card { Length = cardNumberLength, StartIndex = Fix3.NextStartIndex };
        }

        public Card RecordNumber { get; set; }
        public Card Fix { get; set; }
        public Card PAN { get; set; }
        public Card Fix1 { get; set; }
        public Card Can { get; set; }
        public Card Fix2 { get; set; }
        public Card ServiceCode { get; set; }
        public Card Fix3 { get; set; }
        public Card CardNumber { get; set; }

        public void SetValue(string line)
        {
            RecordNumber.SubValue(line);
            Fix.SubValue(line);
            PAN.SubValue(line);
            Fix1.SubValue(line);
            Can.SubValue(line);
            Fix2.SubValue(line);
            ServiceCode.SubValue(line);
            Fix3.SubValue(line);
            CardNumber.SubValue(line);
        }
    }
}
