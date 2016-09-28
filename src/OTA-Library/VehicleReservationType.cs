namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute("VehReservation", Namespace="http://www.opentravel.org/OTA/2003/05", IsNullable=false)]
    public partial class VehicleReservationType
    {
        
        private CustomerPrimaryAdditionalType _customer;
        
        private VehicleReservationTypeVehSegmentCore _vehSegmentCore;
        
        private VehicleSegmentAdditionalInfoType _vehSegmentInfo;
        
        private System.DateTime _createDateTime;
        
        private string _creatorID;
        
        private System.DateTime _lastModifyDateTime;
        
        private string _lastModifierID;
        
        private System.DateTime _purgeDate;
        
        private string _reservationStatus;
        
        public VehicleReservationType()
        {
            this._vehSegmentInfo = new VehicleSegmentAdditionalInfoType();
            this._vehSegmentCore = new VehicleReservationTypeVehSegmentCore();
            this._customer = new CustomerPrimaryAdditionalType();
        }
        
        public CustomerPrimaryAdditionalType Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }
        
        public VehicleReservationTypeVehSegmentCore VehSegmentCore
        {
            get
            {
                return this._vehSegmentCore;
            }
            set
            {
                this._vehSegmentCore = value;
            }
        }
        
        public VehicleSegmentAdditionalInfoType VehSegmentInfo
        {
            get
            {
                return this._vehSegmentInfo;
            }
            set
            {
                this._vehSegmentInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this._createDateTime;
            }
            set
            {
                this._createDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this._creatorID;
            }
            set
            {
                this._creatorID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this._lastModifyDateTime;
            }
            set
            {
                this._lastModifyDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this._lastModifierID;
            }
            set
            {
                this._lastModifierID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this._purgeDate;
            }
            set
            {
                this._purgeDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationStatus
        {
            get
            {
                return this._reservationStatus;
            }
            set
            {
                this._reservationStatus = value;
            }
        }
    }
}