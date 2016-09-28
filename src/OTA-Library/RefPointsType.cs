using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RefPointsType
    {
        
        private List<RefPointsTypeRefPoint> _refPoint;
        
        public RefPointsType()
        {
            this._refPoint = new List<RefPointsTypeRefPoint>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RefPoint")]
        public List<RefPointsTypeRefPoint> RefPoint
        {
            get
            {
                return this._refPoint;
            }
            set
            {
                this._refPoint = value;
            }
        }
    }
}