To enable self-service sign-up for your Microsoft Entra ID tenant, follow these steps:

### Steps to Enable Self-Service Sign-Up

1. **Sign in to the Microsoft Entra Admin Center**:
   - Go to the Microsoft Entra admin center and sign in with your administrator account.

2. **Navigate to External Identities**:
   - In the left-hand navigation pane, select **Identity** > **External Identities**.

3. **Configure External Collaboration Settings**:
   - Under **External Identities**, select **External collaboration settings**.
   - Toggle the **Enable guest self-service sign-up via user flows** switch to **Yes**¹(https://bing.com/search?q=enable+self-service+sign-up+for+Microsoft+Entra+ID+tenant).

4. **Create a User Flow**:
   - Go to **Identity** > **External Identities** > **User flows**.
   - Select **New user flow** and choose **Sign up and sign in**.
   - Configure the user flow by selecting the identity providers (e.g., Microsoft account, Google account, email) and any custom attributes you want to collect during sign-up²(https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview).

5. **Customize the User Flow**:
   - Customize the look and feel of the sign-up experience to match your branding.
   - Add any additional steps or validations, such as invitation code validation if needed.

6. **Associate the User Flow with Your Application**:
   - Ensure that your application is configured to use the created user flow. This typically involves updating the application’s authentication settings to point to the user flow endpoint.

### Example Configuration
1. **Enable Guest Self-Service Sign-Up**:
   - Sign in to the Microsoft Entra admin center.
   - Navigate to **Identity** > **External Identities** > **External collaboration settings**.
   - Toggle the **Enable guest self-service sign-up via user flows** switch to **Yes**¹(https://bing.com/search?q=enable+self-service+sign-up+for+Microsoft+Entra+ID+tenant).

2. **Create and Customize User Flow**:
   - Go to **Identity** > **External Identities** > **User flows**.
   - Select **New user flow** and choose **Sign up and sign in**.
   - Configure the user flow with the desired identity providers and custom attributes²(https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview).

By following these steps, you can enable self-service sign-up for your Microsoft Entra ID tenant, allowing users to sign up using their preferred identity providers.

Would you like more detailed guidance on any specific part of this setup?
²(https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview): [Microsoft Learn - Self-service sign-up overview](https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview)
¹(https://bing.com/search?q=enable+self-service+sign-up+for+Microsoft+Entra+ID+tenant): [Microsoft Learn - Manage self-service sign-up for guests](https://blog.admindroid.com/manage-self-service-sign-up-for-guests-in-microsoft-entra/)

Source: Conversation with Copilot, 17-10-2024
(1) Manage Self-service Sign-up for Guests in Microsoft Entra. https://bing.com/search?q=enable+self-service+sign-up+for+Microsoft+Entra+ID+tenant.
(2) Self-service sign-up for External ID - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview.
(3) Self-service sign up for email-verified users - Microsoft Entra ID. https://learn.microsoft.com/en-us/entra/identity/users/directory-self-service-signup.
(4) Add B2B Guest Sign-in - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-user-flow.
(5) Manage Self-service Sign-up for Guests in Microsoft Entra. https://blog.admindroid.com/manage-self-service-sign-up-for-guests-in-microsoft-entra/.
(6) Set up self-service group management - Microsoft Entra ID. https://learn.microsoft.com/en-us/entra/identity/users/groups-self-service-management.