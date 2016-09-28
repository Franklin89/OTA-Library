namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VoluntaryChangesType
    {
        
        private VoluntaryChangesTypePenalty _penalty;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _volChangeInd;
        
        public VoluntaryChangesType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._penalty = new VoluntaryChangesTypePenalty();
        }
        
        public VoluntaryChangesTypePenalty Penalty
        {
            get
            {
                return this._penalty;
            }
            set
            {
                this._penalty = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VolChangeInd
        {
            get
            {
                return this._volChangeInd;
            }
            set
            {
                this._volChangeInd = value;
            }
        }
    }
}