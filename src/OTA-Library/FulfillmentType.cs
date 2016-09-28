using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FulfillmentType
    {
        
        private List<FulfillmentTypePaymentDetail> _paymentDetails;
        
        private AddressType _deliveryAddress;
        
        private PersonNameType _name;
        
        private FulfillmentTypeReceipt _receipt;
        
        private List<FulfillmentTypePaymentText> _paymentText;
        
        public FulfillmentType()
        {
            this._paymentText = new List<FulfillmentTypePaymentText>();
            this._receipt = new FulfillmentTypeReceipt();
            this._name = new PersonNameType();
            this._deliveryAddress = new AddressType();
            this._paymentDetails = new List<FulfillmentTypePaymentDetail>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentDetail", IsNullable=false)]
        public List<FulfillmentTypePaymentDetail> PaymentDetails
        {
            get
            {
                return this._paymentDetails;
            }
            set
            {
                this._paymentDetails = value;
            }
        }
        
        public AddressType DeliveryAddress
        {
            get
            {
                return this._deliveryAddress;
            }
            set
            {
                this._deliveryAddress = value;
            }
        }
        
        public PersonNameType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public FulfillmentTypeReceipt Receipt
        {
            get
            {
                return this._receipt;
            }
            set
            {
                this._receipt = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentText")]
        public List<FulfillmentTypePaymentText> PaymentText
        {
            get
            {
                return this._paymentText;
            }
            set
            {
                this._paymentText = value;
            }
        }
    }
}