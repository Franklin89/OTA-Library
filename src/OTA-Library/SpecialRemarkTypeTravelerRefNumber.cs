namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialRemarkTypeTravelerRefNumber
    {
        
        private string _rPH;
        
        private string _surnameRefNumber;
        
        private SpecialRemarkTypeTravelerRefNumberRangePosition _rangePosition;
        
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
        public string SurnameRefNumber
        {
            get
            {
                return this._surnameRefNumber;
            }
            set
            {
                this._surnameRefNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SpecialRemarkTypeTravelerRefNumberRangePosition RangePosition
        {
            get
            {
                return this._rangePosition;
            }
            set
            {
                this._rangePosition = value;
            }
        }
    }
}