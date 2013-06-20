var MunchProject;
(function (MunchProject) {
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
    MunchProject.Munch = Munch;
})(MunchProject || (MunchProject = {}));
