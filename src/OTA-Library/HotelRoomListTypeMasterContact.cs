using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRoomListTypeMasterContact : ContactPersonType
    {
        
        private List<UniqueID_Type> _uniqueIDs;
        
        private List<HotelRoomListTypeMasterContactLoyalty> _loyalty;
        
        public HotelRoomListTypeMasterContact()
        {
            this._loyalty = new List<HotelRoomListTypeMasterContactLoyalty>();
            this._uniqueIDs = new List<UniqueID_Type>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("UniqueID", IsNullable=false)]
        public List<UniqueID_Type> UniqueIDs
        {
            get
            {
                return this._uniqueIDs;
            }
            set
            {
                this._uniqueIDs = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Loyalty")]
        public List<HotelRoomListTypeMasterContactLoyalty> Loyalty
        {
            get
            {
                return this._loyalty;
            }
            set
            {
                this._loyalty = value;
            }
        }
    }
}