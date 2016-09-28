using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeRecreations
    {
        
        private List<AreaInfoTypeRecreationsRecreation> _recreation;
        
        private System.DateTime _lastUpdated;
        
        public AreaInfoTypeRecreations()
        {
            this._recreation = new List<AreaInfoTypeRecreationsRecreation>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Recreation")]
        public List<AreaInfoTypeRecreationsRecreation> Recreation
        {
            get
            {
                return this._recreation;
            }
            set
            {
                this._recreation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}