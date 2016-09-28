using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrasType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrasInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ExtrasCoreType
    {
        
        private List<ExtrasCoreTypeSubCategory> _subCategory;
        
        private string _rPH;
        
        private string _code;
        
        private string _type;
        
        private string _quantity;
        
        private string _groupCode;
        
        private string _name;
        
        private List<string> _listOfInventoryItemRPH;
        
        private List<string> _listofRoomRPH;
        
        public ExtrasCoreType()
        {
            this._listofRoomRPH = new List<string>();
            this._listOfInventoryItemRPH = new List<string>();
            this._subCategory = new List<ExtrasCoreTypeSubCategory>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SubCategory")]
        public List<ExtrasCoreTypeSubCategory> SubCategory
        {
            get
            {
                return this._subCategory;
            }
            set
            {
                this._subCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
        public string GroupCode
        {
            get
            {
                return this._groupCode;
            }
            set
            {
                this._groupCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfInventoryItemRPH
        {
            get
            {
                return this._listOfInventoryItemRPH;
            }
            set
            {
                this._listOfInventoryItemRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListofRoomRPH
        {
            get
            {
                return this._listofRoomRPH;
            }
            set
            {
                this._listofRoomRPH = value;
            }
        }
    }
}