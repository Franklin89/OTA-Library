namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoType
    {
        
        private AreaInfoTypeRefPoints _refPoints;
        
        private AreaInfoTypeAttractions _attractions;
        
        private AreaInfoTypeRecreations _recreations;
        
        private AreaInfoTypeOtherHotels _otherHotels;
        
        public AreaInfoType()
        {
            this._otherHotels = new AreaInfoTypeOtherHotels();
            this._recreations = new AreaInfoTypeRecreations();
            this._attractions = new AreaInfoTypeAttractions();
            this._refPoints = new AreaInfoTypeRefPoints();
        }
        
        public AreaInfoTypeRefPoints RefPoints
        {
            get
            {
                return this._refPoints;
            }
            set
            {
                this._refPoints = value;
            }
        }
        
        public AreaInfoTypeAttractions Attractions
        {
            get
            {
                return this._attractions;
            }
            set
            {
                this._attractions = value;
            }
        }
        
        public AreaInfoTypeRecreations Recreations
        {
            get
            {
                return this._recreations;
            }
            set
            {
                this._recreations = value;
            }
        }
        
        public AreaInfoTypeOtherHotels OtherHotels
        {
            get
            {
                return this._otherHotels;
            }
            set
            {
                this._otherHotels = value;
            }
        }
    }
}