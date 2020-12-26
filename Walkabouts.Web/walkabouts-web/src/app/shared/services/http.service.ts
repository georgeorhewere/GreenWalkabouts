import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(
    private httpClient: HttpClient
  ) {
  }

  get<T>(url: string,options?:any): Observable<T> {
      if(options) {
          return this.httpClient.get<T>(url,<Object>options);
      }else{
          return this.httpClient.get<T>(url);
      }

  }

  async getAsync<T>(url: string,options?:any): Promise<T> {
      if(options) {
          return this.get<T>(url, options).toPromise();
      }else{
          return this.get<T>(url).toPromise();}
  }

  post<T>(url: string, body: any | null,
    options?: {
      headers?: HttpHeaders | {
        [header: string]: string | string[];
      };
      observe?: 'body';
      params?: HttpParams | {
        [param: string]: string | string[];
      };
      reportProgress?: boolean;
      responseType?: 'json';
      withCredentials?: boolean;
    }): Observable<T> {


    return this.httpClient.post<T>(url, body, options);
  }

  async postAsync<T>(url: string, body: any | null,
    options?: {
      headers?: HttpHeaders | {
        [header: string]: string | string[];
      };
      observe?: 'body';
      params?: HttpParams | {
        [param: string]: string | string[];
      };
      reportProgress?: boolean;
      responseType?: 'json';
      withCredentials?: boolean;
    }): Promise<T> {

    return this.post<T>(url, body, options).toPromise();
  }

  async postTextAsync(url: string, body: any | null, options?: {
    headers?: HttpHeaders | {
      [header: string]: string | string[];
    };
    observe: 'response';
    params?: HttpParams | {
      [param: string]: string | string[];
    };
    reportProgress?: boolean;
    responseType: 'text';
    withCredentials?: boolean;
  }) {
    this.httpClient.post(url, body, options).subscribe();
  }

  put<T>(url: string, body: any): Observable<T> {
    return this.httpClient.put<T>(url, body);
  }

  async putAsync<T>(url: string, body: any): Promise<T> {
    return this.put<T>(url, body).toPromise();
  }


}
