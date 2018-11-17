import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { EmployeeTasksListComponent } from './components/employee-tasks-list/employee-tasks-list.component';
import { EmployeeTaskComponent } from './components/employee-task/employee-task.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,     
    EmployeeTasksListComponent,
    EmployeeTaskComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'employees', component: EmployeeTasksListComponent },
      { path: 'employees/:id', component: EmployeeTasksListComponent },
      { path: 'employees/:id/:taskId', component: EmployeeTaskComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
