using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OtherServiceInfoType
    {
        
        private List<OtherServiceInfoTypeTravelerRefNumber> _travelerRefNumber;
        
        private CompanyNameType _airline;
        
        private string _text;
        
        private string _code;
        
        public OtherServiceInfoType()
        {
            this._airline = new CompanyNameType();
            this._travelerRefNumber = new List<OtherServiceInfoTypeTravelerRefNumber>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber")]
        public List<OtherServiceInfoTypeTravelerRefNumber> TravelerRefNumber
        {
            get
            {
                return this._travelerRefNumber;
            }
            set
            {
                this._travelerRefNumber = value;
            }
        }
        
        public CompanyNameType Airline
        {
            get
            {
                return this._airline;
            }
            set
            {
                this._airline = value;
            }
        }
        
        public string Text
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
    }
}