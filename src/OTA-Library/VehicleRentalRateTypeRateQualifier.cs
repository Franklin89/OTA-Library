using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalRateTypeRateQualifier : RateQualifierType
    {
        
        private string _tourInfoRPH;
        
        private List<string> _custLoyaltyRPH;
        
        private string _quoteID;
        
        public VehicleRentalRateTypeRateQualifier()
        {
            this._custLoyaltyRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourInfoRPH
        {
            get
            {
                return this._tourInfoRPH;
            }
            set
            {
                this._tourInfoRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> CustLoyaltyRPH
        {
            get
            {
                return this._custLoyaltyRPH;
            }
            set
            {
                this._custLoyaltyRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QuoteID
        {
            get
            {
                return this._quoteID;
            }
            set
            {
                this._quoteID = value;
            }
        }
    }
}