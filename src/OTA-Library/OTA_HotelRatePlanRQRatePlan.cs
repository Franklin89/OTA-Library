using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanRQRatePlan
    {
        
        private OTA_HotelRatePlanRQRatePlanDateRange _dateRange;
        
        private List<DestinationSystemCodesTypeDestinationSystemCode> _destinationSystemsCode;
        
        private List<RatePlanCandidatesTypeRatePlanCandidate> _ratePlanCandidates;
        
        private OTA_HotelRatePlanRQRatePlanOffers _offers;
        
        private OTA_HotelRatePlanRQRatePlanHotelRef _hotelRef;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public OTA_HotelRatePlanRQRatePlan()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._hotelRef = new OTA_HotelRatePlanRQRatePlanHotelRef();
            this._offers = new OTA_HotelRatePlanRQRatePlanOffers();
            this._ratePlanCandidates = new List<RatePlanCandidatesTypeRatePlanCandidate>();
            this._destinationSystemsCode = new List<DestinationSystemCodesTypeDestinationSystemCode>();
            this._dateRange = new OTA_HotelRatePlanRQRatePlanDateRange();
        }
        
        public OTA_HotelRatePlanRQRatePlanDateRange DateRange
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<DestinationSystemCodesTypeDestinationSystemCode> DestinationSystemsCode
        {
            get
            {
                return this._destinationSystemsCode;
            }
            set
            {
                this._destinationSystemsCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlanCandidate", IsNullable=false)]
        public List<RatePlanCandidatesTypeRatePlanCandidate> RatePlanCandidates
        {
            get
            {
                return this._ratePlanCandidates;
            }
            set
            {
                this._ratePlanCandidates = value;
            }
        }
        
        public OTA_HotelRatePlanRQRatePlanOffers Offers
        {
            get
            {
                return this._offers;
            }
            set
            {
                this._offers = value;
            }
        }
        
        public OTA_HotelRatePlanRQRatePlanHotelRef HotelRef
        {
            get
            {
                return this._hotelRef;
            }
            set
            {
                this._hotelRef = value;
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
    }
}