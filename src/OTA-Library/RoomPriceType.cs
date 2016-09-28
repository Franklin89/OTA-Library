using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomPriceType
    {
        
        private List<GuestCountType> _guestCounts;
        
        private List<CostingItemType> _itemPrice;
        
        private RoomPriceTypeProfilePrice _profilePrice;
        
        private string _roomRPH;
        
        private string _code;
        
        public RoomPriceType()
        {
            this._profilePrice = new RoomPriceTypeProfilePrice();
            this._itemPrice = new List<CostingItemType>();
            this._guestCounts = new List<GuestCountType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestCounts")]
        public List<GuestCountType> GuestCounts
        {
            get
            {
                return this._guestCounts;
            }
            set
            {
                this._guestCounts = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemPrice")]
        public List<CostingItemType> ItemPrice
        {
            get
            {
                return this._itemPrice;
            }
            set
            {
                this._itemPrice = value;
            }
        }
        
        public RoomPriceTypeProfilePrice ProfilePrice
        {
            get
            {
                return this._profilePrice;
            }
            set
            {
                this._profilePrice = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomRPH
        {
            get
            {
                return this._roomRPH;
            }
            set
            {
                this._roomRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}