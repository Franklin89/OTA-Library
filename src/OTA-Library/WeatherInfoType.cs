using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class WeatherInfoType
    {
        
        private List<WeatherInfoTypePrecipitation> _precipitation;
        
        private List<WeatherInfoTypeTemperature> _temperature;
        
        private string _period;
        
        public WeatherInfoType()
        {
            this._temperature = new List<WeatherInfoTypeTemperature>();
            this._precipitation = new List<WeatherInfoTypePrecipitation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Precipitation")]
        public List<WeatherInfoTypePrecipitation> Precipitation
        {
            get
            {
                return this._precipitation;
            }
            set
            {
                this._precipitation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Temperature")]
        public List<WeatherInfoTypeTemperature> Temperature
        {
            get
            {
                return this._temperature;
            }
            set
            {
                this._temperature = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Period
        {
            get
            {
                return this._period;
            }
            set
            {
                this._period = value;
            }
        }
    }
}