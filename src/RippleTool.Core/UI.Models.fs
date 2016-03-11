module RippleTool.UI.Models

open System
open System.ComponentModel
open Microsoft.FSharp.Quotations.Patterns
open RippleTool.Types
open RippleTool.UI.Integration

//-------------------------------------------------------------------------------------------------

[<AbstractClass>]
type Model() =

    let propertyName = function
        | PropertyGet (_, info, _) -> info.Name
        | _ -> failwith "Expecting a property expression."

    let propertyChanged = Event<_, _>()

    interface INotifyPropertyChanged with

        [<CLIEvent>]
        member this.PropertyChanged = propertyChanged.Publish

    member this.OnPropertyChanged(expr) =
        let name = propertyName expr
        let args = PropertyChangedEventArgs(name)
        propertyChanged.Trigger(this, args)

//-------------------------------------------------------------------------------------------------

let private set (this : Model) value field expr =
    field := value
    this.OnPropertyChanged(expr)

let private optional value map =
    match value with
    | value when value = "" -> None
    | value -> value |> map |> Some

let private toCurrency code issuer = function
    | true  -> IssuedCurrency { Code = code; Issuer = issuer }
    | false -> NativeCurrency Xrp

let private toIssuedAmount value currency issuer =
    { Value = decimal value
      Currency = IssuedCurrency { Code = currency; Issuer = issuer } }

let private toNativeAmount value =
    { Value = decimal value
      Currency = NativeCurrency Xrp }

let private toAmount value currency issuer = function
    | true  -> toIssuedAmount value currency issuer
    | false -> toNativeAmount value

let private combineFlag flag (add : 'T) (acc : 'T) : 'T =
    let add = LanguagePrimitives.EnumToValue(add)
    let acc = LanguagePrimitives.EnumToValue(acc)
    let res = if flag then acc ||| add else acc
    LanguagePrimitives.EnumOfValue(res)

//-------------------------------------------------------------------------------------------------

type LedgerOption = { Value : Ledger; Display : string }

type LedgerOptions() as this =

    inherit BindingList<LedgerOption>()

    do this.Add({ Value = Ledger.Validated; Display = "Validated" })
    do this.Add({ Value = Ledger.Closed;    Display = "Closed" })
    do this.Add({ Value = Ledger.Current;   Display = "Current" })

//-------------------------------------------------------------------------------------------------

type RawJsonModel() =

    inherit Model()

    let json = ref ""

    member this.Json
        with get () = !json
        and set value = set this value json <@ this.Json @>

    member this.Submit() =

        executeRawJson !json

//-------------------------------------------------------------------------------------------------

type PingModel() =

    inherit Model()

    let commandId = ref ""

    member this.CommandId
        with get () = !commandId
        and set value = set this value commandId <@ this.CommandId @>

    member this.Submit() =

        let commandId = optional !commandId id

        let command : Ping =
            { Id = commandId }

        executeCommand (command |> Ping)

//-------------------------------------------------------------------------------------------------

type RandomModel() =

    inherit Model()

    let commandId = ref ""

    member this.CommandId
        with get () = !commandId
        and set value = set this value commandId <@ this.CommandId @>

    member this.Submit() =

        let commandId = optional !commandId id

        let command : Random =
            { Id = commandId }

        executeCommand (command |> Random)

//-------------------------------------------------------------------------------------------------

type ServerInfoModel() =

    inherit Model()

    let commandId = ref ""

    member this.CommandId
        with get () = !commandId
        and set value = set this value commandId <@ this.CommandId @>

    member this.Submit() =

        let commandId = optional !commandId id

        let command : ServerInfo =
            { Id = commandId }

        executeCommand (command |> ServerInfo)

//-------------------------------------------------------------------------------------------------

type ServerStateModel() =

    inherit Model()

    let commandId = ref ""

    member this.CommandId
        with get () = !commandId
        and set value = set this value commandId <@ this.CommandId @>

    member this.Submit() =

        let commandId = optional !commandId id

        let command : ServerState =
            { Id = commandId }

        executeCommand (command |> ServerState)

//-------------------------------------------------------------------------------------------------

type AccountCurrenciesModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountCurrencies =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> AccountCurrencies)

//-------------------------------------------------------------------------------------------------

type AccountInfoModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountInfo =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> AccountInfo)

//-------------------------------------------------------------------------------------------------

type AccountLinesModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountLines =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> AccountLines)

//-------------------------------------------------------------------------------------------------

type AccountObjectsModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountObjects =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> AccountObjects)

//-------------------------------------------------------------------------------------------------

type AccountOffersModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountOffers =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> AccountOffers)

//-------------------------------------------------------------------------------------------------

type AccountTransactionsModel() =

    inherit Model()

    let account = ref ""
    let binary = ref false

    member this.Ledger = "All"

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Binary
        with get () = !binary
        and set value = set this value binary <@ this.Binary @>

    member this.Submit() =

        let command : AccountTransactions =
            { Id = None
              Account = !account
              Ledger = None
              Binary = Some !binary }

        executeCommand (command |> AccountTransactions)

//-------------------------------------------------------------------------------------------------

type GatewayBalancesModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : GatewayBalances =
            { Id = None
              Account = !account
              Ledger = Some !ledger }

        executeCommand (command |> GatewayBalances)

//-------------------------------------------------------------------------------------------------

type NoRippleCheckModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""
    let roleIsUser = ref true
    let roleIsGateway = ref false

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.RoleIsUser
        with get () = !roleIsUser
        and set value =
            let user, gateway = (value, not value)
            set this user roleIsUser <@ this.RoleIsUser @>
            set this gateway roleIsGateway <@ this.RoleIsGateway @>

    member this.RoleIsGateway
        with get () = !roleIsGateway
        and set value =
            let user, gateway = (not value, value)
            set this user roleIsUser <@ this.RoleIsUser @>
            set this gateway roleIsGateway <@ this.RoleIsGateway @>

    member this.Submit() =

        let role = if !roleIsUser then User else Gateway

        let command : NoRippleCheck =
            { Id = None
              Account = !account
              Ledger = Some !ledger
              Role = role }

        executeCommand (command |> NoRippleCheck)

//-------------------------------------------------------------------------------------------------

type BookOffersModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let taker = ref ""
    let limit = ref ""
    let takerGetsIsIssued = ref true
    let takerGetsIsNative = ref false
    let takerGetsCurrency = ref ""
    let takerGetsIssuer = ref ""
    let takerPaysIsIssued = ref true
    let takerPaysIsNative = ref false
    let takerPaysCurrency = ref ""
    let takerPaysIssuer = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Taker
        with get () = !taker
        and set value = set this value taker <@ this.Taker @>

    member this.Limit
        with get () = !limit
        and set value = set this value limit <@ this.Limit @>

    member this.TakerGetsIsIssued
        with get () = !takerGetsIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsIsNative
        with get () = !takerGetsIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsCurrency
        with get () = !takerGetsCurrency
        and set value = set this value takerGetsCurrency <@ this.TakerGetsCurrency @>

    member this.TakerGetsIssuer
        with get () = !takerGetsIssuer
        and set value = set this value takerGetsIssuer <@ this.TakerGetsIssuer @>

    member this.TakerPaysIsIssued
        with get () = !takerPaysIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysIsNative
        with get () = !takerPaysIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysCurrency
        with get () = !takerPaysCurrency
        and set value = set this value takerPaysCurrency <@ this.TakerPaysCurrency @>

    member this.TakerPaysIssuer
        with get () = !takerPaysIssuer
        and set value = set this value takerPaysIssuer <@ this.TakerPaysIssuer @>

    member this.Submit() =

        let taker = optional !taker id
        let limit = optional !limit uint32

        let takerGets =
            !takerGetsIsIssued
            |> toCurrency !takerGetsCurrency !takerGetsIssuer

        let takerPays =
            !takerPaysIsIssued
            |> toCurrency !takerPaysCurrency !takerPaysIssuer

        let command : BookOffers =
            { Id = None
              Ledger = Some !ledger
              Taker = taker
              Limit = limit
              TakerGets = takerGets
              TakerPays = takerPays }

        executeCommand (command |> BookOffers)

