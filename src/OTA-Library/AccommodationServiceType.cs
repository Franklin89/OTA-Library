using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute("AccommodationService", Namespace="http://www.opentravel.org/OTA/2003/05", IsNullable=false)]
    public partial class AccommodationServiceType
    {
        
        private AccommodationServiceTypeAccommodationDetail _accommodationDetail;
        
        private List<AncillaryService> _ancillaryService;
        
        public AccommodationServiceType()
        {
            this._ancillaryService = new List<AncillaryService>();
            this._accommodationDetail = new AccommodationServiceTypeAccommodationDetail();
        }
        
        public AccommodationServiceTypeAccommodationDetail AccommodationDetail
        {
            get
            {
                return this._accommodationDetail;
            }
            set
            {
                this._accommodationDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AncillaryService")]
        public List<AncillaryService> AncillaryService
        {
            get
            {
                return this._ancillaryService;
            }
            set
            {
                this._ancillaryService = value;
            }
        }
    }
}