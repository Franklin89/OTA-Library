namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoTypeAward
    {
        
        private bool _removal;
        
        private System.DateTime _date;
        
        private string _provider;
        
        private string _rating;
        
        private bool _officialAppointmentInd;
        
        private AffiliationInfoTypeAwardRatingSymbol _ratingSymbol;
        
        private string _rPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider
        {
            get
            {
                return this._provider;
            }
            set
            {
                this._provider = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rating
        {
            get
            {
                return this._rating;
            }
            set
            {
                this._rating = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OfficialAppointmentInd
        {
            get
            {
                return this._officialAppointmentInd;
            }
            set
            {
                this._officialAppointmentInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AffiliationInfoTypeAwardRatingSymbol RatingSymbol
        {
            get
            {
                return this._ratingSymbol;
            }
            set
            {
                this._ratingSymbol = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
    }
}