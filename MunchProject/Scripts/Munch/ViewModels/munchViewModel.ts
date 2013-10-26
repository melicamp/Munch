/// <reference path="../../Typings/knockout/knockout.d.ts" />
import mu = require("munch");

export class MunchViewModel {

    static munchUrl = "api/munch/";

    constructor(public munchlist: KnockoutObservableArray<mu.Munch>) {

    }

    getMunchById(id: number): void {
        $.get(MunchViewModel.munchUrl + id, item => {
            var munch = <mu.Munch>item;
            this.munchlist.push(new mu.Munch(munch.playerName, munch.lifeCount));
        }, "json");
    }

    postMunch(munch: mu.Munch): boolean {

        return false;
    }
}
