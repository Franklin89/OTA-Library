namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MeetingRoomCapacityType
    {
        
        private MeetingRoomCapacityTypeOccupancy _occupancy;
        
        private string _meetingRoomFormatCode;
        
        public MeetingRoomCapacityType()
        {
            this._occupancy = new MeetingRoomCapacityTypeOccupancy();
        }
        
        public MeetingRoomCapacityTypeOccupancy Occupancy
        {
            get
            {
                return this._occupancy;
            }
            set
            {
                this._occupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeetingRoomFormatCode
        {
            get
            {
                return this._meetingRoomFormatCode;
            }
            set
            {
                this._meetingRoomFormatCode = value;
            }
        }
    }
}