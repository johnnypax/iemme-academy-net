import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdottoInserisciComponent } from './prodotto-inserisci.component';

describe('ProdottoInserisciComponent', () => {
  let component: ProdottoInserisciComponent;
  let fixture: ComponentFixture<ProdottoInserisciComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdottoInserisciComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdottoInserisciComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
