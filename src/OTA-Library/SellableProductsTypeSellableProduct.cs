using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SellableProductsTypeSellableProduct
    {
        
        private List<SellableProductsTypeSellableProductDestinationSystemCode> _destinationSystemCodes;
        
        private object _item;
        
        private ParagraphType _description;
        
        private UniqueID_Type _uniqueID;
        
        private string _rPH;
        
        private SellableProductsTypeSellableProductInvCodeApplication _invCodeApplication;
        
        private string _invCode;
        
        private string _invType;
        
        private string _invTypeCode;
        
        private bool _isRoom;
        
        private SellableProductsTypeSellableProductInvNotifType _invNotifType;
        
        private SellableProductsTypeSellableProductInvStatusType _invStatusType;
        
        private string _invGroupingCode;
        
        private string _orderSequence;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        public SellableProductsTypeSellableProduct()
        {
            this._uniqueID = new UniqueID_Type();
            this._description = new ParagraphType();
            this._destinationSystemCodes = new List<SellableProductsTypeSellableProductDestinationSystemCode>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationSystemCode", IsNullable=false)]
        public List<SellableProductsTypeSellableProductDestinationSystemCode> DestinationSystemCodes
        {
            get
            {
                return this._destinationSystemCodes;
            }
            set
            {
                this._destinationSystemCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GuestRoom", typeof(GuestRoomType))]
        [System.Xml.Serialization.XmlElementAttribute("InventoryBlock", typeof(SellableProductsTypeSellableProductInventoryBlock))]
        [System.Xml.Serialization.XmlElementAttribute("MeetingRooms", typeof(MeetingRoomsType))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        public ParagraphType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        public UniqueID_Type UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SellableProductsTypeSellableProductInvCodeApplication InvCodeApplication
        {
            get
            {
                return this._invCodeApplication;
            }
            set
            {
                this._invCodeApplication = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvType
        {
            get
            {
                return this._invType;
            }
            set
            {
                this._invType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvTypeCode
        {
            get
            {
                return this._invTypeCode;
            }
            set
            {
                this._invTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this._isRoom;
            }
            set
            {
                this._isRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SellableProductsTypeSellableProductInvNotifType InvNotifType
        {
            get
            {
                return this._invNotifType;
            }
            set
            {
                this._invNotifType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SellableProductsTypeSellableProductInvStatusType InvStatusType
        {
            get
            {
                return this._invStatusType;
            }
            set
            {
                this._invStatusType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvGroupingCode
        {
            get
            {
                return this._invGroupingCode;
            }
            set
            {
                this._invGroupingCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string OrderSequence
        {
            get
            {
                return this._orderSequence;
            }
            set
            {
                this._orderSequence = value;
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