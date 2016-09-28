using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EmployerType
    {
        
        private CompanyNameType _companyName;
        
        private List<CompanyNameType> _relatedEmployer;
        
        private List<EmployeeInfoType> _employeeInfo;
        
        private List<FreeTextType> _internalRefNmbr;
        
        private List<TravelArrangerType> _travelArranger;
        
        private List<LoyaltyProgramType> _loyaltyProgram;
        
        private bool _defaultInd;
        
        private OfficeLocationType _officeType;
        
        private System.DateTime _effectiveDate;
        
        private System.DateTime _expireDate;
        
        private bool _expireDateExclusiveInd;
        
        public EmployerType()
        {
            this._loyaltyProgram = new List<LoyaltyProgramType>();
            this._travelArranger = new List<TravelArrangerType>();
            this._internalRefNmbr = new List<FreeTextType>();
            this._employeeInfo = new List<EmployeeInfoType>();
            this._relatedEmployer = new List<CompanyNameType>();
            this._companyName = new CompanyNameType();
        }
        
        public CompanyNameType CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RelatedEmployer")]
        public List<CompanyNameType> RelatedEmployer
        {
            get
            {
                return this._relatedEmployer;
            }
            set
            {
                this._relatedEmployer = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EmployeeInfo")]
        public List<EmployeeInfoType> EmployeeInfo
        {
            get
            {
                return this._employeeInfo;
            }
            set
            {
                this._employeeInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("InternalRefNmbr")]
        public List<FreeTextType> InternalRefNmbr
        {
            get
            {
                return this._internalRefNmbr;
            }
            set
            {
                this._internalRefNmbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger")]
        public List<TravelArrangerType> TravelArranger
        {
            get
            {
                return this._travelArranger;
            }
            set
            {
                this._travelArranger = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyProgram")]
        public List<LoyaltyProgramType> LoyaltyProgram
        {
            get
            {
                return this._loyaltyProgram;
            }
            set
            {
                this._loyaltyProgram = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get
            {
                return this._defaultInd;
            }
            set
            {
                this._defaultInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OfficeLocationType OfficeType
        {
            get
            {
                return this._officeType;
            }
            set
            {
                this._officeType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this._expireDate;
            }
            set
            {
                this._expireDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExpireDateExclusiveInd
        {
            get
            {
                return this._expireDateExclusiveInd;
            }
            set
            {
                this._expireDateExclusiveInd = value;
            }
        }
    }
}