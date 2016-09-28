using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailAvailScheduleQueryType
    {
        
        private RailOriginDestinationInformationType _originDestinationInformation;
        
        private List<TrainQueryType> _railSearchCriteria;
        
        private string _maxConnections;
        
        private string _trainTypeCode;
        
        public RailAvailScheduleQueryType()
        {
            this._railSearchCriteria = new List<TrainQueryType>();
            this._originDestinationInformation = new RailOriginDestinationInformationType();
        }
        
        public RailOriginDestinationInformationType OriginDestinationInformation
        {
            get
            {
                return this._originDestinationInformation;
            }
            set
            {
                this._originDestinationInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RailSearchCriteria")]
        public List<TrainQueryType> RailSearchCriteria
        {
            get
            {
                return this._railSearchCriteria;
            }
            set
            {
                this._railSearchCriteria = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxConnections
        {
            get
            {
                return this._maxConnections;
            }
            set
            {
                this._maxConnections = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TrainTypeCode
        {
            get
            {
                return this._trainTypeCode;
            }
            set
            {
                this._trainTypeCode = value;
            }
        }
    }
}