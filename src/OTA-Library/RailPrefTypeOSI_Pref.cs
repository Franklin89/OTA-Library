using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPrefTypeOSI_Pref
    {
        
        private List<RailPrefTypeOSI_PrefTravelerRefNumber> _travelerRefNumber;
        
        private CompanyNameType _operator;
        
        private string _text;
        
        private string _code;
        
        public RailPrefTypeOSI_Pref()
        {
            this._operator = new CompanyNameType();
            this._travelerRefNumber = new List<RailPrefTypeOSI_PrefTravelerRefNumber>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber")]
        public List<RailPrefTypeOSI_PrefTravelerRefNumber> TravelerRefNumber
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
        
        public CompanyNameType Operator
        {
            get
            {
                return this._operator;
            }
            set
            {
                this._operator = value;
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