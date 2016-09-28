namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CostingItemType
    {
        
        private CostingItemTypeUnitCost _unitCost;
        
        private CostingItemTypeExtendedCost _extendedCost;
        
        private CostingItemTypeCommission _commission;
        
        private string _description;
        
        private string _quantity;
        
        private string _inventoryItemRPH;
        
        private string _passengerRPH;
        
        private string _costBasis;
        
        private string _priceTypeCode;
        
        public CostingItemType()
        {
            this._commission = new CostingItemTypeCommission();
            this._extendedCost = new CostingItemTypeExtendedCost();
            this._unitCost = new CostingItemTypeUnitCost();
        }
        
        public CostingItemTypeUnitCost UnitCost
        {
            get
            {
                return this._unitCost;
            }
            set
            {
                this._unitCost = value;
            }
        }
        
        public CostingItemTypeExtendedCost ExtendedCost
        {
            get
            {
                return this._extendedCost;
            }
            set
            {
                this._extendedCost = value;
            }
        }
        
        public CostingItemTypeCommission Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
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
        public string InventoryItemRPH
        {
            get
            {
                return this._inventoryItemRPH;
            }
            set
            {
                this._inventoryItemRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerRPH
        {
            get
            {
                return this._passengerRPH;
            }
            set
            {
                this._passengerRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostBasis
        {
            get
            {
                return this._costBasis;
            }
            set
            {
                this._costBasis = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceTypeCode
        {
            get
            {
                return this._priceTypeCode;
            }
            set
            {
                this._priceTypeCode = value;
            }
        }
    }
}