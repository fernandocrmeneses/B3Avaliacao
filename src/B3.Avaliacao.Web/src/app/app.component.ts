import { Component, Input } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder, FormControlName, Form } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { ComponentService } from './component.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  template: `
       <label for="nome">Mês:</label>
       <input id="mes" type="text" #mes>
       <br />
       <label for="nome">Valor Monetario:</label>
       <input id="valor" type="text" pattern="^\d*(\.\d{0,2})?$" #valor>
       <h3>Resultado</h3>
       <p>Valor Bruto:<span id="valorBruto"></span></p>
       <p>Valor Líquido: <span id="valorLiquido"></span></p>

      <button (click)="obtemValores(mes.value,valor.value)">Enviar</button>
  `
})

export class AppComponent {
   constructor(private componentService: ComponentService) { }

   obtemValores(mes: string, valor: string) {

   this.ValidacaoCampos(mes, valor);

   this.componentService.calculaInvestmento(parseFloat(valor), parseInt(mes))
    .subscribe({
      next: (response) => {
        (document.getElementById('valorBruto') as HTMLElement).innerText = response.valorBruto?.toFixed(2);
        (document.getElementById('valorLiquido') as HTMLElement).innerText = response.valorLiquido?.toFixed(2);
      },
      error: (error) => {
        console.error('Erro:', error);
      },
      complete: () => {
        console.log('Requisição completa');
      }
    });
  }

  ValidacaoCampos(mes: string, valor: string) {

    if (!Number(mes) || !Number(valor)) {
      alert("Mês e valor monetario em um formato incorreto! Digitar somente numeros.");
      return;
    }

    if (parseInt(mes) > 12) {
      alert("Valores digitados incorretamente! Digite de 1 a 12 no campo mês.");
      return;
    }

    if (parseInt(mes) <= 0) {
      alert("Valores digitados incorretamente! O campo mês deve ser maior ou igual a 1.");
    }

    if (parseInt(valor) <= 0) {
      alert("Valores digitados incorretamente! O campo valor monetário deve ser maior que zero.");
    }
  }
}
