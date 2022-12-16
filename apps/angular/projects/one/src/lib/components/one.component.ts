import { Component, OnInit } from '@angular/core';
import { OneService } from '../services/one.service';

@Component({
  selector: 'lib-one',
  template: ` <p>one works!</p> `,
  styles: [],
})
export class OneComponent implements OnInit {
  constructor(private service: OneService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
