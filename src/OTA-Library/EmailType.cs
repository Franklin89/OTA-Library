namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EmailType
    {
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private bool _defaultInd;
        
        private string _emailType1;
        
        private string _rPH;
        
        private string _remark;
        
        private bool _validInd;
        
        private EmailTypeTextFormat _textFormat;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("EmailType")]
        public string EmailType1
        {
            get
            {
                return this._emailType1;
            }
            set
            {
                this._emailType1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ValidInd
        {
            get
            {
                return this._validInd;
            }
            set
            {
                this._validInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmailTypeTextFormat TextFormat
        {
            get
            {
                return this._textFormat;
            }
            set
            {
                this._textFormat = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}