using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialRemarkType
    {
        
        private List<SpecialRemarkTypeTravelerRefNumber> _travelerRefNumber;
        
        private List<SpecialRemarkTypeFlightRefNumber> _flightRefNumber;
        
        private string _text;
        
        private List<CompanyNameType> _airline;
        
        private List<SpecialRemarkTypeAuthorizedViewer> _authorizedViewers;
        
        private string _remarkType;
        
        private string _id;
        
        public SpecialRemarkType()
        {
            this._authorizedViewers = new List<SpecialRemarkTypeAuthorizedViewer>();
            this._airline = new List<CompanyNameType>();
            this._flightRefNumber = new List<SpecialRemarkTypeFlightRefNumber>();
            this._travelerRefNumber = new List<SpecialRemarkTypeTravelerRefNumber>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber")]
        public List<SpecialRemarkTypeTravelerRefNumber> TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlightRefNumber")]
        public List<SpecialRemarkTypeFlightRefNumber> FlightRefNumber
        {
            get
            {
                return this._flightRefNumber;
            }
            set
            {
                this._flightRefNumber = value;
            }
        }
        
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Airline")]
        public List<CompanyNameType> Airline
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AuthorizedViewer", IsNullable=false)]
        public List<SpecialRemarkTypeAuthorizedViewer> AuthorizedViewers
        {
            get
            {
                return this._authorizedViewers;
            }
            set
            {
                this._authorizedViewers = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkType
        {
            get
            {
                return this._remarkType;
            }
            set
            {
                this._remarkType = value;
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
    }
}