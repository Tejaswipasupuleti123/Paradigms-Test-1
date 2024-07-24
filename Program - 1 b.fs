// For more information see https://aka.ms/fsharp-console-apps
let getTaxRate salary =
    match salary with
    | x when x <= 49020.0 -> 0.15
    | x when x <= 98040.0 -> 0.205
    | x when x <= 151978.0 -> 0.26
    | x when x <= 216511.0 -> 0.29
    | _ -> 0.33

let formatSalaryAndRate salary =
    let taxRate = getTaxRate salary
    let rateString = 
        match taxRate with
        | 0.15 -> "15%"
        | 0.205 -> "20.5%"
        | 0.26 -> "26%"
        | 0.29 -> "29%"
        | 0.33 -> "33%"
        | _ -> "Unknown"
    sprintf "$%0.0f;%s" salary rateString

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let formattedResults = List.map formatSalaryAndRate salaries

printfn "List of Salaries: %A" (salaries |> List.map (sprintf "$%0.0f"))
printfn "Tax Results: [%s]" (String.concat ";" formattedResults)
