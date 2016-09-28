using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinClassDetailType
    {
        
        private List<CabinClassAvailabilityType> _availabilityList;
        
        private List<RowDetailType> _rowInfo;
        
        private SeatDetailsType _seatInfo;
        
        private List<SeatZoneSummaryType> _zone;
        
        private List<string> _text;
        
        private string _layout;
        
        private bool _upperDeckInd;
        
        private string _columnNumber;
        
        private string _columnSpan;
        
        public CabinClassDetailType()
        {
            this._text = new List<string>();
            this._zone = new List<SeatZoneSummaryType>();
            this._seatInfo = new SeatDetailsType();
            this._rowInfo = new List<RowDetailType>();
            this._availabilityList = new List<CabinClassAvailabilityType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AvailabilityList")]
        public List<CabinClassAvailabilityType> AvailabilityList
        {
            get
            {
                return this._availabilityList;
            }
            set
            {
                this._availabilityList = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RowInfo")]
        public List<RowDetailType> RowInfo
        {
            get
            {
                return this._rowInfo;
            }
            set
            {
                this._rowInfo = value;
            }
        }
        
        public SeatDetailsType SeatInfo
        {
            get
            {
                return this._seatInfo;
            }
            set
            {
                this._seatInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Zone")]
        public List<SeatZoneSummaryType> Zone
        {
            get
            {
                return this._zone;
            }
            set
            {
                this._zone = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public List<string> Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Layout
        {
            get
            {
                return this._layout;
            }
            set
            {
                this._layout = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UpperDeckInd
        {
            get
            {
                return this._upperDeckInd;
            }
            set
            {
                this._upperDeckInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ColumnNumber
        {
            get
            {
                return this._columnNumber;
            }
            set
            {
                this._columnNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ColumnSpan
        {
            get
            {
                return this._columnSpan;
            }
            set
            {
                this._columnSpan = value;
            }
        }
    }
}