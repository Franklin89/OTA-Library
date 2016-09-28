namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OntologyAgeBirthDateType
    {
        
        private bool _privacyInd;
        
        private string _age;
        
        private System.DateTime _birthDate;
        
        private string _birthYear;
        
        private string _ontologyRefID;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrivacyInd
        {
            get
            {
                return this._privacyInd;
            }
            set
            {
                this._privacyInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        public string BirthYear
        {
            get
            {
                return this._birthYear;
            }
            set
            {
                this._birthYear = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OntologyRefID
        {
            get
            {
                return this._ontologyRefID;
            }
            set
            {
                this._ontologyRefID = value;
            }
        }
    }
}