using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyAnimalType
    {
        
        private List<OntologyAnimalTypeDetail> _detail;
        
        private string _quantity;
        
        private bool _serviceAnimalInd;
        
        public OntologyAnimalType()
        {
            this._detail = new List<OntologyAnimalTypeDetail>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Detail")]
        public List<OntologyAnimalTypeDetail> Detail
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServiceAnimalInd
        {
            get
            {
                return this._serviceAnimalInd;
            }
            set
            {
                this._serviceAnimalInd = value;
            }
        }
    }
}