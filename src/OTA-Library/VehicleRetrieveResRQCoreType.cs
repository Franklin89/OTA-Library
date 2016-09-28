using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleRetrieveResRQCoreType
    {
        
        private List<UniqueID_Type> _uniqueID;
        
        private PersonNameType _personName;
        
        private VehicleRetrieveResRQCoreTypeCustLoyalty _custLoyalty;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleRetrieveResRQCoreType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._custLoyalty = new VehicleRetrieveResRQCoreTypeCustLoyalty();
            this._personName = new PersonNameType();
            this._uniqueID = new List<UniqueID_Type>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UniqueID")]
        public List<UniqueID_Type> UniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        
        public PersonNameType PersonName
        {
            get
            {
                return this._personName;
            }
            set
            {
                this._personName = value;
            }
        }
        
        public VehicleRetrieveResRQCoreTypeCustLoyalty CustLoyalty
        {
            get
            {
                return this._custLoyalty;
            }
            set
            {
                this._custLoyalty = value;
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
    }
}