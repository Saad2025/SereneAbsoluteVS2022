﻿namespace SereneAbsoluteDemoForVS2022.Membership {
    export interface ResetPasswordRequest extends Serenity.ServiceRequest {
        Token?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}

