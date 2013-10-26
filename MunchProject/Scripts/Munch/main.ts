import mvm = require("ViewModels/munchViewModel");
import mu = require("munch");


export class Program {

    main() {
        //var munch = new mu.Munch("Cocia", 1);
        var munchViewModel = new mvm.MunchViewModel(ko.observableArray());
        var munch1 = munchViewModel.getMunchById(1);

        var munchHub = $.connection.munchHub;
    }
}
