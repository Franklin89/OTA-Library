namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListFeeTypeQualifiers
    {
        
        private CodeListFeeTypeQualifiersChargeUnit _chargeUnit;
        
        private System.DateTime _effectiveDateTime;
        
        private System.DateTime _expireDateTime;
        
        private string _maxAge;
        
        private string _minAge;
        
        public CodeListFeeTypeQualifiers()
        {
            this._chargeUnit = new CodeListFeeTypeQualifiersChargeUnit();
        }
        
        public CodeListFeeTypeQualifiersChargeUnit ChargeUnit
        {
            get
            {
                return this._chargeUnit;
            }
            set
            {
                this._chargeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EffectiveDateTime
        {
            get
            {
                return this._effectiveDateTime;
            }
            set
            {
                this._effectiveDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ExpireDateTime
        {
            get
            {
                return this._expireDateTime;
            }
            set
            {
                this._expireDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaxAge
        {
            get
            {
                return this._maxAge;
            }
            set
            {
                this._maxAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MinAge
        {
            get
            {
                return this._minAge;
            }
            set
            {
                this._minAge = value;
            }
        }
    }
}