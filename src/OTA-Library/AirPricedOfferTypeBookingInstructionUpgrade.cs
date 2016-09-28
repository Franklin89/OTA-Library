using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirPricedOfferTypeBookingInstructionUpgrade
    {
        
        private List<string> _instruction;
        
        private AirPricedOfferTypeBookingInstructionUpgradeUpgradeMethod _upgradeMethod;
        
        private string _upgradeDesigCode;
        
        public AirPricedOfferTypeBookingInstructionUpgrade()
        {
            this._instruction = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Instruction")]
        public List<string> Instruction
        {
            get
            {
                return this._instruction;
            }
            set
            {
                this._instruction = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirPricedOfferTypeBookingInstructionUpgradeUpgradeMethod UpgradeMethod
        {
            get
            {
                return this._upgradeMethod;
            }
            set
            {
                this._upgradeMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UpgradeDesigCode
        {
            get
            {
                return this._upgradeDesigCode;
            }
            set
            {
                this._upgradeDesigCode = value;
            }
        }
    }
}