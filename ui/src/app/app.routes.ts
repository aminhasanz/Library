import { Routes } from '@angular/router';
import { AddPageComponent } from './page/add-page/add-page.component';
import { BooksPageComponent } from './page/books-page/books-page.component';
import { BookPageComponent } from './page/book-page/book-page.component';

export const routes: Routes = [
    {path:'add', component:AddPageComponent},
    {path: 'books', component:BooksPageComponent},
    {path: 'book/:bookid', component: BookPageComponent}
];
