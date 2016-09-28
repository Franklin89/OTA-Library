using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirOfferType
    {
        
        private AncillaryServiceDetailType _serviceFamily;
        
        private List<AirOfferTypeRestriction> _restriction;
        
        private FormattedTextTextType _shortDescription;
        
        private List<AirOfferTypeTermsAndConditions> _termsAndConditions;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _id;
        
        private string _name;
        
        private bool _bundleInd;
        
        private string _bundleID;
        
        private bool _mandatoryInd;
        
        private bool _acceptInd;
        
        public AirOfferType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._termsAndConditions = new List<AirOfferTypeTermsAndConditions>();
            this._shortDescription = new FormattedTextTextType();
            this._restriction = new List<AirOfferTypeRestriction>();
            this._serviceFamily = new AncillaryServiceDetailType();
        }
        
        public AncillaryServiceDetailType ServiceFamily
        {
            get
            {
                return this._serviceFamily;
            }
            set
            {
                this._serviceFamily = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Restriction")]
        public List<AirOfferTypeRestriction> Restriction
        {
            get
            {
                return this._restriction;
            }
            set
            {
                this._restriction = value;
            }
        }
        
        public FormattedTextTextType ShortDescription
        {
            get
            {
                return this._shortDescription;
            }
            set
            {
                this._shortDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TermsAndConditions")]
        public List<AirOfferTypeTermsAndConditions> TermsAndConditions
        {
            get
            {
                return this._termsAndConditions;
            }
            set
            {
                this._termsAndConditions = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BundleInd
        {
            get
            {
                return this._bundleInd;
            }
            set
            {
                this._bundleInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BundleID
        {
            get
            {
                return this._bundleID;
            }
            set
            {
                this._bundleID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MandatoryInd
        {
            get
            {
                return this._mandatoryInd;
            }
            set
            {
                this._mandatoryInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AcceptInd
        {
            get
            {
                return this._acceptInd;
            }
            set
            {
                this._acceptInd = value;
            }
        }
    }
}