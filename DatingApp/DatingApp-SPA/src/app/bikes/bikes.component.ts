import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { BsDatepickerConfig } from 'ngx-bootstrap';
import { User } from '../_models/user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-bikes',
  templateUrl: './bikes.component.html',
  styleUrls: ['./bikes.component.css']
})
export class BikesComponent implements OnInit {

  registerForm: FormGroup;
  bsConfig: Partial<BsDatepickerConfig>;


  constructor(private authService: AuthService, private router: Router,
    private alertify: AlertifyService, private fb: FormBuilder) { }

  ngOnInit() {
    this.bsConfig = {
      containerClass: 'theme-red'
    };
    this.createRegisterForm();

  }
  createRegisterForm() {
    this.registerForm = this.fb.group({
  
      Adress: ['', Validators.required],
      ReparationDate: [null, Validators.required],
     ReparationTime: ['', Validators.required],
     TypeOfreperation: ['', Validators.required], 
     TypeOfBike: ['', Validators.required],
     TypeOfreperationDescription: ['', Validators.required],
     FirstName: ['', Validators.required],
     Lastname: ['', Validators.required],
     Email: ['', Validators.required],
     DateBookedSystem: ['', Validators.required]

    }
    );

}

  register( ) {
    alert('test 1');
    if (this.registerForm.valid) {
        alert('test');
  }

}
}
