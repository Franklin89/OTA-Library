using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoTypeGuestRooms
    {
        
        private List<FacilityInfoTypeGuestRoomsGuestRoom> _guestRoom;
        
        private string _maxOccupancy;
        
        public FacilityInfoTypeGuestRooms()
        {
            this._guestRoom = new List<FacilityInfoTypeGuestRoomsGuestRoom>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestRoom")]
        public List<FacilityInfoTypeGuestRoomsGuestRoom> GuestRoom
        {
            get
            {
                return this._guestRoom;
            }
            set
            {
                this._guestRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
    }
}