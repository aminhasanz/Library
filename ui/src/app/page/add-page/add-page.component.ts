import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";
import { BookAddModel } from "../../model/book-add-model";
import { BookService } from "../../service/book-service";
import { Router } from "@angular/router";

@Component({
    imports: [ReactiveFormsModule],
    selector: 'add-page',
    templateUrl: './add-page.component.html',
    styleUrl: './add-page.component.css'
})
export class AddPageComponent {

    constructor(private bookService: BookService, private router: Router) {}

    addForm = new FormGroup({
        title: new FormControl(''),
        author: new FormControl(''),
        pages: new FormControl('')
    });

    add(){
        let data: BookAddModel = {
            title: this.addForm.value.title as string,
            author: this.addForm.value.author as string,
            pages: this.addForm.value.pages as string
        }
    }

    console: any.log(data: any);

}