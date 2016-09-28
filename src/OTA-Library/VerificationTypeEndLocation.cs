namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VerificationTypeEndLocation : LocationType
    {
        
        private System.DateTime _associatedDateTime;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime AssociatedDateTime
        {
            get
            {
                return this._associatedDateTime;
            }
            set
            {
                this._associatedDateTime = value;
            }
        }
    }
}