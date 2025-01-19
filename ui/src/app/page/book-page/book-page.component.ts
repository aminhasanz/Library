import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, RouterLink } from "@angular/router";
import { BookService } from "../../service/book-service";
import { BookModel } from "../../model/book-model";

@Component({
    imports: [RouterLink],

    selector: 'book-page',
    templateUrl: 'book-page.component.html',
    styleUrl: 'book-page.component.css'
})

export class BookPageComponent implements OnInit {
    constructor(private bookService: BookService, private route: ActivatedRoute) {}

    bookId = 0;
    title = '';
    author = '';
    pages = '';

    ngOnInit() {
        this.bookId = parseInt(this.route.snapshot.paramMap.get('bookid') ?? '0');

        this.bookService.getBook(this.bookId).subscribe(response => {
            this.title = response.data.title;
            this.author = response.data.author;
            this.pages = response.data.pages;
        });
    }
}