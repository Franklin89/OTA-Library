namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItemSearchCriterionTypePosition
    {
        
        private string _latitude;
        
        private string _longitude;
        
        private string _altitude;
        
        private string _altitudeUnitOfMeasureCode;
        
        private string _positionAccuracyCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                this._latitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                this._longitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Altitude
        {
            get
            {
                return this._altitude;
            }
            set
            {
                this._altitude = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AltitudeUnitOfMeasureCode
        {
            get
            {
                return this._altitudeUnitOfMeasureCode;
            }
            set
            {
                this._altitudeUnitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PositionAccuracyCode
        {
            get
            {
                return this._positionAccuracyCode;
            }
            set
            {
                this._positionAccuracyCode = value;
            }
        }
    }
}