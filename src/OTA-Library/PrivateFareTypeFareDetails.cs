using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PrivateFareTypeFareDetails
    {
        
        private List_GlobalIndicatorType _globalIndicatorCode;
        
        private List_DataActionType _operation;
        
        private List_FareStatus _fareStatus;
        
        private List_AirTripType _tripType;
        
        private List<PrivateFareTypeFareDetailsDate> _date;
        
        private PrivateFareTypeFareDetailsFare _fare;
        
        private List<PrivateFareTypeFareDetailsPassengerType> _passengerType;
        
        private string _fareBasisCode;
        
        private string _fareDescription;
        
        private string _fareType;
        
        private string _maxPermittedMileage;
        
        private string _rPH;
        
        public PrivateFareTypeFareDetails()
        {
            this._passengerType = new List<PrivateFareTypeFareDetailsPassengerType>();
            this._fare = new PrivateFareTypeFareDetailsFare();
            this._date = new List<PrivateFareTypeFareDetailsDate>();
            this._tripType = new List_AirTripType();
            this._fareStatus = new List_FareStatus();
            this._operation = new List_DataActionType();
            this._globalIndicatorCode = new List_GlobalIndicatorType();
        }
        
        public List_GlobalIndicatorType GlobalIndicatorCode
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
        
        public List_DataActionType Operation
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
        
        public List_FareStatus FareStatus
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
        
        public List_AirTripType TripType
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
        
        [System.Xml.Serialization.XmlElementAttribute("Date")]
        public List<PrivateFareTypeFareDetailsDate> Date
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
        
        public PrivateFareTypeFareDetailsFare Fare
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
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerType")]
        public List<PrivateFareTypeFareDetailsPassengerType> PassengerType
        {
            get
            {
                return this._passengerType;
            }
            set
            {
                this._passengerType = value;
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
        public string FareDescription
        {
            get
            {
                return this._fareDescription;
            }
            set
            {
                this._fareDescription = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxPermittedMileage
        {
            get
            {
                return this._maxPermittedMileage;
            }
            set
            {
                this._maxPermittedMileage = value;
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