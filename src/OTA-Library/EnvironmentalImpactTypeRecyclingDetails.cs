using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class EnvironmentalImpactTypeRecyclingDetails
    {
        
        private List<List_RecycledProducts> _recycledProducts;
        
        private List<List_RecycleFacilityLocation> _recyclingLocations;
        
        public EnvironmentalImpactTypeRecyclingDetails()
        {
            this._recyclingLocations = new List<List_RecycleFacilityLocation>();
            this._recycledProducts = new List<List_RecycledProducts>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RecycledProducts")]
        public List<List_RecycledProducts> RecycledProducts
        {
            get
            {
                return this._recycledProducts;
            }
            set
            {
                this._recycledProducts = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RecyclingLocations")]
        public List<List_RecycleFacilityLocation> RecyclingLocations
        {
            get
            {
                return this._recyclingLocations;
            }
            set
            {
                this._recyclingLocations = value;
            }
        }
    }
}