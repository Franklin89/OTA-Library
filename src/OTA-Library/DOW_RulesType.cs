namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DOW_RulesType
    {
        
        private bool _mon;
        
        private bool _tue;
        
        private bool _weds;
        
        private bool _thur;
        
        private bool _fri;
        
        private bool _sat;
        
        private bool _sun;
        
        private DOW_RulesTypeDOW_TypeCode _dOW_TypeCode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this._mon;
            }
            set
            {
                this._mon = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this._tue;
            }
            set
            {
                this._tue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this._weds;
            }
            set
            {
                this._weds = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this._thur;
            }
            set
            {
                this._thur = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this._fri;
            }
            set
            {
                this._fri = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this._sat;
            }
            set
            {
                this._sat = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this._sun;
            }
            set
            {
                this._sun = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DOW_RulesTypeDOW_TypeCode DOW_TypeCode
        {
            get
            {
                return this._dOW_TypeCode;
            }
            set
            {
                this._dOW_TypeCode = value;
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
    }
}