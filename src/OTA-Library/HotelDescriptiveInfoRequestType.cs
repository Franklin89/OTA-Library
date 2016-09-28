using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestType
    {
        
        private HotelDescriptiveInfoRequestTypeHotelInfo _hotelInfo;
        
        private HotelDescriptiveInfoRequestTypeFacilityInfo _facilityInfo;
        
        private HotelDescriptiveInfoRequestTypePolicies _policies;
        
        private HotelDescriptiveInfoRequestTypeAreaInfo _areaInfo;
        
        private HotelDescriptiveInfoRequestTypeAffiliationInfo _affiliationInfo;
        
        private HotelDescriptiveInfoRequestTypeContactInfo _contactInfo;
        
        private HotelDescriptiveInfoRequestTypeMultimediaObjects _multimediaObjects;
        
        private List<HotelDescriptiveInfoRequestTypeContentInfo> _contentInfos;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _chainCode;
        
        private string _brandCode;
        
        private string _hotelCode;
        
        private string _hotelCityCode;
        
        private string _hotelName;
        
        private string _hotelCodeContext;
        
        private string _chainName;
        
        private string _brandName;
        
        private string _areaID;
        
        private string _tTIcode;
        
        public HotelDescriptiveInfoRequestType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._contentInfos = new List<HotelDescriptiveInfoRequestTypeContentInfo>();
            this._multimediaObjects = new HotelDescriptiveInfoRequestTypeMultimediaObjects();
            this._contactInfo = new HotelDescriptiveInfoRequestTypeContactInfo();
            this._affiliationInfo = new HotelDescriptiveInfoRequestTypeAffiliationInfo();
            this._areaInfo = new HotelDescriptiveInfoRequestTypeAreaInfo();
            this._policies = new HotelDescriptiveInfoRequestTypePolicies();
            this._facilityInfo = new HotelDescriptiveInfoRequestTypeFacilityInfo();
            this._hotelInfo = new HotelDescriptiveInfoRequestTypeHotelInfo();
        }
        
        public HotelDescriptiveInfoRequestTypeHotelInfo HotelInfo
        {
            get
            {
                return this._hotelInfo;
            }
            set
            {
                this._hotelInfo = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypeFacilityInfo FacilityInfo
        {
            get
            {
                return this._facilityInfo;
            }
            set
            {
                this._facilityInfo = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypePolicies Policies
        {
            get
            {
                return this._policies;
            }
            set
            {
                this._policies = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypeAreaInfo AreaInfo
        {
            get
            {
                return this._areaInfo;
            }
            set
            {
                this._areaInfo = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypeAffiliationInfo AffiliationInfo
        {
            get
            {
                return this._affiliationInfo;
            }
            set
            {
                this._affiliationInfo = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypeContactInfo ContactInfo
        {
            get
            {
                return this._contactInfo;
            }
            set
            {
                this._contactInfo = value;
            }
        }
        
        public HotelDescriptiveInfoRequestTypeMultimediaObjects MultimediaObjects
        {
            get
            {
                return this._multimediaObjects;
            }
            set
            {
                this._multimediaObjects = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ContentInfo", IsNullable=false)]
        public List<HotelDescriptiveInfoRequestTypeContentInfo> ContentInfos
        {
            get
            {
                return this._contentInfos;
            }
            set
            {
                this._contentInfos = value;
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
        public string ChainCode
        {
            get
            {
                return this._chainCode;
            }
            set
            {
                this._chainCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this._brandCode;
            }
            set
            {
                this._brandCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this._hotelCode;
            }
            set
            {
                this._hotelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this._hotelCityCode;
            }
            set
            {
                this._hotelCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this._hotelName;
            }
            set
            {
                this._hotelName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this._hotelCodeContext;
            }
            set
            {
                this._hotelCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this._chainName;
            }
            set
            {
                this._chainName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this._brandName;
            }
            set
            {
                this._brandName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaID
        {
            get
            {
                return this._areaID;
            }
            set
            {
                this._areaID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TTIcode
        {
            get
            {
                return this._tTIcode;
            }
            set
            {
                this._tTIcode = value;
            }
        }
    }
}