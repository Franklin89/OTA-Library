using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailReservationType
    {
        
        private UniqueID_Type _uniqueID;
        
        private RailReservationTypeItinerary _itinerary;
        
        private List<RailPassengerCategoryDetailType> _passengerInfo;
        
        private List<MonetaryRuleType> _paymentRules;
        
        private CompanyNameType _fulfillment;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _lastHoldDate;
        
        public RailReservationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._fulfillment = new CompanyNameType();
            this._paymentRules = new List<MonetaryRuleType>();
            this._passengerInfo = new List<RailPassengerCategoryDetailType>();
            this._itinerary = new RailReservationTypeItinerary();
            this._uniqueID = new UniqueID_Type();
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public RailReservationTypeItinerary Itinerary
        {
            get
            {
                return this._itinerary;
            }
            set
            {
                this._itinerary = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerInfo")]
        public List<RailPassengerCategoryDetailType> PassengerInfo
        {
            get
            {
                return this._passengerInfo;
            }
            set
            {
                this._passengerInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable=false)]
        public List<MonetaryRuleType> PaymentRules
        {
            get
            {
                return this._paymentRules;
            }
            set
            {
                this._paymentRules = value;
            }
        }
        
        public CompanyNameType Fulfillment
        {
            get
            {
                return this._fulfillment;
            }
            set
            {
                this._fulfillment = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime LastHoldDate
        {
            get
            {
                return this._lastHoldDate;
            }
            set
            {
                this._lastHoldDate = value;
            }
        }
    }
}