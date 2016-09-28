using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItineraryItemResponseTypeAccommodation
    {
        
        private PropertyIdentityType _identity;
        
        private ItineraryItemResponseTypeAccommodationAccommodationClass _accommodationClass;
        
        private DateTimeSpanType _dateRange;
        
        private List<ItineraryItemResponseTypeAccommodationRoomProfile> _roomProfiles;
        
        private List<MealPlanType> _mealPlans;
        
        private string _rPH;
        
        private string _resortName;
        
        private string _resortCode;
        
        private string _destinationCode;
        
        private DestinationLevelType _destinationLevel;
        
        private string _destinationName;
        
        public ItineraryItemResponseTypeAccommodation()
        {
            this._mealPlans = new List<MealPlanType>();
            this._roomProfiles = new List<ItineraryItemResponseTypeAccommodationRoomProfile>();
            this._dateRange = new DateTimeSpanType();
            this._accommodationClass = new ItineraryItemResponseTypeAccommodationAccommodationClass();
            this._identity = new PropertyIdentityType();
        }
        
        public PropertyIdentityType Identity
        {
            get
            {
                return this._identity;
            }
            set
            {
                this._identity = value;
            }
        }
        
        public ItineraryItemResponseTypeAccommodationAccommodationClass AccommodationClass
        {
            get
            {
                return this._accommodationClass;
            }
            set
            {
                this._accommodationClass = value;
            }
        }
        
        public DateTimeSpanType DateRange
        {
            get
            {
                return this._dateRange;
            }
            set
            {
                this._dateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomProfile", IsNullable=false)]
        public List<ItineraryItemResponseTypeAccommodationRoomProfile> RoomProfiles
        {
            get
            {
                return this._roomProfiles;
            }
            set
            {
                this._roomProfiles = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("MealPlan", IsNullable=false)]
        public List<MealPlanType> MealPlans
        {
            get
            {
                return this._mealPlans;
            }
            set
            {
                this._mealPlans = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResortName
        {
            get
            {
                return this._resortName;
            }
            set
            {
                this._resortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResortCode
        {
            get
            {
                return this._resortCode;
            }
            set
            {
                this._resortCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCode
        {
            get
            {
                return this._destinationCode;
            }
            set
            {
                this._destinationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DestinationLevelType DestinationLevel
        {
            get
            {
                return this._destinationLevel;
            }
            set
            {
                this._destinationLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationName
        {
            get
            {
                return this._destinationName;
            }
            set
            {
                this._destinationName = value;
            }
        }
    }
}