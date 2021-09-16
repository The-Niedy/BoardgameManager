namespace BoardgameManager.Core

[<Measure>]
type cm

type Measures = {
    height: double<cm>
    width1: double<cm>
    width2: double<cm>
}

type Boardgame = {
    name: string
    measures: Measures
}
