import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CorsoListaComponent } from './corso-lista.component';

describe('CorsoListaComponent', () => {
  let component: CorsoListaComponent;
  let fixture: ComponentFixture<CorsoListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CorsoListaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CorsoListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
