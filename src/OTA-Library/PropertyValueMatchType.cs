using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PropertyValueMatchType : BasicPropertyInfoType
    {
        
        private List<PropertyValueMatchTypeSearchValueMatch> _searchValueMatch;
        
        private List<PropertyValueMatchTypeAmenity> _amenities;
        
        private PropertyValueMatchTypeRateRange _rateRange;
        
        private string _moreDataEchoToken;
        
        private bool _sameCountryInd;
        
        private RateIndicatorType _availabilityStatus;
        
        public PropertyValueMatchType()
        {
            this._rateRange = new PropertyValueMatchTypeRateRange();
            this._amenities = new List<PropertyValueMatchTypeAmenity>();
            this._searchValueMatch = new List<PropertyValueMatchTypeSearchValueMatch>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SearchValueMatch")]
        public List<PropertyValueMatchTypeSearchValueMatch> SearchValueMatch
        {
            get
            {
                return this._searchValueMatch;
            }
            set
            {
                this._searchValueMatch = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable=false)]
        public List<PropertyValueMatchTypeAmenity> Amenities
        {
            get
            {
                return this._amenities;
            }
            set
            {
                this._amenities = value;
            }
        }
        
        public PropertyValueMatchTypeRateRange RateRange
        {
            get
            {
                return this._rateRange;
            }
            set
            {
                this._rateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreDataEchoToken
        {
            get
            {
                return this._moreDataEchoToken;
            }
            set
            {
                this._moreDataEchoToken = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SameCountryInd
        {
            get
            {
                return this._sameCountryInd;
            }
            set
            {
                this._sameCountryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateIndicatorType AvailabilityStatus
        {
            get
            {
                return this._availabilityStatus;
            }
            set
            {
                this._availabilityStatus = value;
            }
        }
    }
}