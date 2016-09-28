namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OffLocationServiceType : OffLocationServiceCoreType
    {
        
        private PersonNameType _personName;
        
        private OffLocationServiceTypeTelephone _telephone;
        
        private UniqueID_Type _trackingID;
        
        private string _specInstructions;
        
        public OffLocationServiceType()
        {
            this._trackingID = new UniqueID_Type();
            this._telephone = new OffLocationServiceTypeTelephone();
            this._personName = new PersonNameType();
        }
        
        public PersonNameType PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
        }
        
        public OffLocationServiceTypeTelephone Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        public UniqueID_Type TrackingID
        {
            get
            {
                return this._trackingID;
            }
            set
            {
                this._trackingID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpecInstructions
        {
            get
            {
                return this._specInstructions;
            }
            set
            {
                this._specInstructions = value;
            }
        }
    }
}