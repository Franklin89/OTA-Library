using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeExchResidualFareComponent : FareComponentType
    {
        
        private List<AirTaxType> _taxes;
        
        private EMD_TypeExchResidualFareComponentTotalAmount _totalAmount;
        
        public EMD_TypeExchResidualFareComponent()
        {
            this._totalAmount = new EMD_TypeExchResidualFareComponentTotalAmount();
            this._taxes = new List<AirTaxType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Tax", IsNullable=false)]
        public List<AirTaxType> Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public EMD_TypeExchResidualFareComponentTotalAmount TotalAmount
        {
            get
            {
                return this._totalAmount;
            }
            set
            {
                this._totalAmount = value;
            }
        }
    }
}