using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AdjustmentsTypeAdjustment
    {
        
        private string _reservationOriginatorCode;
        
        private string _confirmationID;
        
        private string _reservationID;
        
        private string _roomInventoryCode;
        
        private string _promotionCode;
        
        private List<string> _promotionVendorCode;
        
        private string _adjustReason;
        
        private string _sequence;
        
        private AdjustmentsTypeAdjustmentInvValue _invValue;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public AdjustmentsTypeAdjustment()
        {
            this._promotionVendorCode = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationOriginatorCode
        {
            get
            {
                return this._reservationOriginatorCode;
            }
            set
            {
                this._reservationOriginatorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfirmationID
        {
            get
            {
                return this._confirmationID;
            }
            set
            {
                this._confirmationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationID
        {
            get
            {
                return this._reservationID;
            }
            set
            {
                this._reservationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomInventoryCode
        {
            get
            {
                return this._roomInventoryCode;
            }
            set
            {
                this._roomInventoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> PromotionVendorCode
        {
            get
            {
                return this._promotionVendorCode;
            }
            set
            {
                this._promotionVendorCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdjustReason
        {
            get
            {
                return this._adjustReason;
            }
            set
            {
                this._adjustReason = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Sequence
        {
            get
            {
                return this._sequence;
            }
            set
            {
                this._sequence = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AdjustmentsTypeAdjustmentInvValue InvValue
        {
            get
            {
                return this._invValue;
            }
            set
            {
                this._invValue = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
    }
}