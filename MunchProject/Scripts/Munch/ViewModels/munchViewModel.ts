/// <reference path="..\..\Typings\Jquery\jquery.d.ts" />
/// <reference path="..\..\Typings\knockout\knockout.d.ts" />
/// <reference path="..\munch.ts" />

module MunchProject {

    export class MunchViewModel {

        static munchUrl = "api/munch/";

        constructor(public munchlist: KnockoutObservableArray<Munch>) {

        }

        getMunchById(id: number): void {
            $.get(MunchViewModel.munchUrl + id, item => {
                var munch = <Munch>item;
                this.munchlist.push(new Munch(munch.playerName, munch.lifeCount));
            }, "json");
        }

        postMunch(munch: Munch): boolean {

            return false;
        }
    }
}