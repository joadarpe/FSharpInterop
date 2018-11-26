namespace FSharpInterop.BusinessRules

module Evaluations = 
    open FSharpInterop.DomainModel

    let private questionsScore (q: Question seq) = 
        q 
        |> Seq.sumBy (fun x -> x.Score)

    let private sectionScore (s: Section) =
        s.Questions
        |> questionsScore

    let overallScore (e: Exam) =
        e.Sections
        |> Seq.sumBy sectionScore

    let sectionScores (e: Exam) =
        e.Sections
        |> Seq.map (fun x -> (x, x |> sectionScore))

    let difficultyScores (e: Exam) =
        e.Sections
        |> Seq.collect (fun x -> x.Questions)
        |> Seq.groupBy (fun x -> x.Difficulty)
        |> Seq.map (fun (k, v) -> (k, v |> questionsScore))

    let easyQuestions (e: Exam) =
        e.Sections
        |> Seq.collect (fun x -> x.Questions)
        |> Seq.filter (fun x -> x.Difficulty = Difficulty.Easy)