namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareComponentTypePriceableUnitFareComponentDetailCouponSequence
    {
        
        private string _sequenceNbr;
        
        private string _couponItinerarySeqNbr;
        
        private string _originCityCode;
        
        private string _originCodeContext;
        
        private string _destinationCityCode;
        
        private string _destinationCodeContext;
        
        private bool _stopoverInd;
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        private string _resBookDesigCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SequenceNbr
        {
            get
            {
                return this._sequenceNbr;
            }
            set
            {
                this._sequenceNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CouponItinerarySeqNbr
        {
            get
            {
                return this._couponItinerarySeqNbr;
            }
            set
            {
                this._couponItinerarySeqNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCityCode
        {
            get
            {
                return this._originCityCode;
            }
            set
            {
                this._originCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCodeContext
        {
            get
            {
                return this._originCodeContext;
            }
            set
            {
                this._originCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCityCode
        {
            get
            {
                return this._destinationCityCode;
            }
            set
            {
                this._destinationCityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCodeContext
        {
            get
            {
                return this._destinationCodeContext;
            }
            set
            {
                this._destinationCodeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StopoverInd
        {
            get
            {
                return this._stopoverInd;
            }
            set
            {
                this._stopoverInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this._companyShortName;
            }
            set
            {
                this._companyShortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
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
    }
}