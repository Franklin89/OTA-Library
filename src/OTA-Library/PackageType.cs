using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PackageType
    {
        
        private URL_Type _uRL;
        
        private CompanyNameType _companyName;
        
        private PackageTypeDateRange _dateRange;
        
        private List<ItineraryItemRequestType> _itineraryItems;
        
        private List<ExtrasType> _extras;
        
        private string _id;
        
        private string _type;
        
        private string _travelCode;
        
        private string _tourCode;
        
        private string _boardCode;
        
        private string _promotionCode;
        
        private string _freeChildrenQuantity;
        
        private string _brandCode;
        
        private string _productCode;
        
        public PackageType()
        {
            this._extras = new List<ExtrasType>();
            this._itineraryItems = new List<ItineraryItemRequestType>();
            this._dateRange = new PackageTypeDateRange();
            this._companyName = new CompanyNameType();
            this._uRL = new URL_Type();
        }
        
        public URL_Type URL
        {
            get
            {
                return this._uRL;
            }
            set
            {
                this._uRL = value;
            }
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
        
        public PackageTypeDateRange DateRange
        {
            get
            {
                return this._dateRange;
            }
            set
            {
                this._dateRange = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ItineraryItem", IsNullable=false)]
        public List<ItineraryItemRequestType> ItineraryItems
        {
            get
            {
                return this._itineraryItems;
            }
            set
            {
                this._itineraryItems = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Extra", IsNullable=false)]
        public List<ExtrasType> Extras
        {
            get
            {
                return this._extras;
            }
            set
            {
                this._extras = value;
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
        public string Type
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelCode
        {
            get
            {
                return this._travelCode;
            }
            set
            {
                this._travelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourCode
        {
            get
            {
                return this._tourCode;
            }
            set
            {
                this._tourCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BoardCode
        {
            get
            {
                return this._boardCode;
            }
            set
            {
                this._boardCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this._promotionCode;
            }
            set
            {
                this._promotionCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string FreeChildrenQuantity
        {
            get
            {
                return this._freeChildrenQuantity;
            }
            set
            {
                this._freeChildrenQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this._brandCode;
            }
            set
            {
                this._brandCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductCode
        {
            get
            {
                return this._productCode;
            }
            set
            {
                this._productCode = value;
            }
        }
    }
}