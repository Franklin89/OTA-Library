namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationInfoTypeResort
    {
        
        private string _resortCode;
        
        private string _resortName;
        
        private string _destinationCode;
        
        private DestinationLevelType _destinationLevel;
        
        private string _destinationName;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResortCode
        {
            get
            {
                return this._resortCode;
            }
            set
            {
                this._resortCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResortName
        {
            get
            {
                return this._resortName;
            }
            set
            {
                this._resortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCode
        {
            get
            {
                return this._destinationCode;
            }
            set
            {
                this._destinationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DestinationLevelType DestinationLevel
        {
            get
            {
                return this._destinationLevel;
            }
            set
            {
                this._destinationLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationName
        {
            get
            {
                return this._destinationName;
            }
            set
            {
                this._destinationName = value;
            }
        }
    }
}