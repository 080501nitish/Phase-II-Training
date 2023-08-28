import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CelsiusFahrenheitComponent } from './celsius-fahrenheit.component';

describe('CelsiusFahrenheitComponent', () => {
  let component: CelsiusFahrenheitComponent;
  let fixture: ComponentFixture<CelsiusFahrenheitComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CelsiusFahrenheitComponent]
    });
    fixture = TestBed.createComponent(CelsiusFahrenheitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
