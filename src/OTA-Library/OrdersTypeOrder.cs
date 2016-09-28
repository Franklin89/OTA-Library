using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OrdersTypeOrder
    {
        
        private OrdersTypeOrderProducts _products;
        
        private string _orderType;
        
        private string _orderID;
        
        private List<string> _listOfRecipientRPH;
        
        public OrdersTypeOrder()
        {
            this._listOfRecipientRPH = new List<string>();
            this._products = new OrdersTypeOrderProducts();
        }
        
        public OrdersTypeOrderProducts Products
        {
            get
            {
                return this._products;
            }
            set
            {
                this._products = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfRecipientRPH
        {
            get
            {
                return this._listOfRecipientRPH;
            }
            set
            {
                this._listOfRecipientRPH = value;
            }
        }
    }
}