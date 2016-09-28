using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeAttractionsAttraction
    {
        
        private AreaInfoTypeAttractionsAttractionContact _contact;
        
        private List<OperationSchedulesPlusChargeTypeOperationSchedule> _operationSchedules;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private List<RefPointsTypeRefPoint> _refPoints;
        
        private string _descriptiveText;
        
        private string _attractionCategoryCode;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _attractionName;
        
        private float _attractionFee;
        
        private bool _courtesyPhone;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _code;
        
        private string _codeContext;
        
        private string _quantity;
        
        private string _uRI;
        
        private string _proximityCode;
        
        private string _id;
        
        private string _sort;
        
        private string _minAgeAppropriateCode;
        
        private string _applicableStart;
        
        private string _applicableEnd;
        
        private string _language;
        
        public AreaInfoTypeAttractionsAttraction()
        {
            this._refPoints = new List<RefPointsTypeRefPoint>();
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._operationSchedules = new List<OperationSchedulesPlusChargeTypeOperationSchedule>();
            this._contact = new AreaInfoTypeAttractionsAttractionContact();
        }
        
        public AreaInfoTypeAttractionsAttractionContact Contact
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
        
        public MultimediaDescriptionsType MultimediaDescriptions
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
        public string AttractionCategoryCode
        {
            get
            {
                return this._attractionCategoryCode;
            }
            set
            {
                this._attractionCategoryCode = value;
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
        public string AttractionName
        {
            get
            {
                return this._attractionName;
            }
            set
            {
                this._attractionName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float AttractionFee
        {
            get
            {
                return this._attractionFee;
            }
            set
            {
                this._attractionFee = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CourtesyPhone
        {
            get
            {
                return this._courtesyPhone;
            }
            set
            {
                this._courtesyPhone = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
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
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MinAgeAppropriateCode
        {
            get
            {
                return this._minAgeAppropriateCode;
            }
            set
            {
                this._minAgeAppropriateCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableStart
        {
            get
            {
                return this._applicableStart;
            }
            set
            {
                this._applicableStart = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableEnd
        {
            get
            {
                return this._applicableEnd;
            }
            set
            {
                this._applicableEnd = value;
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
    }
}