module Config

open System.Configuration

//-------------------------------------------------------------------------------------------------

let private reader = AppSettingsReader()

let serverUri = reader.GetValue("serverUri", typeof<string>) :?> string
let rippleKey = reader.GetValue("rippleKey", typeof<string>) :?> string
let secretKey = reader.GetValue("secretKey", typeof<string>) :?> string
