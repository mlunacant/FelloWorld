﻿namespace FelloWorld.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open ValuesService

[<Route("api/[controller]")>]
[<ApiController>]
type ValuesController (service: IValuesService) =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let values = service.GetAllValues()
        ActionResult<string[]>(values)

    [<HttpGet("{id}")>]
    member this.Get(id:int) =
        let value = service.GetValue(id)
        ActionResult<string>(value)

    [<HttpPost>]
    member this.Post([<FromBody>] value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>] value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
