// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#  my Name is Ankush"
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Given Salaries: %A" salaries

let high =
    salaries
    |> List.filter (fun salary -> salary > 100000)

printfn "High-Income: %A" high

let cal salary =
    match salary with
    | n when n <= 49020 -> int (float n * 0.15)
    | n when n <= 98040 -> int (float n * 0.205)
    | n when n <= 151978 -> int (float n * 0.26)
    | n when n <= 216511 -> int (float n * 0.29)
    | _ -> int (float salary * 0.33)

let taxes =
    salaries
    |> List.map cal


printfn "Tax: %A" taxes

let filter =
    salaries
    |> List.filter (fun salary -> salary < 49020)
    |> List.map (fun salary -> salary + 20000)

printfn "Salaries After adding: %A" filter

let sum =
    salaries
    |> List.filter (fun salary -> salary >= 50000 && salary <= 100000)
    |> List.fold (+) 0

printfn "Sum of Salaries between $50,000 and $100,000: %d" sum

let sumb z =
    let rec b cal c =
        if c > z then
            cal
        else
            b (cal + c) (c + 3)
    
    b 0 3

let result = sumb 27
printfn "Result: %d" result
