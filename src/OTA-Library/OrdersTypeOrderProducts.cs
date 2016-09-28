using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OrdersTypeOrderProducts
    {
        
        private List<OrdersTypeOrderProductsProduct> _product;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public OrdersTypeOrderProducts()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._product = new List<OrdersTypeOrderProductsProduct>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public List<OrdersTypeOrderProductsProduct> Product
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
    }
}