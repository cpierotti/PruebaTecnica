import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpClientModule } from '@angular/common/http';
import { IClave } from '../models/clave';

@Injectable({
  providedIn: 'root'
})
export class ClaveService {
  public url: string = 'http://localhost:55548';
  constructor(private http: HttpClient) {
   }
   generarClave(level: string, longitud: number){
    return this.http.get<IClave>(`${this.url}/api/Generador?level=${level}&pLongitud=${longitud}`);
   }
}
