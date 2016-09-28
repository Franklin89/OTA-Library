using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PackageResponseType
    {
        
        private URL_Type _uRL;
        
        private CompanyNameType _companyName;
        
        private PackageResponseTypeDateRange _dateRange;
        
        private List<ItineraryItemResponseType> _itineraryItems;
        
        private List<ExtrasType> _extras;
        
        private List<PkgCautionType> _cautions;
        
        private string _id;
        
        private string _type;
        
        private string _travelCode;
        
        private string _tourCode;
        
        private string _boardCode;
        
        private string _promotionCode;
        
        private string _brandCode;
        
        private string _productCode;
        
        private string _status;
        
        public PackageResponseType()
        {
            this._cautions = new List<PkgCautionType>();
            this._extras = new List<ExtrasType>();
            this._itineraryItems = new List<ItineraryItemResponseType>();
            this._dateRange = new PackageResponseTypeDateRange();
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
        
        public PackageResponseTypeDateRange DateRange
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
        public List<ItineraryItemResponseType> ItineraryItems
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Caution", IsNullable=false)]
        public List<PkgCautionType> Cautions
        {
            get
            {
                return this._cautions;
            }
            set
            {
                this._cautions = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}