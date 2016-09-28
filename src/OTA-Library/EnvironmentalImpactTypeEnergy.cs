using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeEnergy
    {
        
        private List<EnvironmentalImpactTypeEnergyUsage> _usage;
        
        private List<ParagraphType> _programDescription;
        
        private bool _efficientAppliancesInd;
        
        private bool _efficientLightingInd;
        
        private bool _heatPowerCombInd;
        
        private bool _heatPumpInd;
        
        private bool _powerSavingPolicyInd;
        
        private bool _solarInd;
        
        private string _tempControlInd;
        
        private bool _windTurbineInd;
        
        private string _energyGenerated;
        
        private string _energyStarRating;
        
        public EnvironmentalImpactTypeEnergy()
        {
            this._programDescription = new List<ParagraphType>();
            this._usage = new List<EnvironmentalImpactTypeEnergyUsage>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Usage")]
        public List<EnvironmentalImpactTypeEnergyUsage> Usage
        {
            get
            {
                return this._usage;
            }
            set
            {
                this._usage = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProgramDescription")]
        public List<ParagraphType> ProgramDescription
        {
            get
            {
                return this._programDescription;
            }
            set
            {
                this._programDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EfficientAppliancesInd
        {
            get
            {
                return this._efficientAppliancesInd;
            }
            set
            {
                this._efficientAppliancesInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EfficientLightingInd
        {
            get
            {
                return this._efficientLightingInd;
            }
            set
            {
                this._efficientLightingInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HeatPowerCombInd
        {
            get
            {
                return this._heatPowerCombInd;
            }
            set
            {
                this._heatPowerCombInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HeatPumpInd
        {
            get
            {
                return this._heatPumpInd;
            }
            set
            {
                this._heatPumpInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PowerSavingPolicyInd
        {
            get
            {
                return this._powerSavingPolicyInd;
            }
            set
            {
                this._powerSavingPolicyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SolarInd
        {
            get
            {
                return this._solarInd;
            }
            set
            {
                this._solarInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TempControlInd
        {
            get
            {
                return this._tempControlInd;
            }
            set
            {
                this._tempControlInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WindTurbineInd
        {
            get
            {
                return this._windTurbineInd;
            }
            set
            {
                this._windTurbineInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string EnergyGenerated
        {
            get
            {
                return this._energyGenerated;
            }
            set
            {
                this._energyGenerated = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnergyStarRating
        {
            get
            {
                return this._energyStarRating;
            }
            set
            {
                this._energyStarRating = value;
            }
        }
    }
}