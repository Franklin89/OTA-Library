using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeSSR_Pref
    {
        
        private PreferLevelType _preferLevel;
        
        private string _sSR_Code;
        
        private string _vendorCode;
        
        private string _numberInParty;
        
        private string _defaultStatusCode;
        
        private string _remark;
        
        private string _lookupKey;
        
        private List<string> _vendorPrefRPH;
        
        private TransferActionType _transferActionType;
        
        private string _aDA_Requirement;
        
        public RailPrefTypeSSR_Pref()
        {
            this._vendorPrefRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
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
        public List<string> VendorPrefRPH
        {
            get
            {
                return this._vendorPrefRPH;
            }
            set
            {
                this._vendorPrefRPH = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ADA_Requirement
        {
            get
            {
                return this._aDA_Requirement;
            }
            set
            {
                this._aDA_Requirement = value;
            }
        }
    }
}