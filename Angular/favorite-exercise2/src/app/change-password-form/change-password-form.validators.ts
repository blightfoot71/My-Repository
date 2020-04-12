import { AbstractControl } from '@angular/forms';

export class passwordValidators {
    static shouldExist(control: AbstractControl) {
        return new Promise((resolve) => {
            setTimeout(() => {
                if (control.value !== '1234')
                    resolve({ shouldExist: true });
                else
                    resolve(null);
            }, 2000);
        });
    }

    static shouldMatch(control: AbstractControl) {
        let newPassword = control.get('newPassword');
        let confirmPassword = control.get('confirmPassword');
        
        if (newPassword.value !== confirmPassword.value)
            return { shouldMatch: true };
        
        return null;
    }
}