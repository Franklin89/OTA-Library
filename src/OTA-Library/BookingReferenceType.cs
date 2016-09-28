using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BookingReferenceType
    {
        
        private BookingReferenceTypeUniqueID_Type _uniqueID_Type;
        
        private CompanyNameType _company;
        
        private List<TravelerInfoType> _traveler;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _instance;
        
        private string _id;
        
        private string _associatedID;
        
        public BookingReferenceType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._traveler = new List<TravelerInfoType>();
            this._company = new CompanyNameType();
            this._uniqueID_Type = new BookingReferenceTypeUniqueID_Type();
        }
        
        public BookingReferenceTypeUniqueID_Type UniqueID_Type
        {
            get
            {
                return this._uniqueID_Type;
            }
            set
            {
                this._uniqueID_Type = value;
            }
        }
        
        public CompanyNameType Company
        {
            get
            {
                return this._company;
            }
            set
            {
                this._company = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Traveler")]
        public List<TravelerInfoType> Traveler
        {
            get
            {
                return this._traveler;
            }
            set
            {
                this._traveler = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Instance
        {
            get
            {
                return this._instance;
            }
            set
            {
                this._instance = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssociatedID
        {
            get
            {
                return this._associatedID;
            }
            set
            {
                this._associatedID = value;
            }
        }
    }
}