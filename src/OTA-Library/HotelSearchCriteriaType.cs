using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriteriaType
    {
        
        private List<HotelSearchCriteriaTypeCriterion> _criterion;
        
        private bool _availableOnlyIndicator;
        
        private bool _bestOnlyIndicator;
        
        private bool _totalAfterTaxOnlyInd;
        
        public HotelSearchCriteriaType()
        {
            this._criterion = new List<HotelSearchCriteriaTypeCriterion>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Criterion")]
        public List<HotelSearchCriteriaTypeCriterion> Criterion
        {
            get
            {
                return this._criterion;
            }
            set
            {
                this._criterion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableOnlyIndicator
        {
            get
            {
                return this._availableOnlyIndicator;
            }
            set
            {
                this._availableOnlyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BestOnlyIndicator
        {
            get
            {
                return this._bestOnlyIndicator;
            }
            set
            {
                this._bestOnlyIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TotalAfterTaxOnlyInd
        {
            get
            {
                return this._totalAfterTaxOnlyInd;
            }
            set
            {
                this._totalAfterTaxOnlyInd = value;
            }
        }
    }
}