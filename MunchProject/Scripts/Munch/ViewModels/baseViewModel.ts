import hc = require("../Infrastructure/httpClient");

export class BaseViewModel {

    httpClient: hc.HttpClient

    constructor() {
        this.httpClient = new hc.HttpClient($);
    }

}