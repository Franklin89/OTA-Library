namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class List_ApplyToLevel
    {
        
        private List_ApplyToLevel_Base _list;
        
        private CodeListSummaryExtension _extension;
        
        public List_ApplyToLevel()
        {
            this._extension = new CodeListSummaryExtension();
        }
        
        public List_ApplyToLevel_Base List
        {
            get
            {
                return this._list;
            }
            set
            {
                this._list = value;
            }
        }
        
        public CodeListSummaryExtension Extension
        {
            get
            {
                return this._extension;
            }
            set
            {
                this._extension = value;
            }
        }
    }
}