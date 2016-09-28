using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingCategoryInfoType : SailingInfoType
    {
        
        private List<SailingCategoryInfoTypeSelectedCategory> _selectedCategory;
        
        public SailingCategoryInfoType()
        {
            this._selectedCategory = new List<SailingCategoryInfoTypeSelectedCategory>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectedCategory")]
        public List<SailingCategoryInfoTypeSelectedCategory> SelectedCategory
        {
            get
            {
                return this._selectedCategory;
            }
            set
            {
                this._selectedCategory = value;
            }
        }
    }
}