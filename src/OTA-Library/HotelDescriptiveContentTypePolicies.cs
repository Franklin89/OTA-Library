namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveContentTypePolicies : PoliciesType
    {
        
        private bool _guaranteeRoomTypeViaGDS;
        
        private bool _guaranteeRoomTypeViaCRC;
        
        private bool _guaranteeRoomTypeViaProperty;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeRoomTypeViaGDS
        {
            get
            {
                return this._guaranteeRoomTypeViaGDS;
            }
            set
            {
                this._guaranteeRoomTypeViaGDS = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeRoomTypeViaCRC
        {
            get
            {
                return this._guaranteeRoomTypeViaCRC;
            }
            set
            {
                this._guaranteeRoomTypeViaCRC = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeRoomTypeViaProperty
        {
            get
            {
                return this._guaranteeRoomTypeViaProperty;
            }
            set
            {
                this._guaranteeRoomTypeViaProperty = value;
            }
        }
    }
}