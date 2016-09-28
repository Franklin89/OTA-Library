namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeSupplementPrerequisiteInventory
    {
        
        private string _invCode;
        
        private string _invType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
    }
}