import { TestBed } from '@angular/core/testing';

import { IscrizioneService } from './iscrizione.service';

describe('IscrizioneService', () => {
  let service: IscrizioneService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IscrizioneService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
