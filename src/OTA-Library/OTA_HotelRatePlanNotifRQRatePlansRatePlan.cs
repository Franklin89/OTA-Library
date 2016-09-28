namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelRatePlanNotifRQRatePlansRatePlan : HotelRatePlanType
    {
        
        private RatePlanInclusionsType _ratePlanInclusions;
        
        public OTA_HotelRatePlanNotifRQRatePlansRatePlan()
        {
            this._ratePlanInclusions = new RatePlanInclusionsType();
        }
        
        public RatePlanInclusionsType RatePlanInclusions
        {
            get
            {
                return this._ratePlanInclusions;
            }
            set
            {
                this._ratePlanInclusions = value;
            }
        }
    }
}