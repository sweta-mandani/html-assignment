import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  ngOnInit(): void {
    
  }

  

    constructor(private auth: AuthService) {
    }
  
    needsLogin() {
      return !this.auth.isAuthenticated();
    }
  }