using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CoverageType
    {
        
        private List<CoverageDetailsType> _details;
        
        private string _coverageType1;
        
        private string _code;
        
        public CoverageType()
        {
            this._details = new List<CoverageDetailsType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Details")]
        public List<CoverageDetailsType> Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("CoverageType")]
        public string CoverageType1
        {
            get
            {
                return this._coverageType1;
            }
            set
            {
                this._coverageType1 = value;
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