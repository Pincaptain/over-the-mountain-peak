using System;
using Newtonsoft.Json;

namespace Over_The_Mountains_Peak {
    class DetailView : View {
        public string DetailContent { get; set; }
        public string DetailImagePath { get; set; }
        public string DetailImageDescription { get; set; }
        public string DetailAudioDescription { get; set; }

        public DetailView(string DetailTitle, string DetailContent, string DetailImagePath, string DetailImageDescription,
            string DetailAudioDescription) : base(DetailTitle) {
            this.DetailContent = DetailContent;
            this.DetailImagePath = DetailImagePath;
            this.DetailImageDescription = DetailImageDescription;
            this.DetailAudioDescription = DetailAudioDescription;
        }

        public override bool IsCategory() {
            return false;
        }

        public override string ToString() {
            return ViewName;
        }

        public override string Serialize() {
            return JsonConvert.SerializeObject(this);
        }

        public static DetailView Deserialize(dynamic obj) {
            DetailView detailView = new DetailView(obj.ViewName.ToString(), obj.DetailContent.ToString(),
                obj.DetailImagePath.ToString(), obj.DetailImageDescription.ToString(), obj.DetailAudioDescription.ToString());
            return detailView;
        }
    }
}
