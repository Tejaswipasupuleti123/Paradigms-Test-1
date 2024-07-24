// For more information see https://aka.ms/fsharp-console-apps

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let updatedSalaries = 
    salaries
    |> List.filter (fun x -> x < 49020.0)
    |> List.map (fun x -> x + 20000.0)

printfn "List of Salaries: %A" (salaries |> List.map (sprintf "$%0.0f"))
printfn "Filtered Salaries : %A" (updatedSalaries |> List.map (sprintf "$%0.0f"))
