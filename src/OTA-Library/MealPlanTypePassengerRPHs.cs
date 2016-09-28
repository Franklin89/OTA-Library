using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class MealPlanTypePassengerRPHs
    {
        
        private List<string> _listOfPassengerRPH;
        
        public MealPlanTypePassengerRPHs()
        {
            this._listOfPassengerRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> ListOfPassengerRPH
        {
            get
            {
                return this._listOfPassengerRPH;
            }
            set
            {
                this._listOfPassengerRPH = value;
            }
        }
    }
}