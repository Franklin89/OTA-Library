using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RowDetailType
    {
        
        private List<RowCharacteristicsType> _characteristics;
        
        private List<FormattedTextTextType> _description;
        
        private List<SeatDetailsType> _seatInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _operableInd;
        
        private string _planeSection;
        
        private string _gridNumber;
        
        private bool _bufferInd;
        
        private string _cabinType;
        
        private string _rowNumber;
        
        public RowDetailType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._seatInfo = new List<SeatDetailsType>();
            this._description = new List<FormattedTextTextType>();
            this._characteristics = new List<RowCharacteristicsType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Characteristics")]
        public List<RowCharacteristicsType> Characteristics
        {
            get
            {
                return this._characteristics;
            }
            set
            {
                this._characteristics = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<FormattedTextTextType> Description
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
        
        [System.Xml.Serialization.XmlElementAttribute("SeatInfo")]
        public List<SeatDetailsType> SeatInfo
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
        public bool OperableInd
        {
            get
            {
                return this._operableInd;
            }
            set
            {
                this._operableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlaneSection
        {
            get
            {
                return this._planeSection;
            }
            set
            {
                this._planeSection = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string GridNumber
        {
            get
            {
                return this._gridNumber;
            }
            set
            {
                this._gridNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BufferInd
        {
            get
            {
                return this._bufferInd;
            }
            set
            {
                this._bufferInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinType
        {
            get
            {
                return this._cabinType;
            }
            set
            {
                this._cabinType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
    }
}