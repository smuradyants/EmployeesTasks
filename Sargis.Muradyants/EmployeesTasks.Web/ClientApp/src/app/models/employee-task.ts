import { Employee } from './employee';
import { State } from './state';
import { PriorityLevel } from './priority-level';

export class EmployeeTask {

  public id: number;
  public title: string;
  public description: string;
  public estimate: string;
  public employee: Employee;
  public state: State;
  public prioritylevel: PriorityLevel;
}
