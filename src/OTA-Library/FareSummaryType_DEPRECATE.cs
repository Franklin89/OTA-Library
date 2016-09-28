using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class FareSummaryType_DEPRECATE
    {
        
        private FareSummaryType_DEPRECATETotalFare _totalFare;
        
        private List<FareSummaryType_DEPRECATEDiscount> _discount;
        
        public FareSummaryType_DEPRECATE()
        {
            this._discount = new List<FareSummaryType_DEPRECATEDiscount>();
            this._totalFare = new FareSummaryType_DEPRECATETotalFare();
        }
        
        public FareSummaryType_DEPRECATETotalFare TotalFare
        {
            get
            {
                return this._totalFare;
            }
            set
            {
                this._totalFare = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Discount")]
        public List<FareSummaryType_DEPRECATEDiscount> Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
    }
}