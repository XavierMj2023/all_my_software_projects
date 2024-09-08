import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddEditDepartmentComponent } from './components/department/add-edit-department/add-edit-department.component';
import { ShowDepartmentComponent } from './components/department/show-department/show-department.component';
import { DepartmentComponent } from './components/department/department.component';
import { ShowEmployeeComponent } from './components/employee/show-employee/show-employee.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { ApiserviceService } from './serviceapi/apiservice.service';

import {HttpClientModule} from '@angular/common/http'
import { FormsModule } from '@angular/forms';
import {ReactiveFormsModule} from '@angular/forms'
import { AddEditEmployeeComponent } from './components/employee/add-edit-employee/add-edit-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    AddEditDepartmentComponent,
    ShowDepartmentComponent,
    DepartmentComponent,
    AddEditEmployeeComponent,
    ShowEmployeeComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
