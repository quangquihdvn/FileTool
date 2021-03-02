using FileSplitTool.Commons;

namespace FileSplitTool.Models
{
    public class Input02
    {
        public Input02(int maxLength)
        {
            RecordNumber = new Card { Length = Constants.RECORD_NUMBER_LENGTH, StartIndex = 0 };
            Fix = new Card { Length = Constants.FIX_LENGTH, StartIndex = RecordNumber.NextStartIndex };
            PAN = new Card { Length = Constants.PAN_02_LENGTH, StartIndex = Fix.NextStartIndex };
            Fix1 = new Card { Length = Constants.FIX_LENGTH, StartIndex = PAN.NextStartIndex };
            Can = new Card { Length = Constants.CAN_LENGTH, StartIndex = Fix1.NextStartIndex };
            Fix2 = new Card { Length = Constants.FIX_LENGTH, StartIndex = Can.NextStartIndex };
            ServiceCode = new Card { Length = Constants.SERVICE_CODE_LENGTH, StartIndex = Fix2.NextStartIndex };
            Fix3 = new Card { Length = Constants.FIX_LENGTH, StartIndex = ServiceCode.NextStartIndex };
            var cardNumberLength = maxLength 
                - Constants.RECORD_NUMBER_LENGTH 
                - Constants.PAN_02_LENGTH
                - Constants.FIX_LENGTH * 4
                - Constants.CAN_LENGTH 
                - Constants.SERVICE_CODE_LENGTH;
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
            RecordNumber.SetValue(line);
            Fix.SetValue(line);
            PAN.SetValue(line);
            Fix1.SetValue(line);
            Can.SetValue(line);
            Fix2.SetValue(line);
            ServiceCode.SetValue(line);
            Fix3.SetValue(line);
            CardNumber.SetValue(line);
        }
    }
}
