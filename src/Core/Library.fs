namespace BoardgameManager.Core

[<Measure>]
type cm

type Measures = {
    height: uint<cm>
    width1: uint<cm>
    width2: uint<cm>
}

type Boardgame = {
    name: string
    measures: Measures
}
