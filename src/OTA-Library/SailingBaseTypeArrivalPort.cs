namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingBaseTypeArrivalPort : LocationType
    {
        
        private System.DateTime _debarkationDateTime;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DebarkationDateTime
        {
            get
            {
                return this._debarkationDateTime;
            }
            set
            {
                this._debarkationDateTime = value;
            }
        }
    }
}