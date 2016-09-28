using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OrdersTypeOrderProductsProduct
    {
        
        private string _productIssueDate;
        
        private string _productID;
        
        private string _productType;
        
        private string _productQuantity;
        
        private string _productSerialNumber;
        
        private string _discountCode;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        private OrdersTypeOrderProductsProductStatus _status;
        
        private List<string> _listOfRecipientRPH;
        
        public OrdersTypeOrderProductsProduct()
        {
            this._listOfRecipientRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductIssueDate
        {
            get
            {
                return this._productIssueDate;
            }
            set
            {
                this._productIssueDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductID
        {
            get
            {
                return this._productID;
            }
            set
            {
                this._productID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductType
        {
            get
            {
                return this._productType;
            }
            set
            {
                this._productType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string ProductQuantity
        {
            get
            {
                return this._productQuantity;
            }
            set
            {
                this._productQuantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductSerialNumber
        {
            get
            {
                return this._productSerialNumber;
            }
            set
            {
                this._productSerialNumber = value;
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
        public string CurrencyCode
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OrdersTypeOrderProductsProductStatus Status
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