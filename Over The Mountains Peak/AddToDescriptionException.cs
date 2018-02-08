using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over_The_Mountains_Peak {
    class AddToDescriptionException : Exception {
        private new string Message;

        public AddToDescriptionException(string Message) {
            this.Message = Message;
        }
    }
}
