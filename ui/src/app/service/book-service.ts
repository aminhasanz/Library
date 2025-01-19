import { HttpClient } from "@angular/common/http";

import { Result } from "../model/result";
import { BookModel } from "../model/book-model";
import { Injectable } from "@angular/core";

@Injectable({ providedIn: 'root' })
export class BookService {
    constructor(private http: HttpClient) {}

    postAdd(request: BookModel) {
        let url = "http://localhost:54025/add";
        return this.http.post<Result<Number>>(url, request);
    }

    getBooks() {
        let url = "http://localhost:54025/books";
        return this.http.get<Result<BookModel[]>>(url);
    }

    getBook(request: Number) {
        let url = `$http://localhost:54025/book?bookId=${request}`;
        return this.http.get<Result<BookModel>>(url);
    }
}