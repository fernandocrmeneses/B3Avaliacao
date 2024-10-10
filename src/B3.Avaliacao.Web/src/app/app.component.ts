import { Component, Input } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ComponentService } from './component.service';

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

      <button (click)="ObtemValores(mes.value,valor.value)">Enviar</button>
  `
})

export class AppComponent {
   constructor(private componentService: ComponentService) { }

   ObtemValores(mes: string, valor: string) {

     if (!this.ValidacaoCampos(mes, valor)) return;

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

  ValidacaoCampos(mes: string, valor: string) : boolean {

    if (!Number(mes) || !Number(valor)) {
      alert("Mês e valor monetario em um formato incorreto! Digitar somente numeros.");
      return false;
    }

    if (parseInt(mes) > 12) {
      alert("Valores digitados incorretamente! Digite de 1 a 12 no campo mês.");
      return false;
    }

    if (parseInt(mes) <= 0) {
      alert("Valores digitados incorretamente! O campo mês deve ser maior ou igual a 1.");
      return false;
    }

    if (parseInt(valor) <= 0) {
      alert("Valores digitados incorretamente! O campo valor monetário deve ser maior que zero.");
      return false;
    }

    return true;
  }
}
