namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StatisticApplicationSetTypeStatisticCode
    {
        
        private string _statCode;
        
        private string _statCategoryCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatCode
        {
            get
            {
                return this._statCode;
            }
            set
            {
                this._statCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatCategoryCode
        {
            get
            {
                return this._statCategoryCode;
            }
            set
            {
                this._statCategoryCode = value;
            }
        }
    }
}