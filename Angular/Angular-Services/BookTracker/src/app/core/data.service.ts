import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoggerService } from './logger.service';
import { Reader } from 'app/models/reader';
import { Book } from 'app/models/book';
import { allReaders, allBooks } from 'app/data';

@Injectable()
export class DataService {

  mostPopulerBook: Book = allBooks[0];

  constructor(private loggerService: LoggerService,
              private http: HttpClient) { }

  getAllReaders(): Observable<Reader[]> {
    return this.http.get<Reader[]>('/api/readers');
  }

  getReaderById(id: number): Reader {
    return allReaders.find(reader => reader.readerID === id);
  }

  getAllBooks(): Book[] {
    return allBooks;
  }

  getbookById(id: number): Book {
    return allBooks.find(book => book.bookID === id);
  }

  setMostPopularBook(popularBook: Book): void {
    this.mostPopulerBook = popularBook;
  }
}
