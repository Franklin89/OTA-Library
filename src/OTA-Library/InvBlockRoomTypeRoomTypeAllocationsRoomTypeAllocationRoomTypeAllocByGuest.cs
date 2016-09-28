namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class InvBlockRoomTypeRoomTypeAllocationsRoomTypeAllocationRoomTypeAllocByGuest
    {
        
        private string _numberOfGuests;
        
        private string _numberOfUnits;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string NumberOfGuests
        {
            get
            {
                return this._numberOfGuests;
            }
            set
            {
                this._numberOfGuests = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string NumberOfUnits
        {
            get
            {
                return this._numberOfUnits;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }
    }
}