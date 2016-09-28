using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeWater
    {
        
        private List_UnitOfMeasure _waterUOM;
        
        private List<ParagraphType> _programDescription;
        
        private bool _grayWaterInd;
        
        private bool _waterProgramInd;
        
        private string _perRoomNightUsage;
        
        private string _perRoomDayUsage;
        
        private decimal _wasteDiversionPercentage;
        
        public EnvironmentalImpactTypeWater()
        {
            this._programDescription = new List<ParagraphType>();
            this._waterUOM = new List_UnitOfMeasure();
        }
        
        public List_UnitOfMeasure WaterUOM
        {
            get
            {
                return this._waterUOM;
            }
            set
            {
                this._waterUOM = value;
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
        public bool GrayWaterInd
        {
            get
            {
                return this._grayWaterInd;
            }
            set
            {
                this._grayWaterInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WaterProgramInd
        {
            get
            {
                return this._waterProgramInd;
            }
            set
            {
                this._waterProgramInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string PerRoomNightUsage
        {
            get
            {
                return this._perRoomNightUsage;
            }
            set
            {
                this._perRoomNightUsage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string PerRoomDayUsage
        {
            get
            {
                return this._perRoomDayUsage;
            }
            set
            {
                this._perRoomDayUsage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal WasteDiversionPercentage
        {
            get
            {
                return this._wasteDiversionPercentage;
            }
            set
            {
                this._wasteDiversionPercentage = value;
            }
        }
    }
}