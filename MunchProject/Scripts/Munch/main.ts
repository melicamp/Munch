/// <reference path="..\Typings\Jquery\jquery.d.ts" />
/// <reference path="..\Typings\knockout\knockout.d.ts" />
/// <reference path="munch.ts" />
/// <reference path="ViewModels\munchViewModel.ts" />
/// <reference path="hub.ts" />

module MunchProject {

    export class Program {

        main() {
            //var munch = new Munch("Cocia", 1);
            var munchViewModel = new MunchViewModel(ko.observableArray());
            var munch = munchViewModel.getMunchById(1);

            var munchHub = $.connection.munchHub;
        }
    }
}