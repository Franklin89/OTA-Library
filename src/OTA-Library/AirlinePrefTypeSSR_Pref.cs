using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeSSR_Pref
    {
        
        private string _sSR_Code;
        
        private string _vendorCode;
        
        private string _numberInParty;
        
        private string _defaultStatusCode;
        
        private string _remark;
        
        private string _lookupKey;
        
        private List<string> _airlineVendorPrefRPH;
        
        private TransferActionType _transferActionType;
        
        public AirlinePrefTypeSSR_Pref()
        {
            this._airlineVendorPrefRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SSR_Code
        {
            get
            {
                return this._sSR_Code;
            }
            set
            {
                this._sSR_Code = value;
            }
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
        public string DefaultStatusCode
        {
            get
            {
                return this._defaultStatusCode;
            }
            set
            {
                this._defaultStatusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LookupKey
        {
            get
            {
                return this._lookupKey;
            }
            set
            {
                this._lookupKey = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> AirlineVendorPrefRPH
        {
            get
            {
                return this._airlineVendorPrefRPH;
            }
            set
            {
                this._airlineVendorPrefRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferActionType
        {
            get
            {
                return this._transferActionType;
            }
            set
            {
                this._transferActionType = value;
            }
        }
    }
}