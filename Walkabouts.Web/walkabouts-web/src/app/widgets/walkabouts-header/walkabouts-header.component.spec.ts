import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WalkaboutsHeaderComponent } from './walkabouts-header.component';

describe('WalkaboutsHeaderComponent', () => {
  let component: WalkaboutsHeaderComponent;
  let fixture: ComponentFixture<WalkaboutsHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WalkaboutsHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WalkaboutsHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
