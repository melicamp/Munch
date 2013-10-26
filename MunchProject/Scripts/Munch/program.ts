import mvm = require("ViewModels/munchViewModel");
import mu = require("munch");

export function main() {
    var munch = new mu.Munch("Cocia", 1);
    var munchViewModel = new mvm.MunchViewModel(ko.observableArray());

    $('#caller').on('click', () => {
        var munch1 = munchViewModel.getMunchById(8);
    });

    $('#postMunch').on('click', () => {
        munchViewModel.postMunch(munch);
    });
    var munchHub = $.connection.munchHub;
}
