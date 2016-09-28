namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelSearchCriterionTypeUserGeneratedContent
    {
        
        private HotelSearchCriterionTypeUserGeneratedContentTypeOfRating _typeOfRating;
        
        private string _rating;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelSearchCriterionTypeUserGeneratedContentTypeOfRating TypeOfRating
        {
            get
            {
                return this._typeOfRating;
            }
            set
            {
                this._typeOfRating = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Rating
        {
            get
            {
                return this._rating;
            }
            set
            {
                this._rating = value;
            }
        }
    }
}