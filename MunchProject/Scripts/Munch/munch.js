var munch = (function ($, ko) {

    var private = {
        viewModel: function () {
            this.firstName = ko.observable("Ciocia");
            this.lastName = ko.observable("Jadzie");
        }
    }

    var public = {
        init: function () {
            ko.applyBindings(new private.viewModel());
        }
    }

    return public;
  
})($, ko);