namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeFareRestrictPref
    {
        
        private PreferLevelType _preferLevel;
        
        private string _fareRestriction;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private bool _refundableInd;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareRestriction
        {
            get
            {
                return this._fareRestriction;
            }
            set
            {
                this._fareRestriction = value;
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
        public bool RefundableInd
        {
            get
            {
                return this._refundableInd;
            }
            set
            {
                this._refundableInd = value;
            }
        }
    }
}