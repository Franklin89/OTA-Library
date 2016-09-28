using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailAvailQueryType
    {
        
        private List<RailAvailScheduleQueryType> _availBaseQueryCriteria;
        
        private List<RailPassengerCategoryType> _passengerType;
        
        private TravelDateTimeType _returnInfo;
        
        private RailAvailPrefsType _railPrefs;
        
        public RailAvailQueryType()
        {
            this._railPrefs = new RailAvailPrefsType();
            this._returnInfo = new TravelDateTimeType();
            this._passengerType = new List<RailPassengerCategoryType>();
            this._availBaseQueryCriteria = new List<RailAvailScheduleQueryType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AvailBaseQueryCriteria")]
        public List<RailAvailScheduleQueryType> AvailBaseQueryCriteria
        {
            get
            {
                return this._availBaseQueryCriteria;
            }
            set
            {
                this._availBaseQueryCriteria = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerType")]
        public List<RailPassengerCategoryType> PassengerType
        {
            get
            {
                return this._passengerType;
            }
            set
            {
                this._passengerType = value;
            }
        }
        
        public TravelDateTimeType ReturnInfo
        {
            get
            {
                return this._returnInfo;
            }
            set
            {
                this._returnInfo = value;
            }
        }
        
        public RailAvailPrefsType RailPrefs
        {
            get
            {
                return this._railPrefs;
            }
            set
            {
                this._railPrefs = value;
            }
        }
    }
}