namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeAirAccommodation : AirInfoType
    {
        
        private string _comment;
        
        private string _airAccommodationType;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirAccommodationType
        {
            get
            {
                return this._airAccommodationType;
            }
            set
            {
                this._airAccommodationType = value;
            }
        }
    }
}