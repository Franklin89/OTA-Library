namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class WeatherInfoTypeTemperature
    {
        
        private string _averageHighTemp;
        
        private string _averageLowTemp;
        
        private WeatherInfoTypeTemperatureTempUnit _tempUnit;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AverageHighTemp
        {
            get
            {
                return this._averageHighTemp;
            }
            set
            {
                this._averageHighTemp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AverageLowTemp
        {
            get
            {
                return this._averageLowTemp;
            }
            set
            {
                this._averageLowTemp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WeatherInfoTypeTemperatureTempUnit TempUnit
        {
            get
            {
                return this._tempUnit;
            }
            set
            {
                this._tempUnit = value;
            }
        }
    }
}