
import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { Reparto } from 'src/app/interfaces/reparto';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { ViewRepartoComponent } from '../view-reparto/view-reparto.component';
import { MatDialog } from "@angular/material/dialog";
import { MatSnackBar } from '@angular/material/snack-bar';
import { RepartoService } from 'src/app/components/services/reparto.service';

@Component({
  selector: 'app-list-repartos',
  templateUrl: './list-repartos.component.html',
  styleUrls: ['./list-repartos.component.css']
})
export class ListRepartosComponent implements AfterViewInit{
  displayedColumns: string[] = ['id','empresa_encargada', 'patente_vehiculo', 'cantidad_bultos','fecha_salida','estado_entrega','acciones'];
  dataSource = new MatTableDataSource<Reparto>();

  excelData : any;
  procesando: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  

  ngOninit() : void {
    this.obtenerRepartos();

  }

  constructor(private _snackBar: MatSnackBar
    ,private _repartoService : RepartoService
    ,private dialogo: MatDialog) {    
  }

  ngAfterViewInit() {
    this.obtenerRepartos();
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    if( this.dataSource.data.length > 0){
      this.paginator._intl.itemsPerPageLabel = 'Ítems por página'
    }
  }

  public obtenerRepartos(){
    //this.procesando = true;
    this._repartoService.getRepartos().subscribe(
      {
        next : (data) => {
          //this.procesando = false;
          this.dataSource.data = data;
          console.log(data);
        },
        //error : (e) => this.procesando = false,
        complete : () => console.info('Se cargo correctamente')
      }
    )
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  msjExito(){

    this._snackBar.open('Registro eliminado con exito', '',{ duration:3000,horizontalPosition:'right' });

  }

  viewReparto(id : number): void {
    this.dialogo
      .open(ViewRepartoComponent, {
        width: '50%',
        data: id        
      });
  }

}



