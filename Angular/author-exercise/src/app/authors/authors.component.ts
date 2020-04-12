import { Component, OnInit } from '@angular/core';
import { AuthorsService } from 'C:/Users/Brian/source/repos/Angular/author-exercise/src/app/authors.service';

@Component({
  selector: 'authors',
  // template: `
  //     <h2>{{ this.numberOfAuthors + title }}</h2>
  //     <ul>
  //       <li *ngFor="let author of authors">
  //           {{ author }} 
  //       </li>
  //     </ul>
  // `
  templateUrl: './authors.component.html',
  //styleUrls: ['./authors.component.css']
})
export class AuthorsComponent implements OnInit {
    authors;
    
  constructor(service: AuthorsService) {
      this.authors = service.getAuthors();
   }

  ngOnInit() {
  }

}
