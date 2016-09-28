using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasType : ExtrasCoreType
    {
        
        private DateTimeSpanType _date;
        
        private List<CustomerCountsTypeCustomerCount> _passengerCounts;
        
        private string _additionalInfo;
        
        private List<string> _listOfPassengerRPH;
        
        public ExtrasType()
        {
            this._listOfPassengerRPH = new List<string>();
            this._passengerCounts = new List<CustomerCountsTypeCustomerCount>();
            this._date = new DateTimeSpanType();
        }
        
        public DateTimeSpanType Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomerCount", IsNullable=false)]
        public List<CustomerCountsTypeCustomerCount> PassengerCounts
        {
            get
            {
                return this._passengerCounts;
            }
            set
            {
                this._passengerCounts = value;
            }
        }
        
        public string AdditionalInfo
        {
            get
            {
                return this._additionalInfo;
            }
            set
            {
                this._additionalInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfPassengerRPH
        {
            get
            {
                return this._listOfPassengerRPH;
            }
            set
            {
                this._listOfPassengerRPH = value;
            }
        }
    }
}