import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute, Params, NavigationEnd } from '@angular/router';
import { EmployeeTask } from '../../models/employee-task';

@Component({
  selector: 'app-employee-tasks-list',
  templateUrl: './employee-tasks-list.component.html'
})

export class EmployeeTasksListComponent {
  public employeeTasks: EmployeeTask[];
  private routerEventSubscription: any;
  
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private router: Router) {

    this.routerEventSubscription = router.events.subscribe((val) => {

      if (val instanceof NavigationEnd) {
        
        this.LoadData();

      }

    });
  }

  ngOnDestroy() {
    this.routerEventSubscription.unsubscribe();
  }

  LoadData() {

    let id = this.route.snapshot.params.id;

    this.httpClient.get<EmployeeTask[]>(this.baseUrl + 'api/Employee/GetEmployeeTasks/' + id).subscribe(result => {
      this.employeeTasks = result;
    }, error => console.error(error));

  }
}
