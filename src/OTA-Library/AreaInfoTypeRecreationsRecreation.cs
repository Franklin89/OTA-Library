using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeRecreationsRecreation
    {
        
        private ContactInfoType _contact;
        
        private List<OperationSchedulesPlusChargeTypeOperationSchedule> _operationSchedules;
        
        private List<RefPointsTypeRefPoint> _refPoints;
        
        private AreaInfoTypeRecreationsRecreationMultimediaDescriptions _multimediaDescriptions;
        
        private List<AreaInfoTypeRecreationsRecreationRecreationDetail> _recreationDetails;
        
        private string _descriptiveText;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _code;
        
        private string _name;
        
        private string _proximityCode;
        
        private bool _included;
        
        private string _existsCode;
        
        private string _id;
        
        private string _sort;
        
        private System.DateTime _yearReplaced;
        
        private string _language;
        
        private bool _featuredInd;
        
        public AreaInfoTypeRecreationsRecreation()
        {
            this._recreationDetails = new List<AreaInfoTypeRecreationsRecreationRecreationDetail>();
            this._multimediaDescriptions = new AreaInfoTypeRecreationsRecreationMultimediaDescriptions();
            this._refPoints = new List<RefPointsTypeRefPoint>();
            this._operationSchedules = new List<OperationSchedulesPlusChargeTypeOperationSchedule>();
            this._contact = new ContactInfoType();
        }
        
        public ContactInfoType Contact
        {
            get
            {
                return this._contact;
            }
            set
            {
                this._contact = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationSchedule", IsNullable=false)]
        public List<OperationSchedulesPlusChargeTypeOperationSchedule> OperationSchedules
        {
            get
            {
                return this._operationSchedules;
            }
            set
            {
                this._operationSchedules = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RefPoint", IsNullable=false)]
        public List<RefPointsTypeRefPoint> RefPoints
        {
            get
            {
                return this._refPoints;
            }
            set
            {
                this._refPoints = value;
            }
        }
        
        public AreaInfoTypeRecreationsRecreationMultimediaDescriptions MultimediaDescriptions
        {
            get
            {
                return this._multimediaDescriptions;
            }
            set
            {
                this._multimediaDescriptions = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RecreationDetail", IsNullable=false)]
        public List<AreaInfoTypeRecreationsRecreationRecreationDetail> RecreationDetails
        {
            get
            {
                return this._recreationDetails;
            }
            set
            {
                this._recreationDetails = value;
            }
        }
        
        public string DescriptiveText
        {
            get
            {
                return this._descriptiveText;
            }
            set
            {
                this._descriptiveText = value;
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
        public string CodeDetail
        {
            get
            {
                return this._codeDetail;
            }
            set
            {
                this._codeDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProximityCode
        {
            get
            {
                return this._proximityCode;
            }
            set
            {
                this._proximityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Included
        {
            get
            {
                return this._included;
            }
            set
            {
                this._included = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this._existsCode;
            }
            set
            {
                this._existsCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime YearReplaced
        {
            get
            {
                return this._yearReplaced;
            }
            set
            {
                this._yearReplaced = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FeaturedInd
        {
            get
            {
                return this._featuredInd;
            }
            set
            {
                this._featuredInd = value;
            }
        }
    }
}