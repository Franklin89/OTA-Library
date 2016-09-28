namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryTypePriceRequestInformationSegmentOverride
    {
        
        private string _segmentNumber;
        
        private TravelerInfoSummaryTypePriceRequestInformationSegmentOverrideSegmentType _segmentType;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SegmentNumber
        {
            get
            {
                return this._segmentNumber;
            }
            set
            {
                this._segmentNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TravelerInfoSummaryTypePriceRequestInformationSegmentOverrideSegmentType SegmentType
        {
            get
            {
                return this._segmentType;
            }
            set
            {
                this._segmentType = value;
            }
        }
    }
}