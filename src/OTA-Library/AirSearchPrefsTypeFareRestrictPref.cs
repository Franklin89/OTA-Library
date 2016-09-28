namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSearchPrefsTypeFareRestrictPref
    {
        
        private AdvResTicketingType _advResTicketing;
        
        private StayRestrictionsType _stayRestrictions;
        
        private VoluntaryChangesType _voluntaryChanges;
        
        private PreferLevelType _preferLevel;
        
        private string _fareRestriction;
        
        private string _date;
        
        private string _fareDisplayCurrency;
        
        private string _currencyOverride;
        
        public AirSearchPrefsTypeFareRestrictPref()
        {
            this._voluntaryChanges = new VoluntaryChangesType();
            this._stayRestrictions = new StayRestrictionsType();
            this._advResTicketing = new AdvResTicketingType();
        }
        
        public AdvResTicketingType AdvResTicketing
        {
            get
            {
                return this._advResTicketing;
            }
            set
            {
                this._advResTicketing = value;
            }
        }
        
        public StayRestrictionsType StayRestrictions
        {
            get
            {
                return this._stayRestrictions;
            }
            set
            {
                this._stayRestrictions = value;
            }
        }
        
        public VoluntaryChangesType VoluntaryChanges
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareRestriction
        {
            get
            {
                return this._fareRestriction;
            }
            set
            {
                this._fareRestriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
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
        public string FareDisplayCurrency
        {
            get
            {
                return this._fareDisplayCurrency;
            }
            set
            {
                this._fareDisplayCurrency = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyOverride
        {
            get
            {
                return this._currencyOverride;
            }
            set
            {
                this._currencyOverride = value;
            }
        }
    }
}