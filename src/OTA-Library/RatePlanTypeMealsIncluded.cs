using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RatePlanTypeMealsIncluded
    {
        
        private bool _breakfast;
        
        private bool _lunch;
        
        private bool _dinner;
        
        private bool _mealPlanIndicator;
        
        private List<string> _mealPlanCodes;
        
        public RatePlanTypeMealsIncluded()
        {
            this._mealPlanCodes = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Breakfast
        {
            get
            {
                return this._breakfast;
            }
            set
            {
                this._breakfast = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Lunch
        {
            get
            {
                return this._lunch;
            }
            set
            {
                this._lunch = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Dinner
        {
            get
            {
                return this._dinner;
            }
            set
            {
                this._dinner = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MealPlanIndicator
        {
            get
            {
                return this._mealPlanIndicator;
            }
            set
            {
                this._mealPlanIndicator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> MealPlanCodes
        {
            get
            {
                return this._mealPlanCodes;
            }
            set
            {
                this._mealPlanCodes = value;
            }
        }
    }
}