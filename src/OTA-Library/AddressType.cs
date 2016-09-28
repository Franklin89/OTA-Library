using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AddressType
    {
        
        private AddressTypeStreetNmbr _streetNmbr;
        
        private List<AddressTypeBldgRoom> _bldgRoom;
        
        private List<string> _addressLine;
        
        private string _cityName;
        
        private string _postalCode;
        
        private string _county;
        
        private StateProvType _stateProv;
        
        private CountryNameType _countryName;
        
        private bool _formattedInd;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _type;
        
        private string _remark;
        
        private string _language;
        
        private bool _validInd;
        
        public AddressType()
        {
            this._countryName = new CountryNameType();
            this._stateProv = new StateProvType();
            this._addressLine = new List<string>();
            this._bldgRoom = new List<AddressTypeBldgRoom>();
            this._streetNmbr = new AddressTypeStreetNmbr();
        }
        
        public AddressTypeStreetNmbr StreetNmbr
        {
            get
            {
                return this._streetNmbr;
            }
            set
            {
                this._streetNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BldgRoom")]
        public List<AddressTypeBldgRoom> BldgRoom
        {
            get
            {
                return this._bldgRoom;
            }
            set
            {
                this._bldgRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
        public List<string> AddressLine
        {
            get
            {
                return this._addressLine;
            }
            set
            {
                this._addressLine = value;
            }
        }
        
        public string CityName
        {
            get
            {
                return this._cityName;
            }
            set
            {
                this._cityName = value;
            }
        }
        
        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }
        
        public string County
        {
            get
            {
                return this._county;
            }
            set
            {
                this._county = value;
            }
        }
        
        public StateProvType StateProv
        {
            get
            {
                return this._stateProv;
            }
            set
            {
                this._stateProv = value;
            }
        }
        
        public CountryNameType CountryName
        {
            get
            {
                return this._countryName;
            }
            set
            {
                this._countryName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FormattedInd
        {
            get
            {
                return this._formattedInd;
            }
            set
            {
                this._formattedInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ValidInd
        {
            get
            {
                return this._validInd;
            }
            set
            {
                this._validInd = value;
            }
        }
    }
}