import { Component, Input } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ComponentService } from './component.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  template: `
   
  <div class="container-sm" style="margin-top:40px;">
       <label for="nome">Quantidade de meses para resgate:</label>
       <input id="mes" class="form-control" type="text" #mes>
       <br />
       <label for="nome">Valor Monetario:</label>
       <input mask="separator.2" prefix="R$ " thousandSeparator="." decimalMarker="," placeholder="R$ 0,00" class="form-control col-md-3" id="valor"  type="text" pattern="^\d*(\.\d{0,2})?$" #valor>
       <br/><br/>
       <h3>Resultado</h3>
       <p>Valor Bruto:<span id="valorBruto" style="color:#0d6efd;padding-left:10px;"></span></p>
       <p>Valor Líquido: <span id="valorLiquido" style="color:#198754;padding-left:10px;"></span></p>

      <button class="btn btn-primary" (click)="ObtemValores(mes.value,valor.value)">Enviar</button>
  </div>
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
    console.log(valor);
    var campoValido = /^(\d{1,3}(\.\d{3})*|\d+)(,\d{2})?$/.test(valor);

    if (!campoValido) {
      alert("Necessário informar um valor monetario!");
    }

    if (parseInt(mes) <= 0) {
      alert("Valores digitados incorretamente! O campo mês deve ser maior ou igual a 1.");
      return false;
    }

    if (!Number(mes)) {
      alert("Mês e um formato incorreto! Digitar somente numeros.");
      return false;
    }

    if (parseInt(valor) <= 0) {
      alert("Valores digitados incorretamente! O campo valor monetário deve ser maior que zero.");
      return false;
    }

    return true;
  }
}
