namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PkgTravelSegment
    {
        
        private PkgAirSegmentType _airSegment;
        
        public PkgTravelSegment()
        {
            this._airSegment = new PkgAirSegmentType();
        }
        
        public PkgAirSegmentType AirSegment
        {
            get
            {
                return this._airSegment;
            }
            set
            {
                this._airSegment = value;
            }
        }
    }
}