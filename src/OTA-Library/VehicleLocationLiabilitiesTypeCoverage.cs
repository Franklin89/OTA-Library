using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationLiabilitiesTypeCoverage
    {
        
        private FormattedTextType _coverageInfo;
        
        private List<VehicleLocationLiabilitiesTypeCoverageCoverageFee> _coverageFees;
        
        private string _type;
        
        private bool _requiredInd;
        
        public VehicleLocationLiabilitiesTypeCoverage()
        {
            this._coverageFees = new List<VehicleLocationLiabilitiesTypeCoverageCoverageFee>();
            this._coverageInfo = new FormattedTextType();
        }
        
        public FormattedTextType CoverageInfo
        {
            get
            {
                return this._coverageInfo;
            }
            set
            {
                this._coverageInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CoverageFee", IsNullable=false)]
        public List<VehicleLocationLiabilitiesTypeCoverageCoverageFee> CoverageFees
        {
            get
            {
                return this._coverageFees;
            }
            set
            {
                this._coverageFees = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequiredInd
        {
            get
            {
                return this._requiredInd;
            }
            set
            {
                this._requiredInd = value;
            }
        }
    }
}