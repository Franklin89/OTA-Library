namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactType
    {
        
        private EnvironmentalImpactTypeCarbonFootprint _carbonFootprint;
        
        private EnvironmentalImpactTypeWater _water;
        
        private EnvironmentalImpactTypeEnergy _energy;
        
        private EnvironmentalImpactTypeRecycling _recycling;
        
        private EnvironmentalImpactTypeGeneral _general;
        
        public EnvironmentalImpactType()
        {
            this._general = new EnvironmentalImpactTypeGeneral();
            this._recycling = new EnvironmentalImpactTypeRecycling();
            this._energy = new EnvironmentalImpactTypeEnergy();
            this._water = new EnvironmentalImpactTypeWater();
            this._carbonFootprint = new EnvironmentalImpactTypeCarbonFootprint();
        }
        
        public EnvironmentalImpactTypeCarbonFootprint CarbonFootprint
        {
            get
            {
                return this._carbonFootprint;
            }
            set
            {
                this._carbonFootprint = value;
            }
        }
        
        public EnvironmentalImpactTypeWater Water
        {
            get
            {
                return this._water;
            }
            set
            {
                this._water = value;
            }
        }
        
        public EnvironmentalImpactTypeEnergy Energy
        {
            get
            {
                return this._energy;
            }
            set
            {
                this._energy = value;
            }
        }
        
        public EnvironmentalImpactTypeRecycling Recycling
        {
            get
            {
                return this._recycling;
            }
            set
            {
                this._recycling = value;
            }
        }
        
        public EnvironmentalImpactTypeGeneral General
        {
            get
            {
                return this._general;
            }
            set
            {
                this._general = value;
            }
        }
    }
}