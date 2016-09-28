using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ProfilesTypeProfileInfo
    {
        
        private List<UniqueID_Type> _uniqueID;
        
        private ProfileType _profile;
        
        public ProfilesTypeProfileInfo()
        {
            this._profile = new ProfileType();
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
        
        public ProfileType Profile
        {
            get
            {
                return this._profile;
            }
            set
            {
                this._profile = value;
            }
        }
    }
}