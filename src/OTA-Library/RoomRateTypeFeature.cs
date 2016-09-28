using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomRateTypeFeature
    {
        
        private List<ParagraphType> _description;
        
        private string _roomAmenity;
        
        private string _quantity;
        
        private string _roomViewCode;
        
        private string _accessibilityCode;
        
        public RoomRateTypeFeature()
        {
            this._description = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        public string RoomViewCode
        {
            get
            {
                return this._roomViewCode;
            }
            set
            {
                this._roomViewCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccessibilityCode
        {
            get
            {
                return this._accessibilityCode;
            }
            set
            {
                this._accessibilityCode = value;
            }
        }
    }
}