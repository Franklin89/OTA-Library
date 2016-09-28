using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class PeriodPriceType : OperationScheduleType
    {
        
        private List<PkgPriceType> _price;
        
        private string _rPH;
        
        private PeriodPriceTypeCategory _category;
        
        private PeriodPriceTypeType _type;
        
        private string _durationPeriod;
        
        private PricingType _priceBasis;
        
        private List<string> _basePeriodRPHs;
        
        private bool _guidePriceIndicator;
        
        private string _maximumPeriod;
        
        public PeriodPriceType()
        {
            this._basePeriodRPHs = new List<string>();
            this._price = new List<PkgPriceType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Price")]
        public List<PkgPriceType> Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
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
        public PeriodPriceTypeCategory Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PeriodPriceTypeType Type
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
        public string DurationPeriod
        {
            get
            {
                return this._durationPeriod;
            }
            set
            {
                this._durationPeriod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingType PriceBasis
        {
            get
            {
                return this._priceBasis;
            }
            set
            {
                this._priceBasis = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> BasePeriodRPHs
        {
            get
            {
                return this._basePeriodRPHs;
            }
            set
            {
                this._basePeriodRPHs = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuidePriceIndicator
        {
            get
            {
                return this._guidePriceIndicator;
            }
            set
            {
                this._guidePriceIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaximumPeriod
        {
            get
            {
                return this._maximumPeriod;
            }
            set
            {
                this._maximumPeriod = value;
            }
        }
    }
}