//-------------------------------------------------------------------------------------------------

type RipplePathFindModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let sourceAccount = ref ""
    let destinationAccount = ref ""
    let destinationAmountIsIssued = ref true
    let destinationAmountIsNative = ref false
    let destinationAmountValue = ref ""
    let destinationAmountCurrency = ref ""
    let destinationAmountIssuer = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.SourceAccount
        with get () = !sourceAccount
        and set value = set this value sourceAccount <@ this.SourceAccount @>

    member this.DestinationAccount
        with get () = !destinationAccount
        and set value = set this value destinationAccount <@ this.DestinationAccount @>

    member this.DestinationAmountIsIssued
        with get () = !destinationAmountIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued destinationAmountIsIssued <@ this.DestinationAmountIsIssued @>
            set this native destinationAmountIsNative <@ this.DestinationAmountIsNative @>

    member this.DestinationAmountIsNative
        with get () = !destinationAmountIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued destinationAmountIsIssued <@ this.DestinationAmountIsIssued @>
            set this native destinationAmountIsNative <@ this.DestinationAmountIsNative @>

    member this.DestinationAmountValue
        with get () = !destinationAmountValue
        and set value = set this value destinationAmountValue <@ this.DestinationAmountValue @>

    member this.DestinationAmountCurrency
        with get () = !destinationAmountCurrency
        and set value = set this value destinationAmountCurrency <@ this.DestinationAmountCurrency @>

    member this.DestinationAmountIssuer
        with get () = !destinationAmountIssuer
        and set value = set this value destinationAmountIssuer <@ this.DestinationAmountIssuer @>

    member this.Submit() =

        let destinationAmount =
            !destinationAmountIsIssued
            |> toAmount !destinationAmountValue !destinationAmountCurrency !destinationAmountIssuer

        let command : RipplePathFind =
            { Id = None
              Ledger = Some !ledger
              SourceAccount = !sourceAccount
              DestinationAccount = !destinationAccount
              DestinationAmount = destinationAmount }

        executeCommand (command |> RipplePathFind)

//-------------------------------------------------------------------------------------------------

type SubmitPaymentModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let flagNoRippleDirect = ref false
    let flagPartialPayment = ref false
    let flagLimitQuality = ref false
    let sourceTag = ref ""
    let destinationTag = ref ""
    let destination = ref ""
    let amountIsIssued = ref true
    let amountIsNative = ref false
    let amountValue = ref ""
    let amountCurrency = ref ""
    let amountIssuer = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.FlagNoRippleDirect
        with get () = !flagNoRippleDirect
        and set value = set this value flagNoRippleDirect <@ this.FlagNoRippleDirect @>

    member this.FlagPartialPayment
        with get () = !flagPartialPayment
        and set value = set this value flagPartialPayment <@ this.FlagPartialPayment @>

    member this.FlagLimitQuality
        with get () = !flagLimitQuality
        and set value = set this value flagLimitQuality <@ this.FlagLimitQuality @>

    member this.SourceTag
        with get () = !sourceTag
        and set value = set this value sourceTag <@ this.SourceTag @>

    member this.DestinationTag
        with get () = !destinationTag
        and set value = set this value destinationTag <@ this.DestinationTag @>

    member this.Destination
        with get () = !destination
        and set value = set this value destination <@ this.Destination @>

    member this.AmountIsIssued
        with get () = !amountIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued amountIsIssued <@ this.AmountIsIssued @>
            set this native amountIsNative <@ this.AmountIsNative @>

    member this.AmountIsNative
        with get () = !amountIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued amountIsIssued <@ this.AmountIsIssued @>
            set this native amountIsNative <@ this.AmountIsNative @>

    member this.AmountValue
        with get () = !amountValue
        and set value = set this value amountValue <@ this.AmountValue @>

    member this.AmountCurrency
        with get () = !amountCurrency
        and set value = set this value amountCurrency <@ this.AmountCurrency @>

    member this.AmountIssuer
        with get () = !amountIssuer
        and set value = set this value amountIssuer <@ this.AmountIssuer @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            PaymentFlags.None
            |> combineFlag !flagFullyCanonicalSig PaymentFlags.FullyCanonicalSig
            |> combineFlag !flagNoRippleDirect    PaymentFlags.NoRippleDirect
            |> combineFlag !flagPartialPayment    PaymentFlags.PartialPayment
            |> combineFlag !flagLimitQuality      PaymentFlags.LimitQuality

        let sourceTag = optional !sourceTag uint32
        let destinationTag = optional !destinationTag uint32

        let amount =
            !amountIsIssued
            |> toAmount !amountValue !amountCurrency !amountIssuer

        let transaction : Payment =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              SourceTag = sourceTag
              DestinationTag = destinationTag
              Destination = !destination
              Amount = amount }

        executeSubmitTransaction (transaction |> Payment)

