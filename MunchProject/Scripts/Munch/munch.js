/// <reference path="../Typings/knockout/knockout.d.ts" />
define(["require", "exports"], function(require, exports) {
    var Munch = (function () {
        function Munch(playerName, lifeCount) {
            this.playerName = playerName;
            this.lifeCount = lifeCount;
            ko.observable(playerName);
            ko.observable(lifeCount);
            ko.applyBindings(this);
        }
        return Munch;
    })();
    exports.Munch = Munch;
});
