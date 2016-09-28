using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSeatMarketingClassTypeCabinInfo
    {
        
        private List<AirSeatMarketingClassTypeCabinInfoSubType> _subType;
        
        private string _reqSeatQty;
        
        private string _resBookDesigCode;
        
        private string _classCode;
        
        private string _seatType;
        
        private string _travelerRPH;
        
        private string _origDestSequenceRPH;
        
        private string _itinerarySegmentRPH;
        
        private string _rPH;
        
        public AirSeatMarketingClassTypeCabinInfo()
        {
            this._subType = new List<AirSeatMarketingClassTypeCabinInfoSubType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubType")]
        public List<AirSeatMarketingClassTypeCabinInfoSubType> SubType
        {
            get
            {
                return this._subType;
            }
            set
            {
                this._subType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ReqSeatQty
        {
            get
            {
                return this._reqSeatQty;
            }
            set
            {
                this._reqSeatQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this._resBookDesigCode;
            }
            set
            {
                this._resBookDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassCode
        {
            get
            {
                return this._classCode;
            }
            set
            {
                this._classCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatType
        {
            get
            {
                return this._seatType;
            }
            set
            {
                this._seatType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelerRPH
        {
            get
            {
                return this._travelerRPH;
            }
            set
            {
                this._travelerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrigDestSequenceRPH
        {
            get
            {
                return this._origDestSequenceRPH;
            }
            set
            {
                this._origDestSequenceRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItinerarySegmentRPH
        {
            get
            {
                return this._itinerarySegmentRPH;
            }
            set
            {
                this._itinerarySegmentRPH = value;
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
    }
}