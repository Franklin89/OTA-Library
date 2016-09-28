using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketingCabinType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinAvailabilityType
    {
        
        private List<CabinAvailabilityTypeMeal> _meal;
        
        private CabinAvailabilityTypeBaggageAllowance _baggageAllowance;
        
        private List<CabinAvailabilityTypeEntertainment> _entertainment;
        
        private CabinAvailabilityTypeFlightLoadInfo _flightLoadInfo;
        
        private string _cabinType;
        
        private string _cabinCapacity;
        
        public CabinAvailabilityType()
        {
            this._flightLoadInfo = new CabinAvailabilityTypeFlightLoadInfo();
            this._entertainment = new List<CabinAvailabilityTypeEntertainment>();
            this._baggageAllowance = new CabinAvailabilityTypeBaggageAllowance();
            this._meal = new List<CabinAvailabilityTypeMeal>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Meal")]
        public List<CabinAvailabilityTypeMeal> Meal
        {
            get
            {
                return this._meal;
            }
            set
            {
                this._meal = value;
            }
        }
        
        public CabinAvailabilityTypeBaggageAllowance BaggageAllowance
        {
            get
            {
                return this._baggageAllowance;
            }
            set
            {
                this._baggageAllowance = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Entertainment")]
        public List<CabinAvailabilityTypeEntertainment> Entertainment
        {
            get
            {
                return this._entertainment;
            }
            set
            {
                this._entertainment = value;
            }
        }
        
        public CabinAvailabilityTypeFlightLoadInfo FlightLoadInfo
        {
            get
            {
                return this._flightLoadInfo;
            }
            set
            {
                this._flightLoadInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinType
        {
            get
            {
                return this._cabinType;
            }
            set
            {
                this._cabinType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string CabinCapacity
        {
            get
            {
                return this._cabinCapacity;
            }
            set
            {
                this._cabinCapacity = value;
            }
        }
    }
}