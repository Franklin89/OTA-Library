using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelSearchCriterionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ItemSearchCriterionType
    {
        
        private ItemSearchCriterionTypePosition _position;
        
        private ItemSearchCriterionTypeAddress _address;
        
        private ItemSearchCriterionTypeTelephone _telephone;
        
        private List<ItemSearchCriterionTypeRefPoint> _refPoint;
        
        private ItemSearchCriterionTypeCodeRef _codeRef;
        
        private List<ItemSearchCriterionTypeHotelRef> _hotelRef;
        
        private ItemSearchCriterionTypeRadius _radius;
        
        private ItemSearchCriterionTypeMapArea _mapArea;
        
        private List<ItemSearchCriterionTypeAdditionalContent> _additionalContents;
        
        private bool _exactMatch;
        
        private ItemSearchCriterionTypeImportanceType _importanceType;
        
        private string _ranking;
        
        public ItemSearchCriterionType()
        {
            this._additionalContents = new List<ItemSearchCriterionTypeAdditionalContent>();
            this._mapArea = new ItemSearchCriterionTypeMapArea();
            this._radius = new ItemSearchCriterionTypeRadius();
            this._hotelRef = new List<ItemSearchCriterionTypeHotelRef>();
            this._codeRef = new ItemSearchCriterionTypeCodeRef();
            this._refPoint = new List<ItemSearchCriterionTypeRefPoint>();
            this._telephone = new ItemSearchCriterionTypeTelephone();
            this._address = new ItemSearchCriterionTypeAddress();
            this._position = new ItemSearchCriterionTypePosition();
        }
        
        public ItemSearchCriterionTypePosition Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        
        public ItemSearchCriterionTypeAddress Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        public ItemSearchCriterionTypeTelephone Telephone
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
        
        [System.Xml.Serialization.XmlElementAttribute("RefPoint")]
        public List<ItemSearchCriterionTypeRefPoint> RefPoint
        {
            get
            {
                return this._refPoint;
            }
            set
            {
                this._refPoint = value;
            }
        }
        
        public ItemSearchCriterionTypeCodeRef CodeRef
        {
            get
            {
                return this._codeRef;
            }
            set
            {
                this._codeRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelRef")]
        public List<ItemSearchCriterionTypeHotelRef> HotelRef
        {
            get
            {
                return this._hotelRef;
            }
            set
            {
                this._hotelRef = value;
            }
        }
        
        public ItemSearchCriterionTypeRadius Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                this._radius = value;
            }
        }
        
        public ItemSearchCriterionTypeMapArea MapArea
        {
            get
            {
                return this._mapArea;
            }
            set
            {
                this._mapArea = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalContent", IsNullable=false)]
        public List<ItemSearchCriterionTypeAdditionalContent> AdditionalContents
        {
            get
            {
                return this._additionalContents;
            }
            set
            {
                this._additionalContents = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExactMatch
        {
            get
            {
                return this._exactMatch;
            }
            set
            {
                this._exactMatch = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemSearchCriterionTypeImportanceType ImportanceType
        {
            get
            {
                return this._importanceType;
            }
            set
            {
                this._importanceType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Ranking
        {
            get
            {
                return this._ranking;
            }
            set
            {
                this._ranking = value;
            }
        }
    }
}