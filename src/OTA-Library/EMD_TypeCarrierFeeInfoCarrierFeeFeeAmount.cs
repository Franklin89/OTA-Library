using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeCarrierFeeInfoCarrierFeeFeeAmount
    {
        
        private string _type;
        
        private decimal _amount;
        
        private List<string> _applicationCode;
        
        private string _originCityCode;
        
        private string _originCodeContext;
        
        private string _destinationCityCode;
        
        private string _destinationCodeContext;
        
        public EMD_TypeCarrierFeeInfoCarrierFeeFeeAmount()
        {
            this._applicationCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ApplicationCode
        {
            get
            {
                return this._applicationCode;
            }
            set
            {
                this._applicationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCityCode
        {
            get
            {
                return this._originCityCode;
            }
            set
            {
                this._originCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCodeContext
        {
            get
            {
                return this._originCodeContext;
            }
            set
            {
                this._originCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCityCode
        {
            get
            {
                return this._destinationCityCode;
            }
            set
            {
                this._destinationCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCodeContext
        {
            get
            {
                return this._destinationCodeContext;
            }
            set
            {
                this._destinationCodeContext = value;
            }
        }
    }
}