namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomProfileType : RoomStayCandidateType
    {
        
        private RoomProfileTypePassengerRPHs _passengerRPHs;
        
        private string _description;
        
        private string _minOccupancy;
        
        private string _maxOccupancy;
        
        private string _maxAdults;
        
        private string _cotQuantity;
        
        private bool _freeChildFlag;
        
        public RoomProfileType()
        {
            this._passengerRPHs = new RoomProfileTypePassengerRPHs();
        }
        
        public RoomProfileTypePassengerRPHs PassengerRPHs
        {
            get
            {
                return this._passengerRPHs;
            }
            set
            {
                this._passengerRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MinOccupancy
        {
            get
            {
                return this._minOccupancy;
            }
            set
            {
                this._minOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxAdults
        {
            get
            {
                return this._maxAdults;
            }
            set
            {
                this._maxAdults = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string CotQuantity
        {
            get
            {
                return this._cotQuantity;
            }
            set
            {
                this._cotQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FreeChildFlag
        {
            get
            {
                return this._freeChildFlag;
            }
            set
            {
                this._freeChildFlag = value;
            }
        }
    }
}