using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RevenueDetailType
    {
        
        private List<string> _folioIDs;
        
        private string _referenceID;
        
        private System.DateTime _transactionDate;
        
        private string _ratePlanCode;
        
        private string _description;
        
        private string _pMSRevenueCode;
        
        private string _currencyCode;
        
        private string _decimalPlaces;
        
        private decimal _amount;
        
        public RevenueDetailType()
        {
            this._folioIDs = new List<string>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FolioID", IsNullable=false)]
        public List<string> FolioIDs
        {
            get
            {
                return this._folioIDs;
            }
            set
            {
                this._folioIDs = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceID
        {
            get
            {
                return this._referenceID;
            }
            set
            {
                this._referenceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime TransactionDate
        {
            get
            {
                return this._transactionDate;
            }
            set
            {
                this._transactionDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this._ratePlanCode;
            }
            set
            {
                this._ratePlanCode = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PMSRevenueCode
        {
            get
            {
                return this._pMSRevenueCode;
            }
            set
            {
                this._pMSRevenueCode = value;
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
    }
}