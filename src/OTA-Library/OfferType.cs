using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OfferType
    {
        
        private List<OfferTypeOfferRule> _offerRules;
        
        private OfferTypeDiscount _discount;
        
        private OfferTypeFreeUpgrade _freeUpgrade;
        
        private ParagraphType _offerDescription;
        
        private List<OfferTypeCompatibleOffer> _compatibleOffers;
        
        private List<OfferTypeInventory> _inventories;
        
        private List<OfferTypeGuest> _guests;
        
        private string _offerCode;
        
        private string _rPH;
        
        private string _applicationOrder;
        
        public OfferType()
        {
            this._guests = new List<OfferTypeGuest>();
            this._inventories = new List<OfferTypeInventory>();
            this._compatibleOffers = new List<OfferTypeCompatibleOffer>();
            this._offerDescription = new ParagraphType();
            this._freeUpgrade = new OfferTypeFreeUpgrade();
            this._discount = new OfferTypeDiscount();
            this._offerRules = new List<OfferTypeOfferRule>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OfferRule", IsNullable=false)]
        public List<OfferTypeOfferRule> OfferRules
        {
            get
            {
                return this._offerRules;
            }
            set
            {
                this._offerRules = value;
            }
        }
        
        public OfferTypeDiscount Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
        
        public OfferTypeFreeUpgrade FreeUpgrade
        {
            get
            {
                return this._freeUpgrade;
            }
            set
            {
                this._freeUpgrade = value;
            }
        }
        
        public ParagraphType OfferDescription
        {
            get
            {
                return this._offerDescription;
            }
            set
            {
                this._offerDescription = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CompatibleOffer", IsNullable=false)]
        public List<OfferTypeCompatibleOffer> CompatibleOffers
        {
            get
            {
                return this._compatibleOffers;
            }
            set
            {
                this._compatibleOffers = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Inventory", IsNullable=false)]
        public List<OfferTypeInventory> Inventories
        {
            get
            {
                return this._inventories;
            }
            set
            {
                this._inventories = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable=false)]
        public List<OfferTypeGuest> Guests
        {
            get
            {
                return this._guests;
            }
            set
            {
                this._guests = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OfferCode
        {
            get
            {
                return this._offerCode;
            }
            set
            {
                this._offerCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string ApplicationOrder
        {
            get
            {
                return this._applicationOrder;
            }
            set
            {
                this._applicationOrder = value;
            }
        }
    }
}