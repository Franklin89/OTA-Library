namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaseInvCountTypeInvCountInvBlockCutoff
    {
        
        private string _absoluteCutoff;
        
        private string _offsetDuration;
        
        private BookingRulesTypeBookingRuleOffsetCalculationMode _offsetCalculationMode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteCutoff
        {
            get
            {
                return this._absoluteCutoff;
            }
            set
            {
                this._absoluteCutoff = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string OffsetDuration
        {
            get
            {
                return this._offsetDuration;
            }
            set
            {
                this._offsetDuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookingRulesTypeBookingRuleOffsetCalculationMode OffsetCalculationMode
        {
            get
            {
                return this._offsetCalculationMode;
            }
            set
            {
                this._offsetCalculationMode = value;
            }
        }
    }
}