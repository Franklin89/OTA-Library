namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewershipDistributorType
    {
        
        private string _distributorCode;
        
        private string _distributorTypeCode;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistributorCode
        {
            get
            {
                return this._distributorCode;
            }
            set
            {
                this._distributorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistributorTypeCode
        {
            get
            {
                return this._distributorTypeCode;
            }
            set
            {
                this._distributorTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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