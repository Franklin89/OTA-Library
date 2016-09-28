using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewershipLocationCodes
    {
        
        private List<ViewershipsTypeViewershipLocationCodesLocationCode> _locationCode;
        
        private bool _locationCodesInclusive;
        
        public ViewershipsTypeViewershipLocationCodes()
        {
            this._locationCode = new List<ViewershipsTypeViewershipLocationCodesLocationCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LocationCode")]
        public List<ViewershipsTypeViewershipLocationCodesLocationCode> LocationCode
        {
            get
            {
                return this._locationCode;
            }
            set
            {
                this._locationCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LocationCodesInclusive
        {
            get
            {
                return this._locationCodesInclusive;
            }
            set
            {
                this._locationCodesInclusive = value;
            }
        }
    }
}