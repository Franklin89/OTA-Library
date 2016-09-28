namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingSearchQualifierTypePort
    {
        
        private string _portCode;
        
        private string _portName;
        
        private string _portCountryCode;
        
        private bool _dockIndicator;
        
        private bool _shorexIndicator;
        
        private bool _embarkIndicator;
        
        private bool _disembarkIndicator;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PortCode
        {
            get
            {
                return this._portCode;
            }
            set
            {
                this._portCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PortName
        {
            get
            {
                return this._portName;
            }
            set
            {
                this._portName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PortCountryCode
        {
            get
            {
                return this._portCountryCode;
            }
            set
            {
                this._portCountryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DockIndicator
        {
            get
            {
                return this._dockIndicator;
            }
            set
            {
                this._dockIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ShorexIndicator
        {
            get
            {
                return this._shorexIndicator;
            }
            set
            {
                this._shorexIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EmbarkIndicator
        {
            get
            {
                return this._embarkIndicator;
            }
            set
            {
                this._embarkIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DisembarkIndicator
        {
            get
            {
                return this._disembarkIndicator;
            }
            set
            {
                this._disembarkIndicator = value;
            }
        }
    }
}