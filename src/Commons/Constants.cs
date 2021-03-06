﻿namespace FileSplitTool.Commons
{
    public class Constants
    {
        public class Input01Length
        {
            public const int RECORD_NUMBER_LENGTH = 6;
            public const int CARD_NUMBER_01_LENGTH = 19;
            public const int PRODUCTION_CODE_LENGTH = 2;
            public const int PAN_01_LENGTH = 23;
            public const int PAN_SEQUENCE_NUMBER_LENGTH = 1;
            public const int EFFECTIVE_DATE_LENGTH = 5;
            public const int EXPIRY_DATE_LENGTH = 5;
            public const int CARDHORDER_LENGTH = 26;
            public const int COMPANY_NAME_LENGTH = 26;
            public const int CARD_NUMBER_BACK_SIDE = 23;
            public const int CVV2_LENGTH = 3;
            public const int MAGTRACK1_LENGTH = 76;
            public const int MAGTRACK2_LENGTH = 37;
            public const int ICVV_LENGTH = 3;
            public const int CARDID_LENGTH = 18;
            public const int BARCODE_LENGTH = 32;
        }

        public class Input02Length
        {
            public const int RECORD_NUMBER_LENGTH = 6;
            public const int FIX_LENGTH = 1;
            public const int CAN_LENGTH = 16;
            public const int PAN_02_LENGTH = 16;
            public const int SERVICE_CODE_LENGTH = 40;
            public const int CARD_NUMBER_02_LENGTH = 16;
        }

        public class ConvertFileLength
        {
            public const int CARDHOLDER_NAME_LENGTH = 25;
            public const int PAN_LENGTH = 19;
            public const int MBR_LENGTH = 3;
            public const int VALID_FROM_DATE_LENGTH = 5;
            public const int EXPIRATION_DATE_LENGTH = 5;
            public const int CVV2_LENGTH = 3;
            public const int IDENTIFIER_LENGTH = 25;
            public const int TRACK1_LENGTH = 78;
            public const int TRACK2_LENGTH = 78;
            public const int ICVV_LENGTH = 3;
            public const int ADDRESS_LENGTH = 200;
            public const int OPTIONAL_DATA_LENGTH = 200;
            public const int UNKNOWN_DATA_LENGTH = 200;
        }

        public class RegexConst
        {
            public const string REGEX1 = "^[a-zA-Z0-9 ]*$";
        }
    }
}
