using FileSplitTool.Commons;
using FileSplitTool.Extensions;
using FileSplitTool.Models;
using System.Linq;

namespace FileSplitTool.Validation
{
    public static class Input01Validation
    {
        public static ResultType Validation(Input01 input01)
        {
            if(!RecordNumberValidate(input01.RecordNumber.Value))
            {
                return ResultType.RecordNumberInvalid;
            }
            else if (!CardNumberValidate(input01.CardNumber.Value))
            {
                return ResultType.CardNumber01Invalid;
            }
            else if(!ProductionCodeValidate(input01.ProductionCode.Value))
            {
                return ResultType.ProductionCodeInvalid;
            }
            else if(!PANValidate(input01.PAN.Value))
            {
                return ResultType.PanInvalid;
            }
            else if(!PanSequenceNumberValidate(input01.PanSequenceNumber.Value))
            {
                return ResultType.PanSequenceNumberInvalid;
            }
            else if(!EffectiveDateValidate(input01.EffectiveDate.Value))
            {
                return ResultType.EffectiveDateInvalid;
            }
            else if (!ExpiryDateValidate(input01.ExpiryDate.Value))
            {
                return ResultType.EffectiveDateInvalid;
            }

            else if (!CardHoderNameValidate(input01.CardHoderName.Value))
            {
                return ResultType.CardHoderNameInvalid;
            }

            else if (!CompanyNameValidate(input01.CompanyName.Value))
            {
                return ResultType.CompanyNameInvalid;
            }

            else if (!CardNumberBackSideValidate(input01.CardNumberBackSide.Value))
            {
                return ResultType.CardNumberBackSideInvalid;
            }

            else if (!CVV2Validate(input01.CVV2.Value))
            {
                return ResultType.CVV2Invalid;
            }

            else if (!MagTrack1Validate(input01.MagTrack1.Value))
            {
                return ResultType.MagTrack1Invalid;
            }

            else if (!MagTrack2Validate(input01.MagTrack2.Value))
            {
                return ResultType.MagTrack2Invalid;
            }

            else if (!CardIdValidate(input01.CardID.Value))
            {
                return ResultType.CardIdInvalid;
            }

            else if (!BarCodeValidate(input01.Barcode.Value))
            {
                return ResultType.BarCodeInvalid;
            }

            return ResultType.Success;
        }

        private static bool RecordNumberValidate(string value)
        {
            return value.Length == Constants.RECORD_NUMBER_LENGTH && value.IsValidNumber();
        }

        private static bool CardNumberValidate(string value)
        {
            bool isLength = value.Length == Constants.CARD_NUMBER_01_LENGTH;
            string[] cardNumberSplit = value.Split(' ');
            var isValid = cardNumberSplit.Length == 4 && cardNumberSplit.All(x => x.IsValidNumber());
            return isLength && isValid;
        }

        private static bool ProductionCodeValidate(string value)
        {
            return value.Length == Constants.PRODUCTION_CODE_LENGTH;
        }

        private static bool PANValidate(string value)
        {
            bool isLength = value.Length == Constants.PAN_LENGTH;
            var panValue = value.Substring(0, 16);
            return isLength && panValue.IsValidLongNumber();
        }

        private static bool PanSequenceNumberValidate(string value)
        {
            return value.Length == Constants.PAN_SEQUENCE_NUMBER_LENGTH && value.IsValidNumber();
        }

        private static bool EffectiveDateValidate(string value)
        {
            return value.Length == Constants.EFFECTIVE_DATE_LENGTH && value.IsValidDate();
        }

        private static bool ExpiryDateValidate(string value)
        {
            return value.Length == Constants.EXPIRY_DATE_LENGTH && value.IsValidDate();
        }

        private static bool CardHoderNameValidate(string value)
        {
            return value.Length == Constants.CARDHORDER_LENGTH;
        }

        private static bool CompanyNameValidate(string value)
        {
            return value.Length == Constants.COMPANY_NAME_LENGTH;
        }

        private static bool CardNumberBackSideValidate(string value)
        {
            return value.Length == Constants.CARD_NUMBER_BACK_SIDE;
        }

        private static bool CVV2Validate(string value)
        {
            return value.Length == Constants.CVV2_LENGTH && value.IsValidNumber();
        }

        private static bool MagTrack1Validate(string value)
        {
            return value.Length == Constants.MAGTRACK1_LENGTH;
        }

        private static bool MagTrack2Validate(string value)
        {
            return value.Length == Constants.MAGTRACK2_LENGTH;
        }

        private static bool CardIdValidate(string value)
        {
            return value.Length == Constants.CARDID_LENGTH;
        }

        private static bool BarCodeValidate(string value)
        {
            return value.Length == Constants.BARCODE_LENGTH;
        }
    }
}
