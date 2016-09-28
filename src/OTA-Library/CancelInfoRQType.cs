using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CancelInfoRQType
    {
        
        private List<UniqueID_Type> _uniqueID;
        
        private PersonNameType _personName;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private TransactionActionType _cancelType;
        
        public CancelInfoRQType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._personName = new PersonNameType();
            this._uniqueID = new List<UniqueID_Type>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UniqueID")]
        public List<UniqueID_Type> UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public PersonNameType PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
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
        public TransactionActionType CancelType
        {
            get
            {
                return this._cancelType;
            }
            set
            {
                this._cancelType = value;
            }
        }
    }
}