namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class BaggageSpecificationType
    {
        
        private BaggageWeightType _weight;
        
        private BaggageSizeType _size;
        
        private BaggageSpecificationTypeSpecialItem _specialItem;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _pieces;
        
        public BaggageSpecificationType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._specialItem = new BaggageSpecificationTypeSpecialItem();
            this._size = new BaggageSizeType();
            this._weight = new BaggageWeightType();
        }
        
        public BaggageWeightType Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
        
        public BaggageSizeType Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        public BaggageSpecificationTypeSpecialItem SpecialItem
        {
            get
            {
                return this._specialItem;
            }
            set
            {
                this._specialItem = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Pieces
        {
            get
            {
                return this._pieces;
            }
            set
            {
                this._pieces = value;
            }
        }
    }
}