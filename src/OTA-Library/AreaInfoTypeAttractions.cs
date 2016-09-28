using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeAttractions
    {
        
        private List<AreaInfoTypeAttractionsAttraction> _attraction;
        
        private System.DateTime _lastUpdated;
        
        public AreaInfoTypeAttractions()
        {
            this._attraction = new List<AreaInfoTypeAttractionsAttraction>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Attraction")]
        public List<AreaInfoTypeAttractionsAttraction> Attraction
        {
            get
            {
                return this._attraction;
            }
            set
            {
                this._attraction = value;
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