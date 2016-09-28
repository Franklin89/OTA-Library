using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingBaseType
    {
        
        private SailingBaseTypeCruiseLine _cruiseLine;
        
        private SailingBaseTypeRegion _region;
        
        private SailingBaseTypeDeparturePort _departurePort;
        
        private SailingBaseTypeArrivalPort _arrivalPort;
        
        private List<string> _listOfSailingDescriptionCode;
        
        public SailingBaseType()
        {
            this._listOfSailingDescriptionCode = new List<string>();
            this._arrivalPort = new SailingBaseTypeArrivalPort();
            this._departurePort = new SailingBaseTypeDeparturePort();
            this._region = new SailingBaseTypeRegion();
            this._cruiseLine = new SailingBaseTypeCruiseLine();
        }
        
        public SailingBaseTypeCruiseLine CruiseLine
        {
            get
            {
                return this._cruiseLine;
            }
            set
            {
                this._cruiseLine = value;
            }
        }
        
        public SailingBaseTypeRegion Region
        {
            get
            {
                return this._region;
            }
            set
            {
                this._region = value;
            }
        }
        
        public SailingBaseTypeDeparturePort DeparturePort
        {
            get
            {
                return this._departurePort;
            }
            set
            {
                this._departurePort = value;
            }
        }
        
        public SailingBaseTypeArrivalPort ArrivalPort
        {
            get
            {
                return this._arrivalPort;
            }
            set
            {
                this._arrivalPort = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfSailingDescriptionCode
        {
            get
            {
                return this._listOfSailingDescriptionCode;
            }
            set
            {
                this._listOfSailingDescriptionCode = value;
            }
        }
    }
}