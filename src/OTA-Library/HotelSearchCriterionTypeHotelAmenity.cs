namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeHotelAmenity
    {
        
        private string _code;
        
        private bool _complimentaryInd;
        
        private string _equivalenceGroup;
        
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
        public bool ComplimentaryInd
        {
            get
            {
                return this._complimentaryInd;
            }
            set
            {
                this._complimentaryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string EquivalenceGroup
        {
            get
            {
                return this._equivalenceGroup;
            }
            set
            {
                this._equivalenceGroup = value;
            }
        }
    }
}