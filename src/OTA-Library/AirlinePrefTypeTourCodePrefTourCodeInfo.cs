using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeTourCodePrefTourCodeInfo
    {
        
        private string _tourTypeCode;
        
        private string _yearNum;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _partyID;
        
        public AirlinePrefTypeTourCodePrefTourCodeInfo()
        {
            this._promotionVendorCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourTypeCode
        {
            get
            {
                return this._tourTypeCode;
            }
            set
            {
                this._tourTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string YearNum
        {
            get
            {
                return this._yearNum;
            }
            set
            {
                this._yearNum = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PartyID
        {
            get
            {
                return this._partyID;
            }
            set
            {
                this._partyID = value;
            }
        }
    }
}