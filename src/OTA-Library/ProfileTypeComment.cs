using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ProfileTypeComment : ParagraphType
    {
        
        private List<ProfileTypeCommentAuthorizedViewer> _authorizedViewer;
        
        private string _commentOriginatorCode;
        
        private bool _guestViewable;
        
        private string _category;
        
        private string _airlineVendorPrefRPH;
        
        private TransferActionType _transferAction;
        
        private System.DateTime _actionDate;
        
        public ProfileTypeComment()
        {
            this._authorizedViewer = new List<ProfileTypeCommentAuthorizedViewer>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AuthorizedViewer")]
        public List<ProfileTypeCommentAuthorizedViewer> AuthorizedViewer
        {
            get
            {
                return this._authorizedViewer;
            }
            set
            {
                this._authorizedViewer = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineVendorPrefRPH
        {
            get
            {
                return this._airlineVendorPrefRPH;
            }
            set
            {
                this._airlineVendorPrefRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ActionDate
        {
            get
            {
                return this._actionDate;
            }
            set
            {
                this._actionDate = value;
            }
        }
    }
}