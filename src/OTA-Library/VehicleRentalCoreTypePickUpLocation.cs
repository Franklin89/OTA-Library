namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRentalCoreTypePickUpLocation : LocationType
    {
        
        private string _extendedLocationCode;
        
        private string _counterLocation;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtendedLocationCode
        {
            get
            {
                return this._extendedLocationCode;
            }
            set
            {
                this._extendedLocationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CounterLocation
        {
            get
            {
                return this._counterLocation;
            }
            set
            {
                this._counterLocation = value;
            }
        }
    }
}