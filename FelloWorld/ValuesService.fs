namespace ValuesService

type IValuesService =
    abstract member GetAllValues: unit -> string[]
    abstract member GetValue: int -> string

type ValuesService() = 
    let valuesDB =   [|"value1"; "value2"|]
    interface IValuesService with 
        member __.GetAllValues() = valuesDB
        member __.GetValue(index: int) = 
            let result = valuesDB |> Array.tryItem index
            match result with 
            | Some value -> value
            | None -> "Oh nooooo"