using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GuestCountType
    {
        
        private List<GuestCountTypeGuestCount> _guestCount;
        
        private bool _isPerRoom;
        
        public GuestCountType()
        {
            this._guestCount = new List<GuestCountTypeGuestCount>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestCount")]
        public List<GuestCountTypeGuestCount> GuestCount
        {
            get
            {
                return this._guestCount;
            }
            set
            {
                this._guestCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPerRoom
        {
            get
            {
                return this._isPerRoom;
            }
            set
            {
                this._isPerRoom = value;
            }
        }
    }
}