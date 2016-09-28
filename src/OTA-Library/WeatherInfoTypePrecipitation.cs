namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class WeatherInfoTypePrecipitation
    {
        
        private decimal _averagePrecipitation;
        
        private string _unitOfMeasure;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AveragePrecipitation
        {
            get
            {
                return this._averagePrecipitation;
            }
            set
            {
                this._averagePrecipitation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this._unitOfMeasure;
            }
            set
            {
                this._unitOfMeasure = value;
            }
        }
    }
}