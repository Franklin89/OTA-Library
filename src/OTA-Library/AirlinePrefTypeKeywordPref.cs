using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeKeywordPref
    {
        
        private string _vendorCode;
        
        private string _description;
        
        private string _keyword;
        
        private string _statusCode;
        
        private string _numberInParty;
        
        private List<string> _airlineVendorRPH;
        
        private TransferActionType _transferAction;
        
        public AirlinePrefTypeKeywordPref()
        {
            this._airlineVendorRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCode
        {
            get
            {
                return this._vendorCode;
            }
            set
            {
                this._vendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Keyword
        {
            get
            {
                return this._keyword;
            }
            set
            {
                this._keyword = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatusCode
        {
            get
            {
                return this._statusCode;
            }
            set
            {
                this._statusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string NumberInParty
        {
            get
            {
                return this._numberInParty;
            }
            set
            {
                this._numberInParty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> AirlineVendorRPH
        {
            get
            {
                return this._airlineVendorRPH;
            }
            set
            {
                this._airlineVendorRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
    }
}