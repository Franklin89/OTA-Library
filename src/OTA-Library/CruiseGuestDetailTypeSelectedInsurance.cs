namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeSelectedInsurance
    {
        
        private string _insuranceCode;
        
        private bool _selectedOptionIndicator;
        
        private bool _defaultIndicator;
        
        private string _status;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InsuranceCode
        {
            get
            {
                return this._insuranceCode;
            }
            set
            {
                this._insuranceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SelectedOptionIndicator
        {
            get
            {
                return this._selectedOptionIndicator;
            }
            set
            {
                this._selectedOptionIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultIndicator
        {
            get
            {
                return this._defaultIndicator;
            }
            set
            {
                this._defaultIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}