using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RailPassengerShopType_DEPRECATE
    {
        
        private RailPassengerOccupationType _occupation;
        
        private List<RailPassengerShopType_DEPRECATEPassengerQualifyingInfo> _passengerQualifyingInfo;
        
        private List<string> _aDA_Requirement;
        
        private bool _accompaniedByInfantInd;
        
        private DocumentTypeGender _gender;
        
        public RailPassengerShopType_DEPRECATE()
        {
            this._aDA_Requirement = new List<string>();
            this._passengerQualifyingInfo = new List<RailPassengerShopType_DEPRECATEPassengerQualifyingInfo>();
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
        public List<RailPassengerShopType_DEPRECATEPassengerQualifyingInfo> PassengerQualifyingInfo
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