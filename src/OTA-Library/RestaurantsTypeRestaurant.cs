using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RestaurantsTypeRestaurant : RestaurantType
    {
        
        private List<FeaturesTypeFeature> _features;
        
        private List<ContactInfoRootType> _contactInfos;
        
        private List<RestaurantsTypeRestaurantSrvcInfoCode> _srvcInfoCodes;
        
        private bool _removal;
        
        private string _awardsRPH;
        
        public RestaurantsTypeRestaurant()
        {
            this._srvcInfoCodes = new List<RestaurantsTypeRestaurantSrvcInfoCode>();
            this._contactInfos = new List<ContactInfoRootType>();
            this._features = new List<FeaturesTypeFeature>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public List<FeaturesTypeFeature> Features
        {
            get
            {
                return this._features;
            }
            set
            {
                this._features = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactInfo", IsNullable=false)]
        public List<ContactInfoRootType> ContactInfos
        {
            get
            {
                return this._contactInfos;
            }
            set
            {
                this._contactInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SrvcInfoCode", IsNullable=false)]
        public List<RestaurantsTypeRestaurantSrvcInfoCode> SrvcInfoCodes
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Removal
        {
            get
            {
                return this._removal;
            }
            set
            {
                this._removal = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AwardsRPH
        {
            get
            {
                return this._awardsRPH;
            }
            set
            {
                this._awardsRPH = value;
            }
        }
    }
}