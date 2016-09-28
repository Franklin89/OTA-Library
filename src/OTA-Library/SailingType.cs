using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SailingType : SailingInfoType
    {
        
        private List<SailingTypeDining> _dining;
        
        private List<GuestTransportationType> _transportation;
        
        private List<ParagraphType> _information;
        
        private string _maxCabinOccupancy;
        
        private CategoryLocationType _categoryLocation;
        
        public SailingType()
        {
            this._information = new List<ParagraphType>();
            this._transportation = new List<GuestTransportationType>();
            this._dining = new List<SailingTypeDining>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Dining")]
        public List<SailingTypeDining> Dining
        {
            get
            {
                return this._dining;
            }
            set
            {
                this._dining = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Transportation")]
        public List<GuestTransportationType> Transportation
        {
            get
            {
                return this._transportation;
            }
            set
            {
                this._transportation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Information")]
        public List<ParagraphType> Information
        {
            get
            {
                return this._information;
            }
            set
            {
                this._information = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxCabinOccupancy
        {
            get
            {
                return this._maxCabinOccupancy;
            }
            set
            {
                this._maxCabinOccupancy = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CategoryLocationType CategoryLocation
        {
            get
            {
                return this._categoryLocation;
            }
            set
            {
                this._categoryLocation = value;
            }
        }
    }
}