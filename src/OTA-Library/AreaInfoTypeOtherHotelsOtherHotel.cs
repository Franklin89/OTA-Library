using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeOtherHotelsOtherHotel
    {
        
        private List<ContactInfoRootType> _contactInfos;
        
        private List<RefPointsTypeRefPoint> _refPoints;
        
        private bool _competitorIndicator;
        
        private string _segmentCategoryCode;
        
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
        
        private string _id;
        
        private string _alternateID;
        
        private string _hotelReferenceRPH;
        
        public AreaInfoTypeOtherHotelsOtherHotel()
        {
            this._refPoints = new List<RefPointsTypeRefPoint>();
            this._contactInfos = new List<ContactInfoRootType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactInfo", IsNullable=false)]
        public List<ContactInfoRootType> ContactInfos
        {
            get
            {
                return this._contactInfos;
            }
            set
            {
                this._contactInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RefPoint", IsNullable=false)]
        public List<RefPointsTypeRefPoint> RefPoints
        {
            get
            {
                return this._refPoints;
            }
            set
            {
                this._refPoints = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CompetitorIndicator
        {
            get
            {
                return this._competitorIndicator;
            }
            set
            {
                this._competitorIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SegmentCategoryCode
        {
            get
            {
                return this._segmentCategoryCode;
            }
            set
            {
                this._segmentCategoryCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AlternateID
        {
            get
            {
                return this._alternateID;
            }
            set
            {
                this._alternateID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelReferenceRPH
        {
            get
            {
                return this._hotelReferenceRPH;
            }
            set
            {
                this._hotelReferenceRPH = value;
            }
        }
    }
}