namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AuthorizationTypeBookingReferenceID : UniqueID_Type
    {
        
        private bool _ignoreReservationInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IgnoreReservationInd
        {
            get
            {
                return this._ignoreReservationInd;
            }
            set
            {
                this._ignoreReservationInd = value;
            }
        }
    }
}