using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FacilityInfoTypeGuestRoomsGuestRoomAmenity
    {
        
        private List<OperationSchedulesPlusChargeTypeOperationSchedule> _operationSchedules;
        
        private List<ContactInfoRootType> _contactInfo;
        
        private MultimediaDescriptionsType _multimediaDescriptions;
        
        private string _descriptiveText;
        
        private string _roomAmenityCode;
        
        private bool _includedInRateIndicator;
        
        private string _existsCode;
        
        private bool _removal;
        
        private string _codeDetail;
        
        private string _quantity;
        
        private string _id;
        
        public FacilityInfoTypeGuestRoomsGuestRoomAmenity()
        {
            this._multimediaDescriptions = new MultimediaDescriptionsType();
            this._contactInfo = new List<ContactInfoRootType>();
            this._operationSchedules = new List<OperationSchedulesPlusChargeTypeOperationSchedule>();
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
        
        [System.Xml.Serialization.XmlElementAttribute("ContactInfo")]
        public List<ContactInfoRootType> ContactInfo
        {
            get
            {
                return this._contactInfo;
            }
            set
            {
                this._contactInfo = value;
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
        public string RoomAmenityCode
        {
            get
            {
                return this._roomAmenityCode;
            }
            set
            {
                this._roomAmenityCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludedInRateIndicator
        {
            get
            {
                return this._includedInRateIndicator;
            }
            set
            {
                this._includedInRateIndicator = value;
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
    }
}