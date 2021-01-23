﻿module HOF
open System
open System.Collections.Generic

let method func parameters = func parameters

let memoise fn =
    let cache = Dictionary<_,_>()
    (fun key ->
        match cache.TryGetValue(key) with
        |(true, v)->v
        |(false,_)->
            let v = fn key
            cache.Add(key,v)
            v
    )
    

        