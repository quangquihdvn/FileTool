using FileSplitTool.Commons;
using FileSplitTool.Models;

namespace FileSplitTool.Validation
{
    public static class InputValidation
    {
        public static ResultType Validate(Input01 input01, Input02 input02)
        {
            var input1Validate = Input01Validation.Validation(input01);
            if (input1Validate != ResultType.Success)
            {
                return input1Validate;
            }
            var input2Validate = Input02Validation.Validation(input02);
            if (input2Validate != ResultType.Success)
            {
                return input2Validate;
            }
            return ResultType.Success;
        }
    }
}
