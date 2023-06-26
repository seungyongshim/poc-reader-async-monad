open System


// https://equip.io/f/reader-and-async-and-result-oh-my/
type OrganisationId = OrganisationId of Guid
type CurrencyCode = | CurrencyCode of string
type Currency = {
    Code: CurrencyCode
    Name: string
}

type Organisation = {
    Id: OrganisationId
    Currencies: Currency list
}
