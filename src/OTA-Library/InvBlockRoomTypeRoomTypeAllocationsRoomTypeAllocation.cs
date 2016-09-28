using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocation
    {
        
        private List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocationRoomTypeAllocByGuest> _roomTypeAllocByGuest;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _numberOfUnits;
        
        private string _compRoomQuantity;
        
        private string _compRoomFactor;
        
        private bool _endDateIndicator;
        
        private string _sellLimit;
        
        private string _procureBlockCode;
        
        private string _allocationID;
        
        private bool _allowGeneralInvInd;
        
        public InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocation()
        {
            this._roomTypeAllocByGuest = new List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocationRoomTypeAllocByGuest>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomTypeAllocByGuest")]
        public List<InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocationRoomTypeAllocByGuest> RoomTypeAllocByGuest
        {
            get
            {
                return this._roomTypeAllocByGuest;
            }
            set
            {
                this._roomTypeAllocByGuest = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfUnits
        {
            get
            {
                return this._numberOfUnits;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CompRoomQuantity
        {
            get
            {
                return this._compRoomQuantity;
            }
            set
            {
                this._compRoomQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CompRoomFactor
        {
            get
            {
                return this._compRoomFactor;
            }
            set
            {
                this._compRoomFactor = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EndDateIndicator
        {
            get
            {
                return this._endDateIndicator;
            }
            set
            {
                this._endDateIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string SellLimit
        {
            get
            {
                return this._sellLimit;
            }
            set
            {
                this._sellLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProcureBlockCode
        {
            get
            {
                return this._procureBlockCode;
            }
            set
            {
                this._procureBlockCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllocationID
        {
            get
            {
                return this._allocationID;
            }
            set
            {
                this._allocationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllowGeneralInvInd
        {
            get
            {
                return this._allowGeneralInvInd;
            }
            set
            {
                this._allowGeneralInvInd = value;
            }
        }
    }
}