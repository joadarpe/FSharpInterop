using System;

namespace FSharpInterop.DomainModel
{
    public class Question
    {
        public Difficulty Difficulty { get; set; }
        public int Number { get; set; }
        public int Score { get; set; }
    }
}
