import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  displayValue = '';
  result = '';

  appendToDisplay(value: string) {
    this.displayValue += value;
  }

  operate(operator: string) {
    this.displayValue += ' ' + operator + ' ';
  }

  calculate() {
    try {
      this.result = eval(this.displayValue);
      this.displayValue = this.result;
    } catch (error) {
      this.result = 'Error';
      this.displayValue = '';
    }
  }
  reset() {
    this.displayValue = '';
    this.result = '';
  }
}
