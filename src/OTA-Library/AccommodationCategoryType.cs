using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute("AccommodationCategory", Namespace="http://www.opentravel.org/OTA/2003/05", IsNullable=false)]
    public partial class AccommodationCategoryType
    {
        
        private List<AccommodationCategoryTypeAccommodation> _accommodation;
        
        private List<AncillaryService> _ancillaryService;
        
        public AccommodationCategoryType()
        {
            this._ancillaryService = new List<AncillaryService>();
            this._accommodation = new List<AccommodationCategoryTypeAccommodation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Accommodation")]
        public List<AccommodationCategoryTypeAccommodation> Accommodation
        {
            get
            {
                return this._accommodation;
            }
            set
            {
                this._accommodation = value;
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