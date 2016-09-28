using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecificFlightInfoType
    {
        
        private string _flightNumber;
        
        private CompanyNameType _airline;
        
        private List<SpecificFlightInfoTypeBookingClassPref> _bookingClassPref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public SpecificFlightInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._bookingClassPref = new List<SpecificFlightInfoTypeBookingClassPref>();
            this._airline = new CompanyNameType();
        }
        
        public string FlightNumber
        {
            get
            {
                return this._flightNumber;
            }
            set
            {
                this._flightNumber = value;
            }
        }
        
        public CompanyNameType Airline
        {
            get
            {
                return this._airline;
            }
            set
            {
                this._airline = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingClassPref")]
        public List<SpecificFlightInfoTypeBookingClassPref> BookingClassPref
        {
            get
            {
                return this._bookingClassPref;
            }
            set
            {
                this._bookingClassPref = value;
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
    }
}