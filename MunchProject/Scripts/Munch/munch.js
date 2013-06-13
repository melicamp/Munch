var munch = (function ($, ko) {
    var self = this;
    var private = {
        
    }

    var public = {
        constructMunch: function(){
            self.firstName = ko.observable("Ciocia");
            self.lastName = ko.observable("Jadzie");
            self.posX = ko.observable(100);
        },
        init: function () {
            ko.applyBindings(new public.viewModel());
        }
    }

    return public;
  
})($, ko);

var hubModule = (function (viewModel) {

    var hub = $.connection.munchHub;



}(munch))