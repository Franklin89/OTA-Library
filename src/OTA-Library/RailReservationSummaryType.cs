using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailReservationSummaryType
    {
        
        private List<RailReservationSummaryTypeODInfo> _oDInfo;
        
        private List<RailPassengerCategoryDetailType> _passengerInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _bookingReferenceID;
        
        private System.DateTime _dateBooked;
        
        private TransactionStatusType _status;
        
        public RailReservationSummaryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._passengerInfo = new List<RailPassengerCategoryDetailType>();
            this._oDInfo = new List<RailReservationSummaryTypeODInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ODInfo")]
        public List<RailReservationSummaryTypeODInfo> ODInfo
        {
            get
            {
                return this._oDInfo;
            }
            set
            {
                this._oDInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerInfo")]
        public List<RailPassengerCategoryDetailType> PassengerInfo
        {
            get
            {
                return this._passengerInfo;
            }
            set
            {
                this._passengerInfo = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingReferenceID
        {
            get
            {
                return this._bookingReferenceID;
            }
            set
            {
                this._bookingReferenceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateBooked
        {
            get
            {
                return this._dateBooked;
            }
            set
            {
                this._dateBooked = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionStatusType Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}