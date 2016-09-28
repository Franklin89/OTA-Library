namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccessesTypeAccess
    {
        
        private PersonNameType _accessPerson;
        
        private FreeTextType _accessComment;
        
        private AccessesTypeAccessActionType _actionType;
        
        private System.DateTime _actionDateTime;
        
        private string _id;
        
        public AccessesTypeAccess()
        {
            this._accessComment = new FreeTextType();
            this._accessPerson = new PersonNameType();
        }
        
        public PersonNameType AccessPerson
        {
            get
            {
                return this._accessPerson;
            }
            set
            {
                this._accessPerson = value;
            }
        }
        
        public FreeTextType AccessComment
        {
            get
            {
                return this._accessComment;
            }
            set
            {
                this._accessComment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessesTypeAccessActionType ActionType
        {
            get
            {
                return this._actionType;
            }
            set
            {
                this._actionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ActionDateTime
        {
            get
            {
                return this._actionDateTime;
            }
            set
            {
                this._actionDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}