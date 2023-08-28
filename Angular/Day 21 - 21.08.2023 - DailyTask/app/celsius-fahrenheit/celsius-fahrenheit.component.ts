import { Component } from '@angular/core';

@Component({
  selector: 'app-celsius-fahrenheit',
  templateUrl: './celsius-fahrenheit.component.html',
  styleUrls: ['./celsius-fahrenheit.component.css']
})
export class CelsiusFahrenheitComponent {
  temperature: number = 0;
  selectedUnit: string = 'fahrenheit';
  convertedTemperature?: number=0;

  convertTemperature(): void {
    if (this.selectedUnit === 'fahrenheit') {
      this.convertedTemperature = (this.temperature - 32) * 5/9;
    } else {
      this.convertedTemperature = (this.temperature * 9/5) + 32;
    }
  }
}
