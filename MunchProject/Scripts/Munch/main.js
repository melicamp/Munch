define(["require", "exports", "ViewModels/munchViewModel"], function(require, exports, __mvm__) {
    var mvm = __mvm__;
    

    var Program = (function () {
        function Program() {
        }
        Program.prototype.main = function () {
            //var munch = new mu.Munch("Cocia", 1);
            var munchViewModel = new mvm.MunchViewModel(ko.observableArray());
            var munch1 = munchViewModel.getMunchById(1);

            var munchHub = $.connection.munchHub;
        };
        return Program;
    })();
    exports.Program = Program;
});
