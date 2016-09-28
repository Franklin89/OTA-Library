using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferTypeCompatibleOffer
    {
        
        private List<string> _offerRPH;
        
        private bool _incompatibleOfferIndicator;
        
        public OfferTypeCompatibleOffer()
        {
            this._offerRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> OfferRPH
        {
            get
            {
                return this._offerRPH;
            }
            set
            {
                this._offerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncompatibleOfferIndicator
        {
            get
            {
                return this._incompatibleOfferIndicator;
            }
            set
            {
                this._incompatibleOfferIndicator = value;
            }
        }
    }
}