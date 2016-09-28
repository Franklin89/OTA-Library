namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeCarbonFootprint
    {
        
        private List_UnitOfMeasure _carbonUOM;
        
        private bool _nonCarbonMeasureInd;
        
        private string _nonCarbonMeasureDesc;
        
        private string _meetingEvent;
        
        private string _roomNight;
        
        private string _weatherNormalized;
        
        public EnvironmentalImpactTypeCarbonFootprint()
        {
            this._carbonUOM = new List_UnitOfMeasure();
        }
        
        public List_UnitOfMeasure CarbonUOM
        {
            get
            {
                return this._carbonUOM;
            }
            set
            {
                this._carbonUOM = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonCarbonMeasureInd
        {
            get
            {
                return this._nonCarbonMeasureInd;
            }
            set
            {
                this._nonCarbonMeasureInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonCarbonMeasureDesc
        {
            get
            {
                return this._nonCarbonMeasureDesc;
            }
            set
            {
                this._nonCarbonMeasureDesc = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MeetingEvent
        {
            get
            {
                return this._meetingEvent;
            }
            set
            {
                this._meetingEvent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RoomNight
        {
            get
            {
                return this._roomNight;
            }
            set
            {
                this._roomNight = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string WeatherNormalized
        {
            get
            {
                return this._weatherNormalized;
            }
            set
            {
                this._weatherNormalized = value;
            }
        }
    }
}