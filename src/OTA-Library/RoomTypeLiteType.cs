using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomTypeLiteType
    {
        
        private ParagraphType _roomDescription;
        
        private List<RoomAmenityPrefType> _amenity;
        
        private string _roomTypeCode;
        
        private string _numberOfUnits;
        
        public RoomTypeLiteType()
        {
            this._amenity = new List<RoomAmenityPrefType>();
            this._roomDescription = new ParagraphType();
        }
        
        public ParagraphType RoomDescription
        {
            get
            {
                return this._roomDescription;
            }
            set
            {
                this._roomDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Amenity")]
        public List<RoomAmenityPrefType> Amenity
        {
            get
            {
                return this._amenity;
            }
            set
            {
                this._amenity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this._roomTypeCode;
            }
            set
            {
                this._roomTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfUnits
        {
            get
            {
                return this._numberOfUnits;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }
    }
}