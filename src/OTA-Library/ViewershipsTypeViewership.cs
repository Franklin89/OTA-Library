using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewership
    {
        
        private ViewershipsTypeViewershipViewershipCodes _viewershipCodes;
        
        private ViewershipsTypeViewershipSystemCodes _systemCodes;
        
        private List<ViewershipsTypeViewershipProfileType> _profileTypes;
        
        private List<UniqueID_Type> _profileRefs;
        
        private List<ProfileType> _profiles;
        
        private ViewershipsTypeViewershipLocationCodes _locationCodes;
        
        private ViewershipsTypeViewershipBookingChannelCodes _bookingChannelCodes;
        
        private List<ViewershipsTypeViewershipDistributorType> _distributorTypes;
        
        private string _viewershipRPH;
        
        private bool _viewOnly;
        
        public ViewershipsTypeViewership()
        {
            this._distributorTypes = new List<ViewershipsTypeViewershipDistributorType>();
            this._bookingChannelCodes = new ViewershipsTypeViewershipBookingChannelCodes();
            this._locationCodes = new ViewershipsTypeViewershipLocationCodes();
            this._profiles = new List<ProfileType>();
            this._profileRefs = new List<UniqueID_Type>();
            this._profileTypes = new List<ViewershipsTypeViewershipProfileType>();
            this._systemCodes = new ViewershipsTypeViewershipSystemCodes();
            this._viewershipCodes = new ViewershipsTypeViewershipViewershipCodes();
        }
        
        public ViewershipsTypeViewershipViewershipCodes ViewershipCodes
        {
            get
            {
                return this._viewershipCodes;
            }
            set
            {
                this._viewershipCodes = value;
            }
        }
        
        public ViewershipsTypeViewershipSystemCodes SystemCodes
        {
            get
            {
                return this._systemCodes;
            }
            set
            {
                this._systemCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileType", IsNullable=false)]
        public List<ViewershipsTypeViewershipProfileType> ProfileTypes
        {
            get
            {
                return this._profileTypes;
            }
            set
            {
                this._profileTypes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileRef", IsNullable=false)]
        public List<UniqueID_Type> ProfileRefs
        {
            get
            {
                return this._profileRefs;
            }
            set
            {
                this._profileRefs = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Profile", IsNullable=false)]
        public List<ProfileType> Profiles
        {
            get
            {
                return this._profiles;
            }
            set
            {
                this._profiles = value;
            }
        }
        
        public ViewershipsTypeViewershipLocationCodes LocationCodes
        {
            get
            {
                return this._locationCodes;
            }
            set
            {
                this._locationCodes = value;
            }
        }
        
        public ViewershipsTypeViewershipBookingChannelCodes BookingChannelCodes
        {
            get
            {
                return this._bookingChannelCodes;
            }
            set
            {
                this._bookingChannelCodes = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("DistributorType", IsNullable=false)]
        public List<ViewershipsTypeViewershipDistributorType> DistributorTypes
        {
            get
            {
                return this._distributorTypes;
            }
            set
            {
                this._distributorTypes = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViewershipRPH
        {
            get
            {
                return this._viewershipRPH;
            }
            set
            {
                this._viewershipRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ViewOnly
        {
            get
            {
                return this._viewOnly;
            }
            set
            {
                this._viewOnly = value;
            }
        }
    }
}