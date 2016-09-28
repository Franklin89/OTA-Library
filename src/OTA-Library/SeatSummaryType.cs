namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatSummaryType
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _rPH;
        
        private string _seatSection;
        
        private string _seatNumber;
        
        private string _rowNumber;
        
        private string _airBookDesigCode;
        
        private string _seatSequenceNumber;
        
        private bool _advancePurchaseInd;
        
        private bool _availableInd;
        
        private bool _inoperativeInd;
        
        private bool _occupiedInd;
        
        public SeatSummaryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
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
        public string SeatSection
        {
            get
            {
                return this._seatSection;
            }
            set
            {
                this._seatSection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatNumber
        {
            get
            {
                return this._seatNumber;
            }
            set
            {
                this._seatNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string RowNumber
        {
            get
            {
                return this._rowNumber;
            }
            set
            {
                this._rowNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirBookDesigCode
        {
            get
            {
                return this._airBookDesigCode;
            }
            set
            {
                this._airBookDesigCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SeatSequenceNumber
        {
            get
            {
                return this._seatSequenceNumber;
            }
            set
            {
                this._seatSequenceNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvancePurchaseInd
        {
            get
            {
                return this._advancePurchaseInd;
            }
            set
            {
                this._advancePurchaseInd = value;
            }
        }
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InoperativeInd
        {
            get
            {
                return this._inoperativeInd;
            }
            set
            {
                this._inoperativeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OccupiedInd
        {
            get
            {
                return this._occupiedInd;
            }
            set
            {
                this._occupiedInd = value;
            }
        }
    }
}