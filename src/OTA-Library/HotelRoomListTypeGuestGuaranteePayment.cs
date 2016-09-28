namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeGuestGuaranteePayment : HotelPaymentFormType
    {
        
        private HotelRoomListTypeGuestGuaranteePaymentDetailType _detailType;
        
        private HotelRoomListTypeGuestGuaranteePaymentGuaranteeType _guaranteeType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelRoomListTypeGuestGuaranteePaymentDetailType DetailType
        {
            get
            {
                return this._detailType;
            }
            set
            {
                this._detailType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelRoomListTypeGuestGuaranteePaymentGuaranteeType GuaranteeType
        {
            get
            {
                return this._guaranteeType;
            }
            set
            {
                this._guaranteeType = value;
            }
        }
    }
}