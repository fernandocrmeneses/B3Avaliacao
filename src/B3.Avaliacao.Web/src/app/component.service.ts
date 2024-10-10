import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

interface InvestmentoResultado {
  valorBruto: number;
  valorLiquido: number;
  valorInicial: number;
  meses: number;
}

@Injectable({
  providedIn: 'root'
})
export class ComponentService {
  private apiUrl = 'https://localhost:44386/api/calcular'; // URL da API

  constructor(private http: HttpClient) { }

  calculaInvestmento(valorInicial: number, meses: number): Observable<InvestmentoResultado>{
    
    const request = {
      valorInicial: valorInicial,
      meses: meses
    };

    return this.http.post<InvestmentoResultado>(this.apiUrl, request);

  }
}
