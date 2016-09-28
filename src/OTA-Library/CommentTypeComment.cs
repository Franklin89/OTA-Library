namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CommentTypeComment : ParagraphType
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _commentOriginatorCode;
        
        private bool _guestViewable;
        
        public CommentTypeComment()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommentOriginatorCode
        {
            get
            {
                return this._commentOriginatorCode;
            }
            set
            {
                this._commentOriginatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuestViewable
        {
            get
            {
                return this._guestViewable;
            }
            set
            {
                this._guestViewable = value;
            }
        }
    }
}