namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class NoShowFeeType
    {
        
        private NoShowFeeTypeDeadline _deadline;
        
        private NoShowFeeTypeGracePeriod _gracePeriod;
        
        private NoShowFeeTypeFeeAmount _feeAmount;
        
        private FormattedTextTextType _description;
        
        public NoShowFeeType()
        {
            this._description = new FormattedTextTextType();
            this._feeAmount = new NoShowFeeTypeFeeAmount();
            this._gracePeriod = new NoShowFeeTypeGracePeriod();
            this._deadline = new NoShowFeeTypeDeadline();
        }
        
        public NoShowFeeTypeDeadline Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        public NoShowFeeTypeGracePeriod GracePeriod
        {
            get
            {
                return this._gracePeriod;
            }
            set
            {
                this._gracePeriod = value;
            }
        }
        
        public NoShowFeeTypeFeeAmount FeeAmount
        {
            get
            {
                return this._feeAmount;
            }
            set
            {
                this._feeAmount = value;
            }
        }
        
        public FormattedTextTextType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}