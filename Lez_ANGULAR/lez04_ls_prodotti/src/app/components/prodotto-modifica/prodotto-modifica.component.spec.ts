import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdottoModificaComponent } from './prodotto-modifica.component';

describe('ProdottoModificaComponent', () => {
  let component: ProdottoModificaComponent;
  let fixture: ComponentFixture<ProdottoModificaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdottoModificaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdottoModificaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
