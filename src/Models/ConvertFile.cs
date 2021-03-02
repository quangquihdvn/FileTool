using FileSplitTool.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitTool.Models
{
    public class ConvertFile
    {
        public ConvertFile()
        {
            CARDHOLDER_NAME = new Card { Length = Constants.ConvertFileLength.CARDHOLDER_NAME_LENGTH };
            PAN = new Card { Length = Constants.ConvertFileLength.PAN_LENGTH };
            MBR = new Card { Length = Constants.ConvertFileLength.MBR_LENGTH };
            ValidFromDate = new Card { Length = Constants.ConvertFileLength.VALID_FROM_DATE_LENGTH };
            ExpirationDate = new Card { Length = Constants.ConvertFileLength.EXPIRATION_DATE_LENGTH };
            CVV2 = new Card { Length = Constants.ConvertFileLength.CVV2_LENGTH };
            Identifier = new Card { Length = Constants.ConvertFileLength.IDENTIFIER_LENGTH };
            Track1 = new Card { Length = Constants.ConvertFileLength.TRACK1_LENGTH };
            Track2 = new Card { Length = Constants.ConvertFileLength.TRACK2_LENGTH };
            ICVV = new Card { Length = Constants.ConvertFileLength.ICVV_LENGTH };
            Address = new Card { Length = Constants.ConvertFileLength.ADDRESS_LENGTH };
            OptionalData = new Card { Length = Constants.ConvertFileLength.OPTIONAL_DATA_LENGTH };
            UnknownData = new Card { Length = Constants.ConvertFileLength.UNKNOWN_DATA_LENGTH };
        }
        public Card CARDHOLDER_NAME { get; set; }
        public Card PAN { get; set; }
        public Card MBR { get; set; }
        public Card ValidFromDate { get; set; }
        public Card ExpirationDate { get; set; }
        public Card CVV2 { get; set; }
        public Card Identifier { get; set; }
        public Card Track1 { get; set; }
        public Card Track2 { get; set; }
        public Card ICVV { get; set; }
        public Card Address { get; set; }
        public Card OptionalData { get; set; }
        public Card UnknownData { get; set; }

        public void SetValue(string line)
        {
            var fields = line.Split('|');
            CARDHOLDER_NAME.PadValue(fields[0]);
            PAN.SetValue(fields[1]);
            MBR.PadValue(fields[2]);
            ValidFromDate.SetValue(fields[3]);
            ExpirationDate.SetValue(fields[4]);
            CVV2.SetValue(fields[5]);
            Identifier.PadValue(fields[6]);
            Track1.SetValue(fields[7]);
            Track2.SetValue(fields[8]);
            ICVV.SetValue(fields[9]);
            Address.SetValue(fields[10]);
            OptionalData.SetValue(fields[11]);
            UnknownData.SetValue(fields[12]);
        }

        public string MergeFile()
        {
            var list = new string[]
            {
                CARDHOLDER_NAME.Value,
                PAN.Value,
                MBR.Value,
                ValidFromDate.Value,
                ExpirationDate.Value,
                CVV2.Value,
                Identifier.Value,
                Track1.Value,
                Track2.Value,
                ICVV.Value,
                Address.Value,
                OptionalData.Value,
                UnknownData.Value
            };
            return string.Join("|", list);
        }
    }
}
