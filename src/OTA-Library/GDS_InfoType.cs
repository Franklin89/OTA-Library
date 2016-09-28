using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GDS_InfoType
    {
        
        private GDS_InfoTypeGDS_Codes _gDS_Codes;
        
        private List<GDS_InfoTypeGDS_Status> _gDS_Statuses;
        
        private string _masterChainCode;
        
        public GDS_InfoType()
        {
            this._gDS_Statuses = new List<GDS_InfoTypeGDS_Status>();
            this._gDS_Codes = new GDS_InfoTypeGDS_Codes();
        }
        
        public GDS_InfoTypeGDS_Codes GDS_Codes
        {
            get
            {
                return this._gDS_Codes;
            }
            set
            {
                this._gDS_Codes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GDS_Status", IsNullable=false)]
        public List<GDS_InfoTypeGDS_Status> GDS_Statuses
        {
            get
            {
                return this._gDS_Statuses;
            }
            set
            {
                this._gDS_Statuses = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MasterChainCode
        {
            get
            {
                return this._masterChainCode;
            }
            set
            {
                this._masterChainCode = value;
            }
        }
    }
}