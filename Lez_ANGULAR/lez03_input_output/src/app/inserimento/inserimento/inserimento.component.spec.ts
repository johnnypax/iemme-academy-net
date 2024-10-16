import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InserimentoComponent } from './inserimento.component';

describe('InserimentoComponent', () => {
  let component: InserimentoComponent;
  let fixture: ComponentFixture<InserimentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InserimentoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InserimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
