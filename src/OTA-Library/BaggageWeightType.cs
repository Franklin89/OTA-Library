namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaggageWeightType : List_UnitOfMeasure
    {
        
        private bool _approxInd;
        
        private decimal _weight;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ApproxInd
        {
            get
            {
                return this._approxInd;
            }
            set
            {
                this._approxInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
    }
}