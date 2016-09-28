using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoTypeGuestRoomsGuestRoom
    {
        
        private List<FacilityInfoTypeGuestRoomsGuestRoomTypeRoom> _typeRoom;
        
        private List<FacilityInfoTypeGuestRoomsGuestRoomAmenity> _amenities;
        
        private List<FeaturesTypeFeature> _features;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private string _descriptiveText;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        private string _roomTypeName;
        
        private bool _composite;
        
        private string _quality;
        
        private string _maxOccupancy;
        
        private string _minOccupancy;
        
        private string _maxAdultOccupancy;
        
        private string _nonsmokingQuantity;
        
        private string _id;
        
        private string _maxChildOccupancy;
        
        private string _sort;
        
        private string _language;
        
        public FacilityInfoTypeGuestRoomsGuestRoom()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._features = new List<FeaturesTypeFeature>();
            this._amenities = new List<FacilityInfoTypeGuestRoomsGuestRoomAmenity>();
            this._typeRoom = new List<FacilityInfoTypeGuestRoomsGuestRoomTypeRoom>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TypeRoom")]
        public List<FacilityInfoTypeGuestRoomsGuestRoomTypeRoom> TypeRoom
        {
            get
            {
                return this._typeRoom;
            }
            set
            {
                this._typeRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable=false)]
        public List<FacilityInfoTypeGuestRoomsGuestRoomAmenity> Amenities
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public List<FeaturesTypeFeature> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeName
        {
            get
            {
                return this._roomTypeName;
            }
            set
            {
                this._roomTypeName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Composite
        {
            get
            {
                return this._composite;
            }
            set
            {
                this._composite = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Quality
        {
            get
            {
                return this._quality;
            }
            set
            {
                this._quality = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MinOccupancy
        {
            get
            {
                return this._minOccupancy;
            }
            set
            {
                this._minOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxAdultOccupancy
        {
            get
            {
                return this._maxAdultOccupancy;
            }
            set
            {
                this._maxAdultOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NonsmokingQuantity
        {
            get
            {
                return this._nonsmokingQuantity;
            }
            set
            {
                this._nonsmokingQuantity = value;
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
        public string MaxChildOccupancy
        {
            get
            {
                return this._maxChildOccupancy;
            }
            set
            {
                this._maxChildOccupancy = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
    }
}