namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeTravelerCharacteristicsDetailInfo
    {
        
        private MultiModalOfferTypeTravelerCharacteristicsDetailInfoIdentification _identification;
        
        private OntologyValueType _customerValue;
        
        private bool _serviceAnimalInd;
        
        private bool _disabledInd;
        
        private bool _femaleInd;
        
        private bool _maleInd;
        
        public MultiModalOfferTypeTravelerCharacteristicsDetailInfo()
        {
            this._customerValue = new OntologyValueType();
            this._identification = new MultiModalOfferTypeTravelerCharacteristicsDetailInfoIdentification();
        }
        
        public MultiModalOfferTypeTravelerCharacteristicsDetailInfoIdentification Identification
        {
            get
            {
                return this._identification;
            }
            set
            {
                this._identification = value;
            }
        }
        
        public OntologyValueType CustomerValue
        {
            get
            {
                return this._customerValue;
            }
            set
            {
                this._customerValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServiceAnimalInd
        {
            get
            {
                return this._serviceAnimalInd;
            }
            set
            {
                this._serviceAnimalInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DisabledInd
        {
            get
            {
                return this._disabledInd;
            }
            set
            {
                this._disabledInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FemaleInd
        {
            get
            {
                return this._femaleInd;
            }
            set
            {
                this._femaleInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MaleInd
        {
            get
            {
                return this._maleInd;
            }
            set
            {
                this._maleInd = value;
            }
        }
    }
}