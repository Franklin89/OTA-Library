namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomAmenityPrefType
    {
        
        private PreferLevelType _preferLevel;
        
        private string _roomAmenity;
        
        private string _existsCode;
        
        private string _quantity;
        
        private string _qualityLevel;
        
        private RoomAmenityPrefTypeRoomGender _roomGender;
        
        private bool _sharedRoomInd;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomAmenity
        {
            get
            {
                return this._roomAmenity;
            }
            set
            {
                this._roomAmenity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this._existsCode;
            }
            set
            {
                this._existsCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QualityLevel
        {
            get
            {
                return this._qualityLevel;
            }
            set
            {
                this._qualityLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RoomAmenityPrefTypeRoomGender RoomGender
        {
            get
            {
                return this._roomGender;
            }
            set
            {
                this._roomGender = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SharedRoomInd
        {
            get
            {
                return this._sharedRoomInd;
            }
            set
            {
                this._sharedRoomInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}