using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AffiliationInfoTypeLoyalProgram
    {
        
        private List<AffiliationInfoTypeLoyalProgramProgramDescription> _programDescription;
        
        private AffiliationInfoTypeLoyalProgramProgramRestriction _programRestriction;
        
        private List<DateTimeSpanType> _blackoutDates;
        
        private bool _removal;
        
        private string _programName;
        
        private string _secondaryProgramName;
        
        private string _affiliateProgramName;
        
        private string _hotelLevel;
        
        private string _programCode;
        
        private string _travelSector;
        
        private bool _primaryProgramInd;
        
        public AffiliationInfoTypeLoyalProgram()
        {
            this._blackoutDates = new List<DateTimeSpanType>();
            this._programRestriction = new AffiliationInfoTypeLoyalProgramProgramRestriction();
            this._programDescription = new List<AffiliationInfoTypeLoyalProgramProgramDescription>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProgramDescription")]
        public List<AffiliationInfoTypeLoyalProgramProgramDescription> ProgramDescription
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
        
        public AffiliationInfoTypeLoyalProgramProgramRestriction ProgramRestriction
        {
            get
            {
                return this._programRestriction;
            }
            set
            {
                this._programRestriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("BlackoutDate", IsNullable=false)]
        public List<DateTimeSpanType> BlackoutDates
        {
            get
            {
                return this._blackoutDates;
            }
            set
            {
                this._blackoutDates = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramName
        {
            get
            {
                return this._programName;
            }
            set
            {
                this._programName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecondaryProgramName
        {
            get
            {
                return this._secondaryProgramName;
            }
            set
            {
                this._secondaryProgramName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AffiliateProgramName
        {
            get
            {
                return this._affiliateProgramName;
            }
            set
            {
                this._affiliateProgramName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelLevel
        {
            get
            {
                return this._hotelLevel;
            }
            set
            {
                this._hotelLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramCode
        {
            get
            {
                return this._programCode;
            }
            set
            {
                this._programCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryProgramInd
        {
            get
            {
                return this._primaryProgramInd;
            }
            set
            {
                this._primaryProgramInd = value;
            }
        }
    }
}