module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    0.0 // write your code here

let footToInch x =
    0.0 // write your code here

let yardToFoot v =
    0.0 // write your code here

let mileToYard mile =
    0.0 // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    0.0 // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x // write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    0.0 // write your code here

let meterToKilometer =
    fun x->x // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun x->x // write your code here

let inchToMeter =
    fun x->x // write your code here

let yardToKilometer =
    fun x->x // write your code here

let mileToMeter =
    fun x->x // write your code here


// Define following weight unit transformations
let ounceToGram v =
    0.0 // write your code here

let poundToOunce p =
    0.0 // write your code here

let shortTonToPound t =
    0.0 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    0.0 // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x // write your code here

let poundToKilogram =
    fun x->x // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here
