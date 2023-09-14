import { HttpClient, HttpHandler, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroment/environment';
import { Reparto } from '../../interfaces/reparto';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';
import { ListRepartosComponent } from '../list-repartos/list-repartos.component';


@Injectable({
  providedIn: 'root'
})
export class RepartoService {
  private myAppUrl : string = environment.endpoint;
  private myAPIUrl : string = 'api/Repartos/';  


  constructor(private http: HttpClient) { }

  //IMPLEMENTAR METODOS GET
  getRepartos(){
    return this.http.get<Reparto[]>("https://localhost:7174/api/Repartos") ;
  }
 
  getReparto(id:number):Observable<Reparto>{
    return this.http.get<Reparto>("https://localhost:7174/api/Repartos/"+ id) ;

  }


}
