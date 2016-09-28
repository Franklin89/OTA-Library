namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateRulesTypePickupReturnRules
    {
        
        private RateRulesTypePickupReturnRulesEarliestPickup _earliestPickup;
        
        private RateRulesTypePickupReturnRulesLatestPickup _latestPickup;
        
        private RateRulesTypePickupReturnRulesLatestReturn _latestReturn;
        
        private RateRulesTypePickupReturnRulesEarliestReturn _earliestReturn;
        
        private DayOfWeekType _dayOfWeek;
        
        private string _minimumKeep;
        
        private string _maximumKeep;
        
        private string _maximumRental;
        
        private bool _overnightInd;
        
        private bool _returnAllowedInd;
        
        public RateRulesTypePickupReturnRules()
        {
            this._earliestReturn = new RateRulesTypePickupReturnRulesEarliestReturn();
            this._latestReturn = new RateRulesTypePickupReturnRulesLatestReturn();
            this._latestPickup = new RateRulesTypePickupReturnRulesLatestPickup();
            this._earliestPickup = new RateRulesTypePickupReturnRulesEarliestPickup();
        }
        
        public RateRulesTypePickupReturnRulesEarliestPickup EarliestPickup
        {
            get
            {
                return this._earliestPickup;
            }
            set
            {
                this._earliestPickup = value;
            }
        }
        
        public RateRulesTypePickupReturnRulesLatestPickup LatestPickup
        {
            get
            {
                return this._latestPickup;
            }
            set
            {
                this._latestPickup = value;
            }
        }
        
        public RateRulesTypePickupReturnRulesLatestReturn LatestReturn
        {
            get
            {
                return this._latestReturn;
            }
            set
            {
                this._latestReturn = value;
            }
        }
        
        public RateRulesTypePickupReturnRulesEarliestReturn EarliestReturn
        {
            get
            {
                return this._earliestReturn;
            }
            set
            {
                this._earliestReturn = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DayOfWeek
        {
            get
            {
                return this._dayOfWeek;
            }
            set
            {
                this._dayOfWeek = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MinimumKeep
        {
            get
            {
                return this._minimumKeep;
            }
            set
            {
                this._minimumKeep = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaximumKeep
        {
            get
            {
                return this._maximumKeep;
            }
            set
            {
                this._maximumKeep = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string MaximumRental
        {
            get
            {
                return this._maximumRental;
            }
            set
            {
                this._maximumRental = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OvernightInd
        {
            get
            {
                return this._overnightInd;
            }
            set
            {
                this._overnightInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnAllowedInd
        {
            get
            {
                return this._returnAllowedInd;
            }
            set
            {
                this._returnAllowedInd = value;
            }
        }
    }
}