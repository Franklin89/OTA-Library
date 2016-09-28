namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayTypeBasicPropertyInfo : BasicPropertyInfoType
    {
        
        private RoomStayTypeBasicPropertyInfoUserGeneratedContent _userGeneratedContent;
        
        public RoomStayTypeBasicPropertyInfo()
        {
            this._userGeneratedContent = new RoomStayTypeBasicPropertyInfoUserGeneratedContent();
        }
        
        public RoomStayTypeBasicPropertyInfoUserGeneratedContent UserGeneratedContent
        {
            get
            {
                return this._userGeneratedContent;
            }
            set
            {
                this._userGeneratedContent = value;
            }
        }
    }
}