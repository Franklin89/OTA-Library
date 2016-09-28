using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OriginDestinationInformationType : TravelDateTimeType
    {
        
        private OriginDestinationInformationTypeOriginLocation _originLocation;
        
        private OriginDestinationInformationTypeDestinationLocation _destinationLocation;
        
        private List<ConnectionTypeConnectionLocation> _connectionLocations;
        
        public OriginDestinationInformationType()
        {
            this._connectionLocations = new List<ConnectionTypeConnectionLocation>();
            this._destinationLocation = new OriginDestinationInformationTypeDestinationLocation();
            this._originLocation = new OriginDestinationInformationTypeOriginLocation();
        }
        
        public OriginDestinationInformationTypeOriginLocation OriginLocation
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
        
        public OriginDestinationInformationTypeDestinationLocation DestinationLocation
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
        public List<ConnectionTypeConnectionLocation> ConnectionLocations
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