namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatZoneQueryType
    {
        
        private string _id;
        
        private string _name;
        
        private bool _allSeatsInd;
        
        private bool _availSeatsOnlyInd;
        
        private IncludeExcludeType _includeExclude;
        
        private SeatZoneQueryTypeType _type;
        
        private string _value;
        
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
        public bool AllSeatsInd
        {
            get
            {
                return this._allSeatsInd;
            }
            set
            {
                this._allSeatsInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailSeatsOnlyInd
        {
            get
            {
                return this._availSeatsOnlyInd;
            }
            set
            {
                this._availSeatsOnlyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IncludeExcludeType IncludeExclude
        {
            get
            {
                return this._includeExclude;
            }
            set
            {
                this._includeExclude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatZoneQueryTypeType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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