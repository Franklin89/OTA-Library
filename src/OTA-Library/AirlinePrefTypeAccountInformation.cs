namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeAccountInformation
    {
        
        private AirlinePrefTypeAccountInformationTaxRegistrationDetails _taxRegistrationDetails;
        
        private string _number;
        
        private string _costCenter;
        
        private string _companyNumber;
        
        private string _clientReference;
        
        public AirlinePrefTypeAccountInformation()
        {
            this._taxRegistrationDetails = new AirlinePrefTypeAccountInformationTaxRegistrationDetails();
        }
        
        public AirlinePrefTypeAccountInformationTaxRegistrationDetails TaxRegistrationDetails
        {
            get
            {
                return this._taxRegistrationDetails;
            }
            set
            {
                this._taxRegistrationDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostCenter
        {
            get
            {
                return this._costCenter;
            }
            set
            {
                this._costCenter = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyNumber
        {
            get
            {
                return this._companyNumber;
            }
            set
            {
                this._companyNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClientReference
        {
            get
            {
                return this._clientReference;
            }
            set
            {
                this._clientReference = value;
            }
        }
    }
}