export interface IHttpClient {
    get<TResult>(url: string, data?: any, success?: any, dataType?: any): TResult;
    post<TResult>(url: string, data?: any, success?: any, dataType?: any): TResult;

}

export class HttpClient implements IHttpClient {

    solidClient: JQueryStatic;

    constructor(solidClient: JQueryStatic) {
        this.solidClient = solidClient;
    }

    get<TResult extends JQueryXHR>(url: string, data?: any, success?: any, dataType?: any): TResult {
        return this.solidClient.getJSON(url, data, success);
    }

    post<TResult extends JQueryXHR>(url: string, data?: any, success?: any, dataType?: any): TResult {
        return this.solidClient.post(url, data, success, "json");
    }
}