namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItemSearchCriterionTypeRadius
    {
        
        private string _distance;
        
        private string _distanceMeasure;
        
        private string _direction;
        
        private string _distanceMax;
        
        private string _unitOfMeasureCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistanceMeasure
        {
            get
            {
                return this._distanceMeasure;
            }
            set
            {
                this._distanceMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DistanceMax
        {
            get
            {
                return this._distanceMax;
            }
            set
            {
                this._distanceMax = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
    }
}