using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRetrieveResRQAdditionalInfoType
    {
        
        private LocationType _pickUpLocation;
        
        private LocationType _returnLocation;
        
        private VehicleRetrieveResRQAdditionalInfoTypeTelephone _telephone;
        
        private CompanyNameType _vendor;
        
        private VehiclePrefType _vehPref;
        
        private EmailType _email;
        
        private List<ParagraphType> _remark;
        
        private List<VehicleRetrieveResRQAdditionalInfoTypeSearchDateRange> _searchDateRange;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private System.DateTime _pickUpDateTime;
        
        public VehicleRetrieveResRQAdditionalInfoType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._searchDateRange = new List<VehicleRetrieveResRQAdditionalInfoTypeSearchDateRange>();
            this._remark = new List<ParagraphType>();
            this._email = new EmailType();
            this._vehPref = new VehiclePrefType();
            this._vendor = new CompanyNameType();
            this._telephone = new VehicleRetrieveResRQAdditionalInfoTypeTelephone();
            this._returnLocation = new LocationType();
            this._pickUpLocation = new LocationType();
        }
        
        public LocationType PickUpLocation
        {
            get
            {
                return this._pickUpLocation;
            }
            set
            {
                this._pickUpLocation = value;
            }
        }
        
        public LocationType ReturnLocation
        {
            get
            {
                return this._returnLocation;
            }
            set
            {
                this._returnLocation = value;
            }
        }
        
        public VehicleRetrieveResRQAdditionalInfoTypeTelephone Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
        
        public CompanyNameType Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
            }
        }
        
        public VehiclePrefType VehPref
        {
            get
            {
                return this._vehPref;
            }
            set
            {
                this._vehPref = value;
            }
        }
        
        public EmailType Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Remark")]
        public List<ParagraphType> Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SearchDateRange")]
        public List<VehicleRetrieveResRQAdditionalInfoTypeSearchDateRange> SearchDateRange
        {
            get
            {
                return this._searchDateRange;
            }
            set
            {
                this._searchDateRange = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime PickUpDateTime
        {
            get
            {
                return this._pickUpDateTime;
            }
            set
            {
                this._pickUpDateTime = value;
            }
        }
    }
}