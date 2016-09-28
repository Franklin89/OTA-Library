using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaseInvCountType
    {
        
        private StatusApplicationControlType _statusApplicationControl;
        
        private List<BaseInvCountTypeInvCount> _invCounts;
        
        private BaseInvCountTypeOffSell _offSell;
        
        private UniqueID_Type _uniqueID;
        
        public BaseInvCountType()
        {
            this._uniqueID = new UniqueID_Type();
            this._offSell = new BaseInvCountTypeOffSell();
            this._invCounts = new List<BaseInvCountTypeInvCount>();
            this._statusApplicationControl = new StatusApplicationControlType();
        }
        
        public StatusApplicationControlType StatusApplicationControl
        {
            get
            {
                return this._statusApplicationControl;
            }
            set
            {
                this._statusApplicationControl = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("InvCount", IsNullable=false)]
        public List<BaseInvCountTypeInvCount> InvCounts
        {
            get
            {
                return this._invCounts;
            }
            set
            {
                this._invCounts = value;
            }
        }
        
        public BaseInvCountTypeOffSell OffSell
        {
            get
            {
                return this._offSell;
            }
            set
            {
                this._offSell = value;
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
    }
}