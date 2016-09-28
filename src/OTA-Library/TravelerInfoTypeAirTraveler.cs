using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelerInfoTypeAirTraveler : AirTravelerType
    {
        
        private List<TravelerInfoTypeAirTravelerComment> _comment;
        
        public TravelerInfoTypeAirTraveler()
        {
            this._comment = new List<TravelerInfoTypeAirTravelerComment>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Comment")]
        public List<TravelerInfoTypeAirTravelerComment> Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
    }
}