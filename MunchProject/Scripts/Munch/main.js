var MunchProject;
(function (MunchProject) {
    var Program = (function () {
        function Program() {
        }
        Program.prototype.main = function () {
            var munchViewModel = new MunchProject.MunchViewModel(ko.observableArray());
            var munch = munchViewModel.getMunchById(1);

            var munchHub = $.connection.munchHub;
        };
        return Program;
    })();
    MunchProject.Program = Program;
})(MunchProject || (MunchProject = {}));
