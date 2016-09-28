namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BasicPropertyInfoTypePolicy
    {
        
        private System.DateTime _checkInTime;
        
        private System.DateTime _checkOutTime;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime CheckInTime
        {
            get
            {
                return this._checkInTime;
            }
            set
            {
                this._checkInTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime CheckOutTime
        {
            get
            {
                return this._checkOutTime;
            }
            set
            {
                this._checkOutTime = value;
            }
        }
    }
}