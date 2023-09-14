import { Component, OnInit, inject } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/enviroment/environment';
import { HttpClient } from '@angular/common/http'; 
import { Observable ,of} from 'rxjs'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  excel=[];  
  constructor(public router: Router,private http: HttpClient) {

  }

  isStart = false;
  res: Observable<null | string> = of(null);
  loadingPercent = 0;
  intervalId = {} as any;

  title = 'Reparto';
  ngOnInit() {
    this.toogleSidenav();
  }
  sidenavWidth = 4;
  sidenavStatus = true;
  toogleSidenav() {
    if (this.sidenavStatus === true) {
      this.sidenavStatus = true;
    } else {
      this.sidenavStatus = true;
    }
    if (this.sidenavWidth === 4) {
      this.increase();
    } else {
      this.decrease();
    }
  }

  
  increase() {
    this.sidenavWidth = 15;
  }
  decrease() {
    this.sidenavWidth = 4;
  }
    public getJSON(): Observable<any> {  
      return this.http.get('https://api.myjson.com/bins/zg8of');  
    }  
}
