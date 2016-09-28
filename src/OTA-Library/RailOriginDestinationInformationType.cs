using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailOriginDestinationInformationType : TravelDateTimeType
    {
        
        private RailOriginDestinationInformationTypeOriginLocation _originLocation;
        
        private RailOriginDestinationInformationTypeDestinationLocation _destinationLocation;
        
        private List<RailConnectionTypeConnectionLocation> _connectionLocations;
        
        public RailOriginDestinationInformationType()
        {
            this._connectionLocations = new List<RailConnectionTypeConnectionLocation>();
            this._destinationLocation = new RailOriginDestinationInformationTypeDestinationLocation();
            this._originLocation = new RailOriginDestinationInformationTypeOriginLocation();
        }
        
        public RailOriginDestinationInformationTypeOriginLocation OriginLocation
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
        
        public RailOriginDestinationInformationTypeDestinationLocation DestinationLocation
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ConnectionLocation", IsNullable=false)]
        public List<RailConnectionTypeConnectionLocation> ConnectionLocations
        {
            get
            {
                return this._connectionLocations;
            }
            set
            {
                this._connectionLocations = value;
            }
        }
    }
}