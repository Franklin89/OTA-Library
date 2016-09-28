namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListGlobalReservation
    {
        
        private UniqueID_Type _uniqueID;
        
        private PersonNameType _travelerName;
        
        private string _itineraryName;
        
        private string _start;
        
        public OTA_ResRetrieveRSReservationsListGlobalReservation()
        {
            this._travelerName = new PersonNameType();
            this._uniqueID = new UniqueID_Type();
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
        
        public PersonNameType TravelerName
        {
            get
            {
                return this._travelerName;
            }
            set
            {
                this._travelerName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItineraryName
        {
            get
            {
                return this._itineraryName;
            }
            set
            {
                this._itineraryName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
    }
}