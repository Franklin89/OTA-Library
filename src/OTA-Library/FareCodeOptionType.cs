using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareCodeOptionType
    {
        
        private FareCodeOptionTypeFareRemark _fareRemark;
        
        private List<string> _listOfFareQualifierCode;
        
        private string _status;
        
        private string _fareDescription;
        
        private string _fareCode;
        
        private string _groupCode;
        
        public FareCodeOptionType()
        {
            this._listOfFareQualifierCode = new List<string>();
            this._fareRemark = new FareCodeOptionTypeFareRemark();
        }
        
        public FareCodeOptionTypeFareRemark FareRemark
        {
            get
            {
                return this._fareRemark;
            }
            set
            {
                this._fareRemark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfFareQualifierCode
        {
            get
            {
                return this._listOfFareQualifierCode;
            }
            set
            {
                this._listOfFareQualifierCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareDescription
        {
            get
            {
                return this._fareDescription;
            }
            set
            {
                this._fareDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareCode
        {
            get
            {
                return this._fareCode;
            }
            set
            {
                this._fareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this._groupCode;
            }
            set
            {
                this._groupCode = value;
            }
        }
    }
}