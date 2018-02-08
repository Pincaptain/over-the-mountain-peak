using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Over_The_Mountains_Peak {
    class ViewNode : TreeNode {
        public ViewNode() : base() {}

        public new string ToString() {
            return Text;
        }
    }
}
