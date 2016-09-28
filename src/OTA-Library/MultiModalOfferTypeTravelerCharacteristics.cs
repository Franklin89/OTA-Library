using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MultiModalOfferTypeTravelerCharacteristics
    {
        
        private OntologyTripPurposeType _tripPurpose;
        
        private MultiModalOfferTypeTravelerCharacteristicsClassification _classification;
        
        private List<MultiModalOfferTypeTravelerCharacteristicsDetailInfo> _detailInfo;
        
        private OntologyExtensionType _ontologyExtension;
        
        public MultiModalOfferTypeTravelerCharacteristics()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._detailInfo = new List<MultiModalOfferTypeTravelerCharacteristicsDetailInfo>();
            this._classification = new MultiModalOfferTypeTravelerCharacteristicsClassification();
            this._tripPurpose = new OntologyTripPurposeType();
        }
        
        public OntologyTripPurposeType TripPurpose
        {
            get
            {
                return this._tripPurpose;
            }
            set
            {
                this._tripPurpose = value;
            }
        }
        
        public MultiModalOfferTypeTravelerCharacteristicsClassification Classification
        {
            get
            {
                return this._classification;
            }
            set
            {
                this._classification = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DetailInfo")]
        public List<MultiModalOfferTypeTravelerCharacteristicsDetailInfo> DetailInfo
        {
            get
            {
                return this._detailInfo;
            }
            set
            {
                this._detailInfo = value;
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
    }
}