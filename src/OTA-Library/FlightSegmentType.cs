namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookFlightSegmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FlightSegmentType : FlightSegmentBaseType
    {
        
        private FlightSegmentTypeMarketingAirline _marketingAirline;
        
        private string _flightNumber;
        
        private string _tourOperatorFlightID;
        
        private bool _governmentApprovalInd;
        
        private string _governmentApprovalText;
        
        private string _flownMileageQty;
        
        private string _fareBasisCode;
        
        private string _resBookDesigCode;
        
        public FlightSegmentType()
        {
            this._marketingAirline = new FlightSegmentTypeMarketingAirline();
        }
        
        public FlightSegmentTypeMarketingAirline MarketingAirline
        {
            get
            {
                return this._marketingAirline;
            }
            set
            {
                this._marketingAirline = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightNumber
        {
            get
            {
                return this._flightNumber;
            }
            set
            {
                this._flightNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourOperatorFlightID
        {
            get
            {
                return this._tourOperatorFlightID;
            }
            set
            {
                this._tourOperatorFlightID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GovernmentApprovalInd
        {
            get
            {
                return this._governmentApprovalInd;
            }
            set
            {
                this._governmentApprovalInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GovernmentApprovalText
        {
            get
            {
                return this._governmentApprovalText;
            }
            set
            {
                this._governmentApprovalText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string FlownMileageQty
        {
            get
            {
                return this._flownMileageQty;
            }
            set
            {
                this._flownMileageQty = value;
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
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
            }
        }
    }
}