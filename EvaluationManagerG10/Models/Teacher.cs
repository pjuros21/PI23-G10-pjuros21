﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManagerG10.Models {
    public class Teacher : Person {
        public string Username {
            get; set;
        }
        public string Password {
            get; set;
        }

        public bool CheckPassword(string password) {
            return Password == password;
        }
    }
}