//-------------------------------------------------------------------------------------------------

type AccountSetFlagOption = { Value : AccountSetFlag option; Display : string }

type AccountSetFlagOptions() as this =

    inherit BindingList<AccountSetFlagOption>()

    do this.Add({ Value = None;                              Display = "" })
    do this.Add({ Value = Some AccountSetFlag.RequireDest;   Display = "Require destination tag" })
    do this.Add({ Value = Some AccountSetFlag.RequireAuth;   Display = "Require authorization" })
    do this.Add({ Value = Some AccountSetFlag.DisallowXrp;   Display = "Disallow XRP" })
    do this.Add({ Value = Some AccountSetFlag.DisableMaster; Display = "Disable master" })
    do this.Add({ Value = Some AccountSetFlag.AccountTxnId;  Display = "Account transaction ID" })
    do this.Add({ Value = Some AccountSetFlag.NoFreeze;      Display = "No freeze" })
    do this.Add({ Value = Some AccountSetFlag.GlobalFreeze;  Display = "Global freeze" })
    do this.Add({ Value = Some AccountSetFlag.DefaultRipple; Display = "Default ripple" })

type SubmitAccountSetModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let setFlag = ref None
    let clearFlag = ref None
    let transferRate = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.SetFlag
        with get () = !setFlag
        and set value = set this value setFlag <@ this.SetFlag @>

    member this.ClearFlag
        with get () = !clearFlag
        and set value = set this value clearFlag <@ this.ClearFlag @>

    member this.TransferRate
        with get () = !transferRate
        and set value = set this value transferRate <@ this.TransferRate @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            AccountSetFlags.None
            |> combineFlag !flagFullyCanonicalSig AccountSetFlags.FullyCanonicalSig

        let transferRate = optional !transferRate decimal

        let transaction : AccountSet =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              SetFlag = !setFlag
              ClearFlag = !clearFlag
              TransferRate = transferRate }

        executeSubmitTransaction (transaction |> AccountSet)

//-------------------------------------------------------------------------------------------------

type SubmitSetRegularKeyModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let regularKey = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.RegularKey
        with get () = !regularKey
        and set value = set this value regularKey <@ this.RegularKey @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            SetRegularKeyFlags.None
            |> combineFlag !flagFullyCanonicalSig SetRegularKeyFlags.FullyCanonicalSig

        let regularKey = optional !regularKey string

        let transaction : SetRegularKey =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              RegularKey = regularKey }

        executeSubmitTransaction (transaction |> SetRegularKey)

//-------------------------------------------------------------------------------------------------

