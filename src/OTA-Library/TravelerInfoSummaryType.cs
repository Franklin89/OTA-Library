using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoSummaryType
    {
        
        private List<string> _seatsRequested;
        
        private List<TravelerInformationType> _airTravelerAvail;
        
        private TravelerInfoSummaryTypePriceRequestInformation _priceRequestInformation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public TravelerInfoSummaryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._priceRequestInformation = new TravelerInfoSummaryTypePriceRequestInformation();
            this._airTravelerAvail = new List<TravelerInformationType>();
            this._seatsRequested = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SeatsRequested", DataType="nonNegativeInteger")]
        public List<string> SeatsRequested
        {
            get
            {
                return this._seatsRequested;
            }
            set
            {
                this._seatsRequested = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AirTravelerAvail")]
        public List<TravelerInformationType> AirTravelerAvail
        {
            get
            {
                return this._airTravelerAvail;
            }
            set
            {
                this._airTravelerAvail = value;
            }
        }
        
        public TravelerInfoSummaryTypePriceRequestInformation PriceRequestInformation
        {
            get
            {
                return this._priceRequestInformation;
            }
            set
            {
                this._priceRequestInformation = value;
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