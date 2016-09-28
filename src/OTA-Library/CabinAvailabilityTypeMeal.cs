namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CabinAvailabilityTypeMeal
    {
        
        private string _mealCode;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealCode
        {
            get
            {
                return this._mealCode;
            }
            set
            {
                this._mealCode = value;
            }
        }
    }
}