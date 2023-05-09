using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English4Dummies {
    public class VerbTense {
        string name;
        string structure;
        string whenToUse;
        string example;

        public VerbTense(string name, string structure, string whenToUse, string example) {
            this.Name = name;
            this.Structure = structure;
            this.WhenToUse = whenToUse;
            this.Example = example;
        }

        public string Name { get => name; set => name = value; }
        public string Structure { get => structure; set => structure = value; }
        public string WhenToUse { get => whenToUse; set => whenToUse = value; }
        public string Example { get => example; set => example = value; }

        public override string ToString() {
            return Name;
        }
    }

}
