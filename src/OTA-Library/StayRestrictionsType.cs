namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StayRestrictionsType
    {
        
        private StayRestrictionsTypeMinimumStay _minimumStay;
        
        private StayRestrictionsTypeMaximumStay _maximumStay;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _stayRestrictionsInd;
        
        public StayRestrictionsType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._maximumStay = new StayRestrictionsTypeMaximumStay();
            this._minimumStay = new StayRestrictionsTypeMinimumStay();
        }
        
        public StayRestrictionsTypeMinimumStay MinimumStay
        {
            get
            {
                return this._minimumStay;
            }
            set
            {
                this._minimumStay = value;
            }
        }
        
        public StayRestrictionsTypeMaximumStay MaximumStay
        {
            get
            {
                return this._maximumStay;
            }
            set
            {
                this._maximumStay = value;
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
        public bool StayRestrictionsInd
        {
            get
            {
                return this._stayRestrictionsInd;
            }
            set
            {
                this._stayRestrictionsInd = value;
            }
        }
    }
}