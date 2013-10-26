define(["require", "exports", "../Infrastructure/httpClient"], function(require, exports, __hc__) {
    var hc = __hc__;

    var BaseViewModel = (function () {
        function BaseViewModel() {
            this.httpClient = new hc.HttpClient($);
        }
        return BaseViewModel;
    })();
    exports.BaseViewModel = BaseViewModel;
});
