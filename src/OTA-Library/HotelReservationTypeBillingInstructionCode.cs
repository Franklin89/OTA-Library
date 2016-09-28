using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationTypeBillingInstructionCode
    {
        
        private List<HotelReservationTypeBillingInstructionCodeResGuestRPH> _resGuestRPH;
        
        private string _billingCode;
        
        private string _billingType;
        
        private string _authorizationCode;
        
        private string _description;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _accountNumber;
        
        public HotelReservationTypeBillingInstructionCode()
        {
            this._resGuestRPH = new List<HotelReservationTypeBillingInstructionCodeResGuestRPH>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ResGuestRPH")]
        public List<HotelReservationTypeBillingInstructionCodeResGuestRPH> ResGuestRPH
        {
            get
            {
                return this._resGuestRPH;
            }
            set
            {
                this._resGuestRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillingCode
        {
            get
            {
                return this._billingCode;
            }
            set
            {
                this._billingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillingType
        {
            get
            {
                return this._billingType;
            }
            set
            {
                this._billingType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthorizationCode
        {
            get
            {
                return this._authorizationCode;
            }
            set
            {
                this._authorizationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
            set
            {
                this._accountNumber = value;
            }
        }
    }
}