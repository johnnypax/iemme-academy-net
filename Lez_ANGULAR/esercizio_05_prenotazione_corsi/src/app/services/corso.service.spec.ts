import { TestBed } from '@angular/core/testing';

import { CorsoService } from './corso.service';

describe('CorsoService', () => {
  let service: CorsoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CorsoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
