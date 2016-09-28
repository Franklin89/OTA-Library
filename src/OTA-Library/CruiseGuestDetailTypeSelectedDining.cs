namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseGuestDetailTypeSelectedDining
    {
        
        private string _smokingCode;
        
        private string _diningRoom;
        
        private string _tableSize;
        
        private string _ageCode;
        
        private string _language;
        
        private string _sitting;
        
        private string _status;
        
        private PreferLevelType _preference;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SmokingCode
        {
            get
            {
                return this._smokingCode;
            }
            set
            {
                this._smokingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiningRoom
        {
            get
            {
                return this._diningRoom;
            }
            set
            {
                this._diningRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TableSize
        {
            get
            {
                return this._tableSize;
            }
            set
            {
                this._tableSize = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeCode
        {
            get
            {
                return this._ageCode;
            }
            set
            {
                this._ageCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sitting
        {
            get
            {
                return this._sitting;
            }
            set
            {
                this._sitting = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType Preference
        {
            get
            {
                return this._preference;
            }
            set
            {
                this._preference = value;
            }
        }
    }
}