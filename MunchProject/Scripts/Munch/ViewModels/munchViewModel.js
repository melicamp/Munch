var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
define(["require", "exports", "munch", "ViewModels/baseViewModel"], function(require, exports, __mu__, __bvm__) {
    /// <reference path="../../Typings/knockout/knockout.d.ts" />
    var mu = __mu__;
    var bvm = __bvm__;

    var MunchViewModel = (function (_super) {
        __extends(MunchViewModel, _super);
        function MunchViewModel(munchlist) {
            _super.call(this);
            this.munchlist = munchlist;
        }
        MunchViewModel.prototype.getMunchById = function (id) {
            var _this = this;
            this.httpClient.get(MunchViewModel.munchUrl + id, function (item) {
                var munch = item;
                _this.munchlist.push(new mu.Munch(munch.playerName, munch.lifeCount));
            });
        };

        MunchViewModel.prototype.postMunch = function (munch) {
            this.httpClient.post(MunchViewModel.munchUrl, munch, function (success) {
                alert("Posted!");
            });
        };
        MunchViewModel.munchUrl = "api/munch/";
        return MunchViewModel;
    })(bvm.BaseViewModel);
    exports.MunchViewModel = MunchViewModel;
});
