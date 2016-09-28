using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class GDS_InfoTypeGDS_CodesGDS_Code
    {
        
        private List<GDS_InfoTypeGDS_CodesGDS_CodeGDS_CodeDetail> _gDS_CodeDetails;
        
        private string _chainCode;
        
        private string _gDS_PropertyCode;
        
        private string _gDS_Name;
        
        private bool _loadGDSIndicator;
        
        private string _gDS_PropertyLongName;
        
        private string _gDS_PropertyShortName;
        
        private string _gDS_RoomTypeCode;
        
        public GDS_InfoTypeGDS_CodesGDS_Code()
        {
            this._gDS_CodeDetails = new List<GDS_InfoTypeGDS_CodesGDS_CodeGDS_CodeDetail>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GDS_CodeDetail", IsNullable=false)]
        public List<GDS_InfoTypeGDS_CodesGDS_CodeGDS_CodeDetail> GDS_CodeDetails
        {
            get
            {
                return this._gDS_CodeDetails;
            }
            set
            {
                this._gDS_CodeDetails = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainCode
        {
            get
            {
                return this._chainCode;
            }
            set
            {
                this._chainCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GDS_PropertyCode
        {
            get
            {
                return this._gDS_PropertyCode;
            }
            set
            {
                this._gDS_PropertyCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GDS_Name
        {
            get
            {
                return this._gDS_Name;
            }
            set
            {
                this._gDS_Name = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GDS_PropertyLongName
        {
            get
            {
                return this._gDS_PropertyLongName;
            }
            set
            {
                this._gDS_PropertyLongName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GDS_PropertyShortName
        {
            get
            {
                return this._gDS_PropertyShortName;
            }
            set
            {
                this._gDS_PropertyShortName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GDS_RoomTypeCode
        {
            get
            {
                return this._gDS_RoomTypeCode;
            }
            set
            {
                this._gDS_RoomTypeCode = value;
            }
        }
    }
}