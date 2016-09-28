using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareInfoTypeFareInfo
    {
        
        private List<FareInfoTypeFareInfoDate> _date;
        
        private FareInfoTypeFareInfoFare _fare;
        
        private List<FareInfoTypeFareInfoPTC> _pTC;
        
        private string _fareBasisCode;
        
        private GlobalIndicatorType _globalIndicatorCode;
        
        private string _maximumPermittedMileage;
        
        private AirTripType _tripType;
        
        private string _fareType;
        
        private FareStatusType _fareStatus;
        
        private ActionType _operation;
        
        private string _rPH;
        
        public FareInfoTypeFareInfo()
        {
            this._pTC = new List<FareInfoTypeFareInfoPTC>();
            this._fare = new FareInfoTypeFareInfoFare();
            this._date = new List<FareInfoTypeFareInfoDate>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Date")]
        public List<FareInfoTypeFareInfoDate> Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        public FareInfoTypeFareInfoFare Fare
        {
            get
            {
                return this._fare;
            }
            set
            {
                this._fare = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PTC")]
        public List<FareInfoTypeFareInfoPTC> PTC
        {
            get
            {
                return this._pTC;
            }
            set
            {
                this._pTC = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GlobalIndicatorType GlobalIndicatorCode
        {
            get
            {
                return this._globalIndicatorCode;
            }
            set
            {
                this._globalIndicatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaximumPermittedMileage
        {
            get
            {
                return this._maximumPermittedMileage;
            }
            set
            {
                this._maximumPermittedMileage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType TripType
        {
            get
            {
                return this._tripType;
            }
            set
            {
                this._tripType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this._fareType;
            }
            set
            {
                this._fareType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareStatusType FareStatus
        {
            get
            {
                return this._fareStatus;
            }
            set
            {
                this._fareStatus = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}