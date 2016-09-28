using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PreferencesTypePrefCollection
    {
        
        private List<CommonPrefType> _commonPref;
        
        private List<VehicleProfileRentalPrefType> _vehicleRentalPref;
        
        private List<AirlinePrefType> _airlinePref;
        
        private List<HotelPrefType> _hotelPref;
        
        private List<RailPrefType> _railPref;
        
        private List<OtherSrvcPrefType> _otherSrvcPref;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private PersonNameTypeShareSynchInd _shareSynchInd;
        
        private PersonNameTypeShareMarketInd _shareMarketInd;
        
        private string _travelPurpose;
        
        public PreferencesTypePrefCollection()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._otherSrvcPref = new List<OtherSrvcPrefType>();
            this._railPref = new List<RailPrefType>();
            this._hotelPref = new List<HotelPrefType>();
            this._airlinePref = new List<AirlinePrefType>();
            this._vehicleRentalPref = new List<VehicleProfileRentalPrefType>();
            this._commonPref = new List<CommonPrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CommonPref")]
        public List<CommonPrefType> CommonPref
        {
            get
            {
                return this._commonPref;
            }
            set
            {
                this._commonPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VehicleRentalPref")]
        public List<VehicleProfileRentalPrefType> VehicleRentalPref
        {
            get
            {
                return this._vehicleRentalPref;
            }
            set
            {
                this._vehicleRentalPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirlinePref")]
        public List<AirlinePrefType> AirlinePref
        {
            get
            {
                return this._airlinePref;
            }
            set
            {
                this._airlinePref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelPref")]
        public List<HotelPrefType> HotelPref
        {
            get
            {
                return this._hotelPref;
            }
            set
            {
                this._hotelPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RailPref")]
        public List<RailPrefType> RailPref
        {
            get
            {
                return this._railPref;
            }
            set
            {
                this._railPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherSrvcPref")]
        public List<OtherSrvcPrefType> OtherSrvcPref
        {
            get
            {
                return this._otherSrvcPref;
            }
            set
            {
                this._otherSrvcPref = value;
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
        public PersonNameTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this._shareSynchInd;
            }
            set
            {
                this._shareSynchInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this._shareMarketInd;
            }
            set
            {
                this._shareMarketInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelPurpose
        {
            get
            {
                return this._travelPurpose;
            }
            set
            {
                this._travelPurpose = value;
            }
        }
    }
}