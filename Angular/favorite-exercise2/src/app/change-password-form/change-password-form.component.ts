import { Component } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms';
import { passwordValidators } from './change-password-form.validators'

@Component({
  selector: 'change-password-form',
  templateUrl: './change-password-form.component.html',
  styleUrls: ['./change-password-form.component.css']
})
export class ChangePasswordFormComponent {
  form: FormGroup;

  // form = new FormGroup({
  //   oldPassword: new FormControl('', [
  //     Validators.required
  //   ],
  //     passwordValidators.shouldExist),
  //   newPassword: new FormControl('', [
  //     Validators.required
  //   ]),
  //   confirmPassword: new FormControl('', [
  //     Validators.required,
  //   ])
  // }, passwordValidators.shouldMatch
  // );

  constructor(fb: FormBuilder) {
    this.form = fb.group({
      oldPassword: ['', 
        Validators.required, 
        passwordValidators.shouldExist
      ],
      newPassword: ['', 
        Validators.required
      ],
      confirmPassword: ['', 
        Validators.required
      ]
    }, {
      validator: passwordValidators.shouldMatch
    });
  }

  get oldPassword() { return this.form.get('oldPassword'); }
  get newPassword() { return this.form.get('newPassword'); }
  get confirmPassword() { return this.form.get('confirmPassword'); }
}
