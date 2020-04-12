import { Component, Input } from '@angular/core';

@Component({
  selector: 'like-exercise',
  templateUrl: './like-exercise.component.html',
  styleUrls: ['./like-exercise.component.css']
})
export class LikeExerciseComponent {
  @Input('isActive') isActive: boolean;
  @Input('likesCount') likesCount: number;

  onClick() {
    this.isActive = !this.isActive;
    this.likesCount += (this.isActive) ? +1 : -1;
  }
  
}
