define(["require", "exports"], function(require, exports) {
    var HttpClient = (function () {
        function HttpClient(solidClient) {
            this.solidClient = solidClient;
        }
        HttpClient.prototype.get = function (url, data, success, dataType) {
            return this.solidClient.getJSON(url, data, success);
        };

        HttpClient.prototype.post = function (url, data, success, dataType) {
            return this.solidClient.post(url, data, success, "json");
        };
        return HttpClient;
    })();
    exports.HttpClient = HttpClient;
});
