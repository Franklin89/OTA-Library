namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleEquipmentType
    {
        
        private string _description;
        
        private string _equipType;
        
        private string _quantity;
        
        private EquipmentRestrictionType _restriction;
        
        private InventoryStatusType _status;
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EquipType
        {
            get
            {
                return this._equipType;
            }
            set
            {
                this._equipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
        public EquipmentRestrictionType Restriction
        {
            get
            {
                return this._restriction;
            }
            set
            {
                this._restriction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InventoryStatusType Status
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