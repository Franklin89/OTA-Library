using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RailPassengerCategoryDetailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPassengerCategoryType
    {
        
        private RailPassengerOccupationType _occupation;
        
        private List<RailPassengerCategoryTypePassengerQualifyingInfo> _passengerQualifyingInfo;
        
        private List<string> _aDA_Requirement;
        
        private bool _accompaniedByInfantInd;
        
        private DocumentTypeGender _gender;
        
        public RailPassengerCategoryType()
        {
            this._aDA_Requirement = new List<string>();
            this._passengerQualifyingInfo = new List<RailPassengerCategoryTypePassengerQualifyingInfo>();
            this._occupation = new RailPassengerOccupationType();
        }
        
        public RailPassengerOccupationType Occupation
        {
            get
            {
                return this._occupation;
            }
            set
            {
                this._occupation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerQualifyingInfo")]
        public List<RailPassengerCategoryTypePassengerQualifyingInfo> PassengerQualifyingInfo
        {
            get
            {
                return this._passengerQualifyingInfo;
            }
            set
            {
                this._passengerQualifyingInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ADA_Requirement")]
        public List<string> ADA_Requirement
        {
            get
            {
                return this._aDA_Requirement;
            }
            set
            {
                this._aDA_Requirement = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AccompaniedByInfantInd
        {
            get
            {
                return this._accompaniedByInfantInd;
            }
            set
            {
                this._accompaniedByInfantInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeGender Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
    }
}