namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BusSegmentType
    {
        
        private StationDetailsType _departureStation;
        
        private StationDetailsType _arrivalStation;
        
        private CompanyNameType _marketingCompany;
        
        private CompanyNameType _operatingCompany;
        
        private BusSegmentTypeEquipment _equipment;
        
        private BusInfoType _busInfo;
        
        private System.DateTime _departureDateTime;
        
        private System.DateTime _arrivalDateTime;
        
        private string _stopQuantity;
        
        private string _journeyDuration;
        
        private bool _crossBorderInd;
        
        public BusSegmentType()
        {
            this._busInfo = new BusInfoType();
            this._equipment = new BusSegmentTypeEquipment();
            this._operatingCompany = new CompanyNameType();
            this._marketingCompany = new CompanyNameType();
            this._arrivalStation = new StationDetailsType();
            this._departureStation = new StationDetailsType();
        }
        
        public StationDetailsType DepartureStation
        {
            get
            {
                return this._departureStation;
            }
            set
            {
                this._departureStation = value;
            }
        }
        
        public StationDetailsType ArrivalStation
        {
            get
            {
                return this._arrivalStation;
            }
            set
            {
                this._arrivalStation = value;
            }
        }
        
        public CompanyNameType MarketingCompany
        {
            get
            {
                return this._marketingCompany;
            }
            set
            {
                this._marketingCompany = value;
            }
        }
        
        public CompanyNameType OperatingCompany
        {
            get
            {
                return this._operatingCompany;
            }
            set
            {
                this._operatingCompany = value;
            }
        }
        
        public BusSegmentTypeEquipment Equipment
        {
            get
            {
                return this._equipment;
            }
            set
            {
                this._equipment = value;
            }
        }
        
        public BusInfoType BusInfo
        {
            get
            {
                return this._busInfo;
            }
            set
            {
                this._busInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this._departureDateTime;
            }
            set
            {
                this._departureDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this._arrivalDateTime;
            }
            set
            {
                this._arrivalDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StopQuantity
        {
            get
            {
                return this._stopQuantity;
            }
            set
            {
                this._stopQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string JourneyDuration
        {
            get
            {
                return this._journeyDuration;
            }
            set
            {
                this._journeyDuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CrossBorderInd
        {
            get
            {
                return this._crossBorderInd;
            }
            set
            {
                this._crossBorderInd = value;
            }
        }
    }
}