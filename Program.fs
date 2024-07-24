// For more information see https://aka.ms/fsharp-console-apps

let salaries = [$75000; $48000; $120000; $190000; $300113; $92000; $36000]

let highIncomeSalaries = List.filter (fun x -> x > 100000) salaries

printfn "List of Salaries: %A" salaries
printfn "High-Income Salaries which are above $100,000: %A" highIncomeSalaries
