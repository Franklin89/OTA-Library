using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DocumentHandlingType
    {
        
        private List<DocumentHandlingTypeVendorOption> _vendorOption;
        
        private string _documentTypeCode;
        
        private string _deliveryMethodCode;
        
        private string _documentDestination;
        
        private bool _selectedOptionIndicator;
        
        private bool _defaultIndicator;
        
        private bool _addressRequiredIndicator;
        
        private string _addressRPH;
        
        private string _emailRPH;
        
        private string _telephoneRPH;
        
        private string _documentLanguage;
        
        public DocumentHandlingType()
        {
            this._vendorOption = new List<DocumentHandlingTypeVendorOption>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorOption")]
        public List<DocumentHandlingTypeVendorOption> VendorOption
        {
            get
            {
                return this._vendorOption;
            }
            set
            {
                this._vendorOption = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocumentTypeCode
        {
            get
            {
                return this._documentTypeCode;
            }
            set
            {
                this._documentTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeliveryMethodCode
        {
            get
            {
                return this._deliveryMethodCode;
            }
            set
            {
                this._deliveryMethodCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocumentDestination
        {
            get
            {
                return this._documentDestination;
            }
            set
            {
                this._documentDestination = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SelectedOptionIndicator
        {
            get
            {
                return this._selectedOptionIndicator;
            }
            set
            {
                this._selectedOptionIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultIndicator
        {
            get
            {
                return this._defaultIndicator;
            }
            set
            {
                this._defaultIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressRequiredIndicator
        {
            get
            {
                return this._addressRequiredIndicator;
            }
            set
            {
                this._addressRequiredIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddressRPH
        {
            get
            {
                return this._addressRPH;
            }
            set
            {
                this._addressRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmailRPH
        {
            get
            {
                return this._emailRPH;
            }
            set
            {
                this._emailRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TelephoneRPH
        {
            get
            {
                return this._telephoneRPH;
            }
            set
            {
                this._telephoneRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string DocumentLanguage
        {
            get
            {
                return this._documentLanguage;
            }
            set
            {
                this._documentLanguage = value;
            }
        }
    }
}