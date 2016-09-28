namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeVendorPref
    {
        
        private string _companyShortName;
        
        private string _division;
        
        private string _department;
        
        private PreferLevelType _preferLevel;
        
        private string _rPH;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this._companyShortName;
            }
            set
            {
                this._companyShortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Division
        {
            get
            {
                return this._division;
            }
            set
            {
                this._division = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Department
        {
            get
            {
                return this._department;
            }
            set
            {
                this._department = value;
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