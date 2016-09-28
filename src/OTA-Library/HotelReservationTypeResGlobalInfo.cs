namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationTypeResGlobalInfo : ResGlobalInfoType
    {
        
        private BasicPropertyInfoType _basicPropertyInfo;
        
        public HotelReservationTypeResGlobalInfo()
        {
            this._basicPropertyInfo = new BasicPropertyInfoType();
        }
        
        public BasicPropertyInfoType BasicPropertyInfo
        {
            get
            {
                return this._basicPropertyInfo;
            }
            set
            {
                this._basicPropertyInfo = value;
            }
        }
    }
}