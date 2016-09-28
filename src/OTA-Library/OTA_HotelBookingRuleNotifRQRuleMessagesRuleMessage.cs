using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelBookingRuleNotifRQRuleMessagesRuleMessage
    {
        
        private StatusApplicationControlType _statusApplicationControl;
        
        private List<BookingRulesTypeBookingRule> _bookingRules;
        
        private UniqueID_Type _uniqueID;
        
        public OTA_HotelBookingRuleNotifRQRuleMessagesRuleMessage()
        {
            this._uniqueID = new UniqueID_Type();
            this._bookingRules = new List<BookingRulesTypeBookingRule>();
            this._statusApplicationControl = new StatusApplicationControlType();
        }
        
        public StatusApplicationControlType StatusApplicationControl
        {
            get
            {
                return this._statusApplicationControl;
            }
            set
            {
                this._statusApplicationControl = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingRule", IsNullable=false)]
        public List<BookingRulesTypeBookingRule> BookingRules
        {
            get
            {
                return this._bookingRules;
            }
            set
            {
                this._bookingRules = value;
            }
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
    }
}