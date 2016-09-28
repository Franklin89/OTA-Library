namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingInfoTypeInclusivePackageOption
    {
        
        private string _cruisePackageCode;
        
        private bool _inclusiveIndicator;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CruisePackageCode
        {
            get
            {
                return this._cruisePackageCode;
            }
            set
            {
                this._cruisePackageCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InclusiveIndicator
        {
            get
            {
                return this._inclusiveIndicator;
            }
            set
            {
                this._inclusiveIndicator = value;
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