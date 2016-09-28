using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAdditionalDriverRequirementsTypeAddlDriverInfos
    {
        
        private List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosAddlDriverInfo> _addlDriverInfo;
        
        private List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosVehicle> _vehicles;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private string _chargeType;
        
        public VehicleAdditionalDriverRequirementsTypeAddlDriverInfos()
        {
            this._vehicles = new List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosVehicle>();
            this._addlDriverInfo = new List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosAddlDriverInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AddlDriverInfo")]
        public List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosAddlDriverInfo> AddlDriverInfo
        {
            get
            {
                return this._addlDriverInfo;
            }
            set
            {
                this._addlDriverInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public List<VehicleAdditionalDriverRequirementsTypeAddlDriverInfosVehicle> Vehicles
        {
            get
            {
                return this._vehicles;
            }
            set
            {
                this._vehicles = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
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
        public string ChargeType
        {
            get
            {
                return this._chargeType;
            }
            set
            {
                this._chargeType = value;
            }
        }
    }
}