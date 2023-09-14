import { Component, OnInit, Inject  } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Reparto } from 'src/app/interfaces/reparto';
import { RepartoService } from '../services/reparto.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-view-reparto',
  templateUrl: './view-reparto.component.html',
  styleUrls: ['./view-reparto.component.css']
})
export class ViewRepartoComponent implements OnInit {
  id: number;

  reparto$! : Observable<Reparto>; 

  constructor(public dialogo: MatDialogRef<ViewRepartoComponent>,
    @Inject(MAT_DIALOG_DATA) public data: string[],
    private _repartoService : RepartoService) { 
      this.id = Number(data); 
  }

  ngOnInit(): void {
    this.reparto$ = this._repartoService.getReparto(this.id); 
  }
  cerrarDialogo(): void {
    this.dialogo.close(false);
  }
}
