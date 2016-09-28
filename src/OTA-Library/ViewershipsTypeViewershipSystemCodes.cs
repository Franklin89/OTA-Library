using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewershipSystemCodes
    {
        
        private List<ViewershipsTypeViewershipSystemCodesSystemCode> _systemCode;
        
        private bool _systemCodesInclusive;
        
        public ViewershipsTypeViewershipSystemCodes()
        {
            this._systemCode = new List<ViewershipsTypeViewershipSystemCodesSystemCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SystemCode")]
        public List<ViewershipsTypeViewershipSystemCodesSystemCode> SystemCode
        {
            get
            {
                return this._systemCode;
            }
            set
            {
                this._systemCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SystemCodesInclusive
        {
            get
            {
                return this._systemCodesInclusive;
            }
            set
            {
                this._systemCodesInclusive = value;
            }
        }
    }
}