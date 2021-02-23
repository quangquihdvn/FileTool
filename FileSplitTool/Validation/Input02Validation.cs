using FileSplitTool.Commons;
using FileSplitTool.Extensions;
using FileSplitTool.Models;

namespace FileSplitTool.Validation
{
    public static class Input02Validation
    {
        public static ResultType Validation(Input02 input02)
        {
            if (!RecordNumberValidate(input02.RecordNumber.Value))
            {
                return ResultType.RecordNumberInvalid;
            }
            if (!Fix1Validate(input02.Fix1.Value) || !Fix2Validate(input02.Fix2.Value) || !Fix3Validate(input02.Fix3.Value))
            {
                return ResultType.FixInvalid;
            }
            if (!CanValidate(input02.Can.Value))
            {
                return ResultType.CANInvalid;
            }
            if (!ServiceCodeValidate(input02.ServiceCode.Value))
            {
                return ResultType.ServiceCodeInvalid;
            }
            if (!CardNumberValidate(input02.CardNumber.Value))
            {
                return ResultType.CardNumber02Invalid;
            }

            return ResultType.Success;
        }

        private static bool RecordNumberValidate(string value)
        {
            return value.Length == Constants.RECORD_NUMBER_LENGTH && value.IsValidNumber();
        }

        private static bool Fix1Validate(string value)
        {
            return value == "|";
        }
        private static bool Fix2Validate(string value)
        {
            return value == "#";
        }
        private static bool Fix3Validate(string value)
        {
            return value == "$";
        }

        private static bool CanValidate(string value)
        {
            return value.Length == Constants.CAN_LENGTH && value.IsValidLongNumber();
        }

        private static bool ServiceCodeValidate(string value)
        {
            return value.Length == Constants.SERVICE_CODE_LENGTH;
        }

        private static bool CardNumberValidate(string value)
        {
            return value.Length == Constants.CARD_NUMBER_02_LENGTH && value.IsValidLongNumber();
        }
    }
}
