using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirItineraryType
    {
        
        private List<AirItineraryTypeOriginDestinationOption> _originDestinationOptions;
        
        private AirTripType _directionInd;
        
        private string _airItineraryRPH;
        
        public AirItineraryType()
        {
            this._originDestinationOptions = new List<AirItineraryTypeOriginDestinationOption>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable=false)]
        public List<AirItineraryTypeOriginDestinationOption> OriginDestinationOptions
        {
            get
            {
                return this._originDestinationOptions;
            }
            set
            {
                this._originDestinationOptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType DirectionInd
        {
            get
            {
                return this._directionInd;
            }
            set
            {
                this._directionInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirItineraryRPH
        {
            get
            {
                return this._airItineraryRPH;
            }
            set
            {
                this._airItineraryRPH = value;
            }
        }
    }
}