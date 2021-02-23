using FileSplitTool.Attributes;
using FileSplitTool.Properties;

namespace FileSplitTool.Commons
{
    public enum ResultType
    {
        [Localization(nameof(Resources.MSG_SUCCESS), typeof(Resources))]
        Success = 00,
        [Localization(nameof(Resources.MSG_RECORD_NUMBER_INVALID), typeof(Resources))]
        RecordNumberInvalid = 01,
        [Localization(nameof(Resources.MSG_CARD_NUMBER_01_INVALID), typeof(Resources))]
        CardNumber01Invalid = 02,
        [Localization(nameof(Resources.MSG_PRODUCTION_CODE_INVALID), typeof(Resources))]
        ProductionCodeInvalid = 03,
        [Localization(nameof(Resources.MSG_PAN_INVALID), typeof(Resources))]
        PanInvalid = 04,
        [Localization(nameof(Resources.MSG_PAN_SEQUENCE_INVALID), typeof(Resources))]
        PanSequenceNumberInvalid = 05,
        [Localization(nameof(Resources.MSG_EFFECTIVE_DATE_INVALID), typeof(Resources))]
        EffectiveDateInvalid = 06,
        [Localization(nameof(Resources.MSG_EXPIRY_DATE_INVALID), typeof(Resources))]
        ExpiryDateInvalid = 07,
        [Localization(nameof(Resources.MSG_CARD_HORDER_NAME_INVALID), typeof(Resources))]
        CardHoderNameInvalid = 08,
        [Localization(nameof(Resources.MSG_COMPANY_NAME_INVALID), typeof(Resources))]
        CompanyNameInvalid = 09,
        [Localization(nameof(Resources.MSG_CARD_NUMBER_BACK_SIDE_INVALID), typeof(Resources))]
        CardNumberBackSideInvalid = 10,
        [Localization(nameof(Resources.MSG_CVV2_INVALID), typeof(Resources))]
        CVV2Invalid = 11,
        [Localization(nameof(Resources.MSG_MAG_TRACK_1_INVALID), typeof(Resources))]
        MagTrack1Invalid = 12,
        [Localization(nameof(Resources.MSG_MAG_TRACK_2_INVALID), typeof(Resources))]
        MagTrack2Invalid = 13,
        [Localization(nameof(Resources.MSG_ICCV_INVALID), typeof(Resources))]
        ICVVInvalid = 14,
        [Localization(nameof(Resources.MSG_CARDID_INVALID), typeof(Resources))]
        CardIdInvalid = 15,
        [Localization(nameof(Resources.MSG_BARCODE_INVALID), typeof(Resources))]
        BarCodeInvalid = 16,
        [Localization(nameof(Resources.MSG_FIX_INVALID), typeof(Resources))]
        FixInvalid = 17,
        [Localization(nameof(Resources.MSG_CAN_INVALID), typeof(Resources))]
        CANInvalid = 18,
        [Localization(nameof(Resources.MSG_SERVICE_CODE_INVALID), typeof(Resources))]
        ServiceCodeInvalid = 19,
        [Localization(nameof(Resources.MSG_CARD_NUMBER_02_INVALID), typeof(Resources))]
        CardNumber02Invalid = 20
    }
}
