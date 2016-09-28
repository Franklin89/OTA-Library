namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaseInvCountTypeInvCount
    {
        
        private BaseInvCountTypeInvCountInvBlockCutoff _invBlockCutoff;
        
        private string _countType;
        
        private string _count;
        
        private string _adjustReason;
        
        private BaseInvCountTypeInvCountActionType _actionType;
        
        public BaseInvCountTypeInvCount()
        {
            this._invBlockCutoff = new BaseInvCountTypeInvCountInvBlockCutoff();
        }
        
        public BaseInvCountTypeInvCountInvBlockCutoff InvBlockCutoff
        {
            get
            {
                return this._invBlockCutoff;
            }
            set
            {
                this._invBlockCutoff = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountType
        {
            get
            {
                return this._countType;
            }
            set
            {
                this._countType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdjustReason
        {
            get
            {
                return this._adjustReason;
            }
            set
            {
                this._adjustReason = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BaseInvCountTypeInvCountActionType ActionType
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
    }
}