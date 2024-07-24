// For more information see https://aka.ms/fsharp-console-apps

let sumOfMultiplesOfThree n =
    let rec sumHelper current accumulator =
        if current > n then
            accumulator
        else
            sumHelper (current + 3) (accumulator + current)
    
    sumHelper 3 0

let result = sumOfMultiplesOfThree 27
printfn "Sum of multiples of 3 up to 27: %d" result
