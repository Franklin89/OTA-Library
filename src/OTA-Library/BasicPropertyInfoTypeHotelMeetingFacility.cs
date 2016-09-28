namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BasicPropertyInfoTypeHotelMeetingFacility
    {
        
        private string _meetingRoomCount;
        
        private string _largestSeatingCapacity;
        
        private string _largestRoomSpace;
        
        private string _unitOfMeasureCode;
        
        private string _meetingRoomCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MeetingRoomCount
        {
            get
            {
                return this._meetingRoomCount;
            }
            set
            {
                this._meetingRoomCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LargestSeatingCapacity
        {
            get
            {
                return this._largestSeatingCapacity;
            }
            set
            {
                this._largestSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LargestRoomSpace
        {
            get
            {
                return this._largestRoomSpace;
            }
            set
            {
                this._largestRoomSpace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeetingRoomCode
        {
            get
            {
                return this._meetingRoomCode;
            }
            set
            {
                this._meetingRoomCode = value;
            }
        }
    }
}