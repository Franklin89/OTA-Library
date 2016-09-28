using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AncillaryServiceActionType
    {
        
        private List<AncillaryServiceActionTypeProductGroup> _productGroup;
        
        private AncillaryServiceActionTypeCodeSource _codeSource;
        
        private AncillaryServiceFamilyEnum _serviceCode;
        
        private string _extServiceCode;
        
        private string _description;
        
        private string _rPH;
        
        private IncludeExcludeType _resultsAction;
        
        public AncillaryServiceActionType()
        {
            this._productGroup = new List<AncillaryServiceActionTypeProductGroup>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ProductGroup")]
        public List<AncillaryServiceActionTypeProductGroup> ProductGroup
        {
            get
            {
                return this._productGroup;
            }
            set
            {
                this._productGroup = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AncillaryServiceActionTypeCodeSource CodeSource
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
        public AncillaryServiceFamilyEnum ServiceCode
        {
            get
            {
                return this._serviceCode;
            }
            set
            {
                this._serviceCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtServiceCode
        {
            get
            {
                return this._extServiceCode;
            }
            set
            {
                this._extServiceCode = value;
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