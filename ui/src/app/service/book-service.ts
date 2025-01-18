import { HttpClient } from "@angular/common/http";

import { Result } from "../model/result";
import { BookAddModel } from "../model/book-add-model";
import { Injectable } from "@angular/core";

@Injectable({ providedIn: 'root' })
export class BookService {
    constructor(private http: HttpClient) {}

    postAdd(request: BookAddModel) {
        let url = "http://localhost:54025/add";
        return this.http.post<Result<Number>>(url, request);
    }
}