import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfiloComponent } from './profilo.component';

describe('ProfiloComponent', () => {
  let component: ProfiloComponent;
  let fixture: ComponentFixture<ProfiloComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProfiloComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfiloComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
