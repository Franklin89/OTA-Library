namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveInfoRequestTypeAreaInfo
    {
        
        private bool _sendRefPoints;
        
        private bool _sendAttractions;
        
        private bool _sendRecreations;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendRefPoints
        {
            get
            {
                return this._sendRefPoints;
            }
            set
            {
                this._sendRefPoints = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendAttractions
        {
            get
            {
                return this._sendAttractions;
            }
            set
            {
                this._sendAttractions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SendRecreations
        {
            get
            {
                return this._sendRecreations;
            }
            set
            {
                this._sendRecreations = value;
            }
        }
    }
}