namespace Over_The_Mountains_Peak {
    abstract class View {
        public string ViewName { get; set; }

        public View(string ViewName) {
            this.ViewName = ViewName;
        }

        public abstract bool IsCategory();

        public new abstract string ToString();

        public abstract string Serialize();

        public static bool IsCategory(dynamic obj) {
            if (obj.DetailContent == null) {
                return true;
            }
            return false;
        }
    }
}
