namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RequiredPaymentsTypeGuaranteePaymentDeadline
    {
        
        private string _absoluteDeadline;
        
        private TimeUnitType _offsetTimeUnit;
        
        private string _offsetUnitMultiplier;
        
        private RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime _offsetDropTime;
        
        private bool _overrideIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteDeadline
        {
            get
            {
                return this._absoluteDeadline;
            }
            set
            {
                this._absoluteDeadline = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType OffsetTimeUnit
        {
            get
            {
                return this._offsetTimeUnit;
            }
            set
            {
                this._offsetTimeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string OffsetUnitMultiplier
        {
            get
            {
                return this._offsetUnitMultiplier;
            }
            set
            {
                this._offsetUnitMultiplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime OffsetDropTime
        {
            get
            {
                return this._offsetDropTime;
            }
            set
            {
                this._offsetDropTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OverrideIndicator
        {
            get
            {
                return this._overrideIndicator;
            }
            set
            {
                this._overrideIndicator = value;
            }
        }
    }
}