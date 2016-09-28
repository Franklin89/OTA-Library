namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeEvent
    {
        
        private ContactPersonType _eventContact;
        
        private string _meetingName;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public HotelRoomListTypeEvent()
        {
            this._eventContact = new ContactPersonType();
        }
        
        public ContactPersonType EventContact
        {
            get
            {
                return this._eventContact;
            }
            set
            {
                this._eventContact = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeetingName
        {
            get
            {
                return this._meetingName;
            }
            set
            {
                this._meetingName = value;
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
    }
}