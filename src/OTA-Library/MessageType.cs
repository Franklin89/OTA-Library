namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MessageType
    {
        
        private MessageTypeOriginalPayloadStdAttributes _originalPayloadStdAttributes;
        
        private string _messageContent;
        
        private string _chainCode;
        
        private string _brandCode;
        
        private string _hotelCode;
        
        private string _hotelCityCode;
        
        private string _hotelName;
        
        private string _hotelCodeContext;
        
        private string _chainName;
        
        private string _brandName;
        
        private string _areaID;
        
        private string _tTIcode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _startSeqNmbr;
        
        private string _endSeqNmbr;
        
        private string _messageType1;
        
        private string _responseValue;
        
        private string _requestCode;
        
        private string _reasonForRequest;
        
        private string _userName;
        
        private string _ratePlanCode;
        
        private string _confirmationID;
        
        private string _reservationID;
        
        public MessageType()
        {
            this._originalPayloadStdAttributes = new MessageTypeOriginalPayloadStdAttributes();
        }
        
        public MessageTypeOriginalPayloadStdAttributes OriginalPayloadStdAttributes
        {
            get
            {
                return this._originalPayloadStdAttributes;
            }
            set
            {
                this._originalPayloadStdAttributes = value;
            }
        }
        
        public string MessageContent
        {
            get
            {
                return this._messageContent;
            }
            set
            {
                this._messageContent = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainCode
        {
            get
            {
                return this._chainCode;
            }
            set
            {
                this._chainCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this._brandCode;
            }
            set
            {
                this._brandCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this._hotelCode;
            }
            set
            {
                this._hotelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this._hotelCityCode;
            }
            set
            {
                this._hotelCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this._hotelName;
            }
            set
            {
                this._hotelName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this._hotelCodeContext;
            }
            set
            {
                this._hotelCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this._chainName;
            }
            set
            {
                this._chainName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this._brandName;
            }
            set
            {
                this._brandName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaID
        {
            get
            {
                return this._areaID;
            }
            set
            {
                this._areaID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TTIcode
        {
            get
            {
                return this._tTIcode;
            }
            set
            {
                this._tTIcode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StartSeqNmbr
        {
            get
            {
                return this._startSeqNmbr;
            }
            set
            {
                this._startSeqNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string EndSeqNmbr
        {
            get
            {
                return this._endSeqNmbr;
            }
            set
            {
                this._endSeqNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("MessageType")]
        public string MessageType1
        {
            get
            {
                return this._messageType1;
            }
            set
            {
                this._messageType1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseValue
        {
            get
            {
                return this._responseValue;
            }
            set
            {
                this._responseValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestCode
        {
            get
            {
                return this._requestCode;
            }
            set
            {
                this._requestCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReasonForRequest
        {
            get
            {
                return this._reasonForRequest;
            }
            set
            {
                this._reasonForRequest = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfirmationID
        {
            get
            {
                return this._confirmationID;
            }
            set
            {
                this._confirmationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationID
        {
            get
            {
                return this._reservationID;
            }
            set
            {
                this._reservationID = value;
            }
        }
    }
}