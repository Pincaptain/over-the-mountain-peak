using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Over_The_Mountains_Peak {
    static class Extension {
        public static void TreeViewSerialize(TreeView treeView, string fileName) {
            TreeNodeCollection nodes = treeView.Nodes;

            using (StreamWriter writer = new StreamWriter(fileName)) {
                Serialize(nodes, writer);
                writer.Close();
            }
        }

        public static void Serialize(TreeNodeCollection nodes, StreamWriter writer) {
            foreach (TreeNode node in nodes) {
                writer.Write("{\"Node\":" + ((View)node.Tag).Serialize() + ",\"Nodes\":[");
                Serialize(node.Nodes, writer);

                if (node.Parent == null ||
                    node.Parent.Nodes.Count == 1 ||
                    node.Parent.LastNode.Equals(node)) {
                    writer.Write("]}");
                }
                else {
                    writer.Write("]},");
                }
            }
        }

        public static void TreeViewDeserialize(TreeView treeView, string fileName) {
            using (StreamReader reader = new StreamReader(fileName)) {
                treeView.Nodes.Clear();
                treeView.Nodes.Add(new ViewNode() {
                    Tag = new CategoryView("Global"),
                    Text = "Global"
                });

                dynamic rawRootNode = JsonConvert.DeserializeObject(reader.ReadLine());
                Deserialize(treeView.Nodes[0].Nodes, rawRootNode.Nodes);
                reader.Close();
            }
        }

        public static void Deserialize(TreeNodeCollection populate, dynamic nodes) {
            foreach (dynamic node in nodes) {
                if (View.IsCategory(node.Node)) {
                    ViewNode viewNode = new ViewNode() {
                        Tag = CategoryView.Deserialize(node.Node),
                        Text = node.Node.ViewName.ToString()
                    };

                    populate.Add(viewNode);
                } else {
                    ViewNode viewNode = new ViewNode() {
                        Tag = DetailView.Deserialize(node.Node),
                        Text = node.Node.ViewName.ToString()
                    };

                    populate.Add(viewNode);
                }

                Deserialize(populate[populate.Count-1].Nodes, node.Nodes);
            }
        }
    }
}
