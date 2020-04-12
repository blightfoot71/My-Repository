import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LikeExerciseComponent } from './like-exercise.component';

describe('LikeExerciseComponent', () => {
  let component: LikeExerciseComponent;
  let fixture: ComponentFixture<LikeExerciseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LikeExerciseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LikeExerciseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
