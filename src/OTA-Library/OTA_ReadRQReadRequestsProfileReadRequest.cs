using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_ReadRQReadRequestsProfileReadRequest
    {
        
        private List<OTA_ReadRQReadRequestsProfileReadRequestUniqueID> _uniqueID;
        
        private ContactPersonType _company;
        
        private CustomerType _customer;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private OTA_ReadRQReadRequestsProfileReadRequestDateType _dateType;
        
        private string _statusCode;
        
        private string _profileTypeCode;
        
        public OTA_ReadRQReadRequestsProfileReadRequest()
        {
            this._customer = new CustomerType();
            this._company = new ContactPersonType();
            this._uniqueID = new List<OTA_ReadRQReadRequestsProfileReadRequestUniqueID>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UniqueID")]
        public List<OTA_ReadRQReadRequestsProfileReadRequestUniqueID> UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public ContactPersonType Company
        {
            get
            {
                return this._company;
            }
            set
            {
                this._company = value;
            }
        }
        
        public CustomerType Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_ReadRQReadRequestsProfileReadRequestDateType DateType
        {
            get
            {
                return this._dateType;
            }
            set
            {
                this._dateType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatusCode
        {
            get
            {
                return this._statusCode;
            }
            set
            {
                this._statusCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProfileTypeCode
        {
            get
            {
                return this._profileTypeCode;
            }
            set
            {
                this._profileTypeCode = value;
            }
        }
    }
}