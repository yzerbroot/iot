To allow users to sign up for an account using Microsoft Entra ID (formerly Azure AD) with options for Microsoft accounts, Google accounts, or email, you can follow these steps:

### 1. **Set Up Microsoft Entra ID**
   - **Create an External Tenant**: If you don't already have one, create an external tenant in Microsoft Entra ID.
   - **Enable Self-Service Sign-Up**: Ensure that self-service sign-up is enabled for your tenant.

### 2. **Configure Identity Providers**
   - **Microsoft Account**: This is typically already available if you're using Microsoft Entra ID.
   - **Google Account**:
     1. **Create a Google Application**: Go to the Google Developers Console and create a new project.
     2. **Set Up OAuth 2.0**: Configure OAuth consent screen and create OAuth credentials.
     3. **Add Google as an Identity Provider**: In the Microsoft Entra admin center, navigate to **External Identities > All Identity Providers > Google** and add the necessary details from your Google application¹(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-google-federation-customers).

### 3. **Create a User Flow**
   - **Sign-Up and Sign-In User Flow**:
     1. **Navigate to User Flows**: In the Microsoft Entra admin center, go to **Identity > External Identities > User flows**.
     2. **Create New User Flow**: Select **New user flow** and choose **Sign up and sign in**.
     3. **Configure Sign-In Methods**: Select the sign-in methods you want to offer (Microsoft account, Google account, and email).
     4. **Customize Attributes**: Add any custom attributes you want to collect during sign-up²(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-user-flow-sign-up-sign-in-customers).

### 4. **Integrate with Your Application**
   - **Frontend Integration**: Update your application's frontend to use the user flow you created. This typically involves redirecting users to the Microsoft Entra ID sign-in page.
   - **Backend Integration**: Ensure your backend can handle the tokens and claims provided by Microsoft Entra ID after authentication.

### Example Configuration for Google Identity Provider
1. **Create Google Application**:
   - Go to the Google Developers Console.
   - Create a new project and configure OAuth consent screen.
   - Create OAuth credentials and note the client ID and client secret.

2. **Add Google Identity Provider in Microsoft Entra**:
   - In the Microsoft Entra admin center, navigate to **External Identities > All Identity Providers > Google**.
   - Enter the client ID and client secret from your Google application.
   - Configure the redirect URIs as specified by Microsoft Entra ID¹(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-google-federation-customers).

### Example User Flow Creation
1. **Create User Flow**:
   - In the Microsoft Entra admin center, go to **Identity > External Identities > User flows**.
   - Select **New user flow** and choose **Sign up and sign in**.
   - Name your user flow (e.g., "SignUpSignIn").
   - Select the identity providers (Microsoft, Google, Email) and configure any additional attributes you want to collect²(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-user-flow-sign-up-sign-in-customers).

By following these steps, you can set up a seamless sign-up experience for your users, allowing them to use their preferred identity provider.

Would you like more detailed guidance on any specific part of this setup?
¹(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-google-federation-customers): [Microsoft Learn - Add Google as an identity provider](https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-google-federation-customers)
²(https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-user-flow-sign-up-sign-in-customers): [Microsoft Learn - Create a User Flow](https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-user-flow-sign-up-sign-in-customers)

Source: Conversation with Copilot, 17-10-2024
(1) Add Google as an identity provider - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-google-federation-customers.
(2) Create a User Flow - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/customers/how-to-user-flow-sign-up-sign-in-customers.
(3) Microsoft Entra ID Beginner's Tutorial (Azure Active Directory). https://www.youtube.com/watch?v=0qZzcK1mHwA.
(4) Microsoft Entra ID The Complete Beginners Guide. https://www.youtube.com/watch?v=ThT3n2Yass4.
(5) User sign-in with Microsoft Entra pass-through authentication. https://learn.microsoft.com/en-us/entra/identity/hybrid/connect/how-to-connect-pta.
(6) Microsoft Entra ID (formerly Azure AD) user provisioning and single sign-on. https://cloud.google.com/architecture/identity/federating-gcp-with-azure-ad-configuring-provisioning-and-single-sign-on.
(7) Quickstart - Get started guide - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/customers/quickstart-get-started-guide.
(8) undefined. https://accounts.google.com/signup.
(9) undefined. https://login.microsoftonline.com.
(10) undefined. https://login.microsoftonline.com/te/.