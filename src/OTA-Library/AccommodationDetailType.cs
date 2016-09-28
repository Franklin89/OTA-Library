namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AccommodationDetailType : AccommodationInfoType
    {
        
        private FacilityChoicesType _facilityChoices;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _bedQuantity;
        
        private bool _travelOKFlag;
        
        public AccommodationDetailType()
        {
            this._facilityChoices = new FacilityChoicesType();
        }
        
        public FacilityChoicesType FacilityChoices
        {
            get
            {
                return this._facilityChoices;
            }
            set
            {
                this._facilityChoices = value;
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
        public string BedQuantity
        {
            get
            {
                return this._bedQuantity;
            }
            set
            {
                this._bedQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TravelOKFlag
        {
            get
            {
                return this._travelOKFlag;
            }
            set
            {
                this._travelOKFlag = value;
            }
        }
    }
}