using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MeetingRoomsTypeMeetingRoom
    {
        
        private List<MeetingRoomCodeType> _codes;
        
        private MeetingRoomsTypeMeetingRoomDimension _dimension;
        
        private List<MeetingRoomCapacityType> _availableCapacities;
        
        private List<FeaturesTypeFeature> _features;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private bool _irregular;
        
        private string _propertySystemName;
        
        private string _roomName;
        
        private string _sort;
        
        private string _meetingRoomCapacity;
        
        private bool _removal;
        
        private string _id;
        
        private string _access;
        
        private string _meetingRoomTypeCode;
        
        private string _meetingRoomLevel;
        
        private bool _dedicatedIndicator;
        
        private bool _featuredInd;
        
        public MeetingRoomsTypeMeetingRoom()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._features = new List<FeaturesTypeFeature>();
            this._availableCapacities = new List<MeetingRoomCapacityType>();
            this._dimension = new MeetingRoomsTypeMeetingRoomDimension();
            this._codes = new List<MeetingRoomCodeType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Code", IsNullable=false)]
        public List<MeetingRoomCodeType> Codes
        {
            get
            {
                return this._codes;
            }
            set
            {
                this._codes = value;
            }
        }
        
        public MeetingRoomsTypeMeetingRoomDimension Dimension
        {
            get
            {
                return this._dimension;
            }
            set
            {
                this._dimension = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("MeetingRoomCapacity", IsNullable=false)]
        public List<MeetingRoomCapacityType> AvailableCapacities
        {
            get
            {
                return this._availableCapacities;
            }
            set
            {
                this._availableCapacities = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Irregular
        {
            get
            {
                return this._irregular;
            }
            set
            {
                this._irregular = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertySystemName
        {
            get
            {
                return this._propertySystemName;
            }
            set
            {
                this._propertySystemName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomName
        {
            get
            {
                return this._roomName;
            }
            set
            {
                this._roomName = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MeetingRoomCapacity
        {
            get
            {
                return this._meetingRoomCapacity;
            }
            set
            {
                this._meetingRoomCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
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
        public string Access
        {
            get
            {
                return this._access;
            }
            set
            {
                this._access = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeetingRoomTypeCode
        {
            get
            {
                return this._meetingRoomTypeCode;
            }
            set
            {
                this._meetingRoomTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeetingRoomLevel
        {
            get
            {
                return this._meetingRoomLevel;
            }
            set
            {
                this._meetingRoomLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DedicatedIndicator
        {
            get
            {
                return this._dedicatedIndicator;
            }
            set
            {
                this._dedicatedIndicator = value;
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