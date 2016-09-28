namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRatePlanMethodInfo
    {
        
        private InvBlockRoomTypeRatePlanMethodInfoBillingType _billingType;
        
        private bool _signFoodAndBev;
        
        private string _reservationMethodCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvBlockRoomTypeRatePlanMethodInfoBillingType BillingType
        {
            get
            {
                return this._billingType;
            }
            set
            {
                this._billingType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SignFoodAndBev
        {
            get
            {
                return this._signFoodAndBev;
            }
            set
            {
                this._signFoodAndBev = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationMethodCode
        {
            get
            {
                return this._reservationMethodCode;
            }
            set
            {
                this._reservationMethodCode = value;
            }
        }
    }
}