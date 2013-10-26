/// <reference path="../Typings/knockout/knockout.d.ts" />

export class Munch {

    constructor(public playerName: string, public lifeCount: number) {
        ko.observable(playerName);
        ko.observable(lifeCount);
        ko.applyBindings(this);
    }
}
