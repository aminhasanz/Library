import { NgFor } from "@angular/common";
import { Component, OnInit } from "@angular/core";
import { RouterLink } from "@angular/router";
import { BookService } from "../../service/book-service";
import { BookModel } from "../../model/book-model";

@Component({
    imports: [NgFor, RouterLink],

    selector: 'books-page',
    templateUrl: 'books-page.component.html',
    styleUrl: 'books-page.component.css'
})

export class BooksPageComponent implements OnInit {
    constructor(private bookService: BookService) {}

    books: BookModel[] = [];

    ngOnInit() {
        this.bookService.getBooks().subscribe(response => {
            this.books = response.data;
        })
    }
}