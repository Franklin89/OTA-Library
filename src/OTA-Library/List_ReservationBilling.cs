namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class List_ReservationBilling
    {
        
        private bool _removalInd;
        
        private string _code;
        
        private string _description;
        
        private string _descriptionDetail;
        
        private string _sourceName;
        
        private string _sourceURL;
        
        private string _resourceName;
        
        private string _resourceURL;
        
        private string _uniqueID;
        
        private List_ReservationBillingType_Base _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RemovalInd
        {
            get
            {
                return this._removalInd;
            }
            set
            {
                this._removalInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescriptionDetail
        {
            get
            {
                return this._descriptionDetail;
            }
            set
            {
                this._descriptionDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceName
        {
            get
            {
                return this._sourceName;
            }
            set
            {
                this._sourceName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string SourceURL
        {
            get
            {
                return this._sourceURL;
            }
            set
            {
                this._sourceURL = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResourceName
        {
            get
            {
                return this._resourceName;
            }
            set
            {
                this._resourceName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string ResourceURL
        {
            get
            {
                return this._resourceURL;
            }
            set
            {
                this._resourceURL = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public List_ReservationBillingType_Base Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}