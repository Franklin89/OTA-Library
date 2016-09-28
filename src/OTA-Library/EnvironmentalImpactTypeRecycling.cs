using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeRecycling
    {
        
        private EnvironmentalImpactTypeRecyclingDetails _details;
        
        private List<ParagraphType> _programDescription;
        
        private bool _activeProgramInd;
        
        private bool _ecologicalDishwareInd;
        
        public EnvironmentalImpactTypeRecycling()
        {
            this._programDescription = new List<ParagraphType>();
            this._details = new EnvironmentalImpactTypeRecyclingDetails();
        }
        
        public EnvironmentalImpactTypeRecyclingDetails Details
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
        public bool ActiveProgramInd
        {
            get
            {
                return this._activeProgramInd;
            }
            set
            {
                this._activeProgramInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EcologicalDishwareInd
        {
            get
            {
                return this._ecologicalDishwareInd;
            }
            set
            {
                this._ecologicalDishwareInd = value;
            }
        }
    }
}