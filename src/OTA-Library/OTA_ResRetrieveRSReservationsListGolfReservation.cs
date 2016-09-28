namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ResRetrieveRSReservationsListGolfReservation
    {
        
        private OTA_ResRetrieveRSReservationsListGolfReservationMembership _membership;
        
        private PersonNameType _name;
        
        private string _id;
        
        private string _roundID;
        
        private string _playDateTime;
        
        private string _packageID;
        
        private string _requestorResID;
        
        private string _responderResConfID;
        
        public OTA_ResRetrieveRSReservationsListGolfReservation()
        {
            this._name = new PersonNameType();
            this._membership = new OTA_ResRetrieveRSReservationsListGolfReservationMembership();
        }
        
        public OTA_ResRetrieveRSReservationsListGolfReservationMembership Membership
        {
            get
            {
                return this._membership;
            }
            set
            {
                this._membership = value;
            }
        }
        
        public PersonNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RoundID
        {
            get
            {
                return this._roundID;
            }
            set
            {
                this._roundID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlayDateTime
        {
            get
            {
                return this._playDateTime;
            }
            set
            {
                this._playDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageID
        {
            get
            {
                return this._packageID;
            }
            set
            {
                this._packageID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestorResID
        {
            get
            {
                return this._requestorResID;
            }
            set
            {
                this._requestorResID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponderResConfID
        {
            get
            {
                return this._responderResConfID;
            }
            set
            {
                this._responderResConfID = value;
            }
        }
    }
}