namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyBookingMethodType
    {
        
        private string _otherType;
        
        private string _ontologyRefID;
        
        private List_OfferBookingMethod _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherType
        {
            get
            {
                return this._otherType;
            }
            set
            {
                this._otherType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public List_OfferBookingMethod Value
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