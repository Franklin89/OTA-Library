namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class IndCoverageReqsTypePreexistingCondition : FreeTextType
    {
        
        private System.DateTime _diagnosisDate;
        
        private System.DateTime _lastTreatmentDate;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime DiagnosisDate
        {
            get
            {
                return this._diagnosisDate;
            }
            set
            {
                this._diagnosisDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime LastTreatmentDate
        {
            get
            {
                return this._lastTreatmentDate;
            }
            set
            {
                this._lastTreatmentDate = value;
            }
        }
    }
}