namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccommodationDetailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationInfoType
    {
        
        private PropertyIdentityType _property;
        
        private AccommodationInfoTypeResort _resort;
        
        private AccommodationInfoTypeAccommodationClass _accommodationClass;
        
        private SourceIdentificationType _sourceIdentification;
        
        private URL_Type _contentInfo;
        
        private string _packageID;
        
        private string _minChildAge;
        
        private string _maxChildAge;
        
        private string _baseMealPlan;
        
        public AccommodationInfoType()
        {
            this._contentInfo = new URL_Type();
            this._sourceIdentification = new SourceIdentificationType();
            this._accommodationClass = new AccommodationInfoTypeAccommodationClass();
            this._resort = new AccommodationInfoTypeResort();
            this._property = new PropertyIdentityType();
        }
        
        public PropertyIdentityType Property
        {
            get
            {
                return this._property;
            }
            set
            {
                this._property = value;
            }
        }
        
        public AccommodationInfoTypeResort Resort
        {
            get
            {
                return this._resort;
            }
            set
            {
                this._resort = value;
            }
        }
        
        public AccommodationInfoTypeAccommodationClass AccommodationClass
        {
            get
            {
                return this._accommodationClass;
            }
            set
            {
                this._accommodationClass = value;
            }
        }
        
        public SourceIdentificationType SourceIdentification
        {
            get
            {
                return this._sourceIdentification;
            }
            set
            {
                this._sourceIdentification = value;
            }
        }
        
        public URL_Type ContentInfo
        {
            get
            {
                return this._contentInfo;
            }
            set
            {
                this._contentInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageID
        {
            get
            {
                return this._packageID;
            }
            set
            {
                this._packageID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinChildAge
        {
            get
            {
                return this._minChildAge;
            }
            set
            {
                this._minChildAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxChildAge
        {
            get
            {
                return this._maxChildAge;
            }
            set
            {
                this._maxChildAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BaseMealPlan
        {
            get
            {
                return this._baseMealPlan;
            }
            set
            {
                this._baseMealPlan = value;
            }
        }
    }
}