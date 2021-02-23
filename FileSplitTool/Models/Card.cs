namespace FileSplitTool.Models
{
    public class Card
    {
        public string Value { get; set; }
        public int Length { get; set; }
        public int StartIndex { get; set; }
        public int NextStartIndex
        {
            get
            {
                return Length + StartIndex;
            }
        }

        public void SetValue(string line)
        {
            var cardValue = line.Substring(StartIndex, Length);
            Value = cardValue;
        }
    }
}
