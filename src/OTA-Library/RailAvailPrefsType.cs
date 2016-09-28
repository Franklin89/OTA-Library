using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailAvailPrefsType
    {
        
        private List<CompanyNamePrefType> _operatorPref;
        
        private List<RailAvailPrefsTypeTransportModes> _transportModes;
        
        private List<RailAmenityTypeRailAmenity> _railAmenities;
        
        private List<ClassCodeType> _classCodes;
        
        private AccommodationCategoryType _accommodationCategory;
        
        public RailAvailPrefsType()
        {
            this._accommodationCategory = new AccommodationCategoryType();
            this._classCodes = new List<ClassCodeType>();
            this._railAmenities = new List<RailAmenityTypeRailAmenity>();
            this._transportModes = new List<RailAvailPrefsTypeTransportModes>();
            this._operatorPref = new List<CompanyNamePrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OperatorPref")]
        public List<CompanyNamePrefType> OperatorPref
        {
            get
            {
                return this._operatorPref;
            }
            set
            {
                this._operatorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TransportModes")]
        public List<RailAvailPrefsTypeTransportModes> TransportModes
        {
            get
            {
                return this._transportModes;
            }
            set
            {
                this._transportModes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RailAmenity", IsNullable=false)]
        public List<RailAmenityTypeRailAmenity> RailAmenities
        {
            get
            {
                return this._railAmenities;
            }
            set
            {
                this._railAmenities = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ClassCodes")]
        public List<ClassCodeType> ClassCodes
        {
            get
            {
                return this._classCodes;
            }
            set
            {
                this._classCodes = value;
            }
        }
        
        public AccommodationCategoryType AccommodationCategory
        {
            get
            {
                return this._accommodationCategory;
            }
            set
            {
                this._accommodationCategory = value;
            }
        }
    }
}