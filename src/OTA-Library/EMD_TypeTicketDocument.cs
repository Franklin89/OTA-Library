using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeTicketDocument
    {
        
        private List<EMD_TypeTicketDocumentCouponInfo> _couponInfo;
        
        private string _ticketDocumentNbr;
        
        private EMD_TypeTicketDocumentType _type;
        
        private bool _primaryDocInd;
        
        private string _inConnectionDocNbr;
        
        private System.DateTime _dateOfIssue;
        
        private bool _exchangeTktNbrInd;
        
        private string _companyShortName;
        
        private string _travelSector;
        
        private string _code;
        
        private string _codeContext;
        
        private string _countryCode;
        
        public EMD_TypeTicketDocument()
        {
            this._couponInfo = new List<EMD_TypeTicketDocumentCouponInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CouponInfo")]
        public List<EMD_TypeTicketDocumentCouponInfo> CouponInfo
        {
            get
            {
                return this._couponInfo;
            }
            set
            {
                this._couponInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDocumentNbr
        {
            get
            {
                return this._ticketDocumentNbr;
            }
            set
            {
                this._ticketDocumentNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EMD_TypeTicketDocumentType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryDocInd
        {
            get
            {
                return this._primaryDocInd;
            }
            set
            {
                this._primaryDocInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InConnectionDocNbr
        {
            get
            {
                return this._inConnectionDocNbr;
            }
            set
            {
                this._inConnectionDocNbr = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime DateOfIssue
        {
            get
            {
                return this._dateOfIssue;
            }
            set
            {
                this._dateOfIssue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExchangeTktNbrInd
        {
            get
            {
                return this._exchangeTktNbrInd;
            }
            set
            {
                this._exchangeTktNbrInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this._companyShortName;
            }
            set
            {
                this._companyShortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this._travelSector;
            }
            set
            {
                this._travelSector = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this._codeContext;
            }
            set
            {
                this._codeContext = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
    }
}