using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeRatePlanLevelFee
    {
        
        private List<HotelRatePlanTypeRatePlanLevelFeeFee> _fee;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        public HotelRatePlanTypeRatePlanLevelFee()
        {
            this._fee = new List<HotelRatePlanTypeRatePlanLevelFeeFee>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Fee")]
        public List<HotelRatePlanTypeRatePlanLevelFeeFee> Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
    }
}