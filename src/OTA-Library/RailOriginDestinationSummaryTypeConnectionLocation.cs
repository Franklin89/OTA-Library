using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailOriginDestinationSummaryTypeConnectionLocation
    {
        
        private List<CompanyNamePrefType> _operatorPref;
        
        private string _locationCode;
        
        private string _codeContext;
        
        private bool _multiCityStationInd;
        
        private PreferLevelType _preferLevel;
        
        public RailOriginDestinationSummaryTypeConnectionLocation()
        {
            this._operatorPref = new List<CompanyNamePrefType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OperatorPref")]
        public List<CompanyNamePrefType> OperatorPref
        {
            get
            {
                return this._operatorPref;
            }
            set
            {
                this._operatorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MultiCityStationInd
        {
            get
            {
                return this._multiCityStationInd;
            }
            set
            {
                this._multiCityStationInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
    }
}