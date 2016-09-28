using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeTicketConjunctionTicketNbr
    {
        
        private List<string> _coupons;
        
        private string _value;
        
        public PaymentFormTypeTicketConjunctionTicketNbr()
        {
            this._coupons = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> Coupons
        {
            get
            {
                return this._coupons;
            }
            set
            {
                this._coupons = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}