using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CancelInfoRSType
    {
        
        private List<CancelRuleType> _cancelRules;
        
        private UniqueID_Type _uniqueID;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public CancelInfoRSType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._uniqueID = new UniqueID_Type();
            this._cancelRules = new List<CancelRuleType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CancelRule", IsNullable=false)]
        public List<CancelRuleType> CancelRules
        {
            get
            {
                return this._cancelRules;
            }
            set
            {
                this._cancelRules = value;
            }
        }
        
        public UniqueID_Type UniqueID
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
    }
}