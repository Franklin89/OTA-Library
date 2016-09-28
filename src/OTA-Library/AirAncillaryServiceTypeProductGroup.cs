using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirAncillaryServiceTypeProductGroup
    {
        
        private List<AirAncillaryServiceTypeProductGroupSubGroup> _subGroup;
        
        private AirAncillaryServiceTypeProductGroupCodeSource _codeSource;
        
        private string _code;
        
        private string _description;
        
        private string _brandedFareName;
        
        public AirAncillaryServiceTypeProductGroup()
        {
            this._subGroup = new List<AirAncillaryServiceTypeProductGroupSubGroup>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubGroup")]
        public List<AirAncillaryServiceTypeProductGroupSubGroup> SubGroup
        {
            get
            {
                return this._subGroup;
            }
            set
            {
                this._subGroup = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirAncillaryServiceTypeProductGroupCodeSource CodeSource
        {
            get
            {
                return this._codeSource;
            }
            set
            {
                this._codeSource = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandedFareName
        {
            get
            {
                return this._brandedFareName;
            }
            set
            {
                this._brandedFareName = value;
            }
        }
    }
}