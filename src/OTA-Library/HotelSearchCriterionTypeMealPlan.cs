using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeMealPlan
    {
        
        private List<string> _code;
        
        public HotelSearchCriterionTypeMealPlan()
        {
            this._code = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}