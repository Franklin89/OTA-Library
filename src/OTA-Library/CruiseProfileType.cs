using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CruiseProfileType
    {
        
        private List<CruiseProfileTypeCruiseProfile> _cruiseProfile;
        
        private CruiseProfileTypeProfileTypeIdentifier _profileTypeIdentifier;
        
        public CruiseProfileType()
        {
            this._cruiseProfile = new List<CruiseProfileTypeCruiseProfile>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CruiseProfile")]
        public List<CruiseProfileTypeCruiseProfile> CruiseProfile
        {
            get
            {
                return this._cruiseProfile;
            }
            set
            {
                this._cruiseProfile = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CruiseProfileTypeProfileTypeIdentifier ProfileTypeIdentifier
        {
            get
            {
                return this._profileTypeIdentifier;
            }
            set
            {
                this._profileTypeIdentifier = value;
            }
        }
    }
}