using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeRatePlanShoulder
    {
        
        private List<SellableProductsTypeSellableProduct> _sellableProducts;
        
        private string _shoulderRPH;
        
        private string _preShoulderSellLimit;
        
        private string _postShoulderSellLimit;
        
        private string _preShoulderStartDate;
        
        private string _postShoulderEndDate;
        
        public HotelRatePlanTypeRatePlanShoulder()
        {
            this._sellableProducts = new List<SellableProductsTypeSellableProduct>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SellableProduct", IsNullable=false)]
        public List<SellableProductsTypeSellableProduct> SellableProducts
        {
            get
            {
                return this._sellableProducts;
            }
            set
            {
                this._sellableProducts = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShoulderRPH
        {
            get
            {
                return this._shoulderRPH;
            }
            set
            {
                this._shoulderRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string PreShoulderSellLimit
        {
            get
            {
                return this._preShoulderSellLimit;
            }
            set
            {
                this._preShoulderSellLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string PostShoulderSellLimit
        {
            get
            {
                return this._postShoulderSellLimit;
            }
            set
            {
                this._postShoulderSellLimit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PreShoulderStartDate
        {
            get
            {
                return this._preShoulderStartDate;
            }
            set
            {
                this._preShoulderStartDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PostShoulderEndDate
        {
            get
            {
                return this._postShoulderEndDate;
            }
            set
            {
                this._postShoulderEndDate = value;
            }
        }
    }
}