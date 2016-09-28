namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationServiceTypeAccommodationDetail : RailAccommDetailType
    {
        
        private string _referenceTravelerRPH;
        
        private bool _referenceInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceTravelerRPH
        {
            get
            {
                return this._referenceTravelerRPH;
            }
            set
            {
                this._referenceTravelerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReferenceInd
        {
            get
            {
                return this._referenceInd;
            }
            set
            {
                this._referenceInd = value;
            }
        }
    }
}