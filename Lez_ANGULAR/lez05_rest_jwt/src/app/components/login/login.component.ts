import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  user: string | undefined;
  pass: string | undefined;

  constructor(private service: AuthService, private router: Router) {

  }

  verifica() {
    if (this.user && this.pass) {
      this.service.EffettuaLogin(this.user, this.pass).then(risultato => {
        if(risultato.token){
          localStorage.setItem("ilToken", risultato.token);
          this.router.navigateByUrl("/profilo");
        }
      })
    }
    else {
      alert("Inserisci username e password!");
    }
  }

  // verifica(){
  //   if(this.user && this.pass){
  //     this.service.EffettuaLogin(this.user, this.pass).subscribe(risultato => {
  //       if(risultato.token){
  //         localStorage.setItem("ilToken", risultato.token)
  //         this.router.navigateByUrl("/profilo");
  //       }
  //     })
  //   }
  //   else{
  //     alert("Inserisci username e password!");
  //   }
  // }
}
