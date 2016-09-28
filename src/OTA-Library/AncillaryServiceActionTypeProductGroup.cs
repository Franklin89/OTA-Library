using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AncillaryServiceActionTypeProductGroup
    {
        
        private List<AncillaryServiceActionTypeProductGroupSubGroup> _subGroup;
        
        private AncillaryServiceActionTypeProductGroupCodeSource _codeSource;
        
        private string _code;
        
        private string _description;
        
        private string _rPH;
        
        private string _brandedFareName;
        
        private IncludeExcludeType _resultsAction;
        
        public AncillaryServiceActionTypeProductGroup()
        {
            this._subGroup = new List<AncillaryServiceActionTypeProductGroupSubGroup>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubGroup")]
        public List<AncillaryServiceActionTypeProductGroupSubGroup> SubGroup
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
        public AncillaryServiceActionTypeProductGroupCodeSource CodeSource
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
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IncludeExcludeType ResultsAction
        {
            get
            {
                return this._resultsAction;
            }
            set
            {
                this._resultsAction = value;
            }
        }
    }
}