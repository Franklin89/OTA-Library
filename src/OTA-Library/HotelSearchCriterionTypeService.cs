namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeService
    {
        
        private string _businessServiceCode;
        
        private string _serviceInventoryCode;
        
        private string _quantity;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BusinessServiceCode
        {
            get
            {
                return this._businessServiceCode;
            }
            set
            {
                this._businessServiceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceInventoryCode
        {
            get
            {
                return this._serviceInventoryCode;
            }
            set
            {
                this._serviceInventoryCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
    }
}