namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingBaseTypeDeparturePort : LocationType
    {
        
        private System.DateTime _embarkationTime;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EmbarkationTime
        {
            get
            {
                return this._embarkationTime;
            }
            set
            {
                this._embarkationTime = value;
            }
        }
    }
}