namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanNotifRSRatePlanCrossRefsRatePlanCrossRef
    {
        
        private string _requestRatePlanCode;
        
        private string _requestRatePlanGroupingCode;
        
        private string _responseRatePlanCode;
        
        private string _responseRatePlanGroupingCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestRatePlanCode
        {
            get
            {
                return this._requestRatePlanCode;
            }
            set
            {
                this._requestRatePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestRatePlanGroupingCode
        {
            get
            {
                return this._requestRatePlanGroupingCode;
            }
            set
            {
                this._requestRatePlanGroupingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseRatePlanCode
        {
            get
            {
                return this._responseRatePlanCode;
            }
            set
            {
                this._responseRatePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseRatePlanGroupingCode
        {
            get
            {
                return this._responseRatePlanGroupingCode;
            }
            set
            {
                this._responseRatePlanGroupingCode = value;
            }
        }
    }
}