using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RestaurantsType
    {
        
        private List<RestaurantsTypeRestaurant> _restaurant;
        
        private List<RestaurantsTypeSrvcInfoCode> _srvcInfoCodes;
        
        private string _quantity;
        
        public RestaurantsType()
        {
            this._srvcInfoCodes = new List<RestaurantsTypeSrvcInfoCode>();
            this._restaurant = new List<RestaurantsTypeRestaurant>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Restaurant")]
        public List<RestaurantsTypeRestaurant> Restaurant
        {
            get
            {
                return this._restaurant;
            }
            set
            {
                this._restaurant = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SrvcInfoCode", IsNullable=false)]
        public List<RestaurantsTypeSrvcInfoCode> SrvcInfoCodes
        {
            get
            {
                return this._srvcInfoCodes;
            }
            set
            {
                this._srvcInfoCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
    }
}