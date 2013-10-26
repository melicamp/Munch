define(["require", "exports", "ViewModels/munchViewModel", "munch"], function(require, exports, __mvm__, __mu__) {
    var mvm = __mvm__;
    var mu = __mu__;

    function main() {
        var munch = new mu.Munch("Cocia", 1);
        var munchViewModel = new mvm.MunchViewModel(ko.observableArray());

        $('#caller').on('click', function () {
            var munch1 = munchViewModel.getMunchById(8);
        });

        $('#postMunch').on('click', function () {
            munchViewModel.postMunch(munch);
        });
        var munchHub = $.connection.munchHub;
    }
    exports.main = main;
});
