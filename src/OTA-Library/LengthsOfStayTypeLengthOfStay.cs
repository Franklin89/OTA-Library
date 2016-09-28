namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class LengthsOfStayTypeLengthOfStay
    {
        
        private LengthsOfStayTypeLengthOfStayLOS_Pattern _lOS_Pattern;
        
        private string _time;
        
        private TimeUnitType _timeUnit;
        
        private bool _openStatusIndicator;
        
        private LengthsOfStayTypeLengthOfStayMinMaxMessageType _minMaxMessageType;
        
        public LengthsOfStayTypeLengthOfStay()
        {
            this._lOS_Pattern = new LengthsOfStayTypeLengthOfStayLOS_Pattern();
        }
        
        public LengthsOfStayTypeLengthOfStayLOS_Pattern LOS_Pattern
        {
            get
            {
                return this._lOS_Pattern;
            }
            set
            {
                this._lOS_Pattern = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType TimeUnit
        {
            get
            {
                return this._timeUnit;
            }
            set
            {
                this._timeUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OpenStatusIndicator
        {
            get
            {
                return this._openStatusIndicator;
            }
            set
            {
                this._openStatusIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LengthsOfStayTypeLengthOfStayMinMaxMessageType MinMaxMessageType
        {
            get
            {
                return this._minMaxMessageType;
            }
            set
            {
                this._minMaxMessageType = value;
            }
        }
    }
}