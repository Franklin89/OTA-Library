using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationDetailsType
    {
        
        private List<AddressInfoType> _address;
        
        private List<VehicleLocationDetailsTypeTelephone> _telephone;
        
        private VehicleLocationAdditionalDetailsType _additionalInfo;
        
        private bool _atAirport;
        
        private string _code;
        
        private string _name;
        
        private string _codeContext;
        
        private string _extendedLocationCode;
        
        private List<string> _assocAirportLocList;
        
        public VehicleLocationDetailsType()
        {
            this._assocAirportLocList = new List<string>();
            this._additionalInfo = new VehicleLocationAdditionalDetailsType();
            this._telephone = new List<VehicleLocationDetailsTypeTelephone>();
            this._address = new List<AddressInfoType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<AddressInfoType> Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<VehicleLocationDetailsTypeTelephone> Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        public VehicleLocationAdditionalDetailsType AdditionalInfo
        {
            get
            {
                return this._additionalInfo;
            }
            set
            {
                this._additionalInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AtAirport
        {
            get
            {
                return this._atAirport;
            }
            set
            {
                this._atAirport = value;
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
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtendedLocationCode
        {
            get
            {
                return this._extendedLocationCode;
            }
            set
            {
                this._extendedLocationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> AssocAirportLocList
        {
            get
            {
                return this._assocAirportLocList;
            }
            set
            {
                this._assocAirportLocList = value;
            }
        }
    }
}