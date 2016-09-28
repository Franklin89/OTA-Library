using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RestaurantType
    {
        
        private RestaurantTypeMultimediaDescriptions _multimediaDescriptions;
        
        private RelativePositionType _relativePosition;
        
        private List<OperationSchedulesPlusChargeTypeOperationSchedule> _operationSchedules;
        
        private List<RestaurantTypeInfoCode> _infoCodes;
        
        private List<RestaurantTypeCuisineCode> _cuisineCodes;
        
        private string _descriptiveText;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _restaurantName;
        
        private string _maxSeatingCapacity;
        
        private string _maxSingleParty;
        
        private string _invCode;
        
        private bool _offerBreakfast;
        
        private bool _offerLunch;
        
        private bool _offerDinner;
        
        private bool _offerBrunch;
        
        private string _proximityCode;
        
        private string _id;
        
        private string _sort;
        
        private bool _reservationReqInd;
        
        private bool _featuredInd;
        
        public RestaurantType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._cuisineCodes = new List<RestaurantTypeCuisineCode>();
            this._infoCodes = new List<RestaurantTypeInfoCode>();
            this._operationSchedules = new List<OperationSchedulesPlusChargeTypeOperationSchedule>();
            this._relativePosition = new RelativePositionType();
            this._multimediaDescriptions = new RestaurantTypeMultimediaDescriptions();
        }
        
        public RestaurantTypeMultimediaDescriptions MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        public RelativePositionType RelativePosition
        {
            get
            {
                return this._relativePosition;
            }
            set
            {
                this._relativePosition = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationSchedule", IsNullable=false)]
        public List<OperationSchedulesPlusChargeTypeOperationSchedule> OperationSchedules
        {
            get
            {
                return this._operationSchedules;
            }
            set
            {
                this._operationSchedules = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("InfoCode", IsNullable=false)]
        public List<RestaurantTypeInfoCode> InfoCodes
        {
            get
            {
                return this._infoCodes;
            }
            set
            {
                this._infoCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CuisineCode", IsNullable=false)]
        public List<RestaurantTypeCuisineCode> CuisineCodes
        {
            get
            {
                return this._cuisineCodes;
            }
            set
            {
                this._cuisineCodes = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RestaurantName
        {
            get
            {
                return this._restaurantName;
            }
            set
            {
                this._restaurantName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxSeatingCapacity
        {
            get
            {
                return this._maxSeatingCapacity;
            }
            set
            {
                this._maxSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxSingleParty
        {
            get
            {
                return this._maxSingleParty;
            }
            set
            {
                this._maxSingleParty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OfferBreakfast
        {
            get
            {
                return this._offerBreakfast;
            }
            set
            {
                this._offerBreakfast = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OfferLunch
        {
            get
            {
                return this._offerLunch;
            }
            set
            {
                this._offerLunch = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OfferDinner
        {
            get
            {
                return this._offerDinner;
            }
            set
            {
                this._offerDinner = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OfferBrunch
        {
            get
            {
                return this._offerBrunch;
            }
            set
            {
                this._offerBrunch = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProximityCode
        {
            get
            {
                return this._proximityCode;
            }
            set
            {
                this._proximityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReservationReqInd
        {
            get
            {
                return this._reservationReqInd;
            }
            set
            {
                this._reservationReqInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FeaturedInd
        {
            get
            {
                return this._featuredInd;
            }
            set
            {
                this._featuredInd = value;
            }
        }
    }
}