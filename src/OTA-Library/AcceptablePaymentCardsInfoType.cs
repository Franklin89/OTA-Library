using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AcceptablePaymentCardsInfoType
    {
        
        private List<AcceptablePaymentCardsInfoTypeAcceptablePaymentCard> _acceptablePaymentCards;
        
        private FormattedTextType _info;
        
        public AcceptablePaymentCardsInfoType()
        {
            this._info = new FormattedTextType();
            this._acceptablePaymentCards = new List<AcceptablePaymentCardsInfoTypeAcceptablePaymentCard>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptablePaymentCard", IsNullable=false)]
        public List<AcceptablePaymentCardsInfoTypeAcceptablePaymentCard> AcceptablePaymentCards
        {
            get
            {
                return this._acceptablePaymentCards;
            }
            set
            {
                this._acceptablePaymentCards = value;
            }
        }
        
        public FormattedTextType Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
    }
}