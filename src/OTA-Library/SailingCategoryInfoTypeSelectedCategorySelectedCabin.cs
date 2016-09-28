using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingCategoryInfoTypeSelectedCategorySelectedCabin : CabinOptionType
    {
        
        private List<SailingCategoryInfoTypeSelectedCategorySelectedCabinCabinAttribute> _cabinAttributes;
        
        public SailingCategoryInfoTypeSelectedCategorySelectedCabin()
        {
            this._cabinAttributes = new List<SailingCategoryInfoTypeSelectedCategorySelectedCabinCabinAttribute>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("CabinAttribute", IsNullable=false)]
        public List<SailingCategoryInfoTypeSelectedCategorySelectedCabinCabinAttribute> CabinAttributes
        {
            get
            {
                return this._cabinAttributes;
            }
            set
            {
                this._cabinAttributes = value;
            }
        }
    }
}