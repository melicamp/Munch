/// <reference path="../../Typings/knockout/knockout.d.ts" />
import mu = require("munch");
import bvm = require("ViewModels/baseViewModel")

export class MunchViewModel extends bvm.BaseViewModel {

    static munchUrl = "api/munch/";

    constructor(public munchlist: KnockoutObservableArray<mu.Munch>) {
        super();
    }

    getMunchById(id: number): void {
        this.httpClient.get(MunchViewModel.munchUrl + id, item => {
            var munch = <mu.Munch>item;
            this.munchlist.push(new mu.Munch(munch.playerName, munch.lifeCount));
        });
    }

    postMunch(munch: mu.Munch): void {
        this.httpClient.post(MunchViewModel.munchUrl, munch, success => {
            alert("Posted!");
        });
    }
}
