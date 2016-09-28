using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PoliciesTypePolicyRatePolicy
    {
        
        private PoliciesTypePolicyRatePolicyType _type;
        
        private List<ParagraphType> _description;
        
        private bool _subjectToChangeInd;
        
        private bool _iD_RequiredInd;
        
        private List<string> _guestType;
        
        private string _minRoomNightCommitment;
        
        private string _rateOfferType;
        
        private bool _corporateID_Ind;
        
        public PoliciesTypePolicyRatePolicy()
        {
            this._guestType = new List<string>();
            this._description = new List<ParagraphType>();
            this._type = new PoliciesTypePolicyRatePolicyType();
        }
        
        public PoliciesTypePolicyRatePolicyType Type
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
        
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<ParagraphType> Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SubjectToChangeInd
        {
            get
            {
                return this._subjectToChangeInd;
            }
            set
            {
                this._subjectToChangeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ID_RequiredInd
        {
            get
            {
                return this._iD_RequiredInd;
            }
            set
            {
                this._iD_RequiredInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> GuestType
        {
            get
            {
                return this._guestType;
            }
            set
            {
                this._guestType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MinRoomNightCommitment
        {
            get
            {
                return this._minRoomNightCommitment;
            }
            set
            {
                this._minRoomNightCommitment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateOfferType
        {
            get
            {
                return this._rateOfferType;
            }
            set
            {
                this._rateOfferType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CorporateID_Ind
        {
            get
            {
                return this._corporateID_Ind;
            }
            set
            {
                this._corporateID_Ind = value;
            }
        }
    }
}