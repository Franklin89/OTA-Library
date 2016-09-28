using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OrdersType
    {
        
        private List<OrdersTypeOrder> _order;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _orderType;
        
        private string _discountCode;
        
        private string _vendorPurchaseOrderID;
        
        private string _orderID;
        
        public OrdersType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._order = new List<OrdersTypeOrder>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Order")]
        public List<OrdersTypeOrder> Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
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
        public string OrderType
        {
            get
            {
                return this._orderType;
            }
            set
            {
                this._orderType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiscountCode
        {
            get
            {
                return this._discountCode;
            }
            set
            {
                this._discountCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorPurchaseOrderID
        {
            get
            {
                return this._vendorPurchaseOrderID;
            }
            set
            {
                this._vendorPurchaseOrderID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrderID
        {
            get
            {
                return this._orderID;
            }
            set
            {
                this._orderID = value;
            }
        }
    }
}