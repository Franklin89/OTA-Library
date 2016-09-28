using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomSharesTypeRoomShare
    {
        
        private List<RoomSharesTypeRoomShareGuestRPH> _guestRPHs;
        
        public RoomSharesTypeRoomShare()
        {
            this._guestRPHs = new List<RoomSharesTypeRoomShareGuestRPH>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GuestRPH", IsNullable=false)]
        public List<RoomSharesTypeRoomShareGuestRPH> GuestRPHs
        {
            get
            {
                return this._guestRPHs;
            }
            set
            {
                this._guestRPHs = value;
            }
        }
    }
}