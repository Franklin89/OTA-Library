using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RevenueCategoryType
    {
        
        private RevenueCategoryTypeSummaryAmount _summaryAmount;
        
        private List<RevenueDetailType> _revenueDetails;
        
        private string _revenueCategoryCode;
        
        public RevenueCategoryType()
        {
            this._revenueDetails = new List<RevenueDetailType>();
            this._summaryAmount = new RevenueCategoryTypeSummaryAmount();
        }
        
        public RevenueCategoryTypeSummaryAmount SummaryAmount
        {
            get
            {
                return this._summaryAmount;
            }
            set
            {
                this._summaryAmount = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RevenueDetail", IsNullable=false)]
        public List<RevenueDetailType> RevenueDetails
        {
            get
            {
                return this._revenueDetails;
            }
            set
            {
                this._revenueDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RevenueCategoryCode
        {
            get
            {
                return this._revenueCategoryCode;
            }
            set
            {
                this._revenueCategoryCode = value;
            }
        }
    }
}