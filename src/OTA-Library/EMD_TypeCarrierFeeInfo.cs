using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EMD_TypeCarrierFeeInfo
    {
        
        private PaymentDetailType _paymentDetail;
        
        private List<EMD_TypeCarrierFeeInfoCarrierFee> _carrierFee;
        
        private List<AirTaxType> _taxes;
        
        public EMD_TypeCarrierFeeInfo()
        {
            this._taxes = new List<AirTaxType>();
            this._carrierFee = new List<EMD_TypeCarrierFeeInfoCarrierFee>();
            this._paymentDetail = new PaymentDetailType();
        }
        
        public PaymentDetailType PaymentDetail
        {
            get
            {
                return this._paymentDetail;
            }
            set
            {
                this._paymentDetail = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CarrierFee")]
        public List<EMD_TypeCarrierFeeInfoCarrierFee> CarrierFee
        {
            get
            {
                return this._carrierFee;
            }
            set
            {
                this._carrierFee = value;
            }
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
    }
}