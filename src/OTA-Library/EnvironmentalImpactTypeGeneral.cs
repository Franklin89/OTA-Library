using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeGeneral
    {
        
        private List<ParagraphType> _certification;
        
        private List<ParagraphType> _environmental;
        
        private bool _certificationAvailInd;
        
        private bool _chemicalAllergiesInd;
        
        private bool _environmentalCleanersInd;
        
        private string _linenReuseInd;
        
        private bool _procurementPolicyInd;
        
        public EnvironmentalImpactTypeGeneral()
        {
            this._environmental = new List<ParagraphType>();
            this._certification = new List<ParagraphType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Certification")]
        public List<ParagraphType> Certification
        {
            get
            {
                return this._certification;
            }
            set
            {
                this._certification = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Environmental")]
        public List<ParagraphType> Environmental
        {
            get
            {
                return this._environmental;
            }
            set
            {
                this._environmental = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CertificationAvailInd
        {
            get
            {
                return this._certificationAvailInd;
            }
            set
            {
                this._certificationAvailInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChemicalAllergiesInd
        {
            get
            {
                return this._chemicalAllergiesInd;
            }
            set
            {
                this._chemicalAllergiesInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EnvironmentalCleanersInd
        {
            get
            {
                return this._environmentalCleanersInd;
            }
            set
            {
                this._environmentalCleanersInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinenReuseInd
        {
            get
            {
                return this._linenReuseInd;
            }
            set
            {
                this._linenReuseInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ProcurementPolicyInd
        {
            get
            {
                return this._procurementPolicyInd;
            }
            set
            {
                this._procurementPolicyInd = value;
            }
        }
    }
}