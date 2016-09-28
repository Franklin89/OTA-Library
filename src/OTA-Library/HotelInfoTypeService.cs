using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelInfoTypeService
    {
        
        private ContactInfoType _contact;
        
        private RelativePositionType _relativePosition;
        
        private List<OperationSchedulesPlusChargeTypeOperationSchedule> _operationSchedules;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private List<FeaturesTypeFeature> _features;
        
        private string _descriptiveText;
        
        private bool _included;
        
        private string _code;
        
        private string _businessServiceCode;
        
        private string _existsCode;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private bool _availableToAnyGuest;
        
        private string _invCode;
        
        private string _proximityCode;
        
        private string _mealPlanCode;
        
        private string _quantity;
        
        private string _sort;
        
        private string _meetingRoomCode;
        
        private string _id;
        
        private bool _featuredInd;
        
        public HotelInfoTypeService()
        {
            this._features = new List<FeaturesTypeFeature>();
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._operationSchedules = new List<OperationSchedulesPlusChargeTypeOperationSchedule>();
            this._relativePosition = new RelativePositionType();
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
        
        public RelativePositionType RelativePosition
        {
            get
            {
                return this._relativePosition;
            }
            set
            {
                this._relativePosition = value;
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public List<FeaturesTypeFeature> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
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
        public string BusinessServiceCode
        {
            get
            {
                return this._businessServiceCode;
            }
            set
            {
                this._businessServiceCode = value;
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
        public bool AvailableToAnyGuest
        {
            get
            {
                return this._availableToAnyGuest;
            }
            set
            {
                this._availableToAnyGuest = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvCode
        {
            get
            {
                return this._invCode;
            }
            set
            {
                this._invCode = value;
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
        public string MealPlanCode
        {
            get
            {
                return this._mealPlanCode;
            }
            set
            {
                this._mealPlanCode = value;
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
        public string MeetingRoomCode
        {
            get
            {
                return this._meetingRoomCode;
            }
            set
            {
                this._meetingRoomCode = value;
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