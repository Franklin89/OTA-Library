namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockTypeInvBlockDates
    {
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private bool _endDateExtensionIndicator;
        
        private string _absoluteCutoff;
        
        private string _offsetDuration;
        
        private InvBlockTypeInvBlockDatesOffsetCalculationMode _offsetCalculationMode;
        
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
        public bool EndDateExtensionIndicator
        {
            get
            {
                return this._endDateExtensionIndicator;
            }
            set
            {
                this._endDateExtensionIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteCutoff
        {
            get
            {
                return this._absoluteCutoff;
            }
            set
            {
                this._absoluteCutoff = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
        public string OffsetDuration
        {
            get
            {
                return this._offsetDuration;
            }
            set
            {
                this._offsetDuration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvBlockTypeInvBlockDatesOffsetCalculationMode OffsetCalculationMode
        {
            get
            {
                return this._offsetCalculationMode;
            }
            set
            {
                this._offsetCalculationMode = value;
            }
        }
    }
}