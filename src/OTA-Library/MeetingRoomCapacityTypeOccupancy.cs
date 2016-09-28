namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MeetingRoomCapacityTypeOccupancy
    {
        
        private FeeType _minRoomCharge;
        
        private string _minOccupancy;
        
        private string _maxOccupancy;
        
        private string _standardOccupancy;
        
        public MeetingRoomCapacityTypeOccupancy()
        {
            this._minRoomCharge = new FeeType();
        }
        
        public FeeType MinRoomCharge
        {
            get
            {
                return this._minRoomCharge;
            }
            set
            {
                this._minRoomCharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string StandardOccupancy
        {
            get
            {
                return this._standardOccupancy;
            }
            set
            {
                this._standardOccupancy = value;
            }
        }
    }
}