type SubmitOfferCreate() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let flagPassive = ref false
    let flagImmediateOrCancel = ref false
    let flagFillOrKill = ref false
    let flagSell = ref false
    let offerSequence = ref ""
    let expiration = ref ""
    let takerGetsIsIssued = ref true
    let takerGetsIsNative = ref false
    let takerGetsValue = ref ""
    let takerGetsCurrency = ref ""
    let takerGetsIssuer = ref ""
    let takerPaysIsIssued = ref true
    let takerPaysIsNative = ref false
    let takerPaysValue = ref ""
    let takerPaysCurrency = ref ""
    let takerPaysIssuer = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.FlagPassive
        with get () = !flagPassive
        and set value = set this value flagPassive <@ this.FlagPassive @>

    member this.FlagImmediateOrCancel
        with get () = !flagImmediateOrCancel
        and set value = set this value flagImmediateOrCancel <@ this.FlagImmediateOrCancel @>

    member this.FlagFillOrKill
        with get () = !flagFillOrKill
        and set value = set this value flagFillOrKill <@ this.FlagFillOrKill @>

    member this.FlagSell
        with get () = !flagSell
        and set value = set this value flagSell <@ this.FlagSell @>

    member this.OfferSequence
        with get () = !offerSequence
        and set value = set this value offerSequence <@ this.OfferSequence @>

    member this.Expiration
        with get () = !expiration
        and set value = set this value expiration <@ this.Expiration @>

    member this.TakerGetsIsIssued
        with get () = !takerGetsIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsIsNative
        with get () = !takerGetsIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsValue
        with get () = !takerGetsValue
        and set value = set this value takerGetsValue <@ this.TakerGetsValue @>

    member this.TakerGetsCurrency
        with get () = !takerGetsCurrency
        and set value = set this value takerGetsCurrency <@ this.TakerGetsCurrency @>

    member this.TakerGetsIssuer
        with get () = !takerGetsIssuer
        and set value = set this value takerGetsIssuer <@ this.TakerGetsIssuer @>

    member this.TakerPaysIsIssued
        with get () = !takerPaysIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysIsNative
        with get () = !takerPaysIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysValue
        with get () = !takerPaysValue
        and set value = set this value takerPaysValue <@ this.TakerPaysValue @>

    member this.TakerPaysCurrency
        with get () = !takerPaysCurrency
        and set value = set this value takerPaysCurrency <@ this.TakerPaysCurrency @>

    member this.TakerPaysIssuer
        with get () = !takerPaysIssuer
        and set value = set this value takerPaysIssuer <@ this.TakerPaysIssuer @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            OfferCreateFlags.None
            |> combineFlag !flagFullyCanonicalSig OfferCreateFlags.FullyCanonicalSig
            |> combineFlag !flagPassive           OfferCreateFlags.Passive
            |> combineFlag !flagImmediateOrCancel OfferCreateFlags.ImmediateOrCancel
            |> combineFlag !flagFillOrKill        OfferCreateFlags.FillOrKill
            |> combineFlag !flagSell              OfferCreateFlags.Sell

        let offerSequence = optional !offerSequence uint32
        let expiration = optional !expiration (fun x -> DateTimeOffset.ParseExact(x, "u", null))

        let takerGets =
            !takerGetsIsIssued
            |> toAmount !takerGetsValue !takerGetsCurrency !takerGetsIssuer

        let takerPays =
            !takerPaysIsIssued
            |> toAmount !takerPaysValue !takerPaysCurrency !takerPaysIssuer

        let transaction : OfferCreate =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              OfferSequence = offerSequence
              Expiration = expiration
              TakerGets = takerGets
              TakerPays = takerPays }

        executeSubmitTransaction (transaction |> OfferCreate)

//-------------------------------------------------------------------------------------------------

type SubmitOfferCancel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let flagPassive = ref false
    let flagImmediateOrCancel = ref false
    let flagFillOrKill = ref false
    let flagSell = ref false
    let offerSequence = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.FlagPassive
        with get () = !flagPassive
        and set value = set this value flagPassive <@ this.FlagPassive @>

    member this.FlagImmediateOrCancel
        with get () = !flagImmediateOrCancel
        and set value = set this value flagImmediateOrCancel <@ this.FlagImmediateOrCancel @>

    member this.FlagFillOrKill
        with get () = !flagFillOrKill
        and set value = set this value flagFillOrKill <@ this.FlagFillOrKill @>

    member this.FlagSell
        with get () = !flagSell
        and set value = set this value flagSell <@ this.FlagSell @>

    member this.OfferSequence
        with get () = !offerSequence
        and set value = set this value offerSequence <@ this.OfferSequence @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            OfferCancelFlags.None
            |> combineFlag !flagFullyCanonicalSig OfferCancelFlags.FullyCanonicalSig

        let transaction : OfferCancel =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              OfferSequence = uint32 !offerSequence }

        executeSubmitTransaction (transaction |> OfferCancel)

