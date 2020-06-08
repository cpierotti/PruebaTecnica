import { Component, OnInit } from '@angular/core';
import { ClaveService } from '../../services/clave.service';
import { IClave } from '../../models/clave';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public nivel:string="SIMPLE";
  public longitud:number=0;
  public objClave: IClave;
  public activo: boolean = false;
  public validacion: boolean = false;
  constructor(private claveS: ClaveService) { }

  ngOnInit(): void {
  }
  generador(): void {
    if (this.longitud < 999999999 && this.longitud > 0 ) 
    {
      this.validacion=false;
      this.claveS.generarClave(this.nivel, this.longitud).subscribe((data: IClave) => {
        this.objClave = data; this.activo=true;
        console.log(this.objClave);} );
      console.log(this.nivel, this.longitud);
    } 
    else{
        this.validacion=true;
    }
  
  }

}
