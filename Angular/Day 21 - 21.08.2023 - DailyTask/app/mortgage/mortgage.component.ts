import { Component } from '@angular/core';

@Component({
  selector: 'app-mortgage',
  templateUrl: './mortgage.component.html',
  styleUrls: ['./mortgage.component.css']
})
export class MortgageComponent {
  purchasePrice!: number ;
  downPayment!: number ;
  repaymentTime!: number;
  interestRate!: number ;
  loanAmount!: number ;
  monthlyPayment!: number ;

  calculate() {
    if (this.purchasePrice !== null && this.downPayment !== null &&
        this.repaymentTime !== null && this.interestRate !== null) {
      this.loanAmount = this.purchasePrice - this.downPayment;
      const monthlyInterestRate = this.interestRate / 100 / 12;
      const totalPayments = this.repaymentTime * 12;
      this.monthlyPayment = (this.loanAmount * monthlyInterestRate) / (1 - Math.pow(1 + monthlyInterestRate, -totalPayments));
        }
      }
}