//-------------------------------------------------------------------------------------------------

type SubmitTrustSetModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let lastLedgerSequence = ref ""
    let flagFullyCanonicalSig = ref true
    let flagSetAuth = ref false
    let flagSetNoRipple = ref false
    let flagClearNoRipple = ref false
    let flagSetFreeze = ref false
    let flagClearFreeze = ref false
    let limitAmountValue = ref ""
    let limitAmountCurrency = ref ""
    let limitAmountIssuer = ref ""
    let qualityIn = ref ""
    let qualityOut = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.LastLedgerSequence
        with get () = !lastLedgerSequence
        and set value = set this value lastLedgerSequence <@ this.LastLedgerSequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.FlagSetAuth
        with get () = !flagSetAuth
        and set value = set this value flagSetAuth <@ this.FlagSetAuth @>

    member this.FlagSetNoRipple
        with get () = !flagSetNoRipple
        and set value = set this value flagSetNoRipple <@ this.FlagSetNoRipple @>

    member this.FlagClearNoRipple
        with get () = !flagClearNoRipple
        and set value = set this value flagClearNoRipple <@ this.FlagClearNoRipple @>

    member this.FlagSetFreeze
        with get () = !flagSetFreeze
        and set value = set this value flagSetFreeze <@ this.FlagSetFreeze @>

    member this.FlagClearFreeze
        with get () = !flagClearFreeze
        and set value = set this value flagClearFreeze <@ this.FlagClearFreeze @>

    member this.LimitAmountValue
        with get () = !limitAmountValue
        and set value = set this value limitAmountValue <@ this.LimitAmountValue @>

    member this.LimitAmountCurrency
        with get () = !limitAmountCurrency
        and set value = set this value limitAmountCurrency <@ this.LimitAmountCurrency @>

    member this.LimitAmountIssuer
        with get () = !limitAmountIssuer
        and set value = set this value limitAmountIssuer <@ this.LimitAmountIssuer @>

    member this.QualityIn
        with get () = !qualityIn
        and set value = set this value qualityIn <@ this.QualityIn @>

    member this.QualityOut
        with get () = !qualityOut
        and set value = set this value qualityOut <@ this.QualityOut @>

    member this.Submit() =

        let fee = toNativeAmount !fee
        let lastLedgerSequence = optional !lastLedgerSequence uint32

        let flags =
            TrustSetFlags.None
            |> combineFlag !flagFullyCanonicalSig TrustSetFlags.FullyCanonicalSig
            |> combineFlag !flagSetAuth           TrustSetFlags.SetAuth
            |> combineFlag !flagSetNoRipple       TrustSetFlags.SetNoRipple
            |> combineFlag !flagClearNoRipple     TrustSetFlags.ClearNoRipple
            |> combineFlag !flagSetFreeze         TrustSetFlags.SetFreeze
            |> combineFlag !flagClearFreeze       TrustSetFlags.ClearFreeze

        let limitAmount =
            toIssuedAmount !limitAmountValue !limitAmountCurrency !limitAmountIssuer

        let qualityIn = optional !qualityIn decimal
        let qualityOut = optional !qualityOut decimal

        let transaction : TrustSet =
            { Account = !account
              Fee = fee
              Sequence = uint32 !sequence
              LastLedgerSequence = lastLedgerSequence
              Flags = flags
              LimitAmount = limitAmount
              QualityIn = qualityIn
              QualityOut = qualityOut }

        executeSubmitTransaction (transaction |> TrustSet)

//-------------------------------------------------------------------------------------------------

type TransactionInfoModel() =

    inherit Model()

    let transactionHash = ref ""
    let binary = ref false

    member this.TransactionHash
        with get () = !transactionHash
        and set value = set this value transactionHash <@ this.TransactionHash @>

    member this.Binary
        with get () = !binary
        and set value = set this value binary <@ this.Binary @>

    member this.Submit() =

        let command : TransactionInfo =
            { Id = None
              TransactionHash = !transactionHash
              Binary = Some !binary }

        executeCommand (command |> TransactionInfo)
