using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoTypeMeetingRooms : MeetingRoomsType
    {
        
        private List<MeetingRoomCodeType> _codes;
        
        public FacilityInfoTypeMeetingRooms()
        {
            this._codes = new List<MeetingRoomCodeType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Code", IsNullable=false)]
        public List<MeetingRoomCodeType> Codes
        {
            get
            {
                return this._codes;
            }
            set
            {
                this._codes = value;
            }
        }
    }
}