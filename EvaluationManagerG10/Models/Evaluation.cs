using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EvaluationManagerG10.Models {
    public class Evaluation {
       public Activity Activity { get; set; }
        public Student Student { get; set; }
        public Teacher Evaluator { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int Points { get; set; }

        public bool IsSufficientForGrade() {
            public int Points >= Avtivity.MinPointsForGrade;
        }
    }
}
