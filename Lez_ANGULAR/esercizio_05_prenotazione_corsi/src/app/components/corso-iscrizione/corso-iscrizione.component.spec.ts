import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CorsoIscrizioneComponent } from './corso-iscrizione.component';

describe('CorsoIscrizioneComponent', () => {
  let component: CorsoIscrizioneComponent;
  let fixture: ComponentFixture<CorsoIscrizioneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CorsoIscrizioneComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CorsoIscrizioneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
