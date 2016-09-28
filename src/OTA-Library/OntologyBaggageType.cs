using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyBaggageType
    {
        
        private OntologyWeightType _totalWeight;
        
        private List<OntologyBaggageTypeDetail> _detail;
        
        private OntologyExtensionType _ontologyExtension;
        
        private bool _specialItemInd;
        
        private string _totalPieces;
        
        public OntologyBaggageType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._detail = new List<OntologyBaggageTypeDetail>();
            this._totalWeight = new OntologyWeightType();
        }
        
        public OntologyWeightType TotalWeight
        {
            get
            {
                return this._totalWeight;
            }
            set
            {
                this._totalWeight = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Detail")]
        public List<OntologyBaggageTypeDetail> Detail
        {
            get
            {
                return this._detail;
            }
            set
            {
                this._detail = value;
            }
        }
        
        public OntologyExtensionType OntologyExtension
        {
            get
            {
                return this._ontologyExtension;
            }
            set
            {
                this._ontologyExtension = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SpecialItemInd
        {
            get
            {
                return this._specialItemInd;
            }
            set
            {
                this._specialItemInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TotalPieces
        {
            get
            {
                return this._totalPieces;
            }
            set
            {
                this._totalPieces = value;
            }
        }
    }
}