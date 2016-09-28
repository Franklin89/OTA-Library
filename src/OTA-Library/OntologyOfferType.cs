using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyOfferType
    {
        
        private List<OntologyOfferTypeOffer> _offer;
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _allOffersInd;
        
        private string _ontologyRefID;
        
        public OntologyOfferType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._offer = new List<OntologyOfferTypeOffer>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Offer")]
        public List<OntologyOfferTypeOffer> Offer
        {
            get
            {
                return this._offer;
            }
            set
            {
                this._offer = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllOffersInd
        {
            get
            {
                return this._allOffersInd;
            }
            set
            {
                this._allOffersInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
    }
}