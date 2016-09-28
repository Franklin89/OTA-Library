namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BankAcctType
    {
        
        private string _bankAcctName;
        
        private EncryptionTokenType _bankAcctNumber;
        
        private EncryptionTokenType _bankID;
        
        private List_BankAccountType _type;
        
        private bool _checksAcceptedInd;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _checkNumber;
        
        public BankAcctType()
        {
            this._type = new List_BankAccountType();
            this._bankID = new EncryptionTokenType();
            this._bankAcctNumber = new EncryptionTokenType();
        }
        
        public string BankAcctName
        {
            get
            {
                return this._bankAcctName;
            }
            set
            {
                this._bankAcctName = value;
            }
        }
        
        public EncryptionTokenType BankAcctNumber
        {
            get
            {
                return this._bankAcctNumber;
            }
            set
            {
                this._bankAcctNumber = value;
            }
        }
        
        public EncryptionTokenType BankID
        {
            get
            {
                return this._bankID;
            }
            set
            {
                this._bankID = value;
            }
        }
        
        public List_BankAccountType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChecksAcceptedInd
        {
            get
            {
                return this._checksAcceptedInd;
            }
            set
            {
                this._checksAcceptedInd = value;
            }
        }
        
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
        public string CheckNumber
        {
            get
            {
                return this._checkNumber;
            }
            set
            {
                this._checkNumber = value;
            }
        }
    }
}