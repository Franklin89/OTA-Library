using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRoomTypeAllocations
    {
        
        private List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocation> _roomTypeAllocation;
        
        private string _roomTypePickUpStatus;
        
        public InvBlockRoomTypeRoomTypeAllocations()
        {
            this._roomTypeAllocation = new List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomTypeAllocation")]
        public List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocation> RoomTypeAllocation
        {
            get
            {
                return this._roomTypeAllocation;
            }
            set
            {
                this._roomTypeAllocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypePickUpStatus
        {
            get
            {
                return this._roomTypePickUpStatus;
            }
            set
            {
                this._roomTypePickUpStatus = value;
            }
        }
    }
}