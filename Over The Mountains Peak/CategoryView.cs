using Newtonsoft.Json;
using System;

namespace Over_The_Mountains_Peak {
    class CategoryView : View {
        public CategoryView(string CategoryName) : base(CategoryName) {}

        public override bool IsCategory() {
            return true;
        }

        public override string ToString() {
            return ViewName;
        }

        public override string Serialize() {
            return JsonConvert.SerializeObject(this);
        }

        public static CategoryView Deserialize(dynamic obj) {
            CategoryView categoryView = new CategoryView(obj.ViewName.ToString());
            return categoryView;
        }
    }
}
