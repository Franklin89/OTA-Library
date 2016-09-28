namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GDS_InfoTypeGDS_CodesGDS_CodeGDS_CodeDetail
    {
        
        private string _pseudoCityCode;
        
        private string _agencyName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this._pseudoCityCode;
            }
            set
            {
                this._pseudoCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgencyName
        {
            get
            {
                return this._agencyName;
            }
            set
            {
                this._agencyName = value;
            }
        }
    }
}