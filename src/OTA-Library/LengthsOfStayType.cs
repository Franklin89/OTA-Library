using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class LengthsOfStayType
    {
        
        private List<LengthsOfStayTypeLengthOfStay> _lengthOfStay;
        
        private bool _arrivalDateBased;
        
        private string _fixedPatternLength;
        
        public LengthsOfStayType()
        {
            this._lengthOfStay = new List<LengthsOfStayTypeLengthOfStay>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LengthOfStay")]
        public List<LengthsOfStayTypeLengthOfStay> LengthOfStay
        {
            get
            {
                return this._lengthOfStay;
            }
            set
            {
                this._lengthOfStay = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ArrivalDateBased
        {
            get
            {
                return this._arrivalDateBased;
            }
            set
            {
                this._arrivalDateBased = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string FixedPatternLength
        {
            get
            {
                return this._fixedPatternLength;
            }
            set
            {
                this._fixedPatternLength = value;
            }
        }
    }
}