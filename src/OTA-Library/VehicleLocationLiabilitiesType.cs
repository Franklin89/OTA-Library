using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationLiabilitiesType
    {
        
        private List<VehicleLocationLiabilitiesTypeCoverage> _coverages;
        
        private FormattedTextType _info;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleLocationLiabilitiesType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._info = new FormattedTextType();
            this._coverages = new List<VehicleLocationLiabilitiesTypeCoverage>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Coverage", IsNullable=false)]
        public List<VehicleLocationLiabilitiesTypeCoverage> Coverages
        {
            get
            {
                return this._coverages;
            }
            set
            {
                this._coverages = value;
            }
        }
        
        public FormattedTextType Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}