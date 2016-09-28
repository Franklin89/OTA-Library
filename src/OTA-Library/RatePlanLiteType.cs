using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanLiteType
    {
        
        private List<GuaranteeType> _guarantee;
        
        private ParagraphType _ratePlanDescription;
        
        private string _ratePlanCode;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        private RateIndicatorType _rateIndicator;
        
        private string _ratePlanType;
        
        private string _ratePlanID;
        
        public RatePlanLiteType()
        {
            this._ratePlanDescription = new ParagraphType();
            this._guarantee = new List<GuaranteeType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Guarantee")]
        public List<GuaranteeType> Guarantee
        {
            get
            {
                return this._guarantee;
            }
            set
            {
                this._guarantee = value;
            }
        }
        
        public ParagraphType RatePlanDescription
        {
            get
            {
                return this._ratePlanDescription;
            }
            set
            {
                this._ratePlanDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateIndicatorType RateIndicator
        {
            get
            {
                return this._rateIndicator;
            }
            set
            {
                this._rateIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanType
        {
            get
            {
                return this._ratePlanType;
            }
            set
            {
                this._ratePlanType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanID
        {
            get
            {
                return this._ratePlanID;
            }
            set
            {
                this._ratePlanID = value;
            }
        }
    }
}