using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CategoryOptionType
    {
        
        private List<CategoryOptionTypePriceInfo> _priceInfos;
        
        private List<CategoryOptionTypeDining> _dining;
        
        private string _fareCode;
        
        private string _groupCode;
        
        private string _status;
        
        private bool _heldIndicator;
        
        private CategoryLocationType _categoryLocation;
        
        private string _maxOccupancy;
        
        private List<string> _listOfCategoryQualifierCodes;
        
        private string _berthedCategoryCode;
        
        private string _pricedCategoryCode;
        
        private string _availableGroupAllocationQty;
        
        public CategoryOptionType()
        {
            this._listOfCategoryQualifierCodes = new List<string>();
            this._dining = new List<CategoryOptionTypeDining>();
            this._priceInfos = new List<CategoryOptionTypePriceInfo>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PriceInfo", IsNullable=false)]
        public List<CategoryOptionTypePriceInfo> PriceInfos
        {
            get
            {
                return this._priceInfos;
            }
            set
            {
                this._priceInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Dining")]
        public List<CategoryOptionTypeDining> Dining
        {
            get
            {
                return this._dining;
            }
            set
            {
                this._dining = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareCode
        {
            get
            {
                return this._fareCode;
            }
            set
            {
                this._fareCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this._groupCode;
            }
            set
            {
                this._groupCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HeldIndicator
        {
            get
            {
                return this._heldIndicator;
            }
            set
            {
                this._heldIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CategoryLocationType CategoryLocation
        {
            get
            {
                return this._categoryLocation;
            }
            set
            {
                this._categoryLocation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxOccupancy
        {
            get
            {
                return this._maxOccupancy;
            }
            set
            {
                this._maxOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfCategoryQualifierCodes
        {
            get
            {
                return this._listOfCategoryQualifierCodes;
            }
            set
            {
                this._listOfCategoryQualifierCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BerthedCategoryCode
        {
            get
            {
                return this._berthedCategoryCode;
            }
            set
            {
                this._berthedCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PricedCategoryCode
        {
            get
            {
                return this._pricedCategoryCode;
            }
            set
            {
                this._pricedCategoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string AvailableGroupAllocationQty
        {
            get
            {
                return this._availableGroupAllocationQty;
            }
            set
            {
                this._availableGroupAllocationQty = value;
            }
        }
    }
}