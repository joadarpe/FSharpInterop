using System;
using System.Collections.Generic;

namespace FSharpInterop.DomainModel
{
    public class Section
    {
        public int Number { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
