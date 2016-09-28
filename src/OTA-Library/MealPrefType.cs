namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MealPrefType
    {
        
        private PreferLevelType _preferLevel;
        
        private MealType _mealType;
        
        private string _favoriteFood;
        
        private string _beverage;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this._preferLevel;
            }
            set
            {
                this._preferLevel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MealType MealType
        {
            get
            {
                return this._mealType;
            }
            set
            {
                this._mealType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FavoriteFood
        {
            get
            {
                return this._favoriteFood;
            }
            set
            {
                this._favoriteFood = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Beverage
        {
            get
            {
                return this._beverage;
            }
            set
            {
                this._beverage = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}