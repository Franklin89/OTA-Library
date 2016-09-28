using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MealPlanType
    {
        
        private List<CustomerCountsTypeCustomerCount> _customerCounts;
        
        private MealPlanTypePassengerRPHs _passengerRPHs;
        
        private List<MealPlanTypePrice> _prices;
        
        private string _plan;
        
        private string _code;
        
        private string _quantity;
        
        private string _rPH;
        
        private List<string> _listOfRoomRPH;
        
        public MealPlanType()
        {
            this._listOfRoomRPH = new List<string>();
            this._prices = new List<MealPlanTypePrice>();
            this._passengerRPHs = new MealPlanTypePassengerRPHs();
            this._customerCounts = new List<CustomerCountsTypeCustomerCount>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomerCount", IsNullable=false)]
        public List<CustomerCountsTypeCustomerCount> CustomerCounts
        {
            get
            {
                return this._customerCounts;
            }
            set
            {
                this._customerCounts = value;
            }
        }
        
        public MealPlanTypePassengerRPHs PassengerRPHs
        {
            get
            {
                return this._passengerRPHs;
            }
            set
            {
                this._passengerRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Price", IsNullable=false)]
        public List<MealPlanTypePrice> Prices
        {
            get
            {
                return this._prices;
            }
            set
            {
                this._prices = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Plan
        {
            get
            {
                return this._plan;
            }
            set
            {
                this._plan = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfRoomRPH
        {
            get
            {
                return this._listOfRoomRPH;
            }
            set
            {
                this._listOfRoomRPH = value;
            }
        }
    }
}