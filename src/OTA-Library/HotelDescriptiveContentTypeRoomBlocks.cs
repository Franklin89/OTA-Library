namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelDescriptiveContentTypeRoomBlocks
    {
        
        private bool _availableInd;
        
        private string _totalRoomQty;
        
        private string _cancelPeriodDays;
        
        private string _rateType;
        
        private string _roomType;
        
        private string _blackOutDate;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableInd
        {
            get
            {
                return this._availableInd;
            }
            set
            {
                this._availableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TotalRoomQty
        {
            get
            {
                return this._totalRoomQty;
            }
            set
            {
                this._totalRoomQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string CancelPeriodDays
        {
            get
            {
                return this._cancelPeriodDays;
            }
            set
            {
                this._cancelPeriodDays = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateType
        {
            get
            {
                return this._rateType;
            }
            set
            {
                this._rateType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomType
        {
            get
            {
                return this._roomType;
            }
            set
            {
                this._roomType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BlackOutDate
        {
            get
            {
                return this._blackOutDate;
            }
            set
            {
                this._blackOutDate = value;
            }
        }
    }
}