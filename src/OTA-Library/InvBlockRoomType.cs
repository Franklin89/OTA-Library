using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomType
    {
        
        private List<InvBlockRoomTypeRoomTypeAllocations> _roomTypeAllocations;
        
        private List<InvBlockRoomTypeRatePlan> _ratePlans;
        
        private List<DOW_RulesType> _daysOfWeeks;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _roomTypeCode;
        
        public InvBlockRoomType()
        {
            this._daysOfWeeks = new List<DOW_RulesType>();
            this._ratePlans = new List<InvBlockRoomTypeRatePlan>();
            this._roomTypeAllocations = new List<InvBlockRoomTypeRoomTypeAllocations>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomTypeAllocations")]
        public List<InvBlockRoomTypeRoomTypeAllocations> RoomTypeAllocations
        {
            get
            {
                return this._roomTypeAllocations;
            }
            set
            {
                this._roomTypeAllocations = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlan", IsNullable=false)]
        public List<InvBlockRoomTypeRatePlan> RatePlans
        {
            get
            {
                return this._ratePlans;
            }
            set
            {
                this._ratePlans = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DaysOfWeek", IsNullable=false)]
        public List<DOW_RulesType> DaysOfWeeks
        {
            get
            {
                return this._daysOfWeeks;
            }
            set
            {
                this._daysOfWeeks = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this._roomTypeCode;
            }
            set
            {
                this._roomTypeCode = value;
            }
        }
    }
}