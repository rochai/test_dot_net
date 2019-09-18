import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { User } from '../models/user';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.less']
})
export class LandingComponent implements OnInit {

  private apiService: ApiService;
  users: User[];

  constructor(apiService: ApiService) {
    this.apiService = apiService;
  }

  ngOnInit() {
    this.apiService.getJson()
      .subscribe((data: User[]) =>
        this.users = data
      );
  }

  onClick() {
    alert("You clicked me!");
  }
}
