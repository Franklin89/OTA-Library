using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeFarePref
    {
        
        private string _code;
        
        private string _description;
        
        private List<string> _airlineVendorPrefRPH;
        
        private string _rateCategoryCode;
        
        private TransferActionType _transferAction;
        
        public AirlinePrefTypeFarePref()
        {
            this._airlineVendorPrefRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> AirlineVendorPrefRPH
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
        public string RateCategoryCode
        {
            get
            {
                return this._rateCategoryCode;
            }
            set
            {
                this._rateCategoryCode = value;
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
    }
}