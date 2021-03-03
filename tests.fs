//------------------------------
//   DO NOT MODIFY THIS FILE
//------------------------------
module Test

open System
open Expecto
open Expecto.Impl
open Expecto.Logging
open Expecto.Logging.Message
open Assignment

let tests =
  testList "Tests" [
    testCase "d1" (fun () ->
        Expect.equal (inchToMillimeter 5.0) 127.0 "5in = 127mm"
    );
    testCase "d2" (fun () ->
        Expect.equal (footToInch 2.0) 24.0 "2ft = 24in"
    );
    testCase "d3" (fun () ->
        Expect.equal (yardToFoot 7.0) 21.0 "7yr = 21ft"
    );
    testCase "d4" (fun () ->
        Expect.equal (yardToMillimeter 5.0) 4572.0 "5yr = 4572mm"
    );
    testCase "d5" (fun () ->
        Expect.equal (divBy1000 5000.0) 5.0 "5000/1000 = 5"
    );
    testCase "d6" (fun () ->
        Expect.equal (millimeterToMeter 5000.0) 5.0 "5000mm = 5m"
    );
    testCase "d7" (fun () ->
        Expect.equal (meterToKilometer 5000.0) 5.0 "5000m = 5km"
    );
    testCase "d8" (fun () ->
        Expect.equal (millimeterToKilometer 500000.0) 0.5 "500000mm = 0.5km"
    );
    testCase "d9" (fun () ->
        Expect.equal (inchToMeter 50.0) 1.27 "50in = 1.27m"
    );
    testCase "d10" (fun () ->
        Expect.floatClose Accuracy.high (yardToKilometer 1234.0) 1.1283696 "1234yd= 1.1283696km"
    );
    testCase "d11" (fun () ->
        Expect.floatClose Accuracy.high (mileToMeter 5.0) 2682.24 "5mil = 2682.24m"
    );
    testCase "w1" (fun () ->
        Expect.floatClose Accuracy.high (ounceToGram 12.0) 340.1942775 "12oz = 340.1942775g"
    );
    testCase "w2" (fun () ->
        Expect.floatClose Accuracy.high (poundToOunce 5.0) 80.0 "5lb = 80oz"
    );
    testCase "w3" (fun () ->
        Expect.floatClose Accuracy.high (shortTonToPound 7.0) 14000.0 "7st = 14000lb"
    );
    testCase "w4" (fun () ->
        Expect.floatClose Accuracy.high (gramToKilogram 1285.0) 1.285 "1285g = 1.285kg"
    );
    testCase "w5" (fun () ->
        Expect.floatClose Accuracy.high (gramToMetricTon 123456.0) 0.123456 "123456g = 0.123456t"
    );
    testCase "w6" (fun () ->
        Expect.floatClose Accuracy.high (poundToKilogram 5.0) 2.26796185 "5lb = 2.26796185kg"
    );
    testCase "w7" (fun () ->
        Expect.floatClose Accuracy.high (shortTonToMetricTon 3.0) 2.72155422 "3st = 2.72155422t"
    );
  ]

[<EntryPoint>]
let main args =
  let customFail = { TestPrinters.defaultPrinter with
                        failed = fun n m d ->
                            let lines = m.Split('\n')
                            let res = Array.tryFindIndex (fun (s:string) -> s.Contains("tests.fs")) lines
                            let i = if res.IsNone then 3 else res.Value
                            let newmsg = lines.[0..i] |> Array.fold (fun r s -> r + s + "\n") ""
                            async {
                              do! logger.log LogLevel.Error (
                                    eventX "{testName} failed in {duration}. {message}"
                                    >> setField "testName" n
                                    >> setField "duration" d
                                    >> setField "message" (newmsg.TrimEnd('\n')))
                            }
                    }
  let config = [
    Printer customFail
  ]
  runTestsWithCLIArgs config args tests
