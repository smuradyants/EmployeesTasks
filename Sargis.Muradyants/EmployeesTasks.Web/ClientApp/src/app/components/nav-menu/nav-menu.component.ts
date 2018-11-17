import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from "@angular/router";
import { Employee } from '../../models/employee';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  public employees: Employee[];
  isExpanded = false;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {   

    http.get<Employee[]>(baseUrl + 'api/Employee/GetAllEmployees').subscribe(result => {
      this.employees = result;
      if (this.router.url == '/employees' || this.router.url == '/') {
        this.router.navigate(['/employees/' + this.employees[0].id]);
      }     
    }, error => console.error(error));

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

}
