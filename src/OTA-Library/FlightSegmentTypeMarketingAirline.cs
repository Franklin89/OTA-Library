namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FlightSegmentTypeMarketingAirline : CompanyNameType
    {
        
        private CertificationTypeSingleVendorInd _singleVendorInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CertificationTypeSingleVendorInd SingleVendorInd
        {
            get
            {
                return this._singleVendorInd;
            }
            set
            {
                this._singleVendorInd = value;
            }
        }
    }
}