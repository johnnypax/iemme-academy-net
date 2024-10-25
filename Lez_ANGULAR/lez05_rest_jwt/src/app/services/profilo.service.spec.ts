import { TestBed } from '@angular/core/testing';

import { ProfiloService } from './profilo.service';

describe('ProfiloService', () => {
  let service: ProfiloService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProfiloService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
