using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookFlightSegmentTypeBookingClassAvails
    {
        
        private List<BookFlightSegmentTypeBookingClassAvailsBookingClassAvail> _bookingClassAvail;
        
        private string _cabinType;
        
        public BookFlightSegmentTypeBookingClassAvails()
        {
            this._bookingClassAvail = new List<BookFlightSegmentTypeBookingClassAvailsBookingClassAvail>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingClassAvail")]
        public List<BookFlightSegmentTypeBookingClassAvailsBookingClassAvail> BookingClassAvail
        {
            get
            {
                return this._bookingClassAvail;
            }
            set
            {
                this._bookingClassAvail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinType
        {
            get
            {
                return this._cabinType;
            }
            set
            {
                this._cabinType = value;
            }
        }
    }
}