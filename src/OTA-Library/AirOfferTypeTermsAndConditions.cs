namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirOfferTypeTermsAndConditions
    {
        
        private AirOfferTypeTermsAndConditionsVoluntaryChanges _voluntaryChanges;
        
        private AirOfferTypeTermsAndConditionsVoluntaryRefunds _voluntaryRefunds;
        
        private string _other;
        
        private bool _refundableInd;
        
        private bool _reusableFundsInd;
        
        public AirOfferTypeTermsAndConditions()
        {
            this._voluntaryRefunds = new AirOfferTypeTermsAndConditionsVoluntaryRefunds();
            this._voluntaryChanges = new AirOfferTypeTermsAndConditionsVoluntaryChanges();
        }
        
        public AirOfferTypeTermsAndConditionsVoluntaryChanges VoluntaryChanges
        {
            get
            {
                return this._voluntaryChanges;
            }
            set
            {
                this._voluntaryChanges = value;
            }
        }
        
        public AirOfferTypeTermsAndConditionsVoluntaryRefunds VoluntaryRefunds
        {
            get
            {
                return this._voluntaryRefunds;
            }
            set
            {
                this._voluntaryRefunds = value;
            }
        }
        
        public string Other
        {
            get
            {
                return this._other;
            }
            set
            {
                this._other = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RefundableInd
        {
            get
            {
                return this._refundableInd;
            }
            set
            {
                this._refundableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReusableFundsInd
        {
            get
            {
                return this._reusableFundsInd;
            }
            set
            {
                this._reusableFundsInd = value;
            }
        }
    }
}