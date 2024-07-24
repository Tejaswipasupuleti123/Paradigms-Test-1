// For more information see https://aka.ms/fsharp-console-apps

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let filteredSalaries = 
    salaries
    |> List.filter (fun x -> x >= 50000.0 && x <= 100000.0)

let sumFilteredSalaries = 
    filteredSalaries
    |> List.fold (fun acc x -> acc + x) 0.0

printfn "List of Salaries: %A" (salaries |> List.map (sprintf "$%0.0f"))
printfn "Sum of Salaries between $50,000 and $100,000: $%0.2f" sumFilteredSalaries



