using System;
using System.Collections.Generic;
using System.Linq;
using FSharpInterop.BusinessRules;
using FSharpInterop.DomainModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exam = CreateExam();
            Console.WriteLine("Overall score = {0}", Evaluations.overallScore(exam));
            Evaluations.sectionScores(exam).ToList().ForEach(x => Console.WriteLine("Section {0} score {1}", x.Item1.Number, x.Item2));
            Evaluations.difficultyScores(exam).ToList().ForEach(x => Console.WriteLine("{0} questions score {1}", x.Item1, x.Item2));
            Evaluations.easyQuestions(exam).ToList().ForEach(x => Console.WriteLine("Question {0} is Easy", x.Number));
        }

        private static Exam CreateExam() {
            return new Exam
            {
                Sections = new List<Section>
                {
                    new Section(){
                        Number = 1,
                        Questions = new List<Question>{
                            new Question() {
                                Difficulty = Difficulty.Easy,
                                Number = 1,
                                Score = 5
                            },
                            new Question() {
                                Difficulty = Difficulty.Hard,
                                Number = 2,
                                Score = 5
                            }
                        }
                    },
                    new Section(){
                        Number = 2,
                        Questions = new List<Question>{
                            new Question() {
                                Difficulty = Difficulty.Easy,
                                Number = 3,
                                Score = 4
                            },
                            new Question() {
                                Difficulty = Difficulty.Hard,
                                Number = 4,
                                Score = 4
                            }
                        }
                    }
                }
            };
        }
    }
}
