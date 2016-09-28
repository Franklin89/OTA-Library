namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelInfoTypeDescriptionsRenovation
    {
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private string _descriptiveText;
        
        private bool _immediatePlans;
        
        private decimal _percentOfRenovationCompleted;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _areaText;
        
        private string _renovationCompletionDate;
        
        public HotelInfoTypeDescriptionsRenovation()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
        }
        
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ImmediatePlans
        {
            get
            {
                return this._immediatePlans;
            }
            set
            {
                this._immediatePlans = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PercentOfRenovationCompleted
        {
            get
            {
                return this._percentOfRenovationCompleted;
            }
            set
            {
                this._percentOfRenovationCompleted = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaText
        {
            get
            {
                return this._areaText;
            }
            set
            {
                this._areaText = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RenovationCompletionDate
        {
            get
            {
                return this._renovationCompletionDate;
            }
            set
            {
                this._renovationCompletionDate = value;
            }
        }
    }
}