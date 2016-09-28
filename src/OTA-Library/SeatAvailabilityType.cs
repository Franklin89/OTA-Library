using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatAvailabilityType
    {
        
        private List<FeeType> _charges;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        public SeatAvailabilityType()
        {
            this._charges = new List<FeeType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable=false)]
        public List<FeeType> Charges
        {
            get
            {
                return this._charges;
            }
            set
            {
                this._charges = value;
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