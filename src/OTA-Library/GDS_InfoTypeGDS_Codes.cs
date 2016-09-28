using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GDS_InfoTypeGDS_Codes
    {
        
        private List<GDS_InfoTypeGDS_CodesGDS_Code> _gDS_Code;
        
        private bool _loadGDSIndicator;
        
        public GDS_InfoTypeGDS_Codes()
        {
            this._gDS_Code = new List<GDS_InfoTypeGDS_CodesGDS_Code>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GDS_Code")]
        public List<GDS_InfoTypeGDS_CodesGDS_Code> GDS_Code
        {
            get
            {
                return this._gDS_Code;
            }
            set
            {
                this._gDS_Code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LoadGDSIndicator
        {
            get
            {
                return this._loadGDSIndicator;
            }
            set
            {
                this._loadGDSIndicator = value;
            }
        }
    }
}