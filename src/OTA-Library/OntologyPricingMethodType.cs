namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyPricingMethodType
    {
        
        private bool _inclusiveInd;
        
        private bool _approximateInd;
        
        private string _otherType;
        
        private string _ontologyRefID;
        
        private List_OfferPricingType _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InclusiveInd
        {
            get
            {
                return this._inclusiveInd;
            }
            set
            {
                this._inclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ApproximateInd
        {
            get
            {
                return this._approximateInd;
            }
            set
            {
                this._approximateInd = value;
            }
        }
        
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
        public List_OfferPricingType Value
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