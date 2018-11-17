import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute, Params, NavigationEnd } from '@angular/router';
import { EmployeeTask } from '../../models/employee-task';

@Component({
  selector: 'app-employee-task',
  templateUrl: './employee-task.component.html'
})

export class EmployeeTaskComponent {
  public employeeTask: EmployeeTask;

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private router: Router) {
     
    this.LoadData();

  }

  LoadData() {

    let taskId = this.route.snapshot.params.taskId;
    
    this.httpClient.get<EmployeeTask>(this.baseUrl + 'api/Employee/GetEmployeeTask/' + taskId).subscribe(result => {
      this.employeeTask = result;
    }, error => console.log(error));

  }
}
