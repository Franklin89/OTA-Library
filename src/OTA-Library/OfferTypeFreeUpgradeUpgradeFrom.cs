namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeFreeUpgradeUpgradeFrom
    {
        
        private SellableProductsTypeSellableProductInvCodeApplication _invCodeApplication;
        
        private string _invCode;
        
        private string _invType;
        
        private string _invTypeCode;
        
        private bool _isRoom;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SellableProductsTypeSellableProductInvCodeApplication InvCodeApplication
        {
            get
            {
                return this._invCodeApplication;
            }
            set
            {
                this._invCodeApplication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvTypeCode
        {
            get
            {
                return this._invTypeCode;
            }
            set
            {
                this._invTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this._isRoom;
            }
            set
            {
                this._isRoom = value;
            }
        }
    }
}