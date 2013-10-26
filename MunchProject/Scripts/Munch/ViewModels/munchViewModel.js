define(["require", "exports", "munch"], function(require, exports, __mu__) {
    /// <reference path="../../Typings/knockout/knockout.d.ts" />
    var mu = __mu__;

    var MunchViewModel = (function () {
        function MunchViewModel(munchlist) {
            this.munchlist = munchlist;
        }
        MunchViewModel.prototype.getMunchById = function (id) {
            var _this = this;
            $.get(MunchViewModel.munchUrl + id, function (item) {
                var munch = item;
                _this.munchlist.push(new mu.Munch(munch.playerName, munch.lifeCount));
            }, "json");
        };

        MunchViewModel.prototype.postMunch = function (munch) {
            return false;
        };
        MunchViewModel.munchUrl = "api/munch/";
        return MunchViewModel;
    })();
    exports.MunchViewModel = MunchViewModel;
});
