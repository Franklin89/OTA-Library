using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirPricedInsuranceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirInsuranceOfferType
    {
        
        private CompanyNameType _providerCompany;
        
        private AirInsuranceOfferTypeTotalTripCost _totalTripCost;
        
        private List<SearchTravelerType> _coveredTraveler;
        
        private string _code;
        
        private string _sellingComponentCode;
        
        private string _start;
        
        private string _duration;
        
        private string _end;
        
        private string _rPH;
        
        public AirInsuranceOfferType()
        {
            this._coveredTraveler = new List<SearchTravelerType>();
            this._totalTripCost = new AirInsuranceOfferTypeTotalTripCost();
            this._providerCompany = new CompanyNameType();
        }
        
        public CompanyNameType ProviderCompany
        {
            get
            {
                return this._providerCompany;
            }
            set
            {
                this._providerCompany = value;
            }
        }
        
        public AirInsuranceOfferTypeTotalTripCost TotalTripCost
        {
            get
            {
                return this._totalTripCost;
            }
            set
            {
                this._totalTripCost = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CoveredTraveler")]
        public List<SearchTravelerType> CoveredTraveler
        {
            get
            {
                return this._coveredTraveler;
            }
            set
            {
                this._coveredTraveler = value;
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
        public string SellingComponentCode
        {
            get
            {
                return this._sellingComponentCode;
            }
            set
            {
                this._sellingComponentCode = value;
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
    }
}