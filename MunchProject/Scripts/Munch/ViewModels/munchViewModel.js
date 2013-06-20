var MunchProject;
(function (MunchProject) {
    var MunchViewModel = (function () {
        function MunchViewModel(munchlist) {
            this.munchlist = munchlist;
        }
        MunchViewModel.prototype.getMunchById = function (id) {
            var _this = this;
            $.get(MunchViewModel.munchUrl + id, function (item) {
                var munch = item;
                _this.munchlist.push(new MunchProject.Munch(munch.playerName, munch.lifeCount));
            }, "json");
        };

        MunchViewModel.prototype.postMunch = function (munch) {
            return false;
        };
        MunchViewModel.munchUrl = "api/munch/";
        return MunchViewModel;
    })();
    MunchProject.MunchViewModel = MunchViewModel;
})(MunchProject || (MunchProject = {}));
