using System;
using System.Collections.Generic;

namespace FSharpInterop.DomainModel
{
    public class Exam
    {
        public ICollection<Section> Sections { get; set; }

        public Exam() {

        }
    }
}
