import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { User } from "../models/user";

@Injectable({
  providedIn: "root"
})
export class ApiService {
  private apiUrl = "http://localhost:51905/api/values";
  private jsonUrl = "./assets/data.json";

  constructor(private http: HttpClient) {}

  getAll() {
    return this.http.get<User[]>(this.apiUrl);
  }
  getJson() {
    return this.http.get<User[]>(this.jsonUrl);
  }
}
