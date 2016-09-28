using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingCategoryInfoTypeSelectedCategory
    {
        
        private List<SailingCategoryInfoTypeSelectedCategoryCabinAttribute> _cabinAttributes;
        
        private List<SailingCategoryInfoTypeSelectedCategorySelectedCabin> _selectedCabin;
        
        private string _berthedCategoryCode;
        
        private string _pricedCategoryCode;
        
        private string _deckNumber;
        
        private string _deckName;
        
        private bool _waitlistIndicator;
        
        private string _fareCode;
        
        private string _groupCode;
        
        public SailingCategoryInfoTypeSelectedCategory()
        {
            this._selectedCabin = new List<SailingCategoryInfoTypeSelectedCategorySelectedCabin>();
            this._cabinAttributes = new List<SailingCategoryInfoTypeSelectedCategoryCabinAttribute>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CabinAttribute", IsNullable=false)]
        public List<SailingCategoryInfoTypeSelectedCategoryCabinAttribute> CabinAttributes
        {
            get
            {
                return this._cabinAttributes;
            }
            set
            {
                this._cabinAttributes = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedCabin")]
        public List<SailingCategoryInfoTypeSelectedCategorySelectedCabin> SelectedCabin
        {
            get
            {
                return this._selectedCabin;
            }
            set
            {
                this._selectedCabin = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckNumber
        {
            get
            {
                return this._deckNumber;
            }
            set
            {
                this._deckNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeckName
        {
            get
            {
                return this._deckName;
            }
            set
            {
                this._deckName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WaitlistIndicator
        {
            get
            {
                return this._waitlistIndicator;
            }
            set
            {
                this._waitlistIndicator = value;
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
    }
}