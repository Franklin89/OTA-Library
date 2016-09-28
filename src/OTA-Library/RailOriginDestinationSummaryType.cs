using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailOriginDestinationSummaryType : TravelDateTimeType
    {
        
        private RailOriginDestinationSummaryTypeOriginLocation _originLocation;
        
        private RailOriginDestinationSummaryTypeDestinationLocation _destinationLocation;
        
        private List<RailOriginDestinationSummaryTypeConnectionLocation> _connectionLocation;
        
        private RailAvailPrefsType _preferences;
        
        public RailOriginDestinationSummaryType()
        {
            this._preferences = new RailAvailPrefsType();
            this._connectionLocation = new List<RailOriginDestinationSummaryTypeConnectionLocation>();
            this._destinationLocation = new RailOriginDestinationSummaryTypeDestinationLocation();
            this._originLocation = new RailOriginDestinationSummaryTypeOriginLocation();
        }
        
        public RailOriginDestinationSummaryTypeOriginLocation OriginLocation
        {
            get
            {
                return this._originLocation;
            }
            set
            {
                this._originLocation = value;
            }
        }
        
        public RailOriginDestinationSummaryTypeDestinationLocation DestinationLocation
        {
            get
            {
                return this._destinationLocation;
            }
            set
            {
                this._destinationLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConnectionLocation")]
        public List<RailOriginDestinationSummaryTypeConnectionLocation> ConnectionLocation
        {
            get
            {
                return this._connectionLocation;
            }
            set
            {
                this._connectionLocation = value;
            }
        }
        
        public RailAvailPrefsType Preferences
        {
            get
            {
                return this._preferences;
            }
            set
            {
                this._preferences = value;
            }
        }
    }
}