using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyTravelerClassType
    {
        
        private List<OntologyTravelerClassTypeAgeCategory> _ageCategory;
        
        private List<OntologyTravelerClassTypePassengerCategory> _passengerCategory;
        
        private OntologyExtensionType _ontologyExtension;
        
        private string _disabledQty;
        
        public OntologyTravelerClassType()
        {
            this._ontologyExtension = new OntologyExtensionType();
            this._passengerCategory = new List<OntologyTravelerClassTypePassengerCategory>();
            this._ageCategory = new List<OntologyTravelerClassTypeAgeCategory>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AgeCategory")]
        public List<OntologyTravelerClassTypeAgeCategory> AgeCategory
        {
            get
            {
                return this._ageCategory;
            }
            set
            {
                this._ageCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PassengerCategory")]
        public List<OntologyTravelerClassTypePassengerCategory> PassengerCategory
        {
            get
            {
                return this._passengerCategory;
            }
            set
            {
                this._passengerCategory = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string DisabledQty
        {
            get
            {
                return this._disabledQty;
            }
            set
            {
                this._disabledQty = value;
            }
        }
    }
}