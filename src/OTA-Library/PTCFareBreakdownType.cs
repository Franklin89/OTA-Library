using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PTCFareBreakdownType
    {
        
        private PassengerTypeQuantityType _passengerTypeQuantity;
        
        private List<FareBasisCodeType> _fareBasisCodes;
        
        private List<PTCFareBreakdownTypePassengerFare> _passengerFare;
        
        private List<PTCFareBreakdownTypeTravelerRefNumber> _travelerRefNumber;
        
        private List<PTCFareBreakdownTypeTicketDesignator> _ticketDesignators;
        
        private PTCFareBreakdownTypeEndorsements _endorsements;
        
        private List<PTCFareBreakdownTypeFareInfo> _fareInfo;
        
        private List<PTCFareBreakdownTypePricingUnit> _pricingUnit;
        
        private PricingSourceType _pricingSource;
        
        private List<string> _flightRefNumberRPHList;
        
        public PTCFareBreakdownType()
        {
            this._flightRefNumberRPHList = new List<string>();
            this._pricingUnit = new List<PTCFareBreakdownTypePricingUnit>();
            this._fareInfo = new List<PTCFareBreakdownTypeFareInfo>();
            this._endorsements = new PTCFareBreakdownTypeEndorsements();
            this._ticketDesignators = new List<PTCFareBreakdownTypeTicketDesignator>();
            this._travelerRefNumber = new List<PTCFareBreakdownTypeTravelerRefNumber>();
            this._passengerFare = new List<PTCFareBreakdownTypePassengerFare>();
            this._fareBasisCodes = new List<FareBasisCodeType>();
            this._passengerTypeQuantity = new PassengerTypeQuantityType();
        }
        
        public PassengerTypeQuantityType PassengerTypeQuantity
        {
            get
            {
                return this._passengerTypeQuantity;
            }
            set
            {
                this._passengerTypeQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FareBasisCode", IsNullable=false)]
        public List<FareBasisCodeType> FareBasisCodes
        {
            get
            {
                return this._fareBasisCodes;
            }
            set
            {
                this._fareBasisCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerFare")]
        public List<PTCFareBreakdownTypePassengerFare> PassengerFare
        {
            get
            {
                return this._passengerFare;
            }
            set
            {
                this._passengerFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber")]
        public List<PTCFareBreakdownTypeTravelerRefNumber> TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable=false)]
        public List<PTCFareBreakdownTypeTicketDesignator> TicketDesignators
        {
            get
            {
                return this._ticketDesignators;
            }
            set
            {
                this._ticketDesignators = value;
            }
        }
        
        public PTCFareBreakdownTypeEndorsements Endorsements
        {
            get
            {
                return this._endorsements;
            }
            set
            {
                this._endorsements = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FareInfo")]
        public List<PTCFareBreakdownTypeFareInfo> FareInfo
        {
            get
            {
                return this._fareInfo;
            }
            set
            {
                this._fareInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PricingUnit")]
        public List<PTCFareBreakdownTypePricingUnit> PricingUnit
        {
            get
            {
                return this._pricingUnit;
            }
            set
            {
                this._pricingUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingSourceType PricingSource
        {
            get
            {
                return this._pricingSource;
            }
            set
            {
                this._pricingSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> FlightRefNumberRPHList
        {
            get
            {
                return this._flightRefNumberRPHList;
            }
            set
            {
                this._flightRefNumberRPHList = value;
            }
        }
    }
}