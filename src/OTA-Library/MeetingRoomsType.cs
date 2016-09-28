using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MeetingRoomsType
    {
        
        private List<MeetingRoomsTypeMeetingRoom> _meetingRoom;
        
        private string _meetingRoomCount;
        
        private string _smallestRoomSpace;
        
        private string _largestRoomSpace;
        
        private decimal _unitOfMeasureQuantity;
        
        private string _unitOfMeasure;
        
        private string _unitOfMeasureCode;
        
        private string _totalRoomSpace;
        
        private string _largestSeatingCapacity;
        
        private string _secondLargestSeatingCapacity;
        
        private string _smallestSeatingCapacity;
        
        private string _totalRoomSeatingCapacity;
        
        private string _largestRoomHeight;
        
        private string _totalExhibitSpace;
        
        public MeetingRoomsType()
        {
            this._meetingRoom = new List<MeetingRoomsTypeMeetingRoom>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MeetingRoom")]
        public List<MeetingRoomsTypeMeetingRoom> MeetingRoom
        {
            get
            {
                return this._meetingRoom;
            }
            set
            {
                this._meetingRoom = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string MeetingRoomCount
        {
            get
            {
                return this._meetingRoomCount;
            }
            set
            {
                this._meetingRoomCount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SmallestRoomSpace
        {
            get
            {
                return this._smallestRoomSpace;
            }
            set
            {
                this._smallestRoomSpace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LargestRoomSpace
        {
            get
            {
                return this._largestRoomSpace;
            }
            set
            {
                this._largestRoomSpace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitOfMeasureQuantity
        {
            get
            {
                return this._unitOfMeasureQuantity;
            }
            set
            {
                this._unitOfMeasureQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this._unitOfMeasure;
            }
            set
            {
                this._unitOfMeasure = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this._unitOfMeasureCode;
            }
            set
            {
                this._unitOfMeasureCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string TotalRoomSpace
        {
            get
            {
                return this._totalRoomSpace;
            }
            set
            {
                this._totalRoomSpace = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LargestSeatingCapacity
        {
            get
            {
                return this._largestSeatingCapacity;
            }
            set
            {
                this._largestSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SecondLargestSeatingCapacity
        {
            get
            {
                return this._secondLargestSeatingCapacity;
            }
            set
            {
                this._secondLargestSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SmallestSeatingCapacity
        {
            get
            {
                return this._smallestSeatingCapacity;
            }
            set
            {
                this._smallestSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string TotalRoomSeatingCapacity
        {
            get
            {
                return this._totalRoomSeatingCapacity;
            }
            set
            {
                this._totalRoomSeatingCapacity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string LargestRoomHeight
        {
            get
            {
                return this._largestRoomHeight;
            }
            set
            {
                this._largestRoomHeight = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string TotalExhibitSpace
        {
            get
            {
                return this._totalExhibitSpace;
            }
            set
            {
                this._totalExhibitSpace = value;
            }
        }
    }
}