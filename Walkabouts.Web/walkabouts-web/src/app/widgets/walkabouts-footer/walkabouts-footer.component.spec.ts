import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WalkaboutsFooterComponent } from './walkabouts-footer.component';

describe('WalkaboutsFooterComponent', () => {
  let component: WalkaboutsFooterComponent;
  let fixture: ComponentFixture<WalkaboutsFooterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WalkaboutsFooterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WalkaboutsFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
